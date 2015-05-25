using Automation.BDaq;
using DAQNavi_WF_v1_0_0.Utils;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQNavi_WF_v1_0_0.Forms
{
    public partial class ABIMeasureOptionsForm : MetroForm
    {
        MainWindow mainWindow;
        ValueRange[] ABIOP_channels_array = new ValueRange[8];
        int step;

        public ABIMeasureOptionsForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            ABIOP_label_int1.Text = ((int.Parse(mainWindow.Options_comboBox_aiiMax.SelectedIndex.ToString()) + 2) * 100).ToString();
            step = (10000 - int.Parse(ABIOP_label_int1.Text)) / 100;
            MetroFramework.MetroThemeStyle parentStyle = MainWindow.choosenStyle;
            MainWindow.Language language = MainWindow.choosenLanguage;

            this.MaximizeBox = false;
            this.Theme = parentStyle;
            ABIOP_button_Save.Theme = parentStyle;
            ABIOP_comboBox_NumberOfChannels.Theme = parentStyle;
            ABIOP_comboBox_StartChannel.Theme = parentStyle;
            ABIOP_label_channelRange.Theme = parentStyle;
            ABIOP_label_Interval_1.Theme = parentStyle;
            ABIOP_label_Interval_2.Theme = parentStyle;
            ABIOP_label_NumberOfChannels.Theme = parentStyle;
            ABIOP_label_samples.Theme = parentStyle;
            ABIOP_label_StartChannel.Theme = parentStyle;
            ABIOP_textBox_samples.Theme = parentStyle;
            ABIOP_trackBar_SampleInterval.Theme = parentStyle;
            ABIOP_label_int1.Theme = parentStyle;
            ABIOP_label_int2.Theme = parentStyle;

            ABIOP_trackBar_SampleInterval.Value = 50;
            ABIOP_comboBox_StartChannel.SelectedIndex = 0;
            ABIOP_comboBox_NumberOfChannels.SelectedIndex = 0;
            for (int i = 0; i < ABIOP_channels_array.Length; i++)
            {
                ABIOP_channels_array[i] = ValueRange.V_Neg10To10;
            }



            //Languages

            if (language == MainWindow.Language.ENG)
            {
                ABIOP_label_Interval_1.Text = "Interval";
                ABIOP_label_StartChannel.Text = "Start Channel";
                ABIOP_label_NumberOfChannels.Text = "Number of Channels";
                ABIOP_label_samples.Text = "Samples per Channel";
                ABIOP_label_channelRange.Text = "Channels range";
                ABIOP_button_Save.Text = "Save";
                this.Text = "ABI Options";

            }
            else
            {
                ABIOP_label_Interval_1.Text = "Częstotliwość";
                ABIOP_label_StartChannel.Text = "Kanał startowy";
                ABIOP_label_NumberOfChannels.Text = "Liczba kanałów";
                ABIOP_label_samples.Text = "Próbki na kanał";
                ABIOP_label_channelRange.Text = "Zakresy pomiarowe";
                ABIOP_button_Save.Text = "Zapisz";
                this.Text = "Opcje pomiaru";
            }

            newTimeValue();
        }

        private void ABIOP_comboBox_StartChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choosenChannel = ABIOP_comboBox_StartChannel.SelectedIndex;
            GridUtils.clearGrid(ABIOP_grid);
            ABIOP_comboBox_NumberOfChannels.Items.Clear();
            int numOfChan = 0;
            for (int i = choosenChannel; i < 8; i++)
            {
                ABIOP_comboBox_NumberOfChannels.Items.Add(numOfChan + 1);
                ABIOP_grid.Rows.Add();
                ABIOP_grid.Rows[numOfChan].Cells[0].Value = i;
                ABIOP_grid.Rows[numOfChan].Cells[1].Value = "V_Neg10To10";
                numOfChan++;
            }
            ABIOP_comboBox_NumberOfChannels.SelectedIndex = 0;
        }

        private void ABIOP_trackBar_SampleInterval_ValueChanged(object sender, EventArgs e)
        {
            
            if (ABIOP_trackBar_SampleInterval.Value > 0)
            {
                ABIOP_label_Interval_2.Text = (int.Parse(ABIOP_label_int1.Text) + (ABIOP_trackBar_SampleInterval.Value * step)).ToString();
            }
            else
            {
                ABIOP_label_Interval_2.Text = ABIOP_label_int1.Text;
            }

            newTimeValue();

        }

        private void ABIOP_button_Save_Click(object sender, EventArgs e)
        {
            int trackbar_value = ABIOP_trackBar_SampleInterval.Value;
            if (trackbar_value == 0)
            {
                trackbar_value = 1;
            }
            MainWindow.ABI_rate = int.Parse(ABIOP_label_int1.Text) + (trackbar_value * step);
            MainWindow.ABI_startChannel = ABIOP_comboBox_StartChannel.SelectedIndex;
            MainWindow.ABI_numOfChannels = ABIOP_comboBox_NumberOfChannels.SelectedIndex + 1;
            MainWindow.ABI_samplesPerChannel = int.Parse(ABIOP_textBox_samples.Text);
            mainWindow.ABI_checkBox_custom.Checked = true;
            mainWindow.ABI_checkBox_defaults.Checked = false;

            int choosenChannel = ABIOP_comboBox_StartChannel.SelectedIndex;
            int gridRow = 0;
            for (int i = choosenChannel; i < ABIOP_grid.Rows.Count + choosenChannel; i++)
            {
                ABIOP_channels_array[i] = GridUtils.rangeToValueRange(ABIOP_grid.Rows[gridRow].Cells[1].Value.ToString());
                gridRow++;
            }

            MainWindow.ABI_channels_ranges = ABIOP_channels_array;

            this.Hide();
        }

        private void ABIOP_comboBox_NumberOfChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choosenChannel = ABIOP_comboBox_StartChannel.SelectedIndex;
            GridUtils.clearGrid(ABIOP_grid);
            int numOfChan = 0;
            for (int i = choosenChannel; i < ABIOP_comboBox_NumberOfChannels.SelectedIndex + choosenChannel + 1; i++)
            {
                ABIOP_grid.Rows.Add();
                ABIOP_grid.Rows[numOfChan].Cells[0].Value = i;
                ABIOP_grid.Rows[numOfChan].Cells[1].Value = "V_Neg10To10";
                numOfChan++;
            }

            newTimeValue();
        }

        private void ABIOP_textBox_samples_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ABIOP_textBox_samples_TextChanged(object sender, EventArgs e)
        {
            newTimeValue();
        }

        private void newTimeValue()
        {
            int hz = int.Parse(ABIOP_label_int1.Text) + (ABIOP_trackBar_SampleInterval.Value * step);
            int channels = ABIOP_comboBox_NumberOfChannels.SelectedIndex + 1;
            if (channels == 0)
            {
                return;
            }

            double seconds = (double.Parse(ABIOP_textBox_samples.Text)) / (hz / channels);
            TimeSpan t = TimeSpan.FromSeconds(seconds);

            string answer = string.Format("{1:D2}m {2:D2}s {3:D3}ms",
                            t.Hours,
                            t.Minutes,
                            t.Seconds,
                            t.Milliseconds);

            ABIOP_label_estimatedTimeValue.Text = answer;
        }

    }
}
