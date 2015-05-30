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
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

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
            this.MaximizeBox = false;
            this.mainWindow = mainWindow;
            this.TextBox_CommentForm_AdminComment.Text = mainWindow.TextBox_Options_AdminComment_Visible.Text.ToString();
            this.TextBox_CommentForm_UserComment.Text = mainWindow.TextBox_Options_UserComment_Visible.Text.ToString();

            //style
            MetroFramework.MetroThemeStyle parentStyle = MainWindow.choosenStyle;
            MainWindow.Language language = MainWindow.choosenLanguage;
            this.Theme = parentStyle;
            Label_CommentForm_AdminComment.Theme = parentStyle;
            Label_CommentForm_FileFormat.Theme = parentStyle;
            Label_CommentForm_UserComment.Theme = parentStyle;
            TextBox_CommentForm_AdminComment.Theme = parentStyle;
            TextBox_CommentForm_UserComment.Theme = parentStyle;
            RadioButton_CommentForm_DB.Theme = parentStyle;
            commentForm_checkBox.Theme = parentStyle;
            RadioButton_CommentForm_txt.Theme = parentStyle;
            RadioButton_CommentForm_xlsx.Theme = parentStyle;
            Button_CommentForm_Cancel.Theme = parentStyle;
            Button_CommentForm_Export.Theme = parentStyle;
            ProgressBar_CommentForm.Theme = parentStyle;
            Panel_CommentForm.Theme = parentStyle;

            if (language == MainWindow.Language.ENG)
            {
                Label_CommentForm_AdminComment.Text = "Admin comment";
                Label_CommentForm_FileFormat.Text = "File format";
                Label_CommentForm_UserComment.Text = "User comment";
                Button_CommentForm_Cancel.Text = "Cancel";
                Button_CommentForm_Export.Text = "Export";
                RadioButton_CommentForm_DB.Text = "only Data Base";
                commentForm_checkBox.Text = "save to Data Base";
                this.Text = "Export to file";

            }
            else
            {
                Label_CommentForm_AdminComment.Text = "Komentarz admina";
                Label_CommentForm_FileFormat.Text = "Format pliku";
                Label_CommentForm_UserComment.Text = "Komentarz użytkownika";
                Button_CommentForm_Cancel.Text = "Anuluj";
                Button_CommentForm_Export.Text = "Eksport";
                RadioButton_CommentForm_DB.Text = "tylko baza danych";
                commentForm_checkBox.Text = "zapis do bazy danych";
                this.Text = "Eksport do pliku";
            }

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

            if (MainWindow.lastMeasurmentType.Equals(MainWindow.MeasurmentType.ANALOG_BUFFERED_INPUT))
            {
                timeStart = MainWindow.ABI_timerStart.ToString("yyyy-MM-dd     HH:mm:ss.fff", CultureInfo.InvariantCulture);
                timeEnd = MainWindow.ABI_timeEnd.ToString("yyyy-MM-dd     HH:mm:ss.fff", CultureInfo.InvariantCulture);
                timeDurration = new DateTime(MainWindow.ABI_timeDiff.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
                samples = MainWindow.ABI_allData.Count.ToString();
                numberOfChannels = MainWindow.ABI_numOfChannels.ToString();
                choosenChannel = MainWindow.ABI_startChannel.ToString();
                frequency = ((MainWindow.ABI_allData.Count / MainWindow.ABI_timeDiff.TotalMilliseconds * 1000) / MainWindow.ABI_numOfChannels).ToString() + " Hz";
            }
            else if (MainWindow.lastMeasurmentType.Equals(MainWindow.MeasurmentType.ANALOG_INSTANT_INPUT))
            {
                timeStart = MainWindow.AII_timeStart.ToString("yyyy-MM-dd     HH:mm:ss.fff", CultureInfo.InvariantCulture);
                timeEnd = MainWindow.AII_timeEnd.ToString("yyyy-MM-dd     HH:mm:ss.fff", CultureInfo.InvariantCulture);
                timeDurration = new DateTime(MainWindow.AII_timeDiff.Ticks).ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture);
                samples = MainWindow.AAI_sampleCount.ToString();
                numberOfChannels = mainWindow.getNumberOfChannelsAAI.ToString();
                choosenChannel = mainWindow.getChoosenChannelAII.ToString();
                frequency = ((MainWindow.AAI_sampleCount / MainWindow.AII_timeDiff.TotalMilliseconds * 1000) / mainWindow.getNumberOfChannelsAAI).ToString() + " Hz a powinno: " + (1 / (mainWindow.getAnalogInstantInputTimer / 1000)).ToString();
            }

            string time = DateTime.Now.ToString("yyyy-MM-dd     HH:mm:ss.fff", CultureInfo.InvariantCulture);
            double[] myResults = new double[mainWindow.LastMeasure_GridTable.Rows.Count * int.Parse(numberOfChannels)];
            int myResultsCounter = 0;

            // ZAPIS DO PLIKU
            if (RadioButton_CommentForm_txt.Checked)
            {
                using (var dlg = new SaveFileDialog())
                {

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
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
                                for (int k = 0; k < mainWindow.LastMeasure_GridTable.Columns.Count + 1; k++)
                                {
                                    if (k < 1)
                                    {
                                        Rowbind.Append("\t");
                                        Rowbind.Append("Sample" + ' ');
                                    }
                                    else
                                    {
                                        Rowbind.Append("\t");
                                        Rowbind.Append(mainWindow.LastMeasure_GridTable.Columns[k - 1].HeaderText + ' ');
                                    }

                                }


                                Rowbind.Append("\r\n");
                                for (int i = 0; i < mainWindow.LastMeasure_GridTable.Rows.Count; i++)
                                {
                                    for (int k = 0; k < mainWindow.LastMeasure_GridTable.Columns.Count + 1; k++)
                                    {
                                        if (k < 1)
                                        {
                                            Rowbind.Append("\t");
                                            Rowbind.Append(i + 1);
                                        }
                                        else
                                        {
                                            Rowbind.Append("\t");
                                            if (mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value != null)
                                            {
                                                if ((k - 1) == 0)
                                                {
                                                    //Rowbind.Append(String.Format("{0:0.000000000}", Decimal.Parse(mainWindow.metroGridTableVisible.Rows[i].Cells[k - 1].Value.ToString())) + ' ');
                                                    //myResults[myResultsCounter] = (int)mainWindow.metroGridTableVisible.Rows[i].Cells[k - 1].Value;
                                                    //myResultsCounter++;
                                                }
                                                else
                                                {
                                                    Rowbind.Append(String.Format("{0:0.000000000}", Decimal.Parse(mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value.ToString())) + ' ');
                                                    myResults[myResultsCounter] = (double)mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value;
                                                    myResultsCounter++;
                                                }
                                            }
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

            // ZAPIS DO EXCELA
            if (RadioButton_CommentForm_xlsx.Checked)
            {
                using (var dlg = new SaveFileDialog())
                {

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {

                        Excel.Application excelApp = null;
                        Excel.Workbook excelWorkbook = null;
                        Excel.Sheets excelSheets = null;
                        Excel.Worksheet excelWorksheet = null;


                        try
                        {

                            string workbookPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DAQNavi_file";
                            excelApp = new Excel.Application();
                            excelApp.Visible = false;
                            excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, true, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

                            excelSheets = excelWorkbook.Worksheets;
                            excelWorksheet = (Excel.Worksheet)excelSheets.get_Item("Results");
                            excelWorksheet.Cells[14, 6] = MainWindow.loginManager.username.ToString();
                            excelWorksheet.Cells[18, 6] = time;
                            excelWorksheet.Cells[19, 6] = timeStart;
                            excelWorksheet.Cells[20, 6] = timeEnd;
                            excelWorksheet.Cells[21, 6] = timeDurration;
                            excelWorksheet.Cells[22, 6] = samples;
                            excelWorksheet.Cells[23, 6] = numberOfChannels;
                            excelWorksheet.Cells[24, 6] = choosenChannel;
                            excelWorksheet.Cells[25, 6] = frequency;


                            int excelColumn = 2;
                            int excelRow = 60;

                            var data_ex = new object[mainWindow.LastMeasure_GridTable.Rows.Count, int.Parse(numberOfChannels) + 1];
                            for (int i = 0; i < mainWindow.LastMeasure_GridTable.Rows.Count; i++)
                            {
                                for (int k = 0; k < int.Parse(numberOfChannels) + 2; k++)
                                {
                                    if (k < 1)
                                    {

                                    }
                                    else
                                    {

                                        if (mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value != null)
                                        {
                                            if ((k - 1) == 0)
                                            {
                                                data_ex[i, k - 1] = i + 1;
                                            }
                                            else
                                            {
                                                double value = (double)mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value;
                                                data_ex[i, k - 1] = value;
                                                myResults[myResultsCounter] = value;
                                                myResultsCounter++;
                                            }
                                        }
                                    }
                                }
                            }

                            var startCell = (Range)excelWorksheet.Cells[excelRow, 1];
                            var endCell = (Range)excelWorksheet.Cells[mainWindow.LastMeasure_GridTable.Rows.Count + excelRow - 1, int.Parse(numberOfChannels) + 1];
                            var writeRange = excelWorksheet.Range[startCell, endCell];

                            excelWorksheet.Range[startCell,
                                (Range)excelWorksheet.Cells[mainWindow.LastMeasure_GridTable.Rows.Count + excelRow - 1, int.Parse(numberOfChannels) + 3]]
                                .Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                            writeRange.Value2 = data_ex;
                            int num = myResultsCounter / int.Parse(numberOfChannels) + 60;
                            excelWorksheet.PageSetup.PrintArea = "$A$1:$K$" + num;


                            excelWorkbook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookDefault, "", "", false, false,
                                Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlUserResolution, true, "", "", "");


                            MetroMessageBox.Show(this, "Plik " + dlg.FileName + ".xlsx zapisano na pulpicie.", "Zapis udany!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, "Pliku nie udało się zapisać!", "Zapis nie udany!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            Marshal.ReleaseComObject(excelSheets);
                            excelSheets = null;
                            excelWorkbook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                            Marshal.ReleaseComObject(excelWorkbook);
                            Marshal.ReleaseComObject(excelApp);
                            excelWorkbook = null;
                            excelApp = null;
                        }
                    }
                }

            }

            // ZAPIS TYLKO DO DB
            if (RadioButton_CommentForm_DB.Checked)
            {
                try
                {
                    for (int i = 0; i < mainWindow.LastMeasure_GridTable.Rows.Count; i++)
                    {
                        for (int k = 0; k < int.Parse(numberOfChannels) + 2; k++)
                        {
                            if (k < 1)
                            {
                            }
                            else
                            {
                                if (mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value != null)
                                {
                                    if ((k - 1) == 0)
                                    {
                                    }
                                    else
                                    {
                                        myResults[myResultsCounter] = (double)mainWindow.LastMeasure_GridTable.Rows[i].Cells[k - 1].Value;
                                        myResultsCounter++;
                                    }
                                }
                            }
                        }
                    }

                    MetroMessageBox.Show(this, "Dane wpisane do bazy", "Zapis udany!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Pliku nie udało się zapisać!", "Zapis nie udany!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            // Zapis do bazy
            if (commentForm_checkBox.Checked)
            {
                try
                {
                    mainWindow.saveResultsToDataBase(timeStart,
                        timeEnd,
                        myResults,
                        timeDurration,
                        samples,
                        numberOfChannels,
                        choosenChannel,
                        this.ProgressBar_CommentForm);

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Danych nie udało wpisać się do bazy!", "Zapis nie udany!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                // Load measurments
                MainWindow.measurmentDAO.loadMyMeasurments(MainWindow.loginManager.loggedUser.idusers, mainWindow);
            }


            this.Hide();
        }

        private void Button_CommentForm_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void commentForm_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (commentForm_checkBox.Checked)
            {
                RadioButton_CommentForm_DB.Enabled = true;
            }
            else
            {
                RadioButton_CommentForm_DB.Enabled = false;
            }

        }
    }
}
