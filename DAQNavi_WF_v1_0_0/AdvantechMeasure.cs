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
using DAQNavi_WF_v1_0_0.Utils;
using MySql.Data.MySqlClient;
using DAQNavi_WF_v1_0_0.DTO;

namespace DAQNavi_WF_v1_0_0
{
    public partial class MainWindow : MetroForm
    {
        /* STYLE VARIABLES */
        public static readonly MetroThemeStyle STYLE_LIGHT = MetroFramework.MetroThemeStyle.Light;
        public static readonly MetroThemeStyle STYLE_DARK = MetroFramework.MetroThemeStyle.Dark;
        public static readonly Color COLOR_LIGHT_DARK = Color.FromArgb(170, 170, 170);
        public static readonly Color COLOR_GRAY_DARK = Color.FromArgb(34, 34, 34);

        /* UTILITY CONSTANTS */
        public delegate void UpdateUIDelegate();
        private delegate void AutoScrollPositionDelegate(ScrollableControl sender, Point p);
        public static readonly String ADVANTECH_SITE = "http://www.advantech.com/";
        public enum Language { ENG, PL }
        public static Language choosenLanguage = LanguageUtils.getDefaultLanguage();
        public static MeasurmentType lastMeasurmentType;
        public static Stopwatch stopWatch = new Stopwatch();
        public static LoginManager loginManager;
        public static MeasurmentDAO measurmentDAO;
        public enum MeasurmentType { ANALOG_INSTANT_INPUT, ANALOG_BUFFERED_INPUT }

        /* BUFFERED ANALOG INPUT (ABI) */
        public static List<double> ABI_allData = new List<double>();
        public static BufferedAnalogInput ABI;
        public static DateTime ABI_timerStart;
        public static TimeSpan ABI_timeDiff;
        public static DateTime ABI_timeEnd;
        public static double[] ABI_data;
        public static int ABI_xPoint = 0;

        /* ANALOG INSTANT INPUT (AII) */
        public static MicroLibrary.MicroTimer AII_timer = new MicroLibrary.MicroTimer();
        public static double[] AII_data = new double[8];
        public static Boolean AII_MovingWindow = true;
        public static Boolean AAI_isRunning = false;
        public static DateTime AII_timeStart;
        public static DateTime AII_timeEnd;
        public static TimeSpan AII_timeDiff;
        public static int AAI_sampleCount = 0;
        public static Label[] AII_labels;
        public static int AII_drawnPoints = 0;
        public static double AII_timerValue;
        public static int AII_choosenChannel;
        public static int AII_numOfChannels;

        /* MY MEASURMENTS PANEL */
        public static int MM_numberOfMeasurments = 0;
        public static List<MetroFramework.Controls.MetroButton> MM_list_buttons = new List<MetroFramework.Controls.MetroButton>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_titles = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_channelStart = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_channelStartValue = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_numberOfChannels = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_numberOfChannelsValue = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_samples = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MetroFramework.Controls.MetroLabel> MM_list_samplesValue = new List<MetroFramework.Controls.MetroLabel>();
        public static List<MeasurmentDTO> myLoadedMeasurments = new List<MeasurmentDTO>();



        /*
         * ==================================  INICJALIZACJA PROGRAMU ========================================
         */

        public MainWindow()
        {

            // Przygotowanie programu do pracy - ukrycie zakładek
            InitializeComponent();

            TabControl.TabPages.Remove(TabPage_AnalogInstantInput);
            TabControl.TabPages.Remove(TabPage_AnalogBufferedInput);
            TabControl.TabPages.Remove(TabPage_DigitalInput);
            TabControl.TabPages.Remove(TabPage_DigitalOutput);
            TabControl.TabPages.Remove(TabPage_LastMeasure);
            TabControl.TabPages.Remove(TabPage_Options);
            TabControl.TabPages.Remove(TabPage_Measure);
            TabControl.TabPages.Remove(TabPage_MyMeasurements);
            TabControl.TabPages.Remove(TabPage_ShowMeasure);
            
            // Ustawienie tekstów
            LanguageUtils.setLanguage(choosenLanguage, this);

            TabPage_Welcome.Text = ConfigurationManager.AppSettings["WelcomeTabName" + choosenLanguage];
            Welcome_label_username.Text = ConfigurationManager.AppSettings["WelcomeLabelUsername" + choosenLanguage];
            Welcome_label_password.Text = ConfigurationManager.AppSettings["WelcomeLabelPassword" + choosenLanguage];
            Welcome_button_login.Text = ConfigurationManager.AppSettings["WelcomeButtonLogin" + choosenLanguage];
            AII_button_measure.Text = "Measure";

            Welcome_label_helloText.Text = "Welcome in Advantech Measure application. \n\nTo start, " +
                          "choose one of the options on the tab pane.\n" +
                          "If You want to read more about Advantech, click" +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and thats it" +
                          "\n\n KW";
            Measure_label_analogInput.Text = "You can measure:" +
                          "\n  - Instant input" +
                          "\n  - Buffered input";
            Measure_label_analogOutput.Text = "You can measure:" +
                          "\n  - Instant output" +
                          "\n  - Buffered output";
            Measure_label_digitalInput.Text = "You can measure:" +
                          "\n  - Instant input";
            Measure_label_digitalOutput.Text = "You can measure:" +
                          "\n  - Instant output";
            Measure_label_instant.Text = "You can measure:" +
                          "\n  - Instant output";
            Measure_label_buffered.Text = "You can measure:" +
                          "\n  - Instant output";

            // Ustawienie opcji wykresów
			ChartUtils.setChartZoomProperties (ABI_Chart);
			ChartUtils.setChartZoomProperties (AII_Chart);

            AII_labels = new Label[]{
                AII_label_ch0Value, 
                AII_label_ch1Value,
                AII_label_ch2Value, 
                AII_label_ch3Value,
                AII_label_ch4Value, 
                AII_label_ch5Value,
                AII_label_ch6Value, 
                AII_label_ch7Value
			};

			// Aktywacja pola wpisywania username'a
            this.Select();
            Welcome_textBox_username.Select();
        }



