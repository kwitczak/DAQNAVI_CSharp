using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using Automation.BDaq;
using System.Management;

namespace DAQNavi_WF_v1_0_0
{
    public partial class MainWindow : MetroForm
    {
        delegate void UpdateUIDelegate();
        Stopwatch stopwatch = new Stopwatch();
        String lang = ConfigurationManager.AppSettings["defaultLanguage"];
        Boolean analogInstantInputMovingWindow = true;
        BufferedAnalogInput bufferedAnalogInput;
        LoginPanel myLoginPanel;

        public double[] dataBufferedAI;
        public DateTime timeStartABI;
        public DateTime timeEndABI;
        public TimeSpan timeDiffABI;
        public DateTime timeStartAII;
        public DateTime timeEndAII;
        public TimeSpan timeDiffAII;
        public int TrueCount = 0;
        double[] dataInstantAI = new double[8];
        int myABIXPoint = 0;
        public Label[] analogInstantInputLabels;

        // From AnalogInstantMeasureOptions
        double analogInstantInputTimer;
        int analogInstantInput_choosenChannel;
        int analogInstantInput_numberOfChannels;



        public MainWindow()
        {

            // Przygotowanie programu do pracy - ukrycie zakładek
            InitializeComponent();

            this.TabControl.TabPages.Remove(TabPage_AnalogInstantInput);
            this.TabControl.TabPages.Remove(TabPage_AnalogBufferedInput);
            this.TabControl.TabPages.Remove(TabPage_DigitalInput);
            this.TabControl.TabPages.Remove(TabPage_DigitalOutput);
            this.TabControl.TabPages.Remove(TabPage_LastMeasure);
            this.TabControl.TabPages.Remove(TabPage_Options);
            this.TabControl.TabPages.Remove(TabPage_Measure);
            this.TabControl.TabPages.Remove(TabPage_MyMeasurements);
            

            // Ustawienie tekstów
            SetLanguage();

            this.metroTabPageWelcome.Text = ConfigurationManager.AppSettings["WelcomeTabName" + lang];
            Label_Welcome_Username.Text = ConfigurationManager.AppSettings["WelcomeLabelUsername" + lang];
            Label_Welcome_Password.Text = ConfigurationManager.AppSettings["WelcomeLabelPassword" + lang];
            Button_Welcome_Login.Text = ConfigurationManager.AppSettings["WelcomeButtonLogin" + lang];
            // -- 
            Label_Welcome_HelloText.Text = "Welcome in Advantech Measure application. \n\nTo start, " +
                          "choose one of the options on the tab pane.\n" +
                          "If You want to read more about Advantech, click" +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and thats it" +
                          "\n\n KW";
            Label_Measure_AnalogInput.Text = "You can measure:" +
                          "\n  - Instant input" +
                          "\n  - Buffered input";
            Label_Measure_AnalogOutput.Text = "You can measure:" +
                          "\n  - Instant output" +
                          "\n  - Buffered output";
            Label_Measure_DigitalInput.Text = "You can measure:" +
                          "\n  - Instant input";
            Label_Measure_DigitalOutput.Text = "You can measure:" +
                          "\n  - Instant output";
            Label_Measure_Instant.Text = "You can measure:" +
                          "\n  - Instant output";
            Label_Measure_Buffered.Text = "You can measure:" +
                          "\n  - Instant output";

            // Ustawienie opcji wykresów
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            Chart_AnalogBufferedInput.ChartAreas[0].CursorX.AutoScroll = true;
            Chart_AnalogBufferedInput.ChartAreas[0].CursorY.AutoScroll = true;

            Chart_AnalogBufferedInput.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            Chart_AnalogBufferedInput.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;


            Chart_AnalogInstantInput.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            Chart_AnalogInstantInput.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            Chart_AnalogInstantInput.ChartAreas[0].CursorX.AutoScroll = true;
            Chart_AnalogInstantInput.ChartAreas[0].CursorY.AutoScroll = true;

            Chart_AnalogInstantInput.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            Chart_AnalogInstantInput.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            

            analogInstantInputLabels = new Label[]{
                Label_AnalogInstantInput_Ch0Value, 
                Label_AnalogInstantInput_Ch1Value,
                Label_AnalogInstantInput_Ch2Value, 
                Label_AnalogInstantInput_Ch3Value,
                Label_AnalogInstantInput_Ch4Value, 
                Label_AnalogInstantInput_Ch5Value,
                Label_AnalogInstantInput_Ch6Value, 
                Label_AnalogInstantInput_Ch7Value};

            this.Select();
            this.TextBox_Welcome_Username.Select();
        }

        /// <summary>
        /// W momencie uzyskania danych z karty (koniec przygotowania pomiaru),
        /// narysuj wykres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bufferedAiCtrl1_DataReady(object sender, Automation.BDaq.BfdAiEventArgs e)
        {
            bufferedAiCtrl1.GetData(e.Count, dataBufferedAI);
            this.Invoke((UpdateUIDelegate)delegate()
            {

                int myABIXDataReadyPoint = 0;
                int mySeries = 0;
                int channels = int.Parse(this.TextBox_AnalogBufferedInput_Channels.Text.ToString());
                for (int i = 0; i < e.Count; ++i)
                {
                    mySeries = (i % channels);
                    if (mySeries == 0){
                        myABIXPoint++;
                        myABIXDataReadyPoint++;
                    }

                    //MEMO LEAK
                    Chart_AnalogBufferedInput.Series[mySeries].Points.Add(new DataPoint(myABIXPoint,dataBufferedAI[i]));
                    Chart_AnalogBufferedInput.Series[mySeries].ToolTip = "X=#VALX\nY=#VALY";
                    metroGridTable.Rows.Add();
                    metroGridTable.Rows[myABIXPoint - 1].Cells[mySeries].Value = dataBufferedAI[i];

                }
                
                this.TrackBar_AnalogBufferedInput_1.Value = 100;
                this.TrackBar_AnalogBufferedInput_2.Value = 0;
                if (this.TabControl.TabPages.Contains(TabPage_LastMeasure))
                {

                }
                else
                {
                    this.TabControl.TabPages.Add(TabPage_LastMeasure);
                }

                timer_ProgressBar.Stop();
                ProgressSpinner.Visible = false;
                ProgressSpinner.Refresh();
                
            });


        }

