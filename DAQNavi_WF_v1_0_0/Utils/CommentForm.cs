﻿using MetroFramework;
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

            if (mainWindow.lastMeasurmentType.Equals(MainWindow.measurmentType.AnalogBufferedInput))
            {
                timeStart = mainWindow.timeStartABI.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeEnd = mainWindow.timeEndABI.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeDurration = new DateTime(mainWindow.timeDiffABI.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
                samples = mainWindow.dataBufferedAI.Length.ToString();
                numberOfChannels = mainWindow.getNumberOfChannelsABI.ToString();
                choosenChannel = mainWindow.getChoosenChannelABI.ToString();
            }
            else if (mainWindow.lastMeasurmentType.Equals(MainWindow.measurmentType.AnalogInstantInput))
            {
                timeStart = mainWindow.timeStartAII.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeEnd = mainWindow.timeEndAII.ToString("HH : mm : ss.fff", CultureInfo.InvariantCulture);
                timeDurration = new DateTime(mainWindow.timeDiffAII.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
                samples = mainWindow.sampleCountAAI.ToString();
                numberOfChannels = mainWindow.getNumberOfChannelsAAI.ToString();
                choosenChannel = mainWindow.getChoosenChannelAII.ToString();
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
                            file.WriteLine("Measure start :\t" + timeStart);
                            file.WriteLine("Measure end :\t" + timeEnd);
                            file.WriteLine("Measure time :\t" + timeDurration);
                            file.WriteLine("Samples :\t" + "");
                            file.WriteLine("Channels :\t" + "");
                            file.WriteLine("Channel start :\t" + "");
                            file.WriteLine("Rate :\t" + "");
                            file.WriteLine("\n=========================================\n");
                            file.WriteLine("Admin comment: " + "\n\t" + TextBox_CommentForm_AdminComment.Text);
                            file.WriteLine("\n=========================================\n");
                            file.WriteLine("User comment: " + "\n\t" + TextBox_CommentForm_UserComment.Text);
                            file.WriteLine("\n=========================================\n");
                            StringBuilder Rowbind = new StringBuilder();
                            for (int k = 0; k < mainWindow.metroGridTableVisible.Columns.Count; k++)
                            {
                                Rowbind.Append("\t");
                                Rowbind.Append(mainWindow.metroGridTableVisible.Columns[k].HeaderText + ' ');
                            }


                            Rowbind.Append("\r\n");
                            for (int i = 0; i < mainWindow.metroGridTableVisible.Rows.Count; i++)
                            {
                                for (int k = 0; k < mainWindow.metroGridTableVisible.Columns.Count; k++)
                                {
                                    Rowbind.Append("\t");
                                    if (mainWindow.metroGridTableVisible.Rows[i].Cells[k].Value != null)
                                    {
                                        Rowbind.Append(String.Format("{0:0.000000000}", Decimal.Parse(mainWindow.metroGridTableVisible.Rows[i].Cells[k].Value.ToString())) + ' ');
                                        myResults[myResultsCounter] = (double)mainWindow.metroGridTableVisible.Rows[i].Cells[k].Value;
                                        myResultsCounter++;
                                    }
                                }

                                Rowbind.Append("\r\n");
                            }

                            file.WriteLine(Rowbind.ToString());
                        }

                        // ZAPIS DO BAZY
                        mainWindow.saveResultsToDataBase(timeStart,
                            timeEnd,
                            myResults,
                            timeDurration,
                            samples,
                            numberOfChannels,
                            choosenChannel,
                            this.ProgressBar_CommentForm);

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
