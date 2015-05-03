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

        public ABIMeasureOptionsForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            MetroFramework.MetroThemeStyle parentStyle = MainWindow.choosenStyle;
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
            double step = 10000 / 100;
            if (ABIOP_trackBar_SampleInterval.Value > 0)
            {
                ABIOP_label_Interval_2.Text = (ABIOP_trackBar_SampleInterval.Value * step).ToString();
            }
            else
            {
                ABIOP_label_Interval_2.Text = step.ToString();
            }

        }

        private void ABIOP_button_Save_Click(object sender, EventArgs e)
        {
            MainWindow.ABI_interval = ABIOP_trackBar_SampleInterval.Value;
            MainWindow.ABI_startChannel = ABIOP_comboBox_StartChannel.SelectedIndex;
            MainWindow.ABI_numOfChannels = ABIOP_comboBox_NumberOfChannels.SelectedIndex + 1;
            MainWindow.ABI_samplesPerChannel = int.Parse(ABIOP_textBox_samples.Text);
            mainWindow.ABI_checkBox_custom.Checked = true;
            mainWindow.ABI_checkBox_defaults.Checked = false;

            //int[] ABI_channels = new int[ABIOP_grid.Rows.Count];
            //int[] ABI_channels_min = new int[ABIOP_grid.Rows.Count];
            //int[] ABI_channels_max = new int[ABIOP_grid.Rows.Count];

            //for (int i = 0; i < ABIOP_grid.Rows.Count; i++)
            //{
            //    ABI_channels[i] = int.Parse(ABIOP_grid.Rows[i].Cells[0].Value.ToString());
            //    ABI_channels_min[i] = int.Parse(ABIOP_grid.Rows[i].Cells[1].Value.ToString());
            //    ABI_channels_max[i] = int.Parse(ABIOP_grid.Rows[i].Cells[2].Value.ToString());
            //}

            //MainWindow.ABI_channels = ABI_channels;
            //MainWindow.ABI_channels_min = ABI_channels_min;
            //MainWindow.ABI_channels_max = ABI_channels_max;
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
        }

    }
}