        /// <summary>
        /// Rozpocznij proces pobierana zbufforowanych danych z karty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnalogBufferedInput_Click(object sender, EventArgs e)
        {
            timer_ProgressBar.Start();
            timeStartABI = DateTime.Now;
            Label_AnalogBufferedInput_StartValue.Text = timeStartABI.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
            Label_AnalogBufferedInput_EndValue.Text = "00 : 00 : 00.000";
            Label_AnalogBufferedInput_DurationValue.Text = "00 : 00 : 00.000";

            ProgressSpinner.Visible = true;
            dataBufferedAI = null;
            foreach (var series in Chart_AnalogBufferedInput.Series)
            { 
                series.Points.Clear();
                metroGridTable.Rows.Clear();
                myABIXPoint = 0;

            }

            // Obiekty pomagające
            bufferedAnalogInput = new BufferedAnalogInput();
            bufferedAnalogInput.setSamples(Convert.ToInt32(TextBox_AnalogBufferedInput_Samples.Text));
            bufferedAnalogInput.setChannels(Convert.ToInt32(TextBox_AnalogBufferedInput_Channels.Text));
            bufferedAnalogInput.setChannelStart(Convert.ToInt32(TextBox_AnalogBufferedInput_ChannelStart.Text));
            bufferedAnalogInput.setIntervalCount(Convert.ToInt32(TextBox_AnalogBufferedInput_IntervalCount.Text));
            bufferedAnalogInput.setScanCount(Convert.ToInt32(TextBox_AnalogBufferedInput_ScanCount.Text));
            bufferedAnalogInput.setRate(Convert.ToInt32(TextBox_AnalogBufferedInput_Rate.Text));

            //bufferedAiCtrl1.SelectedDevice = new DeviceInformation(TextBox_Options_CardName.Text);
            dataBufferedAI = bufferedAnalogInput.przygotujPomiar(bufferedAiCtrl1);
        }

        /// <summary>
        /// Zmiana stylu z light na dark i odwrotnie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            MetroThemeStyle Light = MetroFramework.MetroThemeStyle.Light;
            MetroThemeStyle Dark = MetroFramework.MetroThemeStyle.Dark;

