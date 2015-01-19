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
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace DAQNavi_WF_v1_0_0
{
    public partial class MainWindow : MetroForm
    {
        delegate void UpdateUIDelegate();
        double[] dataDownloadedAI;
        Stopwatch stopwatch = new Stopwatch();


        public MainWindow()
        {

            // Przygotowanie programu do pracy - ukrycie zakładek
            InitializeComponent();

            this.TabControl.TabPages.Remove(TabPage_AnalogOutput);
            this.TabControl.TabPages.Remove(TabPage_AnalogBufferedInput);
            this.TabControl.TabPages.Remove(TabPage_DigitalInput);
            this.TabControl.TabPages.Remove(TabPage_DigitalOutput);
            this.TabControl.TabPages.Remove(TabPage_LastMeasure);
            this.TabControl.TabPages.Remove(TabPage_Options);
            this.TabControl.TabPages.Remove(TabPage_Measure);

            // Ustawienie tekstów
            Label_HelloText.Text = "Welcome in Advantech Measure application. \n\nTo start, " +
                          "choose one of the options on the tab pane.\n" +
                          "If You want to read more about Advantech, click" +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and thats it" +
                          "\n\n KW";
            Label_AnalogInput.Text = "You can measure:" +
                          "\n  - Instant input" +
                          "\n  - Buffered input";
            Label_AnalogOutput.Text = "You can measure:" +
                          "\n  - Instant output" +
                          "\n  - Buffered output";
            Label_DigitalInput.Text = "You can measure:" +
                          "\n  - Instant input";
            Label_DigitalOutput.Text = "You can measure:" +
                          "\n  - Instant output";
            Label_Instant.Text = "You can measure:" +
                          "\n  - Instant output";
            Label_Buffered.Text = "You can measure:" +
                          "\n  - Instant output";

            // Ustawienie opcji wykresów
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            Chart_AnalogBufferedInput.ChartAreas[0].CursorX.AutoScroll = true;
            Chart_AnalogBufferedInput.ChartAreas[0].CursorY.AutoScroll = true;

            Chart_AnalogBufferedInput.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            Chart_AnalogBufferedInput.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            this.Select();
            this.TextBox_Username.Select();
        }

        /// <summary>
        /// W momencie uzyskania danych z karty (koniec przygotowania pomiaru),
        /// narysuj wykres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bufferedAiCtrl1_DataReady(object sender, Automation.BDaq.BfdAiEventArgs e)
        {
            bufferedAiCtrl1.GetData(e.Count, dataDownloadedAI);
            this.Invoke((UpdateUIDelegate)delegate()
            {
                AnalogBufferedInput_ProgressSpinner.Visible = true;
                AnalogBufferedInput_ProgressSpinner.Refresh();

                int myXPoint = 0;
                int mySeries = 0;
                int channels = int.Parse(this.TextBox_Channels.Text.ToString());
                for (int i = 0; i < e.Count; ++i)
                {
                    mySeries = (i % channels);
                    if (mySeries == 0){
                        myXPoint++;
                    }

                    Chart_AnalogBufferedInput.Series[mySeries].Points.Add(new DataPoint(myXPoint,dataDownloadedAI[i]));
                    Chart_AnalogBufferedInput.Series[mySeries].ToolTip = "X=#VALX\nY=#VALY";
                    metroGridTable.Rows.Add();
                    metroGridTable.Rows[myXPoint-1].Cells[mySeries].Value = dataDownloadedAI[i];
                    //Odświeżanie wyresu
                    //if (i % 20 == 0)
                    //{
                    //    Chart_AnalogInput.Refresh();
                    //    metroProgress_Spinner.Refresh();
                    //}
                }
                
                this.TrackBar_AnalogBufferedInput_1.Value = 100;
                AnalogBufferedInput_ProgressSpinner.Visible = false;
                AnalogBufferedInput_ProgressSpinner.Refresh();
                if (this.TabControl.TabPages.Contains(TabPage_LastMeasure))
                {

                }
                else
                {
                    this.TabControl.TabPages.Add(TabPage_LastMeasure);
                }
                
            });
        }

        /// <summary>
        /// Rozpocznij proces pobierana zbufforowanych danych z karty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnalogBufferedInput_Click(object sender, EventArgs e)
        {
            foreach (var series in Chart_AnalogBufferedInput.Series)
            {
                series.Points.Clear();
                metroGridTable.Rows.Clear();
            }

            BufferedAnalogInput bufferedAnalogInput = new BufferedAnalogInput();
            bufferedAnalogInput.setSamples(Convert.ToInt32(TextBox_Samples.Text));
            bufferedAnalogInput.setChannels(Convert.ToInt32(TextBox_Channels.Text));
            bufferedAnalogInput.setChannelStart(Convert.ToInt32(TextBox_ChannelStart.Text));
            bufferedAnalogInput.setIntervalCount(Convert.ToInt32(TextBox_IntervalCount.Text));
            bufferedAnalogInput.setScanCount(Convert.ToInt32(TextBox_ScanCount.Text));
            bufferedAnalogInput.setRate(Convert.ToInt32(TextBox_Rate.Text));

            dataDownloadedAI = bufferedAnalogInput.przygotujPomiar(bufferedAiCtrl1);
        }

        /// <summary>
        /// Zmiana stylu z light na dark i odwrotnie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            TabPage_AnalogBufferedInput.Theme = MetroFramework.MetroThemeStyle.Light;
            TabPage_AnalogOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            TabPage_DigitalInput.Theme = MetroFramework.MetroThemeStyle.Light;
            TabPage_DigitalOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            TabPage_Options.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabelSamples.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabelChannels.Theme = MetroFramework.MetroThemeStyle.Light;
            metroGridTable.Theme = MetroFramework.MetroThemeStyle.Light;
            TextBox_Channels.Theme = MetroFramework.MetroThemeStyle.Light;
            TextBox_Samples.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            Button_AnalogBufferedInput_Measure.Theme = MetroFramework.MetroThemeStyle.Light;
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
            Tile_AnalogInput.Visible = false;
            Tile_AnalogOutput.Visible = false;
            Tile_DigitalInput.Visible = false;
            Tile_DigitalOutput.Visible = false;
            Tile_InstantInput.Visible = true;
            Tile_BufferedInput.Visible = true;
        }

        /// <summary>
        /// Odkrycie przycisków po wciśnięciu przycisku powrót.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MeasureReturn_Click(object sender, EventArgs e)
        {
            Tile_AnalogInput.Visible = true;
            Tile_AnalogOutput.Visible = true;
            Tile_DigitalInput.Visible = true;
            Tile_DigitalOutput.Visible = true;
            Tile_InstantInput.Visible = false;
            Tile_BufferedInput.Visible = false;
        }

        /// <summary>
        /// Logowanie się.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            LoginPanel myLoginPanel = new LoginPanel();
            Boolean loginSuccessful = myLoginPanel.checkLogin(this.TextBox_Username.Text, this.metroTextBoxPassword.Text);
            if (loginSuccessful)
            {
                User user = myLoginPanel.loggedUser;
                MetroMessageBox.Show(this, "" + user.imie + ", logowanie powiodło się.", "Witaj", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (user.admin == 1)
                {
                    this.TabControl.TabPages.Remove(metroTabPageWelcome);
                    this.TabControl.TabPages.Add(TabPage_AnalogOutput);
                    this.TabControl.TabPages.Add(TabPage_AnalogBufferedInput);
                    this.TabControl.TabPages.Add(TabPage_DigitalInput);
                    this.TabControl.TabPages.Add(TabPage_DigitalOutput);
                    this.TabControl.TabPages.Add(TabPage_LastMeasure);
                    this.TabControl.TabPages.Add(TabPage_Options);
                    this.TabControl.TabPages.Add(TabPage_Measure);

                    this.TabControl.SelectedTab = TabPage_Options;
                }
                else
                {
                    this.TabControl.TabPages.Remove(metroTabPageWelcome);
                    this.TabControl.TabPages.Add(TabPage_Measure);

                    this.TabControl.SelectedTab = TabPage_Measure;
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
                this.Button_Login.PerformClick();
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
            Label_DigitalInput.Visible = true;
        }

        private void metroTileDigitalInput_MouseLeave(object sender, EventArgs e)
        {
            Label_DigitalInput.Visible = false;
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            Label_AnalogInput.Visible = true;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            Label_AnalogInput.Visible = false;
        }

        private void metroTileAnalogOutput_MouseEnter(object sender, EventArgs e)
        {
            Label_AnalogOutput.Visible = true;
        }

        private void metroTileAnalogOutput_MouseLeave(object sender, EventArgs e)
        {
            Label_AnalogOutput.Visible = false;
        }

        private void metroTileDigitalOutput_MouseEnter(object sender, EventArgs e)
        {
            Label_DigitalOutput.Visible = true;
        }

        private void metroTileDigitalOutput_MouseLeave(object sender, EventArgs e)
        {
            Label_DigitalOutput.Visible = false;
        }

        private void metroTileInstantInput_MouseEnter(object sender, EventArgs e)
        {
            Label_Instant.Visible = true;
        }

        private void metroTileInstantInput_MouseLeave(object sender, EventArgs e)
        {
            Label_Instant.Visible = false;
        }

        private void metroTileBufferedInput_MouseEnter(object sender, EventArgs e)
        {
            Label_Buffered.Visible = true;
        }

        private void metroTileBufferedInput_MouseLeave(object sender, EventArgs e)
        {
            Label_Buffered.Visible = false;
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
            this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum = double.Parse(this.TextBox_Samples.Text) * ((double)(this.TrackBar_AnalogBufferedInput_1.Value)/100);
            
            double ratio = (this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum - this.Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum);
            ChangeChartMarkerRatio(this.Chart_AnalogBufferedInput, ratio);
        }

        /// <summary>
        /// Przesunięcie suwagiem 2 powinno przesuwać wykres wzdłóż jego osi,
        /// od minimalnej do maksymalnej wartości.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar_AnalogBufferedInput_2_ValueChanged(object sender, EventArgs e)
        {
            double MIN = 0;
            double MAX = (double.Parse(this.TextBox_Samples.Text));
            double howMuchToChange = (MAX / 100) * this.TrackBar_AnalogBufferedInput_2.Value;
            double window = Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum - Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Minimum = howMuchToChange;
            Chart_AnalogBufferedInput.ChartAreas[0].AxisX.Maximum = window + howMuchToChange;
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
            string time = DateTime.Now.ToString("yyyy-MM-dd HH mm ss", CultureInfo.InvariantCulture);
            using (var dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(dlg.FileName + ".txt"))
                        {

                            file.WriteLine("Report from :\t" + time);
                            StringBuilder Rowbind = new StringBuilder();
                            for (int k = 0; k < metroGridTable.Columns.Count; k++)
                            {
                                Rowbind.Append("\t");
                                Rowbind.Append(metroGridTable.Columns[k].HeaderText + ' ');
                            }

                            Rowbind.Append("\r\n");
                            for (int i = 0; i < metroGridTable.Rows.Count; i++)
                            {
                                for (int k = 0; k < metroGridTable.Columns.Count; k++)
                                {
                                    Rowbind.Append("\t");
                                    if (metroGridTable.Rows[i].Cells[k].Value != null)
                                    {
                                        Rowbind.Append(String.Format("{0:0.000000000}", Decimal.Parse(metroGridTable.Rows[i].Cells[k].Value.ToString())) + ' ');
                                    }   
                                }

                                Rowbind.Append("\r\n");
                            }

                            file.WriteLine(Rowbind.ToString());
                        }

                        MetroMessageBox.Show(this, "Plik " + dlg.FileName + ".txt zapisano na pulpicie.", "Zapis udany!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Pliku nie udało się zapisać!", "Zapis nie udany!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            


        }



    }
}