        /*
         * ==================================  ZMIANY STYLU I JĘZYKA, OPCJE  ========================================
         */

        /* Zmiana stylu z light na dark i odwrotnie.
           Używane z panelu opcji switcherem. */
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            StyleUtils.changeStyle(TabControl.Theme, this);
        }

        /* Zmiana języka na angielski */
        private void RadioButton_Options_English_CheckedChanged(object sender, EventArgs e)
        {
            LanguageUtils.changeLanguage(Language.ENG, this);
        }

        /* Zmiana języka na polski */
        private void RadioButton_Options_Polski_CheckedChanged(object sender, EventArgs e)
        {
            LanguageUtils.changeLanguage(Language.PL, this);
        }

        /* Metoda która zapisuje zmiany wprowadzone w panelu admina */
        private void Button_Options_ApplyChanges_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /* Metoda która przywraca domyślne ustawienia */
        private void Button_Options_BackToDefaults_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /* Zmień status dla dostepnosci opcji */
        private void CheckBox_AnalogInstantInput_Defaults_CheckedChanged(object sender, EventArgs e)
        {
            // TODO
        }

        /* Wybranie domyślnych wartości pomiaru */
        private void Button_AnalogInstantInput_Defaults_Click(object sender, EventArgs e)
        {
            AII_checkBox_measurmentOptions.Checked = false;
            AII_checkBox_defaults.Checked = true;

            DefaultStateUtils.setDefaultAII();
        }

        /* Czyszczenie pomiarow z bazy danych */
        private void Button_Options_ClearResults_Click(object sender, EventArgs e)
        {
            measurmentDAO.clearMeasurments();
        }



        /*
        * ============================================  NAWIGACJA  ========================================
        */


        /* Hiperłącze do strony Advantech. */
        private void Link1_Click(object sender, EventArgs e)
        {
            Process.Start(ADVANTECH_SITE);
        }

        /* Ukrycie przycisków z pozostałych wyborów. */
        private void Tile_AnalogInput_Click(object sender, EventArgs e)
        {
            Measure_tile_instantInput.Visible = true;
            Measure_tile_bufferedInput.Visible = true;

            Measure_tile_analogInput.Visible = false;
            Measure_tile_analogOutput.Visible = false;
            Measure_tile_digitalInput.Visible = false;
            Measure_tile_digitalOutput.Visible = false;
        }

        /* Odkrycie przycisków po wciśnięciu przycisku powrót. */
        private void Button_MeasureReturn_Click(object sender, EventArgs e)
        {
            if (Measure_tile_analogInput.Visible)
            {
                TabControl.SelectedTab = TabPage_MyMeasurements;
                TabControl.TabPages.Remove(TabPage_Measure);
            }
            else
            {
                Measure_tile_instantInput.Visible = false;
                Measure_tile_bufferedInput.Visible = false;

                Measure_tile_analogInput.Visible = true;
                Measure_tile_analogOutput.Visible = true;
                Measure_tile_digitalInput.Visible = true;
                Measure_tile_digitalOutput.Visible = true;
            }
        }

