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

namespace DAQNavi_WF_v1_0_0
{
    public partial class AnalogInstantMeasureOptions : MetroForm
    {
        MainWindow mainWindow;

        public AnalogInstantMeasureOptions(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void AnalogInstantMeasureOptions_Load(object sender, EventArgs e)
        {
            TrackBar_AnalogInstantInput_SampleInterval.Value = 50;
            ComboBox_AnalogInstantInput_StartChannel.SelectedIndex = 0;
            ComboBox_AnalogInstantInput_NumberOfChannels.SelectedIndex = 0;
        }

        
        /// <summary>
        ///  Przy zmianie indeksu powinna zmienić się rownież druga lista rozwijana, ponnieważ nie może
        ///  dojść do sytuacji, gdy ktoś wybierze kanał 8 i 8 kanałów do pomiaru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_AnalogInstantInput_StartChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

            int choosenChannel = this.ComboBox_AnalogInstantInput_StartChannel.SelectedIndex;
            ComboBox_AnalogInstantInput_NumberOfChannels.Items.Clear();
            for (int i = choosenChannel; i < 8 ; i++){
                ComboBox_AnalogInstantInput_NumberOfChannels.Items.Add(i + 1);
            }
            ComboBox_AnalogInstantInput_NumberOfChannels.SelectedIndex = 0;

        }

        /// <summary>
        /// Zapisanie stanu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AIMOptions_Save_Click(object sender, EventArgs e)
        {
            mainWindow.getAnalogInstantInputTimer = TrackBar_AnalogInstantInput_SampleInterval.Value;
            mainWindow.getChoosenChannel = ComboBox_AnalogInstantInput_StartChannel.SelectedIndex;
            mainWindow.getNumberOfChannels = ComboBox_AnalogInstantInput_NumberOfChannels.SelectedIndex + 1;
            mainWindow.getCheckbox_AnalogInstantInput_MeasurmentOptions.Checked = true;
            mainWindow.getCheckbox_AnalogInstantInput_Defaults.Checked = false;
            this.Hide();
        }
    }
}