            if (TabControl.Theme == Dark)
            {
                //This
                this.Theme = Light;
                TabControl.Theme = Light;
                ProgressSpinner.Theme = Light;

                // Options
                TabPage_Options.Theme = Light;
                Toggle_Options_Layout.Theme = Light;
                RadioButton_Options_Polski.Theme = Light;
                RadioButton_Options_English.Theme = Light;
                Label_Options_Baza.Theme = Light;
                Label_Options_Haslo.Theme = Light;
                Label_Options_User.Theme = Light;
                TextBox_Options_Baza.Theme = Light;
                TextBox_Options_Haslo.Theme = Light;
                TextBox_Options_User.Theme = Light;
                TextBox_Options_AdminComment.Theme = Light;
                TextBox_Options_UserComment.Theme = Light;
                TextBox_Options_CardModule.Theme = Light;
                TextBox_Options_CardName.Theme = Light;
                TextBox_Options_CardNumber.Theme = Light;
                TextBox_Options_Port.Theme = Light;
                Panel_Options_Card.Theme = Light;
                Panel_Options_Comments.Theme = Light;
                Panel_Options_Database.Theme = Light;
                Panel_Options_Language.Theme = Light;
                Panel_Options_Theme.Theme = Light;
                Label_Options_Theme.Theme = Light;
                Label_Options_Language.Theme = Light;
                Label_Options_Database.Theme = Light;
                Label_Options_Port.Theme = Light;
                ScrollBar_Options.Theme = Light;
                Label_Options_Card.Theme = Light;
                Label_Options_CardModule.Theme = Light;
                Label_Options_CardName.Theme = Light;
                Label_Options_CardNumber.Theme  = Light;
                Label_Options_AdminComment.Theme = Light;
                Label_Options_UserComment.Theme = Light;
                Label_Options_CommentOptions.Theme = Light;
                Button_Options_ApplyChanges.Theme = Light;
                Button_Options_BackToDefaults.Theme = Light;


                // AnalogBufferedInput
                TabPage_AnalogBufferedInput.Theme = Light;
                Label_AnalogBufferedInput_Samples.Theme = Light;
                Label_AnalogBufferedInput_Channels.Theme = Light;
                Label_AnalogBufferedInput_ChannelStart.Theme = Light;
                Label_AnalogBufferedInput_IntervalCount.Theme = Light;
                Label_AnalogBufferedInput_Rate.Theme = Light;
                Label_AnalogBufferedInput_ScanCount.Theme = Light;
                TextBox_AnalogBufferedInput_Channels.Theme = Light;
                TextBox_AnalogBufferedInput_ChannelStart.Theme = Light;
                TextBox_AnalogBufferedInput_IntervalCount.Theme = Light;
                TextBox_AnalogBufferedInput_Rate.Theme = Light;
                TextBox_AnalogBufferedInput_ScanCount.Theme = Light;
                TrackBar_AnalogBufferedInput_1.Theme = Light;
                TrackBar_AnalogBufferedInput_2.Theme = Light;
                Button_AnalogBufferedInput_Back.Theme = Light;
                Button_AnalogBufferedInput_Measure.Theme = Light;
                TextBox_AnalogBufferedInput_Samples.Theme = Light;

                // Analog Instant Input
                TabPage_AnalogInstantInput.Theme = Light;
                Label_AnalogInstantInput_ChartAutosize.Theme = Light;
                //Label_AnalogInstantInput_Interval_1.Theme = Light;
                //Label_AnalogInstantInput_Interval_2.Theme = Light;
                //Label_AnalogInstantInput_NumberOfChannels.Theme = Light;
                //Label_AnalogInstantInput_SampleCount.Theme = Light;
                //Label_AnalogInstantInput_StartChannel.Theme = Light;
                //ComboBox_AnalogInstantInput_NumberOfChannels.Theme = Light;
                //ComboBox_AnalogInstantInput_StartChannel.Theme = Light;
                Toggle_AnalogInstantInput_ChartAutosize.Theme = Light;
                TrackBar_AnalogInstantInput_1.Theme = Light;
                TrackBar_AnalogInstantInput_2.Theme = Light;
                //TrackBar_AnalogInstantInput_SampleInterval.Theme = Light;
                Button_AnalogInstantInput_Back.Theme = Light;
                Button_AnalogInstantInput_Pause.Theme = Light;
                Button_AnalogInstantInput_Measure.Theme = Light;
                Button_AnalogInstantInput_Reset.Theme = Light;
                
                // Results
                TabPage_LastMeasure.Theme = Light;
                metroGridTable.Theme = Light;
                Panel_Results.Theme = Light;
                Button_Results_ExportToFile.Theme = Light;
                Button_Results_ExportToTXT.Theme = Light;
                Button_Results_ExportToXLSM.Theme = Light;

                // Measure
                TabPage_Measure.Theme = Light;
                Label_Measure_AnalogInput.Theme = Light;
                Label_Measure_AnalogOutput.Theme = Light;
                Label_Measure_Buffered.Theme = Light;
                Label_Measure_DigitalInput.Theme = Light;
                Label_Measure_DigitalOutput.Theme = Light;
                Label_Measure_Instant.Theme = Light;
                Tile_Measure_AnalogInput.Theme = Light;
                Tile_Measure_AnalogOutput.Theme = Light;
                Tile_Measure_BufferedInput.Theme = Light;
                Tile_Measure_DigitalInput.Theme = Light;
                Tile_Measure_DigitalOutput.Theme = Light;
                Tile_Measure_InstantInput.Theme = Light;
                Button_Measure_Return.Theme = Light;


                // Tabs
                TabPage_DigitalInput.Theme = Light;
                TabPage_DigitalOutput.Theme = Light;


                

                // Welcome
                
               

                

                // Results
            }
            else
            {

                //This
                this.Theme = Dark;
                TabControl.Theme = Dark;
                ProgressSpinner.Theme = Dark;

                TabPage_Options.Theme = Dark;
                Toggle_Options_Layout.Theme = Dark;
                RadioButton_Options_Polski.Theme = Dark;
                RadioButton_Options_English.Theme = Dark;
                Label_Options_Baza.Theme = Dark;
                Label_Options_Haslo.Theme = Dark;
                Label_Options_User.Theme = Dark;
                TextBox_Options_Baza.Theme = Dark;
                TextBox_Options_Haslo.Theme = Dark;
                TextBox_Options_User.Theme = Dark;
                TextBox_Options_AdminComment.Theme = Dark;
                TextBox_Options_UserComment.Theme = Dark;
                TextBox_Options_CardModule.Theme = Dark;
                TextBox_Options_CardName.Theme = Dark;
                TextBox_Options_CardNumber.Theme = Dark;
                TextBox_Options_Port.Theme = Dark;
                Panel_Options_Card.Theme = Dark;
                Panel_Options_Comments.Theme = Dark;
                Panel_Options_Database.Theme = Dark;
                Panel_Options_Language.Theme = Dark;
                Panel_Options_Theme.Theme = Dark;
                Label_Options_Theme.Theme = Dark;
                Label_Options_Language.Theme = Dark;
                Label_Options_Database.Theme = Dark;
                Label_Options_Port.Theme = Dark;
                ScrollBar_Options.Theme = Dark;
                Label_Options_Card.Theme = Dark;
                Label_Options_CardModule.Theme = Dark;
                Label_Options_CardName.Theme = Dark;
                Label_Options_CardNumber.Theme = Dark;
                Label_Options_AdminComment.Theme = Dark;
                Label_Options_UserComment.Theme = Dark;
                Label_Options_CommentOptions.Theme = Dark;
                Button_Options_ApplyChanges.Theme = Dark;
                Button_Options_BackToDefaults.Theme = Dark;

                // AnalogBufferedInput
                TabPage_AnalogBufferedInput.Theme = Dark;
                Label_AnalogBufferedInput_Samples.Theme = Dark;
                Label_AnalogBufferedInput_Channels.Theme = Dark;
                Label_AnalogBufferedInput_ChannelStart.Theme = Dark;
                Label_AnalogBufferedInput_IntervalCount.Theme = Dark;
                Label_AnalogBufferedInput_Rate.Theme = Dark;
                Label_AnalogBufferedInput_ScanCount.Theme = Dark;
                TextBox_AnalogBufferedInput_Channels.Theme = Dark;
                TextBox_AnalogBufferedInput_ChannelStart.Theme = Dark;
                TextBox_AnalogBufferedInput_IntervalCount.Theme = Dark;
                TextBox_AnalogBufferedInput_Rate.Theme = Dark;
                TextBox_AnalogBufferedInput_ScanCount.Theme = Dark;
                TrackBar_AnalogBufferedInput_1.Theme = Dark;
                TrackBar_AnalogBufferedInput_2.Theme = Dark;
                Button_AnalogBufferedInput_Back.Theme = Dark;
                Button_AnalogBufferedInput_Measure.Theme = Dark;
                TextBox_AnalogBufferedInput_Samples.Theme = Dark;

                // Analog Instant Input
                TabPage_AnalogInstantInput.Theme = Dark;
                Label_AnalogInstantInput_ChartAutosize.Theme = Dark;
                //Label_AnalogInstantInput_Interval_1.Theme = Dark;
                //Label_AnalogInstantInput_Interval_2.Theme = Dark;
                //Label_AnalogInstantInput_NumberOfChannels.Theme = Dark;
                //Label_AnalogInstantInput_SampleCount.Theme = Dark;
                //Label_AnalogInstantInput_StartChannel.Theme = Dark;
                //ComboBox_AnalogInstantInput_NumberOfChannels.Theme = Dark;
                //ComboBox_AnalogInstantInput_StartChannel.Theme = Dark;
                Toggle_AnalogInstantInput_ChartAutosize.Theme = Dark;
                TrackBar_AnalogInstantInput_1.Theme = Dark;
                TrackBar_AnalogInstantInput_2.Theme = Dark;
                //TrackBar_AnalogInstantInput_SampleInterval.Theme = Dark;
                Button_AnalogInstantInput_Back.Theme = Dark;
                Button_AnalogInstantInput_Pause.Theme = Dark;
                Button_AnalogInstantInput_Measure.Theme = Dark;
                Button_AnalogInstantInput_Reset.Theme = Dark;

                // Results
                TabPage_LastMeasure.Theme = Dark;
                metroGridTable.Theme = Dark;
                Panel_Results.Theme = Dark;
                Button_Results_ExportToFile.Theme = Dark;
                Button_Results_ExportToTXT.Theme = Dark;
                Button_Results_ExportToXLSM.Theme = Dark;

                // Measure
                TabPage_Measure.Theme = Dark;
                Label_Measure_AnalogInput.Theme = Dark;
                Label_Measure_AnalogOutput.Theme = Dark;
                Label_Measure_Buffered.Theme = Dark;
                Label_Measure_DigitalInput.Theme = Dark;
                Label_Measure_DigitalOutput.Theme = Dark;
                Label_Measure_Instant.Theme = Dark;
                Tile_Measure_AnalogInput.Theme = Dark;
                Tile_Measure_AnalogOutput.Theme = Dark;
                Tile_Measure_BufferedInput.Theme = Dark;
                Tile_Measure_DigitalInput.Theme = Dark;
                Tile_Measure_DigitalOutput.Theme = Dark;
                Tile_Measure_InstantInput.Theme = Dark;
                Button_Measure_Return.Theme = Dark;


                // Tabs
                TabPage_DigitalInput.Theme = Dark;
                TabPage_DigitalOutput.Theme = Dark;




                // Welcome





                // Results

            }