        /* Po wciśnięciu Entera w ekranie logowania, sytuacja powinna być identyczna
           jak po wciśnięciu przycisku. */
        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Welcome_button_login.PerformClick();
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Add(TabPage_AnalogBufferedInput);
            TabControl.TabPages.Remove(TabPage_Measure);
            TabControl.SelectedTab = TabPage_AnalogBufferedInput;
        }

        private void metroTileDigitalInput_MouseHover(object sender, EventArgs e)
        {
            Measure_label_digitalInput.Visible = true;
        }

        private void metroTileDigitalInput_MouseLeave(object sender, EventArgs e)
        {
            Measure_label_digitalInput.Visible = false;
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            Measure_label_analogInput.Visible = true;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            Measure_label_analogInput.Visible = false;
        }

        private void metroTileAnalogOutput_MouseEnter(object sender, EventArgs e)
        {
            Measure_label_analogOutput.Visible = true;
        }

        private void metroTileAnalogOutput_MouseLeave(object sender, EventArgs e)
        {
            Measure_label_analogOutput.Visible = false;
        }

        private void metroTileDigitalOutput_MouseEnter(object sender, EventArgs e)
        {
            Measure_label_digitalOutput.Visible = true;
        }

        private void metroTileDigitalOutput_MouseLeave(object sender, EventArgs e)
        {
            Measure_label_digitalOutput.Visible = false;
        }

        private void metroTileInstantInput_MouseEnter(object sender, EventArgs e)
        {
            Measure_label_instant.Visible = true;
        }

        private void metroTileInstantInput_MouseLeave(object sender, EventArgs e)
        {
            Measure_label_instant.Visible = false;
        }

        private void metroTileBufferedInput_MouseEnter(object sender, EventArgs e)
        {
            Measure_label_buffered.Visible = true;
        }

        private void metroTileBufferedInput_MouseLeave(object sender, EventArgs e)
        {
            Measure_label_buffered.Visible = false;
        }


        /* Przejście do InstantAnalogInput */
        private void Tile_InstantInput_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPage_AnalogInstantInput;
            TabControl.TabPages.Add(TabPage_AnalogInstantInput);
            TabControl.TabPages.Remove(TabPage_Measure);

            DefaultStateUtils.setDefaultAII();
        }

        /* Powrot z AnalogBufferedInput do measure */
        private void Button_AnalogBufferedInput_Back_Click(object sender, EventArgs e)
        {
            ABI_data = null;
            ABI_xPoint = 0;
            LastMeasure_GridTable.Rows.Clear();
            ChartUtils.clearChart(ABI_Chart);

            TabControl.TabPages.Add(TabPage_Measure);
            TabControl.TabPages.Remove(TabPage_AnalogBufferedInput);
            TabControl.SelectedTab = TabPage_Measure;
            //TabControl.TabPages.Remove(TabPage_LastMeasure);

        }

        /* Powrot z AnalogInstantInput do measure */
        private void Button_AnalogInstantInput_Back_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Add(TabPage_Measure);
            TabControl.TabPages.Remove(TabPage_AnalogInstantInput);
            TabControl.SelectedTab = TabPage_Measure;
            TabControl.TabPages.Remove(TabPage_LastMeasure);
        }

        /* Przejście do nowego pomiaru */
        private void Button_MyMeasurements_NewMeasure_Click(object sender, EventArgs e)
        {
            TabControl.TabPages.Add(TabPage_Measure);
            TabControl.SelectedTab = TabPage_Measure;
        }


        /*
        * =========================================== UTILITY ====================================================
        */



        private void timer_ProgressBar_Tick(object sender, EventArgs e)
        {
            ProgressSpinner.Refresh();
        }

        /* Tworzenie nowego usera */
        private void Button_Welcome_CreateNewUser_Click(object sender, EventArgs e)
        {
            CreateNewUserForm createNewUser = new CreateNewUserForm(this);
            createNewUser.Show();
        }

        /* Logowanie się. */
        private void Button_Login_Click(object sender, EventArgs e)
        {
            loginManager = new LoginManager(Options_textBox_baza.Text, Options_textBox_port.Text, Options_textBox_user.Text, Options_textBox_password.Text);
            Boolean loginSuccessful = loginManager.checkLogin(this.Welcome_textBox_username.Text, this.Welcome_textBox_password.Text);
            if (loginSuccessful)
            {
                UserDTO user = loginManager.loggedUser;
                measurmentDAO = new MeasurmentDAO(loginManager);
                MetroMessageBox.Show(this, "" + user.imie + ", logowanie powiodło się.", "Witaj", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (user.admin == 1)
                {
                    //this.TabControl.TabPages.Remove(metroTabPageWelcome);
                    TabControl.TabPages.Add(TabPage_Options);
                    TabControl.TabPages.Add(TabPage_MyMeasurements);

                    TabControl.SelectedTab = TabPage_Options;
                }
                else
                {
                    //this.TabControl.TabPages.Remove(metroTabPageWelcome);
                    this.TabControl.TabPages.Add(TabPage_MyMeasurements);

                    this.TabControl.SelectedTab = TabPage_MyMeasurements;
                }

                Welcome_textBox_username.Text = "";
                Welcome_textBox_password.Text = "";
                Welcome_textBox_password.Enabled = false;
                Welcome_textBox_username.Enabled = false;
                Welcome_button_login.Text = "Logout";

                // Load measurments
                measurmentDAO.loadMyMeasurments(user.idusers, this);
            }
            else
            {
                MetroMessageBox.Show(this, "Logowanie nie powiodło się. Spróbuj ponownie!", "Witaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /* Metoda odpowiedzialna za zapisanie pliku w formacie txt na pulpicie.
           Plik zawiera dane z ostatniego pomiaru. */
        private void Button_AnalogBufferedInput_ExportToFile_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm(this);
            commentForm.Show();
        }

        /* W przyszlosci - powiekszanie wykresu? */
        private void metroButton1_Click(object sender, EventArgs e)
        {
            // TODO
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        /* Zapis danych do bazy - czas poczatku pomiaru, konca, dane, id usera */
        public void saveResultsToDataBase(string dateStart, string dateEnd, double[] data, string duration, string samples, string numberofchannels, string startchannel, MetroFramework.Controls.MetroProgressBar progressBar)
        {
            measurmentDAO.saveDataToDataBase(dateStart, dateEnd, data, duration, samples, numberofchannels, startchannel, progressBar);
        }

        /* Edytowalny scrollbar zamiast utomatycznego */
        private void metroScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            TabPage_Options.VerticalScroll.Value = e.NewValue * 5;
        }

        /* Automatyczne ustawienie focusa na kontrolce */
        private void metroTextBox4_Enter(object sender, EventArgs e)
        {
            Point p = TabPage_Options.AutoScrollPosition;
            AutoScrollPositionDelegate del = new AutoScrollPositionDelegate(SetAutoScrollPosition);
            Object[] args = { TabPage_Options, p };
            BeginInvoke(del, args);
        }

        /* Metoda ustawiajaca focus na kontrolce */
        public void SetAutoScrollPosition(ScrollableControl sender, Point p)
        {
            p.X = Math.Abs(p.X);
            p.Y = Math.Abs(p.Y);
            sender.AutoScrollPosition = p;
        }

        /* Accessor dla innego formularza, aby byl widoczny gridTable */
        public MetroFramework.Controls.MetroGrid metroGridTableVisible
        {
            get { return this.LastMeasure_GridTable; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroTextBox TextBox_Options_UserComment_Visible
        {
            get { return this.Options_textBox_userComment; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroTextBox TextBox_Options_AdminComment_Visible
        {
            get { return this.Options_textBox_adminComment; }
        }

        /* Accessor dla innego formularza */
        public double getAnalogInstantInputTimer
        {
            set { AII_timerValue = value; }
            get { return AII_timerValue; }
        }

        /* Accessor dla innego formularza */
        public int getChoosenChannelAII
        {
            set { AII_choosenChannel = value; }
            get { return AII_choosenChannel; }
        }

        /* Accessor dla innego formularza */
        public int getChoosenChannelABI
        {
            set { this.ABI_textBox_channelStart.Text = value.ToString(); }
            get { return int.Parse(this.ABI_textBox_channelStart.Text); }
        }

        /* Accessor dla innego formularza */
        public int getNumberOfChannelsAAI
        {
            set { AII_numOfChannels = value; }
            get { return AII_numOfChannels; }
        }

        /* Accessor dla innego formularza */
        public int getNumberOfChannelsABI
        {
            set { this.ABI_textBox_channels.Text = value.ToString(); }
            get { return int.Parse(this.ABI_textBox_channels.Text); }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroCheckBox getCheckbox_AnalogInstantInput_MeasurmentOptions
        {
            get { return this.AII_checkBox_measurmentOptions; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroCheckBox getCheckbox_AnalogInstantInput_Defaults
        {
            get { return this.AII_checkBox_defaults; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroTextBox getDatabaseAddress
        {
            get { return this.Options_textBox_baza; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroTextBox getDatabasePort
        {
            get { return this.Options_textBox_port; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroTextBox getDatabaseUser
        {
            get { return this.Options_textBox_user; }
        }

        /* Accessor dla innego formularza */
        public MetroFramework.Controls.MetroTextBox getDatabasePassword
        {
            get { return this.Options_textBox_password; }
        }


        /*
        * =============================================  ABI ====================================================
        */

        /* Rozpocznij proces pobierana zbufforowanych danych z karty. */
        private void buttonAnalogBufferedInput_Click(object sender, EventArgs e)
        {
            // TODO REFACTOR

            lastMeasurmentType = MeasurmentType.ANALOG_BUFFERED_INPUT;
            timer_ProgressBar.Start();
            ABI_timerStart = DateTime.Now;
            ABI_label_startValue.Text = ABI_timerStart.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
            ABI_label_endValue.Text = "00 : 00 : 00.000";
            ABI_label_durationValue.Text = "00 : 00 : 00.000";

            ProgressSpinner.Visible = true;
            ABI_data = null;
            ABI_xPoint = 0;
            LastMeasure_GridTable.Rows.Clear();
            ChartUtils.clearChart(ABI_Chart);

            // Obiekty pomagające
            ABI = new BufferedAnalogInput();
            ABI.setSamples(Convert.ToInt32(ABI_textBox_samples.Text));
            ABI.setChannels(Convert.ToInt32(ABI_textBox_channels.Text));
            ABI.setChannelStart(Convert.ToInt32(ABI_textBox_channelStart.Text));
            ABI.setIntervalCount(Convert.ToInt32(ABI_textBox_intervalCount.Text));
            ABI.setScanCount(Convert.ToInt32(ABI_textBox_scanCount.Text));
            ABI.setRate(Convert.ToInt32(ABI_textBox_rate.Text));

            ABI_data = ABI.przygotujPomiar(ABIControl);
        }

        /* W momencie uzyskania danych z karty (koniec przygotowania pomiaru),
         skopiuj dane do globalnego zbioru. */
        private void bufferedAiCtrl1_DataReady(object sender, Automation.BDaq.BfdAiEventArgs e)
        {
            ABIControl.GetData(e.Count, ABI_data);
            ABI_allData.AddRange(ABI_data);
        }


        /* Przesunięcie suwakiem powinno zwiększać/zmniejszać maksymalny zakres
           na osi X na wykresie. Markery powinny pojawiać się po przekroczeniu
           pewnego poziomu zbliżenia. */
        private void TrackBar_AnalogBufferedInput_1_ValueChanged(object sender, EventArgs e)
        {
            if (this.ABI_TrackBar_1.Value == 0)
            {
                return;
            }
            this.ABI_Chart.ChartAreas[0].AxisX.Maximum = double.Parse(this.ABI_textBox_samples.Text) * ((double)(this.ABI_TrackBar_1.Value) / 100);

            double ratio = (this.ABI_Chart.ChartAreas[0].AxisX.Maximum - this.ABI_Chart.ChartAreas[0].AxisX.Minimum);
            ChartUtils.changeChartMarkerRatio(this.ABI_Chart, ratio);
            ABI_label_trackBar1.Text = "Zoom X: " + ABI_TrackBar_1.Value + " %";
        }

        /* Przesunięcie suwakiem 2 powinno przesuwać wykres wzdłóż jego osi,
           od minimalnej do maksymalnej wartości. */
        private void TrackBar_AnalogBufferedInput_2_ValueChanged(object sender, EventArgs e)
        {
            double MIN = 0;
            double MAX = (double.Parse(this.ABI_textBox_samples.Text));
            double howMuchToChange = (MAX / 100) * this.ABI_TrackBar_2.Value;
            double window = ABI_Chart.ChartAreas[0].AxisX.Maximum - ABI_Chart.ChartAreas[0].AxisX.Minimum;
            ABI_Chart.ChartAreas[0].AxisX.Minimum = howMuchToChange;
            ABI_Chart.ChartAreas[0].AxisX.Maximum = window + howMuchToChange;
            ABI_label_trackBar2.Text = "Position X: " + ABI_TrackBar_2.Value + " %";
        }

        /* Zoom myszą powinien spowodować pojawienie się markerów na wykresie
           po przekroczeniu pewnego zbliżenia. */
        private void Chart_AnalogBufferedInput_AxisViewChanged(object sender, ViewEventArgs e)
        {
            double ratio = (this.ABI_Chart.ChartAreas[0].AxisX.ScaleView.ViewMaximum - this.ABI_Chart.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
            ChartUtils.changeChartMarkerRatio(this.ABI_Chart, ratio);
        }

        /* Restart zbliżenia po kliknięciu prawego przycisku myszy. */
        private void Chart_AnalogBufferedInput_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Right)
                {
                    ABI_Chart.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    ABI_Chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    double ratio = ABI_Chart.ChartAreas[0].AxisX.Maximum - ABI_Chart.ChartAreas[0].AxisX.Minimum;

                    ChartUtils.changeChartMarkerRatio(ABI_Chart, ratio);
                }
            }
        }

        /* Czyszczenie danych po zakonczeniu ich pobierania w trybie buffered */
        private void bufferedAiCtrl1_Stopped(object sender, BfdAiEventArgs e)
        {
            ABI = null;
            ABI_timeEnd = DateTime.Now;
            ABI_timeDiff = ABI_timeEnd.Subtract(ABI_timerStart);
            MessageBox.Show("Koniec");
            // Update UI z innego wątku
            MethodInvoker inv = delegate
            {
                ABI_label_endValue.Text = ABI_timeEnd.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                ABI_label_durationValue.Text = new DateTime(ABI_timeDiff.Ticks).ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                if (TabControl.TabPages.Contains(TabPage_LastMeasure))
                {

                }
                else
                {
                    TabControl.TabPages.Add(TabPage_LastMeasure);
                }

                ABI_TrackBar_1.Value = 100;
                ABI_TrackBar_2.Value = 0;

                timer_ProgressBar.Stop();
                ProgressSpinner.Visible = false;
                ProgressSpinner.Refresh();

                this.Invoke((UpdateUIDelegate)delegate()
                {

                    int myABIXDataReadyPoint = 0;
                    int mySeries = 0;
                    int channels = int.Parse(this.ABI_textBox_channels.Text.ToString());
                    for (int i = 0; i < ABI_allData.Count; ++i)
                    {
                        mySeries = (i % channels);
                        if (mySeries == 0)
                        {
                            ABI_xPoint++;
                            myABIXDataReadyPoint++;
                        }

                        //MEMO LEAK
                        ABI_Chart.Series[mySeries].Points.Add(new DataPoint(ABI_xPoint, ABI_allData[i]));
                        ABI_Chart.Series[mySeries].ToolTip = "X=#VALX\nY=#VALY";
                        LastMeasure_GridTable.Rows.Add();
                        LastMeasure_GridTable.Rows[ABI_xPoint - 1].Cells[mySeries].Value = ABI_allData[i];
                    }
                });
            };
            this.Invoke(inv);
        }



        /*
        * =============================================  AII ====================================================
        */

        /* Rozpoczęcie pomiaru Analog Instant Input */
        private void Button_AnalogInstantInput_Click(object sender, EventArgs e)
        {
            // Button start mode
            if (AII_button_measure.Text.Equals("Measure"))
            {
                createNewMeasurment();
                lastMeasurmentType = MeasurmentType.ANALOG_INSTANT_INPUT;
                MM_list_titles[MM_numberOfMeasurments - 1].Text = "Measurment #" + MM_numberOfMeasurments;

                // Set start time
                AII_timeStart = DateTime.Now;
                AII_label_startValue.Text = AII_timeStart.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                MM_list_titles[MM_numberOfMeasurments - 1].Text += "  -  " + AII_timeStart.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);

                AAI_isRunning = true;

                // Un-enable edit buttons
                AII_button_editOptions.Enabled = false;
                AII_button_defaults.Enabled = false;

                // Clear chart
                foreach (var series in AII_Chart.Series)
                {
                    series.Points.Clear();
                    LastMeasure_GridTable.Rows.Clear();
                }

                // Show markers if zoomed
                double ratio = AII_Chart.ChartAreas[0].AxisX.Maximum - AII_Chart.ChartAreas[0].AxisX.Minimum;
                ChartUtils.changeChartMarkerRatio(AII_Chart, ratio);

                AII_button_measure.Text = "Stop";


                // Start!
                //timer_getData.Start();

                AII_timer.MicroTimerElapsed +=
                    new MicroLibrary.MicroTimer.MicroTimerElapsedEventHandler(OnTimedEvent);

                AII_timer.Interval = 1000; // Call micro timer every 1000µs (1ms)
                AII_timerValue = AII_timer.Interval / 1000;

                // Can choose to ignore event if late by Xµs (by default will try to catch up)
                // microTimer.IgnoreEventIfLateBy = 500; // 500µs (0.5ms)

                AII_timer.Enabled = true; // Start timer

            } // Button stop mode
            else if (AII_button_measure.Text.Equals("Stop"))
            {
                // pokazanie czasu
                AII_timeEnd = DateTime.Now;
                AII_label_endValue.Text = AII_timeEnd.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                AII_timeDiff = AII_timeEnd.Subtract(AII_timeStart);
                AII_label_durationValue.Text = new DateTime(AII_timeDiff.Ticks).ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                MM_list_titles[MM_numberOfMeasurments - 1].Text += "                                           duration:  " + new DateTime(AII_timeDiff.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);

                //timer_getData.Stop();
                AII_timer.Enabled = false;
                AII_data = new double[8];
                AII_button_measure.Text = "Save";
                MM_list_samplesValue[MM_numberOfMeasurments - 1].Text = AAI_sampleCount.ToString();
                MM_list_numberOfChannelsValue[MM_numberOfMeasurments - 1].Text = AII_numOfChannels.ToString();
                MM_list_channelStartValue[MM_numberOfMeasurments - 1].Text = AII_choosenChannel.ToString();
            }

                // Button save mode
            else
            {
                this.TabControl.TabPages.Add(TabPage_LastMeasure);
                this.TabControl.SelectedTab = TabPage_LastMeasure;
            }
        }

        /* Każdy tick oznacza odświeżenie wykresu dla opcji instant input,
          im jest częściej, tym większa częstotliwość pomiaru. */
        private void timer_getData_Tick(object sender, EventArgs e)
        {
            //double timeInterval = analogInstantInputTimer;
            //if (timeInterval == 0)
            //{
            //    timeInterval = 1;
            //    analogInstantInputTimer = 1;
            //}

            //timer_getData.Interval = (int)timeInterval * 1;
            ErrorCode err;

            err = AIIControl.Read(AII_choosenChannel, AII_numOfChannels, AII_data);
            if (err != ErrorCode.Success)
            {
                timer_getData.Stop();
            }
            //for (int i = 0; i < analogInstantInput_numberOfChannels; i++)
            //{
            //    Chart_AnalogInstantInput.Series[i].Points.Add(dataInstantAI[i]);
            //    metroGridTable.Rows.Add();
            //    metroGridTable.Rows[sampleCountAAI].Cells[i].Value = dataInstantAI[i];
            //    analogInstantInputLabels[i].Text = Math.Round(dataInstantAI[i], 2).ToString();
            //}

            AAI_sampleCount++;


            //if (analogInstantInputMovingWindow)
            //{
            //    Chart_AnalogInstantInput.ChartAreas[0].AxisX.Minimum = sampleCountAAI - int.Parse(TextBox_AnalogInstantInput_MovingWindow.Text);
            //}

        }

        private void OnTimedEvent(object sender,
                                  MicroLibrary.MicroTimerEventArgs timerEventArgs)
        {
            ErrorCode err;

            err = AIIControl.Read(AII_choosenChannel, AII_numOfChannels, AII_data);
            if (err != ErrorCode.Success)
            {
                AII_timer.Stop();
            }

            // Do something small that takes significantly less time than Interval
            MethodInvoker inv = delegate
            {
                for (int i = 0; i < AII_numOfChannels; i++)
                {
                    if (AAI_sampleCount % 10 == 0)
                    {
                        AII_drawnPoints++;
                        AII_Chart.Series[i].Points.Add(AII_data[i]);
                        if (AII_MovingWindow)
                        {
                            AII_Chart.ChartAreas[0].AxisX.Minimum = AII_drawnPoints - int.Parse(AII_textBox_movingWindow.Text);
                        }
                    }

                    LastMeasure_GridTable.Rows.Add();
                    LastMeasure_GridTable.Rows[AAI_sampleCount].Cells[i].Value = AII_data[i];
                    //analogInstantInputLabels[i].Text = Math.Round(dataInstantAI[i], 2).ToString();
                }


            };

            this.Invoke(inv);

            AAI_sampleCount++;
        }

        /* Zatrzymanie pobierania danych */
        private void Button_AnalogInstantInput_Reset_Click(object sender, EventArgs e)
        {
            timer_getData.Stop();
            AII_data = new double[8];
            //Button_AnalogInstantInput_Pause.Text.Equals("Pause");
            foreach (var series in AII_Chart.Series)
            {
                series.Points.Clear();
                LastMeasure_GridTable.Rows.Clear();
            }

            // Restart Chart to 0 position
            AII_Chart.ChartAreas[0].AxisX.Minimum = 0;
            AII_Chart.ChartAreas[0].AxisX.Maximum = Double.NaN;
            AAI_sampleCount = 0;
            AAI_isRunning = false;
            AII_button_measure.Text = "Measure";

            //unlock buttons
            AII_button_defaults.Enabled = true;
            AII_button_editOptions.Enabled = true;


        }

        /// ??
        private void TrackBar_AnalogInstantInput_1_Scroll(object sender, ScrollEventArgs e)
        {
            // TODO
            AII_toggle_movingWindow.Checked = false;

            AII_Chart.ChartAreas[0].AxisX.Minimum = 0;

            if (AII_trackBar_1.Value == 0)
            {
                return;
            }
            AII_Chart.ChartAreas[0].AxisX.Maximum = AAI_sampleCount * ((double)(AII_trackBar_1.Value) / 100);

            double ratio = (AII_Chart.ChartAreas[0].AxisX.Maximum - AII_Chart.ChartAreas[0].AxisX.Minimum);
            ChartUtils.changeChartMarkerRatio(AII_Chart, ratio);
        }

        /* Ustawienie widoku wykresu "poruszającego się okna" */
        private void Toggle_AnalogInstantInput_MovingWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (AII_toggle_movingWindow.Checked)
            {
                AII_Chart.ChartAreas[0].AxisX.Maximum = Double.NaN;
                AII_Chart.ChartAreas[0].AxisX.Minimum = AAI_sampleCount - int.Parse(AII_textBox_movingWindow.Text.ToString());
                AII_trackBar_1.Enabled = false;
                AII_trackBar_2.Enabled = false;
                AII_MovingWindow = true;
            }
            else
            {
                AII_Chart.ChartAreas[0].AxisX.Maximum = Double.NaN;
                AII_Chart.ChartAreas[0].AxisX.Minimum = 0;
                AII_trackBar_1.Enabled = true;
                AII_trackBar_2.Enabled = true;
                AII_MovingWindow = false;
            }
        }

        /* Otworzenie okna opcji dla AnalogInstantInput */
        private void Button_AnalogInstantInput_EditOptions_Click(object sender, EventArgs e)
        {
            AIIMeasureOptionsForm analogInstantInputOptions = new AIIMeasureOptionsForm(this);
            analogInstantInputOptions.Show();

        }

        /* Wyświetlanie markerów na wykresie analoginstantinput */
        private void Chart_AnalogInstantInput_AxisViewChanged(object sender, ViewEventArgs e)
        {
            double ratio = (this.AII_Chart.ChartAreas[0].AxisX.ScaleView.ViewMaximum - this.AII_Chart.ChartAreas[0].AxisX.ScaleView.ViewMinimum);
            ChartUtils.changeChartMarkerRatio(this.AII_Chart, ratio);

        }

        /* Oddalenie widoku na wykresie analoginstantinput */
        private void Chart_AnalogInstantInput_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Right)
                {
                    AII_Chart.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                    AII_Chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    double ratio = AII_Chart.ChartAreas[0].AxisX.Maximum - AII_Chart.ChartAreas[0].AxisX.Minimum;

                    ChartUtils.changeChartMarkerRatio(AII_Chart, ratio);
                }
            }
        }

        /* Przesunięcie suwakiem 2 powinno przesuwać wykres wzdłóż jego osi,
        od minimalnej do maksymalnej wartości. */
        private void TrackBar_AnalogInstantInput_2_Scroll(object sender, ScrollEventArgs e)
        {
            double MIN = 0;
            double MAX = AAI_sampleCount;
            double howMuchToChange = (MAX / 100) * this.AII_trackBar_2.Value;
            double window = AII_Chart.ChartAreas[0].AxisX.Maximum - AII_Chart.ChartAreas[0].AxisX.Minimum;
            AII_Chart.ChartAreas[0].AxisX.Minimum = howMuchToChange;
            AII_Chart.ChartAreas[0].AxisX.Maximum = window + howMuchToChange;
            //Label_AnalogBufferedInput_TrackBar2.Text = "Position X: " + TrackBar_AnalogBufferedInput_2.Value + " %";
        }


        /*
        * =============================================  MY MEASURMENTS ====================================================
        */

        /* Zmiana kolorów labeli po najechaniu na PRZYCISK myszką,
           tak żeby nie było widać że są postawione na przycisku */
        private void metroButton1_MouseEnter(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroButton)sender).BackColor = Color.FromArgb(255, 0, 0);
            if (MM_list_buttons.Contains(sender))
            {
                int index = MM_list_buttons.IndexOf((MetroFramework.Controls.MetroButton)sender);
                MM_list_titles[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_channelStart[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_samplesValue[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_numberOfChannels[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_numberOfChannelsValue[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_channelStart[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_channelStartValue[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_samples[index].BackColor = COLOR_LIGHT_DARK;
                MM_list_samplesValue[index].BackColor = COLOR_LIGHT_DARK;

                MM_list_titles[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_channelStart[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_samplesValue[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_numberOfChannels[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_numberOfChannelsValue[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_channelStart[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_channelStartValue[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_samples[index].ForeColor = COLOR_GRAY_DARK;
                MM_list_samplesValue[index].ForeColor = COLOR_GRAY_DARK;
            }
        }

        private void metroButton1_MouseLeave(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroButton)sender).BackColor = COLOR_GRAY_DARK;
            if (MM_list_buttons.Contains(sender))
            {
                int index = MM_list_buttons.IndexOf((MetroFramework.Controls.MetroButton)sender);
                MM_list_titles[index].BackColor = COLOR_GRAY_DARK;
                MM_list_channelStart[index].BackColor = COLOR_GRAY_DARK;
                MM_list_samplesValue[index].BackColor = COLOR_GRAY_DARK;
                MM_list_numberOfChannels[index].BackColor = COLOR_GRAY_DARK;
                MM_list_numberOfChannelsValue[index].BackColor = COLOR_GRAY_DARK;
                MM_list_channelStart[index].BackColor = COLOR_GRAY_DARK;
                MM_list_channelStartValue[index].BackColor = COLOR_GRAY_DARK;
                MM_list_samples[index].BackColor = COLOR_GRAY_DARK;
                MM_list_samplesValue[index].BackColor = COLOR_GRAY_DARK;

                MM_list_titles[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_channelStart[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_samplesValue[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_numberOfChannels[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_numberOfChannelsValue[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_channelStart[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_channelStartValue[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_samples[index].ForeColor = COLOR_LIGHT_DARK;
                MM_list_samplesValue[index].ForeColor = COLOR_LIGHT_DARK;
            }
        }

        private void Button_MyMeasurments_Measure1_MouseHover(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroButton)sender).BackColor = COLOR_LIGHT_DARK;
        }


        /* Tworzy nowy zestaw przyciskow i labelów w oknie MyMeasurments
           dla jednego, aktualnego pomiaru */
        public void createNewMeasurment()
        {

            // Button
            MetroFramework.Controls.MetroButton newButton = new MetroFramework.Controls.MetroButton();
            newButton.Theme = STYLE_DARK;
            newButton.Location = new Point(25, 72 + (80 + 20) * MM_numberOfMeasurments);
            newButton.Size = new Size(700, 80);
            newButton.Name = "Button_MyMeasurments_Measurment" + MM_numberOfMeasurments;
            newButton.UseCustomBackColor = true;
            newButton.BackColor = COLOR_GRAY_DARK;
            newButton.MouseLeave += new EventHandler(metroButton1_MouseLeave);
            newButton.MouseEnter += new EventHandler(metroButton1_MouseEnter);
            newButton.Click += Button_MyMeasurments_Measure1_Click;
            TabPage_MyMeasurements.Controls.Add(newButton);
            MM_list_buttons.Add(newButton);

            // Label title
            MetroFramework.Controls.MetroLabel titleLabel = new MetroFramework.Controls.MetroLabel();
            titleLabel.Theme = STYLE_DARK;
            titleLabel.Location = new Point(30, 80 + (80 + 20) * MM_numberOfMeasurments);
            titleLabel.Name = "Label_MyMeasurments_ResultTitle" + MM_numberOfMeasurments;
            titleLabel.Text = "Measurment #" + MM_numberOfMeasurments;
            titleLabel.Size = new Size(140, 25);
            titleLabel.UseCustomBackColor = true;
            titleLabel.UseCustomForeColor = true;
            titleLabel.BackColor = COLOR_GRAY_DARK;
            titleLabel.ForeColor = COLOR_LIGHT_DARK;
            titleLabel.UseStyleColors = true;
            titleLabel.Style = MetroColorStyle.Red;
            titleLabel.FontSize = MetroLabelSize.Tall;
            titleLabel.AutoSize = true;
            TabPage_MyMeasurements.Controls.Add(titleLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(titleLabel, 0);
            MM_list_titles.Add(titleLabel);

            // Label Channel start
            MetroFramework.Controls.MetroLabel channelStartLabel = new MetroFramework.Controls.MetroLabel();
            channelStartLabel.Theme = STYLE_DARK;
            channelStartLabel.Location = new Point(110, 120 + (80 + 20) * MM_numberOfMeasurments);
            channelStartLabel.Name = "Label_MyMeasurments_ChannelStart" + MM_numberOfMeasurments;
            channelStartLabel.Text = "Channel start:";
            //channelStartLabel.Size = new Size(140, 25);
            channelStartLabel.UseCustomBackColor = true;
            channelStartLabel.BackColor = COLOR_GRAY_DARK;
            channelStartLabel.ForeColor = COLOR_LIGHT_DARK;
            channelStartLabel.UseCustomForeColor = true;
            channelStartLabel.FontSize = MetroLabelSize.Medium;
            TabPage_MyMeasurements.Controls.Add(channelStartLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(channelStartLabel, 0);
            MM_list_channelStart.Add(channelStartLabel);

            // Label Channel start value
            MetroFramework.Controls.MetroLabel channelStartValueLabel = new MetroFramework.Controls.MetroLabel();
            channelStartValueLabel.Theme = STYLE_DARK;
            channelStartValueLabel.Location = new Point(200, 120 + (80 + 20) * MM_numberOfMeasurments);
            channelStartValueLabel.Name = "Label_MyMeasurments_ChannelStartValue" + MM_numberOfMeasurments;
            channelStartValueLabel.Text = "0";
            //channelStartValueLabel.Size = new Size(140, 25);
            channelStartValueLabel.UseCustomBackColor = true;
            channelStartValueLabel.UseCustomForeColor = true;
            channelStartValueLabel.BackColor = COLOR_GRAY_DARK;
            channelStartValueLabel.ForeColor = COLOR_LIGHT_DARK;
            channelStartValueLabel.FontSize = MetroLabelSize.Medium;
            TabPage_MyMeasurements.Controls.Add(channelStartValueLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(channelStartValueLabel, 0);
            MM_list_channelStartValue.Add(channelStartValueLabel);


            // Label Number of channels
            MetroFramework.Controls.MetroLabel numberOfChannelsLabel = new MetroFramework.Controls.MetroLabel();
            numberOfChannelsLabel.Theme = STYLE_DARK;
            numberOfChannelsLabel.Location = new Point(290, 120 + (80 + 20) * MM_numberOfMeasurments);
            numberOfChannelsLabel.Name = "Label_MyMeasurments_NumberOfChannels" + MM_numberOfMeasurments;
            numberOfChannelsLabel.Text = "Number of channels:";
            numberOfChannelsLabel.Size = new Size(140, 25);
            numberOfChannelsLabel.UseCustomBackColor = true;
            numberOfChannelsLabel.UseCustomForeColor = true;
            numberOfChannelsLabel.BackColor = COLOR_GRAY_DARK;
            numberOfChannelsLabel.ForeColor = COLOR_LIGHT_DARK;
            numberOfChannelsLabel.FontSize = MetroLabelSize.Medium;
            TabPage_MyMeasurements.Controls.Add(numberOfChannelsLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(numberOfChannelsLabel, 0);
            MM_list_numberOfChannels.Add(numberOfChannelsLabel);

            // Label Number of channels value
            MetroFramework.Controls.MetroLabel numberOfChannelsValueLabel = new MetroFramework.Controls.MetroLabel();
            numberOfChannelsValueLabel.Theme = STYLE_DARK;
            numberOfChannelsValueLabel.Location = new Point(425, 120 + (80 + 20) * MM_numberOfMeasurments);
            numberOfChannelsValueLabel.Name = "Label_MyMeasurments_NumberOfChannelsValue" + MM_numberOfMeasurments;
            numberOfChannelsValueLabel.Text = "0";
            //numberOfChannelsValueLabel.Size = new Size(140, 25);
            numberOfChannelsValueLabel.UseCustomBackColor = true;
            numberOfChannelsValueLabel.UseCustomForeColor = true;
            numberOfChannelsValueLabel.BackColor = COLOR_GRAY_DARK;
            numberOfChannelsValueLabel.ForeColor = COLOR_LIGHT_DARK;
            numberOfChannelsValueLabel.FontSize = MetroLabelSize.Medium;
            TabPage_MyMeasurements.Controls.Add(numberOfChannelsValueLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(numberOfChannelsValueLabel, 0);
            MM_list_numberOfChannelsValue.Add(numberOfChannelsValueLabel);

            // Label Samples
            MetroFramework.Controls.MetroLabel samplesLabel = new MetroFramework.Controls.MetroLabel();
            samplesLabel.Theme = STYLE_DARK;
            samplesLabel.Location = new Point(540, 120 + (80 + 20) * MM_numberOfMeasurments);
            samplesLabel.Name = "Label_MyMeasurments_Samples" + MM_numberOfMeasurments;
            samplesLabel.Text = "Samples:";
            //samplesLabel.Size = new Size(140, 25);
            samplesLabel.UseCustomBackColor = true;
            samplesLabel.UseCustomForeColor = true;
            samplesLabel.BackColor = COLOR_GRAY_DARK;
            samplesLabel.ForeColor = COLOR_LIGHT_DARK;
            samplesLabel.FontSize = MetroLabelSize.Medium;
            TabPage_MyMeasurements.Controls.Add(samplesLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(samplesLabel, 0);
            MM_list_samples.Add(samplesLabel);

            // Label Samples value
            MetroFramework.Controls.MetroLabel samplesValueLabel = new MetroFramework.Controls.MetroLabel();
            samplesValueLabel.Theme = STYLE_DARK;
            samplesValueLabel.Location = new Point(605, 120 + (80 + 20) * MM_numberOfMeasurments);
            samplesValueLabel.Name = "Label_MyMeasurments_SamplesValue" + MM_numberOfMeasurments;
            samplesValueLabel.Text = "0";
            //samplesValueLabel.Size = new Size(140, 25);
            samplesValueLabel.UseCustomBackColor = true;
            samplesValueLabel.UseCustomForeColor = true;
            samplesValueLabel.BackColor = COLOR_GRAY_DARK;
            samplesValueLabel.ForeColor = COLOR_LIGHT_DARK;
            samplesValueLabel.FontSize = MetroLabelSize.Medium;
            TabPage_MyMeasurements.Controls.Add(samplesValueLabel);
            TabPage_MyMeasurements.Controls.SetChildIndex(samplesValueLabel, 0);
            MM_list_samplesValue.Add(samplesValueLabel);

            MM_numberOfMeasurments++;

        }



        /* Reakcja na kliknięcie konkretnego przycisku */
        private void Button_MyMeasurments_Measure1_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedTab = TabPage_ShowMeasure;
            int index = MM_list_buttons.IndexOf((MetroFramework.Controls.MetroButton)sender);
            MessageBox.Show(index.ToString());
            ShowMeasure_label_startValue.Text = myLoadedMeasurments[index].timestart;
            ShowMeasure_label_endValue.Text = myLoadedMeasurments[index].timeend;
            ShowMeasure_label_durationValue.Text = myLoadedMeasurments[index].duration;
        }

        /* method stub */
        internal void SetLanguage()
        {
            throw new NotImplementedException();
        }
    }
}
