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

namespace DAQNavi_WF_v1_0_0
{
    public partial class Form1 : MetroForm
    {
        delegate void UpdateUIDelegate();
        double[] dataDownloadedAI;
        Stopwatch stopwatch = new Stopwatch();


        public Form1()
        {

            // Przygotowanie programu do pracy
            InitializeComponent();
            this.metroTabControl1.TabPages.Remove(metroTabPageAnalogOutput);
            this.metroTabControl1.TabPages.Remove(metroTabPageAnalogBufferedInput);
            this.metroTabControl1.TabPages.Remove(metroTabPageDigitalInput);
            this.metroTabControl1.TabPages.Remove(metroTabPageDigitalOutput);
            this.metroTabControl1.TabPages.Remove(metroTabPageLastMeasure);
            this.metroTabControl1.TabPages.Remove(metroTabPageOptions);
            this.metroTabControl1.TabPages.Remove(metroTabPageMeasure);

            LabelHelloText.Text = "Welcome in Advantech Measure application. \n\nTo start, " +
                          "choose one of the options on the tab pane.\n" +
                          "If You want to read more about Advantech, click" +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and " +
                          "\nSome more information, other information and thats it" +
                          "\n\n KW";
            metroLabelAnalogInput.Text = "You can measure:" +
                          "\n  - Instant input" +
                          "\n  - Buffered input";
            metroLabelAnalogOutput.Text = "You can measure:" +
                          "\n  - Instant output" +
                          "\n  - Buffered output";
            metroLabelDigitalInput.Text = "You can measure:" +
                          "\n  - Instant input";
            metroLabelDigitalOutput.Text = "You can measure:" +
                          "\n  - Instant output";
            metroLabelInstant.Text = "You can measure:" +
                          "\n  - Instant output";
            metroLabelBuffered.Text = "You can measure:" +
                          "\n  - Instant output";

            chartAnalogInput.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartAnalogInput.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartAnalogInput.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chartAnalogInput.ChartAreas[0].CursorX.AutoScroll = true;
            chartAnalogInput.ChartAreas[0].CursorY.AutoScroll = true;

            chartAnalogInput.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartAnalogInput.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            this.Select();
            this.metroTextBoxUsername.Select();
        }

        private void bufferedAiCtrl1_DataReady(object sender, Automation.BDaq.BfdAiEventArgs e)
        {
            bufferedAiCtrl1.GetData(e.Count, dataDownloadedAI);
            this.Invoke((UpdateUIDelegate)delegate()
            {
                metroProgressSpinner1.Visible = true;
                metroProgressSpinner1.Refresh();

                for (int i = 0; i < e.Count; ++i)
                {
                    //TODO - czas na osi X
                    //stopwatch.Start();
                    //stopwatch.Stop();
                    //metroGridTable.Rows.Add(dataDownloadedAI[i], stopwatch.Elapsed.TotalMilliseconds);
                    //chartAnalogInput.Series[0].Points.AddXY(dataDownloadedAI[i], stopwatch.Elapsed.TotalMilliseconds);
                    metroGridTable.Rows.Add(dataDownloadedAI[i]);
                    chartAnalogInput.Series[0].Points.Add(dataDownloadedAI[i]);
                    if (i % 20 == 0)
                    {
                        chartAnalogInput.Refresh();
                        metroProgressSpinner1.Refresh();
                    }
                }

                metroProgressSpinner1.Visible = false;
                metroProgressSpinner1.Refresh();
            });
        }

        private void buttonAnalogBufferedInput_Click(object sender, EventArgs e)
        {
            foreach (var series in chartAnalogInput.Series)
            {
                series.Points.Clear();
                metroGridTable.Rows.Clear();
            }

            BufferedAnalogInput bufferedAnalogInput = new BufferedAnalogInput();
            bufferedAnalogInput.setSamples(Convert.ToInt32(MetroTextBoxSamples.Text));
            bufferedAnalogInput.setChannels(Convert.ToInt32(MetroTextBoxChannels.Text));
            bufferedAnalogInput.setChannelStart(Convert.ToInt32(MetroTextBoxChannelStart.Text));
            bufferedAnalogInput.setIntervalCount(Convert.ToInt32(MetroTextBoxIntervalCount.Text));
            bufferedAnalogInput.setScanCount(Convert.ToInt32(MetroTextBoxScanCount.Text));
            bufferedAnalogInput.setRate(Convert.ToInt32(MetroTextBoxRate.Text));
            
            dataDownloadedAI = bufferedAnalogInput.przygotujPomiar(bufferedAiCtrl1);
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPageAnalogBufferedInput.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPageAnalogOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPageDigitalInput.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPageDigitalOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabPageOptions.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabelSamples.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabelChannels.Theme = MetroFramework.MetroThemeStyle.Light;
            metroGridTable.Theme = MetroFramework.MetroThemeStyle.Light;
            MetroTextBoxChannels.Theme = MetroFramework.MetroThemeStyle.Light;
            MetroTextBoxSamples.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            MetroButtonMeasure.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void Link1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.advantech.com/");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroTileAnalogInput.Visible = false;
            metroTileAnalogOutput.Visible = false;
            metroTileDigitalInput.Visible = false;
            metroTileDigitalOutput.Visible = false;
            metroTileInstantInput.Visible = true;
            metroTileBufferedInput.Visible = true;
        }