            this.Refresh();
            
        }

        /// <summary>
        /// Hiperłącze do strony Advantech.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Link1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.advantech.com/");
        }

        /// <summary>
        /// Ukrycie przycisków z pozostałych wyborów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_AnalogInput_Click(object sender, EventArgs e)
        {
            Tile_Measure_AnalogInput.Visible = false;
            Tile_Measure_AnalogOutput.Visible = false;
            Tile_Measure_DigitalInput.Visible = false;
            Tile_Measure_DigitalOutput.Visible = false;
            Tile_Measure_InstantInput.Visible = true;
            Tile_Measure_BufferedInput.Visible = true;
        }

        /// <summary>
        /// Odkrycie przycisków po wciśnięciu przycisku powrót.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MeasureReturn_Click(object sender, EventArgs e)
        {
            if (Tile_Measure_AnalogInput.Visible)
            {    
                this.TabControl.SelectedTab = TabPage_MyMeasurements;
                TabControl.TabPages.Remove(TabPage_Measure);
            }
            else
            {
                Tile_Measure_AnalogInput.Visible = true;
                Tile_Measure_AnalogOutput.Visible = true;
                Tile_Measure_DigitalInput.Visible = true;
                Tile_Measure_DigitalOutput.Visible = true;
                Tile_Measure_InstantInput.Visible = false;
                Tile_Measure_BufferedInput.Visible = false;
            }
            

        }

        /// <summary>
        /// Logowanie się.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            myLoginPanel = new LoginPanel(TextBox_Options_Baza.Text, TextBox_Options_Port.Text, TextBox_Options_User.Text, TextBox_Options_Haslo.Text);
            Boolean loginSuccessful = myLoginPanel.checkLogin(this.TextBox_Welcome_Username.Text, this.TextBox_Welcome_Password.Text);
            if (loginSuccessful)
            {
                User user = myLoginPanel.loggedUser;
                MetroMessageBox.Show(this, "" + user.imie + ", logowanie powiodło się.", "Witaj", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (user.admin == 1)
                {
                    this.TabControl.TabPages.Remove(metroTabPageWelcome);
                    this.TabControl.TabPages.Add(TabPage_Options);
                    this.TabControl.TabPages.Add(TabPage_MyMeasurements);

                    this.TabControl.SelectedTab = TabPage_Options;
                }
                else
                {
                    this.TabControl.TabPages.Remove(metroTabPageWelcome);
                    this.TabControl.TabPages.Add(TabPage_MyMeasurements);

                    this.TabControl.SelectedTab = TabPage_MyMeasurements;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Logowanie nie powiodło się. Spróbuj ponownie!", "Witaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          }

        /// <summary>
        /// Po wciśnięciu Entera w ekranie logowania, sytuacja powinna być identyczna
        /// jak po wciśnięciu przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Button_Welcome_Login.PerformClick();
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.TabControl.TabPages.Add(TabPage_AnalogBufferedInput);
            this.TabControl.TabPages.Remove(TabPage_Measure);
            this.TabControl.SelectedTab = TabPage_AnalogBufferedInput;
        }

        private void metroTileDigitalInput_MouseHover(object sender, EventArgs e)
        {
            Label_Measure_DigitalInput.Visible = true;
        }

        private void metroTileDigitalInput_MouseLeave(object sender, EventArgs e)
        {
            Label_Measure_DigitalInput.Visible = false;
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            Label_Measure_AnalogInput.Visible = true;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            Label_Measure_AnalogInput.Visible = false;
        }

        private void metroTileAnalogOutput_MouseEnter(object sender, EventArgs e)
        {
            Label_Measure_AnalogOutput.Visible = true;
        }

        private void metroTileAnalogOutput_MouseLeave(object sender, EventArgs e)
        {
            Label_Measure_AnalogOutput.Visible = false;
        }

        private void metroTileDigitalOutput_MouseEnter(object sender, EventArgs e)
        {
            Label_Measure_DigitalOutput.Visible = true;
        }

        private void metroTileDigitalOutput_MouseLeave(object sender, EventArgs e)
        {
            Label_Measure_DigitalOutput.Visible = false;
        }

        private void metroTileInstantInput_MouseEnter(object sender, EventArgs e)
        {
            Label_Measure_Instant.Visible = true;
        }

        private void metroTileInstantInput_MouseLeave(object sender, EventArgs e)
        {
            Label_Measure_Instant.Visible = false;
        }

        private void metroTileBufferedInput_MouseEnter(object sender, EventArgs e)
        {
            Label_Measure_Buffered.Visible = true;
        }

        private void metroTileBufferedInput_MouseLeave(object sender, EventArgs e)
        {
            Label_Measure_Buffered.Visible = false;
        }


        ///<summary>
        /// Przesunięcie suwakiem powinno zwiększać/zmniejszać maksymalny zakres
        /// na osi X na wykresie. Markery powinny pojawiać się po przekroczeniu
        /// pewnego poziomu zbliżenia. 
        /// </summary>
        private void TrackBar_AnalogBufferedInput_1_ValueChanged(object sender, EventArgs e)
        {
            if (this.TrackBar_AnalogBufferedInput_1.Value == 0)
            {
                return;
            }
            this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum = double.Parse(this.TextBox_AnalogBufferedInput_Samples.Text) * ((double)(this.TrackBar_AnalogBufferedInput_1.Value)/100);
            
            double ratio = (this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum - this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum);
            ChangeChartMarkerRatio(this.Chart_AnalogBufferedInput, ratio);
            Label_AnalogBufferedInput_TrackBar1.Text = "Zoom X: " + TrackBar_AnalogBufferedInput_1.Value + " %";
        }

        /// <summary>
        /// Przesunięcie suwakiem 2 powinno przesuwać wykres wzdłóż jego osi,
        /// od minimalnej do maksymalnej wartości.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar_AnalogBufferedInput_2_ValueChanged(object sender, EventArgs e)
        {
            double MIN = 0;
            double MAX = (double.Parse(this.TextBox_AnalogBufferedInput_Samples.Text));
            double howMuchToChange = (MAX / 100) * this.TrackBar_AnalogBufferedInput_2.Value;
            double window = Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum - Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum = howMuchToChange;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum = window + howMuchToChange;
            Label_AnalogBufferedInput_TrackBar2.Text = "Position X: " + TrackBar_AnalogBufferedInput_2.Value + " %";
        }

        ///<summary>
        /// Zoom myszą powinien spowodować pojawienie się markerów na wykresie
        /// po przekroczeniu pewnego zbliżenia.
        /// </summary>
        private void Chart_AnalogBufferedInput_AxisViewChanged(object sender, ViewEventArgs e)
        {
            double ratio = (this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.ScaleView.ViewMaximum - this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
            ChangeChartMarkerRatio(this.Chart_AnalogBufferedInput, ratio);
        }

        /// <summary>
        /// Obliczenie nowych wartości punktów dla danego wykresu,
        /// bazując na rozpiętości jego osi X.
        /// </summary>
        private void ChangeChartMarkerRatio(Chart chart, double ratio)
        {
            if (ratio <= 30)
            {
                for (int i = 0; i < chart.Series.Count; i++)
                {
                    chart.Series[i].MarkerSize = 8;
                }
            }
            else
            {
                for (int i = 0; i < chart.Series.Count; i++)
                {
                    chart.Series[i].MarkerSize = 0;
                }
            }
        }


        /// <summary>
        /// Restart zbliżenia po kliknięciu prawego przycisku myszy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chart_AnalogBufferedInput_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Right)
                {
                    Chart_AnalogBufferedInput.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    Chart_AnalogBufferedInput.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    double ratio = Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum - Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum;

                    ChangeChartMarkerRatio(Chart_AnalogBufferedInput, ratio);
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za zapisanie pliku w formacie txt na pulpicie.
        /// Plik zawiera dane z ostatniego pomiaru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogBufferedInput_ExportToFile_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm(this);
            commentForm.Show();

        }

        /// <summary>
        /// Przejście do InstantAnalogInput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_InstantInput_Click(object sender, EventArgs e)
        {
             this.TabControl.TabPages.Add(TabPage_AnalogInstantInput);
            this.TabControl.TabPages.Remove(TabPage_Measure);
            this.TabControl.SelectedTab = TabPage_AnalogInstantInput;

            // Default values for AnalogInstantInput
            analogInstantInputTimer = 50;
            analogInstantInput_choosenChannel = 0;
            analogInstantInput_numberOfChannels = 1;
        }

        /// <summary>
        /// Rozpoczęcie pomiaru Analog Instant Input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogInstantInput_Click(object sender, EventArgs e)
        {
            // Set start time
            timeStartAII = DateTime.Now;
            Label_AnalogInstantInput_StartValue.Text = timeStartAII.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
            
            // Un-enable edit buttons
            Button_AnalogInstantInput_EditOptions.Enabled = false;
            Button_AnalogInstantInput_Defaults.Enabled = false;

            // Clear chart
            foreach (var series in Chart_AnalogInstantInput.Series)
            {
                series.Points.Clear();
                metroGridTable.Rows.Clear();
            }

            // Show markers if zoomed
            double ratio = Chart_AnalogInstantInput.ChartAreas[0].AxisX.Maximum - Chart_AnalogInstantInput.ChartAreas[0].AxisX.Minimum;
            ChangeChartMarkerRatio(Chart_AnalogInstantInput, ratio);

            // Start!
            timer_getData.Start();
            
        }

        /// <summary>
        /// Każdy tick oznacza odświeżenie wykresu dla opcji instant input,
        /// im jest częściej, tym większa częstotliwość pomiaru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_getData_Tick(object sender, EventArgs e)
        {
            double timeInterval = analogInstantInputTimer;
            if (timeInterval == 0)
            {
                timeInterval = 1;
            }

            timer_getData.Interval = (int)timeInterval * 1;
            ErrorCode err;
            
            err = instantAiCtrl1.Read(analogInstantInput_choosenChannel, analogInstantInput_numberOfChannels, dataInstantAI);
            if (err != ErrorCode.Success)
            {
                timer_getData.Stop();
            }
            for (int i = 0; i < analogInstantInput_numberOfChannels; i++)
            {
                Chart_AnalogInstantInput.Series[i].Points.Add(dataInstantAI[i]);
                analogInstantInputLabels[i].Text = Math.Round(dataInstantAI[i],2).ToString();
            }

            TrueCount++;


            if (analogInstantInputMovingWindow)
            {
                Chart_AnalogInstantInput.ChartAreas[0].AxisX.Minimum = TrueCount - int.Parse(TextBox_AnalogInstantInput_MovingWindow.Text); 
            }
              
        }

        /// <summary>
        /// Zmiana czasu pobierania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void TrackBar_AnalogInstantInput_SampleInterval_ValueChanged(object sender, EventArgs e)
        //{
            
        //    double timeInterval = TrackBar_AnalogInstantInput_SampleInterval.Value;
        //    if (timeInterval == 0)
        //    {
        //        timeInterval = 1;
        //    }

        //    timer_getData.Interval = (int)timeInterval;
        //    Label_AnalogInstantInput_Interval_2.Text = timeInterval.ToString();
        //}

        /// <summary>
        /// Pauza i wznowienie pobierania danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogInstantInput_Pause_Click(object sender, EventArgs e)
        {
            if (Button_AnalogInstantInput_Pause.Text.Equals("Pause"))
            {
                timer_getData.Stop();
                Button_AnalogInstantInput_Pause.Text = "Resume";
            }
            else
            {
                timer_getData.Start();
                Button_AnalogInstantInput_Pause.Text = "Pause";
            }
            
        }

        /// <summary>
        /// Zatrzymanie pobierania danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogInstantInput_Reset_Click(object sender, EventArgs e)
        {
            timer_getData.Stop();
            Button_AnalogInstantInput_Pause.Text.Equals("Pause");
            foreach (var series in Chart_AnalogInstantInput.Series)
            {
                series.Points.Clear();
                metroGridTable.Rows.Clear();
            }


        }

        /// <summary>
        /// Zmiana z auto na manualny scale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toggle_AnalogInstantInput_ChartAutosize_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_AnalogInstantInput_ChartAutosize.Checked)
            {
                Chart_AnalogInstantInput.ChartAreas[0].AxisX.Maximum = Double.NaN;
                TrackBar_AnalogInstantInput_1.Enabled = false;
                TrackBar_AnalogInstantInput_2.Enabled = false;

            }
            else
            {
                Chart_AnalogInstantInput.ChartAreas[0].AxisX.Maximum = 10;
                TrackBar_AnalogInstantInput_1.Enabled = true;
                TrackBar_AnalogInstantInput_2.Enabled = true;

            }
        }

        /// <summary>
        /// ??
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar_AnalogInstantInput_1_Scroll(object sender, ScrollEventArgs e)
        {
            //if (TrackBar_AnalogInstantInput_1.Value == 0)
            //{
            //    return;
            //}
            //Chart_AnalogInstantInput.ChartAreas[0].AxisX.Maximum = double.Parse(Label_AnalogInstantInput_SampleCount.Text) * ((double)(TrackBar_AnalogInstantInput_1.Value) / 100);

            //double ratio = (Chart_AnalogInstantInput.ChartAreas[0].AxisX.Maximum - Chart_AnalogInstantInput.ChartAreas[0].AxisX.Minimum);
            //ChangeChartMarkerRatio(Chart_AnalogInstantInput, ratio);
        }

        /// <summary>
        /// Powrot z AnalogBufferedInput do measure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogBufferedInput_Back_Click(object sender, EventArgs e)
        {
            dataBufferedAI = null;
            foreach (var series in Chart_AnalogBufferedInput.Series)
            {
                series.Points.Clear();
                metroGridTable.Rows.Clear();
                myABIXPoint = 0;

            }

            this.TabControl.TabPages.Add(TabPage_Measure);
            this.TabControl.TabPages.Remove(TabPage_AnalogBufferedInput);
            this.TabControl.SelectedTab = TabPage_Measure;
            //this.TabControl.TabPages.Remove(TabPage_LastMeasure);
            
        }
        
        /// <summary>
        /// Powrot z AnalogInstantInput do measure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogInstantInput_Back_Click(object sender, EventArgs e)
        {
            this.TabControl.TabPages.Add(TabPage_Measure);
            this.TabControl.TabPages.Remove(TabPage_AnalogInstantInput);
            this.TabControl.SelectedTab = TabPage_Measure;
            this.TabControl.TabPages.Remove(TabPage_LastMeasure);
        }

        private void timer_ProgressBar_Tick(object sender, EventArgs e)
        {
            ProgressSpinner.Refresh();
        }

        /// <summary>
        /// Zmiana języka na angielski
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Options_English_CheckedChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //make changes
            config.AppSettings.Settings["defaultLanguage"].Value = "ENG";

            //save to apply changes
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            SetLanguage();
        }

        /// <summary>
        /// Zmiana języka na polski
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Options_Polski_CheckedChanged(object sender, EventArgs e)
        {
            //ConfigurationManager.AppSettings.Set("defaultLanguage", "PL");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //make changes
            config.AppSettings.Settings["defaultLanguage"].Value = "PL";

            //save to apply changes
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            SetLanguage();
        }

        /// <summary>
        /// Metoda która zapisuje zmiany wprowadzone w panelu admina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Options_ApplyChanges_Click(object sender, EventArgs e)
        {
            //delete
            //bufferedAiCtrl1.SelectedDevice.
            //MessageBox.Show(my.ToString());
                
            //var query = string.Format("select * from {0}", "*");

            //using (var searcher = new ManagementObjectSearcher(query))
            //{
            //    ManagementObjectCollection objectCollection = searcher.Get();

            //    foreach (ManagementBaseObject managementBaseObject in objectCollection)
            //    {
            //        foreach (PropertyData propertyData in managementBaseObject.Properties)
            //        {   
            //            String my = String.Format("Property:  {0}, Value: {1}", propertyData.Origin, propertyData.Name);
            //            if (my.IndexOf("4702")>0)
            //            {
            //                MessageBox.Show(my);
            //            }
                            
            //        }
            //    }



            //}

        }

        /// <summary>
        /// Metoda która przywraca domyślne ustawienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Options_BackToDefaults_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Odświeżenie języka w całej aplikaji (ustawienie tekstu)
        /// </summary>
        private void SetLanguage()
        {
            // Welcome Tab
            this.metroTabPageWelcome.Text = ConfigurationManager.AppSettings["WelcomeTabName" + lang];
            Label_Welcome_Username.Text = ConfigurationManager.AppSettings["WelcomeLabelUsername" + lang];
            Label_Welcome_Password.Text = ConfigurationManager.AppSettings["WelcomeLabelPassword" + lang];
            Button_Welcome_Login.Text = ConfigurationManager.AppSettings["WelcomeButtonLogin" + lang];
            // Analog Buffered Input Tab
            this.TabPage_AnalogBufferedInput.Text = ConfigurationManager.AppSettings["ABITab" + lang];
            this.Label_AnalogBufferedInput_Samples.Text = ConfigurationManager.AppSettings["ABISamples" + lang];
            this.Label_AnalogBufferedInput_Channels.Text = ConfigurationManager.AppSettings["ABIChannels" + lang];
            this.Label_AnalogBufferedInput_ChannelStart.Text = ConfigurationManager.AppSettings["ABIChannelStart" + lang];
            this.Label_AnalogBufferedInput_IntervalCount.Text = ConfigurationManager.AppSettings["ABIIntervalCount" + lang];
            this.Label_AnalogBufferedInput_ScanCount.Text = ConfigurationManager.AppSettings["ABIScanCount" + lang];
            this.Label_AnalogBufferedInput_Rate.Text = ConfigurationManager.AppSettings["ABIRate" + lang];
            this.Button_AnalogBufferedInput_Back.Text = ConfigurationManager.AppSettings["ABIButtonBack" + lang];
            this.Button_AnalogBufferedInput_Measure.Text = ConfigurationManager.AppSettings["ABIButtonMeasure" + lang];


        }

        /// <summary>
        /// Ustawienie widoku wykresu "poruszającego się okna"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toggle_AnalogInstantInput_MovingWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_AnalogInstantInput_MovingWindow.Checked)
            {
                analogInstantInputMovingWindow = true;
            }
            else
            {
                analogInstantInputMovingWindow = false;
            }
        }

        /// <summary>
        /// Czyszczenie danych po zakonczeniu ich pobierania w trybie buffered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bufferedAiCtrl1_Stopped(object sender, BfdAiEventArgs e)
        {
            bufferedAnalogInput = null;
            timeEndABI = DateTime.Now;
            timeDiffABI = timeEndABI.Subtract(timeStartABI);
            MessageBox.Show("Koniec");
            // Update UI z innego wątku
            MethodInvoker inv = delegate
            {
                Label_AnalogBufferedInput_EndValue.Text = timeEndABI.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                Label_AnalogBufferedInput_DurationValue.Text = new DateTime(timeDiffABI.Ticks).ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
            };

            this.Invoke(inv);
            
        }

        /// <summary>
        /// W przyszlosci - powiekszanie wykresu?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Zapis danych do bazy - czas poczatku pomiaru, konca, dane, id usera
        /// </summary>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="data"></param>
        /// <param name="userID"></param>
        public void saveResultsToDataBase(string dateStart, string dateEnd, double[] data, MetroFramework.Controls.MetroProgressBar progressBar)
        {
            Measurment.saveDataToDataBase(myLoginPanel, dateStart, dateEnd, data, progressBar);
        }


        /// <summary>
        /// Edytowalny scrollbar zamiast utomatycznego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            TabPage_Options.VerticalScroll.Value = e.NewValue * 5;
        }


        /// <summary>
        /// Delegat do ustawiania scrollBara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="p"></param>
        private delegate void AutoScrollPositionDelegate(ScrollableControl sender, Point p);

        /// <summary>
        /// Automatyczne ustawienie focusa na kontrolce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTextBox4_Enter(object sender, EventArgs e)
        {
            
            Point p = TabPage_Options.AutoScrollPosition;
            AutoScrollPositionDelegate del = new AutoScrollPositionDelegate(SetAutoScrollPosition);
            Object[] args = { TabPage_Options, p };
            BeginInvoke(del,args);
        }

        /// <summary>
        /// Metoda ustawiajaca focus na kontrolce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="p"></param>
        public void SetAutoScrollPosition(ScrollableControl sender, Point p)
        {
            p.X = Math.Abs(p.X);
            p.Y = Math.Abs(p.Y);
            sender.AutoScrollPosition = p;
        }

        /// <summary>
        /// Accessor dla innego formularza, aby byl widoczny gridTable
        /// </summary>
        public MetroFramework.Controls.MetroGrid metroGridTableVisible
        {
            get { return this.metroGridTable; }
        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public MetroFramework.Controls.MetroTextBox TextBox_Options_UserComment_Visible
        {
            get { return this.TextBox_Options_UserComment; }
        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public MetroFramework.Controls.MetroTextBox TextBox_Options_AdminComment_Visible
        {
            get { return this.TextBox_Options_AdminComment; }
        }

        /// <summary>
        /// Przejście do nowego pomiaru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MyMeasurements_NewMeasure_Click(object sender, EventArgs e)
        {
            this.TabControl.TabPages.Add(TabPage_Measure);
            this.TabControl.SelectedTab = TabPage_Measure;
        }

        /// <summary>
        /// Otworzenie okna opcji dla AnalogInstantInput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogInstantInput_EditOptions_Click(object sender, EventArgs e)
        {
            AnalogInstantMeasureOptions analogInstantInputOptions = new AnalogInstantMeasureOptions(this);
           analogInstantInputOptions.Show();

        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public double getAnalogInstantInputTimer
        {
            set { this.analogInstantInputTimer = value; }
            get { return this.analogInstantInputTimer; }
        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public int getChoosenChannel
        {
            set { this.analogInstantInput_choosenChannel = value; }
            get { return this.analogInstantInput_choosenChannel; }
        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public int getNumberOfChannels
        {
            set { this.analogInstantInput_numberOfChannels = value; }
            get { return this.analogInstantInput_numberOfChannels; }
        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public MetroFramework.Controls.MetroCheckBox getCheckbox_AnalogInstantInput_MeasurmentOptions
        {
            get { return this.CheckBox_AnalogInstantInput_MeasurmentOptions; }
        }

        /// <summary>
        /// Accessor dla innego formularza
        /// </summary>
        public MetroFramework.Controls.MetroCheckBox getCheckbox_AnalogInstantInput_Defaults
        {
            get { return this.CheckBox_AnalogInstantInput_Defaults; }
        }


        /// <summary>
        /// Zmień status dla dostepnosci opcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_AnalogInstantInput_Defaults_CheckedChanged(object sender, EventArgs e)
        {
            //if (!CheckBox_AnalogInstantInput_Defaults.Checked)
            //{
            //    CheckBox_AnalogInstantInput_MeasurmentOptions.Checked = false;
            //}

        }

        /// <summary>
        /// Wybranie domyślnych wartości pomiaru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AnalogInstantInput_Defaults_Click(object sender, EventArgs e)
        {
            CheckBox_AnalogInstantInput_MeasurmentOptions.Checked = false;
            CheckBox_AnalogInstantInput_Defaults.Checked = true;

            // Default values for AnalogInstantInput
            analogInstantInputTimer = 50;
            analogInstantInput_choosenChannel = 0;
            analogInstantInput_numberOfChannels = 1;
        }

        /// <summary>
        /// Wyświetlanie markerów na wykresie analoginstantinput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chart_AnalogInstantInput_AxisViewChanged(object sender, ViewEventArgs e)
        {
            double ratio = (this.Chart_AnalogInstantInput.ChartAreas[0].AxisX.ScaleView.ViewMaximum - this.Chart_AnalogInstantInput.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
            ChangeChartMarkerRatio(this.Chart_AnalogInstantInput, ratio);
        
        }

        /// <summary>
        /// Oddalenie widoku na wykresie analoginstantinput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chart_AnalogInstantInput_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Right)
                {
                    Chart_AnalogInstantInput.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    Chart_AnalogInstantInput.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    double ratio = Chart_AnalogInstantInput.ChartAreas[0].AxisX.Maximum - Chart_AnalogInstantInput.ChartAreas[0].AxisX.Minimum;

                    ChangeChartMarkerRatio(Chart_AnalogInstantInput, ratio);
                }
            }
        }


        
    }
}
