using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQNavi_WF_v1_0_0
{
    public partial class Form1 : MetroForm
    {
        delegate void UpdateUIDelegate();
        double[] m_dataScaled;
        public Form1()
        {
            InitializeComponent();
            m_dataScaled = new double[bufferedAiCtrl1.BufferCapacity];
            bufferedAiCtrl1.Streaming = false;
            
            bufferedAiCtrl1.Prepare();
        }

        private void bufferedAiCtrl1_DataReady(object sender, Automation.BDaq.BfdAiEventArgs e)
        {
            bufferedAiCtrl1.GetData(e.Count, m_dataScaled);
            this.Invoke((UpdateUIDelegate)delegate()
            {
                metroProgressSpinner1.Visible = true;
                metroProgressSpinner1.Refresh();
                for (int i = 0; i < e.Count; ++i)
                {
                    metroGrid1.Rows.Add(m_dataScaled[i]);
                    chart2.Series[0].Points.Add(m_dataScaled[i]);
                    if (i % 20 == 0)
                    {
                        chart2.Refresh();
                        metroProgressSpinner1.Refresh();
                    }
                }
                metroProgressSpinner1.Visible = false;
                metroProgressSpinner1.Refresh();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bufferedAiCtrl1.ScanChannel.Samples = Convert.ToInt32(tbSamples.Text);
            bufferedAiCtrl1.ScanChannel.ChannelCount = 1;
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
                metroGrid1.Rows.Clear();
            }
            bufferedAiCtrl1.Start();

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPage5.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            tbChannels.Theme = MetroFramework.MetroThemeStyle.Light;
            tbSamples.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            button1.Theme = MetroFramework.MetroThemeStyle.Light;
        }

    }
}