        private void metroButtonMeasureReturn_Click(object sender, EventArgs e)
        {
            metroTileAnalogInput.Visible = true;
            metroTileAnalogOutput.Visible = true;
            metroTileDigitalInput.Visible = true;
            metroTileDigitalOutput.Visible = true;
            metroTileInstantInput.Visible = false;
            metroTileBufferedInput.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoginPanel myLoginPanel = new LoginPanel();
            Boolean loginSuccessful = myLoginPanel.checkLogin(this.metroTextBoxUsername.Text, this.metroTextBoxPassword.Text);
            if (loginSuccessful)
            {
                User user = myLoginPanel.loggedUser;
                MetroMessageBox.Show(this, "Witaj, " + user.imie + ", logowanie powiodło się.", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (user.admin == 1)
                {
                    this.metroTabControl1.TabPages.Remove(metroTabPageWelcome);
                    this.metroTabControl1.TabPages.Add(metroTabPageAnalogOutput);
                    this.metroTabControl1.TabPages.Add(metroTabPageAnalogBufferedInput);
                    this.metroTabControl1.TabPages.Add(metroTabPageDigitalInput);
                    this.metroTabControl1.TabPages.Add(metroTabPageDigitalOutput);
                    this.metroTabControl1.TabPages.Add(metroTabPageLastMeasure);
                    this.metroTabControl1.TabPages.Add(metroTabPageOptions);
                    this.metroTabControl1.TabPages.Add(metroTabPageMeasure);

                    this.metroTabControl1.SelectedTab = metroTabPageOptions;
                }
                else
                {
                    this.metroTabControl1.TabPages.Remove(metroTabPageWelcome);
                    this.metroTabControl1.TabPages.Add(metroTabPageMeasure);

                    this.metroTabControl1.SelectedTab = metroTabPageMeasure;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Logowanie nie powiodło się", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.metroButtonLogin.PerformClick();
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.metroTabControl1.TabPages.Add(metroTabPageAnalogBufferedInput);
            this.metroTabControl1.TabPages.Remove(metroTabPageMeasure);
            this.metroTabControl1.SelectedTab = metroTabPageAnalogBufferedInput;
        }

        private void metroTileDigitalInput_MouseHover(object sender, EventArgs e)
        {
            metroLabelDigitalInput.Visible = true;
        }

        private void metroTileDigitalInput_MouseLeave(object sender, EventArgs e)
        {
            metroLabelDigitalInput.Visible = false;
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            metroLabelAnalogInput.Visible = true;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroLabelAnalogInput.Visible = false;
        }

        private void metroTileAnalogOutput_MouseEnter(object sender, EventArgs e)
        {
            metroLabelAnalogOutput.Visible = true;
        }

        private void metroTileAnalogOutput_MouseLeave(object sender, EventArgs e)
        {
            metroLabelAnalogOutput.Visible = false;
        }

        private void metroTileDigitalOutput_MouseEnter(object sender, EventArgs e)
        {
            metroLabelDigitalOutput.Visible = true;
        }

        private void metroTileDigitalOutput_MouseLeave(object sender, EventArgs e)
        {
            metroLabelDigitalOutput.Visible = false;
        }

        private void metroTileInstantInput_MouseEnter(object sender, EventArgs e)
        {
            metroLabelInstant.Visible = true;
        }

        private void metroTileInstantInput_MouseLeave(object sender, EventArgs e)
        {
            metroLabelInstant.Visible = false;
        }

        private void metroTileBufferedInput_MouseEnter(object sender, EventArgs e)
        {
            metroLabelBuffered.Visible = true;
        }

        private void metroTileBufferedInput_MouseLeave(object sender, EventArgs e)
        {
            metroLabelBuffered.Visible = false;
        }





    }
}
