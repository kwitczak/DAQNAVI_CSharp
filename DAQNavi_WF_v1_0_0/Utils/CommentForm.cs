using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQNavi_WF_v1_0_0
{
    public partial class CommentForm : MetroForm
    {
        private MainWindow mainWindow;

        public CommentForm()
        {
            InitializeComponent();
        }

        public CommentForm(MainWindow mainWindow)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.TextBox_CommentForm_AdminComment.Text = mainWindow.TextBox_Options_AdminComment_Visible.Text.ToString();
            this.TextBox_CommentForm_UserComment.Text = mainWindow.TextBox_Options_UserComment_Visible.Text.ToString();
        }

        private void Button_CommentForm_Export_Click(object sender, EventArgs e)
        {
            String timeStart = "";
            String timeEnd = "";
            String timeDurration = "";
            String samples = "";
            String numberOfChannels = "";
            String choosenChannel = "";
            String frequency = "";

            if (mainWindow.lastMeasurmentType.Equals(MainWindow.measurmentType.AnalogBufferedInput))
            {
                timeStart = mainWindow.ABI_timerStart.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeEnd = mainWindow.ABI_timeEnd.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeDurration = new DateTime(mainWindow.ABI_timeDiff.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
                samples = mainWindow.ABI_data.Length.ToString();
                numberOfChannels = mainWindow.getNumberOfChannelsABI.ToString();
                choosenChannel = mainWindow.getChoosenChannelABI.ToString();
                frequency = ((mainWindow.ABI_data.Length / mainWindow.ABI_timeDiff.TotalMilliseconds * 1000)/mainWindow.getNumberOfChannelsABI).ToString() + " Hz";
            }
            else if (mainWindow.lastMeasurmentType.Equals(MainWindow.measurmentType.AnalogInstantInput))
            {
                timeStart = mainWindow.AII_timeStart.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeEnd = mainWindow.AII_timeEnd.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeDurration = new DateTime(mainWindow.AII_timeDiff.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
                samples = mainWindow.AAI_sampleCount.ToString();
                numberOfChannels = mainWindow.getNumberOfChannelsAAI.ToString();
                choosenChannel = mainWindow.getChoosenChannelAII.ToString();
                frequency = ((mainWindow.AAI_sampleCount / mainWindow.AII_timeDiff.TotalMilliseconds * 1000)/mainWindow.getNumberOfChannelsAAI).ToString() + " Hz a powinno: " + (1 / (mainWindow.getAnalogInstantInputTimer / 1000)).ToString();
            }

            string time = DateTime.Now.ToString("yyyy-MM-dd     HH:mm:ss.fff", CultureInfo.InvariantCulture);
            double[] myResults = new double[mainWindow.metroGridTableVisible.Rows.Count * int.Parse(numberOfChannels)];
            int myResultsCounter = 0;
            using (var dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // ZAPIS DO PLIKU
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(dlg.FileName + ".txt"))
                        {

                            file.WriteLine("=========================================\n");
                            file.WriteLine("Report from :\t" + time);
                            file.WriteLine("\n=========================================\n");
                            file.WriteLine("Report Details:");
                            file.WriteLine("Measure start :\t\t" + timeStart);
                            file.WriteLine("Measure end :\t\t" + timeEnd);
                            file.WriteLine("Measure time :\t\t" + timeDurration);
                            file.WriteLine("Samples :\t\t" + samples);
                            file.WriteLine("Channels :\t\t" + numberOfChannels);
                            file.WriteLine("Channel start :\t\t" + choosenChannel);
                            file.WriteLine("Sampling frequency :\t" + frequency);
                            file.WriteLine("\n=========================================\n");
                            file.WriteLine("Admin comment: " + "\n\t" + TextBox_CommentForm_AdminComment.Text);
                            file.WriteLine("\n=========================================\n");
                            file.WriteLine("User comment: " + "\n\t" + TextBox_CommentForm_UserComment.Text);
                            file.WriteLine("\n=========================================\n");
                            StringBuilder Rowbind = new StringBuilder();
                            for (int k = 0; k < mainWindow.metroGridTableVisible.Columns.Count + 1; k++)
                            {
                                if (k < 1)
                                {
                                    Rowbind.Append("\t");
                                    Rowbind.Append("Sample" + ' ');
                                }
                                else
                                {
                                    Rowbind.Append("\t");
                                    Rowbind.Append(mainWindow.metroGridTableVisible.Columns[k - 1].HeaderText + ' ');
                                }

                            }


                            Rowbind.Append("\r\n");
                            for (int i = 0; i < mainWindow.metroGridTableVisible.Rows.Count/int.Parse(numberOfChannels); i++)
                            {
                                for (int k = 0; k < mainWindow.metroGridTableVisible.Columns.Count + 1; k++)
                                {
                                    if (k < 1)
                                    {
                                        Rowbind.Append("\t");
                                        Rowbind.Append(i + 1);
                                    }
                                    else
                                    {
                                        Rowbind.Append("\t");
                                        if (mainWindow.metroGridTableVisible.Rows[i].Cells[k - 1].Value != null)
                                        {
                                            Rowbind.Append(String.Format("{0:0.000000000}", Decimal.Parse(mainWindow.metroGridTableVisible.Rows[i].Cells[k - 1].Value.ToString())) + ' ');
                                            myResults[myResultsCounter] = (double)mainWindow.metroGridTableVisible.Rows[i].Cells[k - 1].Value;
                                            myResultsCounter++;
                                        }
                                    }
                                }

                                Rowbind.Append("\r\n");
                            }

                            file.WriteLine(Rowbind.ToString());
                        }

                        // ZAPIS DO BAZY
                        //mainWindow.saveResultsToDataBase(timeStart,
                        //    timeEnd,
                        //    myResults,
                        //    timeDurration,
                        //    samples,
                        //    numberOfChannels,
                        //    choosenChannel,
                        //    this.ProgressBar_CommentForm);

                        myResults = null;
                        MetroMessageBox.Show(this, "Plik " + dlg.FileName + ".txt zapisano na pulpicie.", "Zapis udany!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Pliku nie udało się zapisać!", "Zapis nie udany!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            this.Hide();
        }

        private void Button_CommentForm_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
