using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MetroFramework.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAQNavi_WF_v1_0_0.Utils;
using Automation.BDaq;

namespace DAQNavi_WF_v1_0_0
{
    public partial class AIIMeasureOptionsForm : MetroForm
    {
        MainWindow mainWindow;
        ValueRange[] AIIOP_channels_array = new ValueRange[8];

        public AIIMeasureOptionsForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            MetroFramework.MetroThemeStyle parentStyle = MainWindow.choosenStyle;
            this.Theme = parentStyle;
            AAIOP_label_Interval_1.Theme = parentStyle;
            AAIOP_label_Interval_2.Theme = parentStyle;
            AIIOP_label_NumberOfChannels.Theme = parentStyle;
            AIIOP_label_StartChannel.Theme = parentStyle;
            Button_AIMOptions_Save.Theme = parentStyle;
            AIIOP_comboBox_NumberOfChannels.Theme = parentStyle;
            AIIOP_comboBox_StartChannel.Theme = parentStyle;
            AIIOP_trackBar_SampleInterval.Theme = parentStyle;
            for (int i = 0; i < AIIOP_channels_array.Length; i++)
            {
                AIIOP_channels_array[i] = ValueRange.V_Neg10To10;
            }
        }

        private void AnalogInstantMeasureOptions_Load(object sender, EventArgs e)
        {
            AIIOP_trackBar_SampleInterval.Value = 50;
            AIIOP_comboBox_StartChannel.SelectedIndex = 0;
            AIIOP_comboBox_NumberOfChannels.SelectedIndex = 0;
        }

        
        /// <summary>
        ///  Przy zmianie indeksu powinna zmienić się rownież druga lista rozwijana, ponnieważ nie może
        ///  dojść do sytuacji, gdy ktoś wybierze kanał 8 i 8 kanałów do pomiaru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_AnalogInstantInput_StartChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

            int choosenChannel = this.AIIOP_comboBox_StartChannel.SelectedIndex;
            GridUtils.clearGrid(AIIOP_grid);
            AIIOP_comboBox_NumberOfChannels.Items.Clear();
            int numOfChan = 0;
            for (int i = choosenChannel; i < 8; i++)
            {
                AIIOP_comboBox_NumberOfChannels.Items.Add(numOfChan + 1);
                AIIOP_grid.Rows.Add();
                AIIOP_grid.Rows[numOfChan].Cells[0].Value = i;
                AIIOP_grid.Rows[numOfChan].Cells[1].Value = "V_Neg10To10";
                numOfChan++;
            }
            AIIOP_comboBox_NumberOfChannels.SelectedIndex = 0;

        }

        /// <summary>
        /// Zapisanie stanu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AIMOptions_Save_Click(object sender, EventArgs e)
        {
            mainWindow.getAnalogInstantInputTimer = AIIOP_trackBar_SampleInterval.Value;
            mainWindow.getChoosenChannelAII = AIIOP_comboBox_StartChannel.SelectedIndex;
            mainWindow.getNumberOfChannelsAAI = AIIOP_comboBox_NumberOfChannels.SelectedIndex + 1;
            mainWindow.getCheckbox_AnalogInstantInput_MeasurmentOptions.Checked = true;
            mainWindow.getCheckbox_AnalogInstantInput_Defaults.Checked = false;

            int choosenChannel = AIIOP_comboBox_StartChannel.SelectedIndex;
            int gridRow = 0;
            for (int i = choosenChannel; i < AIIOP_grid.Rows.Count ; i++)
            {
                AIIOP_channels_array[i] = GridUtils.rangeToValueRange(AIIOP_grid.Rows[gridRow].Cells[1].Value.ToString());
                gridRow++;
            }

            MainWindow.AII_channels_ranges = AIIOP_channels_array;


            this.Hide();
        }

        private void AAIOP_trackBar_SampleInterval_ValueChanged(object sender, EventArgs e)
        {
            double step = 10000 / 100;
            if (AIIOP_trackBar_SampleInterval.Value > 0)
            {
                AAIOP_label_Interval_2.Text = (AIIOP_trackBar_SampleInterval.Value * step).ToString();
            }
            else
            {
                AAIOP_label_Interval_2.Text = step.ToString();
            }
        }

        private void AIIOP_comboBox_NumberOfChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choosenChannel = AIIOP_comboBox_StartChannel.SelectedIndex;
            GridUtils.clearGrid(AIIOP_grid);
            int numOfChan = 0;
            for (int i = choosenChannel; i < AIIOP_comboBox_NumberOfChannels.SelectedIndex + choosenChannel + 1; i++)
            {
                AIIOP_grid.Rows.Add();
                AIIOP_grid.Rows[numOfChan].Cells[0].Value = i;
                AIIOP_grid.Rows[numOfChan].Cells[1].Value = "V_Neg10To10";
                numOfChan++;
            }
        }
    }
}
