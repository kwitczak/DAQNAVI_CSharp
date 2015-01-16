namespace DAQNavi_WF_v1_0_0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bufferedAiCtrl1 = new Automation.BDaq.BufferedAiCtrl(this.components);
            this.chartAnalogInput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabelSamples = new MetroFramework.Controls.MetroLabel();
            this.metroLabelChannels = new MetroFramework.Controls.MetroLabel();
            this.MetroTextBoxSamples = new MetroFramework.Controls.MetroTextBox();
            this.MetroTextBoxChannels = new MetroFramework.Controls.MetroTextBox();
            this.MetroButtonMeasure = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageWelcome = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.pictureBoxAdvantech = new System.Windows.Forms.PictureBox();
            this.Link1 = new MetroFramework.Controls.MetroLink();
            this.LabelHelloText = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageAnalogBufferedInput = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.MetroTextBoxRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroTextBoxScanCount = new MetroFramework.Controls.MetroTextBox();
            this.MetroTextBoxIntervalCount = new MetroFramework.Controls.MetroTextBox();
            this.MetroTextBoxChannelStart = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroTabPageOptions = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroTabPageAnalogOutput = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageLastMeasure = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGridTable = new MetroFramework.Controls.MetroGrid();
            this.Channel_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPageMeasure = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelInstant = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBuffered = new MetroFramework.Controls.MetroLabel();
            this.metroButtonMeasureReturn = new MetroFramework.Controls.MetroButton();
            this.metroLabelDigitalOutput = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAnalogOutput = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDigitalInput = new MetroFramework.Controls.MetroLabel();
            this.metroTileBufferedInput = new MetroFramework.Controls.MetroTile();
            this.metroTileInstantInput = new MetroFramework.Controls.MetroTile();
            this.metroLabelAnalogInput = new MetroFramework.Controls.MetroLabel();
            this.metroTileDigitalOutput = new MetroFramework.Controls.MetroTile();
            this.metroTileDigitalInput = new MetroFramework.Controls.MetroTile();
            this.metroTileAnalogOutput = new MetroFramework.Controls.MetroTile();
            this.metroTileAnalogInput = new MetroFramework.Controls.MetroTile();
            this.metroTabPageDigitalOutput = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageDigitalInput = new MetroFramework.Controls.MetroTabPage();
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalogInput)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvantech)).BeginInit();
            this.metroTabPageAnalogBufferedInput.SuspendLayout();
            this.metroTabPageOptions.SuspendLayout();
            this.metroTabPageAnalogOutput.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPageLastMeasure.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTable)).BeginInit();
            this.metroTabPageMeasure.SuspendLayout();
            this.SuspendLayout();
            // 
            // bufferedAiCtrl1
            // 
            this.bufferedAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("bufferedAiCtrl1._StateStream")));
            this.bufferedAiCtrl1.DataReady += new System.EventHandler<Automation.BDaq.BfdAiEventArgs>(this.bufferedAiCtrl1_DataReady);
            // 
            // chartAnalogInput
            // 
            this.chartAnalogInput.BackColor = System.Drawing.Color.Transparent;
            this.chartAnalogInput.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAnalogInput.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartAnalogInput.Legends.Add(legend1);
            this.chartAnalogInput.Location = new System.Drawing.Point(244, 3);
            this.chartAnalogInput.Name = "chartAnalogInput";
            this.chartAnalogInput.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.MarkerBorderWidth = 0;
            series1.MarkerSize = 4;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartAnalogInput.Series.Add(series1);
            this.chartAnalogInput.Size = new System.Drawing.Size(673, 380);
            this.chartAnalogInput.TabIndex = 3;
            this.chartAnalogInput.Text = "chart2";
            // 
            // metroLabelSamples
            // 
            this.metroLabelSamples.AutoSize = true;
            this.metroLabelSamples.Location = new System.Drawing.Point(30, 23);
            this.metroLabelSamples.Name = "metroLabelSamples";
            this.metroLabelSamples.Size = new System.Drawing.Size(58, 19);
            this.metroLabelSamples.TabIndex = 8;
            this.metroLabelSamples.Text = "Samples";
            this.metroLabelSamples.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabelChannels
            // 
            this.metroLabelChannels.AutoSize = true;
            this.metroLabelChannels.Location = new System.Drawing.Point(27, 50);
            this.metroLabelChannels.Name = "metroLabelChannels";
            this.metroLabelChannels.Size = new System.Drawing.Size(61, 19);
            this.metroLabelChannels.TabIndex = 9;
            this.metroLabelChannels.Text = "Channels";
            this.metroLabelChannels.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroTextBoxSamples
            // 
            this.MetroTextBoxSamples.Lines = new string[] {
        "10"};
            this.MetroTextBoxSamples.Location = new System.Drawing.Point(117, 22);
            this.MetroTextBoxSamples.MaxLength = 32767;
            this.MetroTextBoxSamples.Name = "MetroTextBoxSamples";
            this.MetroTextBoxSamples.PasswordChar = '\0';
            this.MetroTextBoxSamples.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxSamples.SelectedText = "";
            this.MetroTextBoxSamples.Size = new System.Drawing.Size(97, 20);
            this.MetroTextBoxSamples.TabIndex = 10;
            this.MetroTextBoxSamples.Text = "10";
            this.MetroTextBoxSamples.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBoxSamples.UseSelectable = true;
            // 
            // MetroTextBoxChannels
            // 
            this.MetroTextBoxChannels.Lines = new string[] {
        "1"};
            this.MetroTextBoxChannels.Location = new System.Drawing.Point(117, 49);
            this.MetroTextBoxChannels.MaxLength = 32767;
            this.MetroTextBoxChannels.Name = "MetroTextBoxChannels";
            this.MetroTextBoxChannels.PasswordChar = '\0';
            this.MetroTextBoxChannels.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxChannels.SelectedText = "";
            this.MetroTextBoxChannels.Size = new System.Drawing.Size(97, 20);
            this.MetroTextBoxChannels.TabIndex = 11;
            this.MetroTextBoxChannels.Text = "1";
            this.MetroTextBoxChannels.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBoxChannels.UseSelectable = true;
            // 
            // MetroButtonMeasure
            // 
            this.MetroButtonMeasure.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.MetroButtonMeasure.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.MetroButtonMeasure.Location = new System.Drawing.Point(3, 364);
            this.MetroButtonMeasure.Name = "MetroButtonMeasure";
            this.MetroButtonMeasure.Size = new System.Drawing.Size(150, 69);
            this.MetroButtonMeasure.TabIndex = 12;
            this.MetroButtonMeasure.Text = "Measure";
            this.MetroButtonMeasure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroButtonMeasure.UseSelectable = true;
            this.MetroButtonMeasure.UseStyleColors = true;
            this.MetroButtonMeasure.Click += new System.EventHandler(this.buttonAnalogBufferedInput_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPageWelcome);
            this.metroTabControl1.Controls.Add(this.metroTabPageAnalogBufferedInput);
            this.metroTabControl1.Controls.Add(this.metroTabPageOptions);
            this.metroTabControl1.Controls.Add(this.metroTabPageAnalogOutput);
            this.metroTabControl1.Controls.Add(this.metroTabPageLastMeasure);
            this.metroTabControl1.Controls.Add(this.metroTabPageMeasure);
            this.metroTabControl1.Controls.Add(this.metroTabPageDigitalOutput);
            this.metroTabControl1.Controls.Add(this.metroTabPageDigitalInput);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(925, 486);
            this.metroTabControl1.TabIndex = 40;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPageWelcome
            // 
            this.metroTabPageWelcome.Controls.Add(this.metroButtonLogin);
            this.metroTabPageWelcome.Controls.Add(this.metroLabel4);
            this.metroTabPageWelcome.Controls.Add(this.metroLabel3);
            this.metroTabPageWelcome.Controls.Add(this.metroTextBoxPassword);
            this.metroTabPageWelcome.Controls.Add(this.metroTextBoxUsername);
            this.metroTabPageWelcome.Controls.Add(this.pictureBoxAdvantech);
            this.metroTabPageWelcome.Controls.Add(this.Link1);
            this.metroTabPageWelcome.Controls.Add(this.LabelHelloText);
            this.metroTabPageWelcome.HorizontalScrollbarBarColor = true;
            this.metroTabPageWelcome.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageWelcome.HorizontalScrollbarSize = 10;
            this.metroTabPageWelcome.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageWelcome.Name = "metroTabPageWelcome";
            this.metroTabPageWelcome.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageWelcome.TabIndex = 6;
            this.metroTabPageWelcome.Text = "Welcome";
            this.metroTabPageWelcome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageWelcome.VerticalScrollbarBarColor = true;
            this.metroTabPageWelcome.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageWelcome.VerticalScrollbarSize = 10;
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonLogin.Location = new System.Drawing.Point(96, 249);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(114, 39);
            this.metroButtonLogin.TabIndex = 11;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(122, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Password";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(118, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Username";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(73, 177);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.Size = new System.Drawing.Size(162, 24);
            this.metroTextBoxPassword.TabIndex = 6;
            this.metroTextBoxPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.Lines = new string[0];
            this.metroTextBoxUsername.Location = new System.Drawing.Point(73, 112);
            this.metroTextBoxUsername.MaxLength = 32767;
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.PasswordChar = '\0';
            this.metroTextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsername.SelectedText = "";
            this.metroTextBoxUsername.Size = new System.Drawing.Size(162, 24);
            this.metroTextBoxUsername.TabIndex = 5;
            this.metroTextBoxUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxUsername.UseSelectable = true;
            // 
            // pictureBoxAdvantech
            // 
            this.pictureBoxAdvantech.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdvantech.Image")));
            this.pictureBoxAdvantech.Location = new System.Drawing.Point(355, 343);
            this.pictureBoxAdvantech.Name = "pictureBoxAdvantech";
            this.pictureBoxAdvantech.Size = new System.Drawing.Size(568, 105);
            this.pictureBoxAdvantech.TabIndex = 4;
            this.pictureBoxAdvantech.TabStop = false;
            // 
            // Link1
            // 
            this.Link1.BackColor = System.Drawing.Color.Transparent;
            this.Link1.Location = new System.Drawing.Point(687, 146);
            this.Link1.Name = "Link1";
            this.Link1.Size = new System.Drawing.Size(40, 23);
            this.Link1.Style = MetroFramework.MetroColorStyle.Blue;
            this.Link1.TabIndex = 3;
            this.Link1.Text = "here.";
            this.Link1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Link1.UseCustomBackColor = true;
            this.Link1.UseSelectable = true;
            this.Link1.UseStyleColors = true;
            this.Link1.Click += new System.EventHandler(this.Link1_Click);
            // 
            // LabelHelloText
            // 
            this.LabelHelloText.AutoSize = true;
            this.LabelHelloText.Location = new System.Drawing.Point(400, 90);
            this.LabelHelloText.Name = "LabelHelloText";
            this.LabelHelloText.Size = new System.Drawing.Size(371, 19);
            this.LabelHelloText.TabIndex = 2;
            this.LabelHelloText.Text = "\"Welcome in AdvantechMeasure application. \\n\\nTo start, \" + ";
            this.LabelHelloText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPageAnalogBufferedInput
            // 
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroLabel6);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroTextBoxRate);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroLabel5);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroLabel2);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroLabel1);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroTextBoxScanCount);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroTextBoxIntervalCount);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroTextBoxChannelStart);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroProgressSpinner1);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroTrackBar2);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroTrackBar1);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroButtonMeasure);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroTextBoxChannels);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.MetroTextBoxSamples);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.chartAnalogInput);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroLabelChannels);
            this.metroTabPageAnalogBufferedInput.Controls.Add(this.metroLabelSamples);
            this.metroTabPageAnalogBufferedInput.HorizontalScrollbarBarColor = true;
            this.metroTabPageAnalogBufferedInput.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageAnalogBufferedInput.HorizontalScrollbarSize = 10;
            this.metroTabPageAnalogBufferedInput.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageAnalogBufferedInput.Name = "metroTabPageAnalogBufferedInput";
            this.metroTabPageAnalogBufferedInput.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageAnalogBufferedInput.TabIndex = 0;
            this.metroTabPageAnalogBufferedInput.Text = "Analog Buffered Input";
            this.metroTabPageAnalogBufferedInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageAnalogBufferedInput.VerticalScrollbarBarColor = true;
            this.metroTabPageAnalogBufferedInput.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageAnalogBufferedInput.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(53, 155);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 48;
            this.metroLabel6.Text = "Rate";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroTextBoxRate
            // 
            this.MetroTextBoxRate.Lines = new string[] {
        "100"};
            this.MetroTextBoxRate.Location = new System.Drawing.Point(117, 154);
            this.MetroTextBoxRate.MaxLength = 32767;
            this.MetroTextBoxRate.Name = "MetroTextBoxRate";
            this.MetroTextBoxRate.PasswordChar = '\0';
            this.MetroTextBoxRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxRate.SelectedText = "";
            this.MetroTextBoxRate.Size = new System.Drawing.Size(97, 20);
            this.MetroTextBoxRate.TabIndex = 47;
            this.MetroTextBoxRate.Text = "100";
            this.MetroTextBoxRate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBoxRate.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 129);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Scan Count";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-2, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Interval Count";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "Channel Start";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroTextBoxScanCount
            // 
            this.MetroTextBoxScanCount.Lines = new string[] {
        "10"};
            this.MetroTextBoxScanCount.Location = new System.Drawing.Point(117, 128);
            this.MetroTextBoxScanCount.MaxLength = 32767;
            this.MetroTextBoxScanCount.Name = "MetroTextBoxScanCount";
            this.MetroTextBoxScanCount.PasswordChar = '\0';
            this.MetroTextBoxScanCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxScanCount.SelectedText = "";
            this.MetroTextBoxScanCount.Size = new System.Drawing.Size(97, 20);
            this.MetroTextBoxScanCount.TabIndex = 43;
            this.MetroTextBoxScanCount.Text = "10";
            this.MetroTextBoxScanCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBoxScanCount.UseSelectable = true;
            // 
            // MetroTextBoxIntervalCount
            // 
            this.MetroTextBoxIntervalCount.Lines = new string[] {
        "512"};
            this.MetroTextBoxIntervalCount.Location = new System.Drawing.Point(117, 102);
            this.MetroTextBoxIntervalCount.MaxLength = 32767;
            this.MetroTextBoxIntervalCount.Name = "MetroTextBoxIntervalCount";
            this.MetroTextBoxIntervalCount.PasswordChar = '\0';
            this.MetroTextBoxIntervalCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxIntervalCount.SelectedText = "";
            this.MetroTextBoxIntervalCount.Size = new System.Drawing.Size(97, 20);
            this.MetroTextBoxIntervalCount.TabIndex = 42;
            this.MetroTextBoxIntervalCount.Text = "512";
            this.MetroTextBoxIntervalCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBoxIntervalCount.UseSelectable = true;
            // 
            // MetroTextBoxChannelStart
            // 
            this.MetroTextBoxChannelStart.Lines = new string[] {
        "0"};
            this.MetroTextBoxChannelStart.Location = new System.Drawing.Point(117, 75);
            this.MetroTextBoxChannelStart.MaxLength = 32767;
            this.MetroTextBoxChannelStart.Name = "MetroTextBoxChannelStart";
            this.MetroTextBoxChannelStart.PasswordChar = '\0';
            this.MetroTextBoxChannelStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxChannelStart.SelectedText = "";
            this.MetroTextBoxChannelStart.Size = new System.Drawing.Size(97, 20);
            this.MetroTextBoxChannelStart.TabIndex = 41;
            this.MetroTextBoxChannelStart.Text = "0";
            this.MetroTextBoxChannelStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBoxChannelStart.UseSelectable = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(159, 382);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(55, 51);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.TabIndex = 40;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 30;
            this.metroProgressSpinner1.Visible = false;
            // 
            // metroTrackBar2
            // 
            this.metroTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar2.Location = new System.Drawing.Point(311, 402);
            this.metroTrackBar2.Name = "metroTrackBar2";
            this.metroTrackBar2.Size = new System.Drawing.Size(584, 10);
            this.metroTrackBar2.TabIndex = 15;
            this.metroTrackBar2.Text = "metroTrackBar2";
            this.metroTrackBar2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(312, 423);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(583, 10);
            this.metroTrackBar1.TabIndex = 14;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPageOptions
            // 
            this.metroTabPageOptions.Controls.Add(this.metroRadioButton2);
            this.metroTabPageOptions.Controls.Add(this.metroRadioButton1);
            this.metroTabPageOptions.Controls.Add(this.metroToggle1);
            this.metroTabPageOptions.HorizontalScrollbarBarColor = true;
            this.metroTabPageOptions.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageOptions.HorizontalScrollbarSize = 10;
            this.metroTabPageOptions.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageOptions.Name = "metroTabPageOptions";
            this.metroTabPageOptions.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageOptions.TabIndex = 4;
            this.metroTabPageOptions.Text = "Options";
            this.metroTabPageOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageOptions.VerticalScrollbarBarColor = true;
            this.metroTabPageOptions.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageOptions.VerticalScrollbarSize = 10;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(60, 133);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(61, 15);
            this.metroRadioButton2.TabIndex = 4;
            this.metroRadioButton2.Text = "English";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(61, 112);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(54, 15);
            this.metroRadioButton1.TabIndex = 3;
            this.metroRadioButton1.Text = "Polski";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(60, 63);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 2;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroTabPageAnalogOutput
            // 
            this.metroTabPageAnalogOutput.Controls.Add(this.metroTabControl2);
            this.metroTabPageAnalogOutput.HorizontalScrollbarBarColor = true;
            this.metroTabPageAnalogOutput.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageAnalogOutput.HorizontalScrollbarSize = 10;
            this.metroTabPageAnalogOutput.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageAnalogOutput.Name = "metroTabPageAnalogOutput";
            this.metroTabPageAnalogOutput.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageAnalogOutput.TabIndex = 1;
            this.metroTabPageAnalogOutput.Text = "Analog Output";
            this.metroTabPageAnalogOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageAnalogOutput.VerticalScrollbarBarColor = true;
            this.metroTabPageAnalogOutput.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageAnalogOutput.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage7);
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Location = new System.Drawing.Point(49, 3);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(872, 338);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(864, 296);
            this.metroTabPage7.TabIndex = 0;
            this.metroTabPage7.Text = "InstantOutput";
            this.metroTabPage7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(864, 296);
            this.metroTabPage8.TabIndex = 1;
            this.metroTabPage8.Text = "BufferedOutput";
            this.metroTabPage8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // metroTabPageLastMeasure
            // 
            this.metroTabPageLastMeasure.Controls.Add(this.metroPanel1);
            this.metroTabPageLastMeasure.HorizontalScrollbarBarColor = true;
            this.metroTabPageLastMeasure.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageLastMeasure.HorizontalScrollbarSize = 10;
            this.metroTabPageLastMeasure.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageLastMeasure.Name = "metroTabPageLastMeasure";
            this.metroTabPageLastMeasure.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageLastMeasure.TabIndex = 5;
            this.metroTabPageLastMeasure.Text = "LastMeasure";
            this.metroTabPageLastMeasure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageLastMeasure.VerticalScrollbarBarColor = true;
            this.metroTabPageLastMeasure.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageLastMeasure.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroGridTable);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(914, 388);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroGridTable
            // 
            this.metroGridTable.AllowUserToAddRows = false;
            this.metroGridTable.AllowUserToDeleteRows = false;
            this.metroGridTable.AllowUserToResizeColumns = false;
            this.metroGridTable.AllowUserToResizeRows = false;
            this.metroGridTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Channel_1,
            this.Channel_2,
            this.Channel_3,
            this.Channel_4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGridTable.EnableHeadersVisualStyles = false;
            this.metroGridTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridTable.Location = new System.Drawing.Point(0, 0);
            this.metroGridTable.Name = "metroGridTable";
            this.metroGridTable.ReadOnly = true;
            this.metroGridTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridTable.ShowEditingIcon = false;
            this.metroGridTable.Size = new System.Drawing.Size(914, 388);
            this.metroGridTable.TabIndex = 16;
            this.metroGridTable.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Channel_1
            // 
            this.Channel_1.HeaderText = "Channel 1";
            this.Channel_1.Name = "Channel_1";
            this.Channel_1.ReadOnly = true;
            this.Channel_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Channel_2
            // 
            this.Channel_2.HeaderText = "Channel 2";
            this.Channel_2.Name = "Channel_2";
            this.Channel_2.ReadOnly = true;
            // 
            // Channel_3
            // 
            this.Channel_3.HeaderText = "Channel 3";
            this.Channel_3.Name = "Channel_3";
            this.Channel_3.ReadOnly = true;
            // 
            // Channel_4
            // 
            this.Channel_4.HeaderText = "Channel 4";
            this.Channel_4.Name = "Channel_4";
            this.Channel_4.ReadOnly = true;
            // 
            // metroTabPageMeasure
            // 
            this.metroTabPageMeasure.Controls.Add(this.metroLabelInstant);
            this.metroTabPageMeasure.Controls.Add(this.metroLabelBuffered);
            this.metroTabPageMeasure.Controls.Add(this.metroButtonMeasureReturn);
            this.metroTabPageMeasure.Controls.Add(this.metroLabelDigitalOutput);
            this.metroTabPageMeasure.Controls.Add(this.metroLabelAnalogOutput);
            this.metroTabPageMeasure.Controls.Add(this.metroLabelDigitalInput);
            this.metroTabPageMeasure.Controls.Add(this.metroTileBufferedInput);
            this.metroTabPageMeasure.Controls.Add(this.metroTileInstantInput);
            this.metroTabPageMeasure.Controls.Add(this.metroLabelAnalogInput);
            this.metroTabPageMeasure.Controls.Add(this.metroTileDigitalOutput);
            this.metroTabPageMeasure.Controls.Add(this.metroTileDigitalInput);
            this.metroTabPageMeasure.Controls.Add(this.metroTileAnalogOutput);
            this.metroTabPageMeasure.Controls.Add(this.metroTileAnalogInput);
            this.metroTabPageMeasure.HorizontalScrollbarBarColor = true;
            this.metroTabPageMeasure.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageMeasure.HorizontalScrollbarSize = 10;
            this.metroTabPageMeasure.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageMeasure.Name = "metroTabPageMeasure";
            this.metroTabPageMeasure.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageMeasure.TabIndex = 7;
            this.metroTabPageMeasure.Text = "Measure";
            this.metroTabPageMeasure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageMeasure.VerticalScrollbarBarColor = true;
            this.metroTabPageMeasure.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageMeasure.VerticalScrollbarSize = 10;
            // 
            // metroLabelInstant
            // 
            this.metroLabelInstant.AutoSize = true;
            this.metroLabelInstant.Location = new System.Drawing.Point(113, 206);
            this.metroLabelInstant.Name = "metroLabelInstant";
            this.metroLabelInstant.Size = new System.Drawing.Size(74, 19);
            this.metroLabelInstant.TabIndex = 14;
            this.metroLabelInstant.Text = "Instant opis";
            this.metroLabelInstant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabelInstant.Visible = false;
            // 
            // metroLabelBuffered
            // 
            this.metroLabelBuffered.AutoSize = true;
            this.metroLabelBuffered.Location = new System.Drawing.Point(681, 206);
            this.metroLabelBuffered.Name = "metroLabelBuffered";
            this.metroLabelBuffered.Size = new System.Drawing.Size(87, 19);
            this.metroLabelBuffered.TabIndex = 13;
            this.metroLabelBuffered.Text = "Buffered opis";
            this.metroLabelBuffered.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabelBuffered.Visible = false;
            // 
            // metroButtonMeasureReturn
            // 
            this.metroButtonMeasureReturn.Location = new System.Drawing.Point(784, 389);
            this.metroButtonMeasureReturn.Name = "metroButtonMeasureReturn";
            this.metroButtonMeasureReturn.Size = new System.Drawing.Size(133, 52);
            this.metroButtonMeasureReturn.TabIndex = 12;
            this.metroButtonMeasureReturn.Text = "Return";
            this.metroButtonMeasureReturn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonMeasureReturn.UseSelectable = true;
            this.metroButtonMeasureReturn.Click += new System.EventHandler(this.metroButtonMeasureReturn_Click);
            // 
            // metroLabelDigitalOutput
            // 
            this.metroLabelDigitalOutput.AutoSize = true;
            this.metroLabelDigitalOutput.Location = new System.Drawing.Point(681, 262);
            this.metroLabelDigitalOutput.Name = "metroLabelDigitalOutput";
            this.metroLabelDigitalOutput.Size = new System.Drawing.Size(119, 19);
            this.metroLabelDigitalOutput.TabIndex = 11;
            this.metroLabelDigitalOutput.Text = "Digital Output opis";
            this.metroLabelDigitalOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabelDigitalOutput.Visible = false;
            // 
            // metroLabelAnalogOutput
            // 
            this.metroLabelAnalogOutput.AutoSize = true;
            this.metroLabelAnalogOutput.Location = new System.Drawing.Point(681, 116);
            this.metroLabelAnalogOutput.Name = "metroLabelAnalogOutput";
            this.metroLabelAnalogOutput.Size = new System.Drawing.Size(124, 19);
            this.metroLabelAnalogOutput.TabIndex = 10;
            this.metroLabelAnalogOutput.Text = "Analog Output opis";
            this.metroLabelAnalogOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabelAnalogOutput.Visible = false;
            // 
            // metroLabelDigitalInput
            // 
            this.metroLabelDigitalInput.AutoSize = true;
            this.metroLabelDigitalInput.Location = new System.Drawing.Point(113, 262);
            this.metroLabelDigitalInput.Name = "metroLabelDigitalInput";
            this.metroLabelDigitalInput.Size = new System.Drawing.Size(107, 19);
            this.metroLabelDigitalInput.TabIndex = 9;
            this.metroLabelDigitalInput.Text = "Digital Input opis";
            this.metroLabelDigitalInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabelDigitalInput.Visible = false;
            // 
            // metroTileBufferedInput
            // 
            this.metroTileBufferedInput.ActiveControl = null;
            this.metroTileBufferedInput.Location = new System.Drawing.Point(460, 179);
            this.metroTileBufferedInput.Name = "metroTileBufferedInput";
            this.metroTileBufferedInput.Size = new System.Drawing.Size(168, 86);
            this.metroTileBufferedInput.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileBufferedInput.TabIndex = 8;
            this.metroTileBufferedInput.Text = "Buffered Input";
            this.metroTileBufferedInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileBufferedInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileBufferedInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileBufferedInput.UseSelectable = true;
            this.metroTileBufferedInput.Visible = false;
            this.metroTileBufferedInput.Click += new System.EventHandler(this.metroTile6_Click);
            this.metroTileBufferedInput.MouseEnter += new System.EventHandler(this.metroTileBufferedInput_MouseEnter);
            this.metroTileBufferedInput.MouseLeave += new System.EventHandler(this.metroTileBufferedInput_MouseLeave);
            // 
            // metroTileInstantInput
            // 
            this.metroTileInstantInput.ActiveControl = null;
            this.metroTileInstantInput.Location = new System.Drawing.Point(243, 179);
            this.metroTileInstantInput.Name = "metroTileInstantInput";
            this.metroTileInstantInput.Size = new System.Drawing.Size(168, 86);
            this.metroTileInstantInput.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileInstantInput.TabIndex = 7;
            this.metroTileInstantInput.Text = "Instant Input";
            this.metroTileInstantInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileInstantInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileInstantInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileInstantInput.UseSelectable = true;
            this.metroTileInstantInput.Visible = false;
            this.metroTileInstantInput.MouseEnter += new System.EventHandler(this.metroTileInstantInput_MouseEnter);
            this.metroTileInstantInput.MouseLeave += new System.EventHandler(this.metroTileInstantInput_MouseLeave);
            // 
            // metroLabelAnalogInput
            // 
            this.metroLabelAnalogInput.AutoSize = true;
            this.metroLabelAnalogInput.Location = new System.Drawing.Point(113, 116);
            this.metroLabelAnalogInput.Name = "metroLabelAnalogInput";
            this.metroLabelAnalogInput.Size = new System.Drawing.Size(112, 19);
            this.metroLabelAnalogInput.TabIndex = 6;
            this.metroLabelAnalogInput.Text = "Analog Input opis";
            this.metroLabelAnalogInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabelAnalogInput.Visible = false;
            // 
            // metroTileDigitalOutput
            // 
            this.metroTileDigitalOutput.ActiveControl = null;
            this.metroTileDigitalOutput.Location = new System.Drawing.Point(460, 244);
            this.metroTileDigitalOutput.Name = "metroTileDigitalOutput";
            this.metroTileDigitalOutput.Size = new System.Drawing.Size(168, 86);
            this.metroTileDigitalOutput.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileDigitalOutput.TabIndex = 5;
            this.metroTileDigitalOutput.Text = "Digital Output";
            this.metroTileDigitalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDigitalOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileDigitalOutput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDigitalOutput.UseSelectable = true;
            this.metroTileDigitalOutput.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTileDigitalOutput.MouseEnter += new System.EventHandler(this.metroTileDigitalOutput_MouseEnter);
            this.metroTileDigitalOutput.MouseLeave += new System.EventHandler(this.metroTileDigitalOutput_MouseLeave);
            // 
            // metroTileDigitalInput
            // 
            this.metroTileDigitalInput.ActiveControl = null;
            this.metroTileDigitalInput.Location = new System.Drawing.Point(243, 244);
            this.metroTileDigitalInput.Name = "metroTileDigitalInput";
            this.metroTileDigitalInput.Size = new System.Drawing.Size(168, 86);
            this.metroTileDigitalInput.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileDigitalInput.TabIndex = 4;
            this.metroTileDigitalInput.Text = "Digital Input";
            this.metroTileDigitalInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDigitalInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileDigitalInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDigitalInput.UseSelectable = true;
            this.metroTileDigitalInput.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTileDigitalInput.MouseEnter += new System.EventHandler(this.metroTileDigitalInput_MouseHover);
            this.metroTileDigitalInput.MouseLeave += new System.EventHandler(this.metroTileDigitalInput_MouseLeave);
            // 
            // metroTileAnalogOutput
            // 
            this.metroTileAnalogOutput.ActiveControl = null;
            this.metroTileAnalogOutput.Location = new System.Drawing.Point(460, 120);
            this.metroTileAnalogOutput.Name = "metroTileAnalogOutput";
            this.metroTileAnalogOutput.Size = new System.Drawing.Size(168, 86);
            this.metroTileAnalogOutput.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTileAnalogOutput.TabIndex = 3;
            this.metroTileAnalogOutput.Text = "Analog Output";
            this.metroTileAnalogOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAnalogOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileAnalogOutput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAnalogOutput.UseSelectable = true;
            this.metroTileAnalogOutput.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTileAnalogOutput.MouseEnter += new System.EventHandler(this.metroTileAnalogOutput_MouseEnter);
            this.metroTileAnalogOutput.MouseLeave += new System.EventHandler(this.metroTileAnalogOutput_MouseLeave);
            // 
            // metroTileAnalogInput
            // 
            this.metroTileAnalogInput.ActiveControl = null;
            this.metroTileAnalogInput.Location = new System.Drawing.Point(243, 120);
            this.metroTileAnalogInput.Name = "metroTileAnalogInput";
            this.metroTileAnalogInput.Size = new System.Drawing.Size(168, 86);
            this.metroTileAnalogInput.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTileAnalogInput.TabIndex = 2;
            this.metroTileAnalogInput.Text = "Analog Input";
            this.metroTileAnalogInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAnalogInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTileAnalogInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAnalogInput.UseSelectable = true;
            this.metroTileAnalogInput.Click += new System.EventHandler(this.metroTile1_Click);
            this.metroTileAnalogInput.MouseEnter += new System.EventHandler(this.metroTile1_MouseHover);
            this.metroTileAnalogInput.MouseLeave += new System.EventHandler(this.metroTile1_MouseLeave);
            // 
            // metroTabPageDigitalOutput
            // 
            this.metroTabPageDigitalOutput.HorizontalScrollbarBarColor = true;
            this.metroTabPageDigitalOutput.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageDigitalOutput.HorizontalScrollbarSize = 10;
            this.metroTabPageDigitalOutput.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageDigitalOutput.Name = "metroTabPageDigitalOutput";
            this.metroTabPageDigitalOutput.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageDigitalOutput.TabIndex = 3;
            this.metroTabPageDigitalOutput.Text = "Digital Output";
            this.metroTabPageDigitalOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageDigitalOutput.VerticalScrollbarBarColor = true;
            this.metroTabPageDigitalOutput.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageDigitalOutput.VerticalScrollbarSize = 10;
            // 
            // metroTabPageDigitalInput
            // 
            this.metroTabPageDigitalInput.HorizontalScrollbarBarColor = true;
            this.metroTabPageDigitalInput.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageDigitalInput.HorizontalScrollbarSize = 10;
            this.metroTabPageDigitalInput.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageDigitalInput.Name = "metroTabPageDigitalInput";
            this.metroTabPageDigitalInput.Size = new System.Drawing.Size(917, 444);
            this.metroTabPageDigitalInput.TabIndex = 2;
            this.metroTabPageDigitalInput.Text = "Digital Input";
            this.metroTabPageDigitalInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPageDigitalInput.VerticalScrollbarBarColor = true;
            this.metroTabPageDigitalInput.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageDigitalInput.VerticalScrollbarSize = 10;
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 572);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Advantech Measure";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalogInput)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageWelcome.ResumeLayout(false);
            this.metroTabPageWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvantech)).EndInit();
            this.metroTabPageAnalogBufferedInput.ResumeLayout(false);
            this.metroTabPageAnalogBufferedInput.PerformLayout();
            this.metroTabPageOptions.ResumeLayout(false);
            this.metroTabPageOptions.PerformLayout();
            this.metroTabPageAnalogOutput.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPageLastMeasure.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTable)).EndInit();
            this.metroTabPageMeasure.ResumeLayout(false);
            this.metroTabPageMeasure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Automation.BDaq.BufferedAiCtrl bufferedAiCtrl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalogInput;
        private MetroFramework.Controls.MetroLabel metroLabelSamples;
        private MetroFramework.Controls.MetroLabel metroLabelChannels;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxSamples;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxChannels;
        private MetroFramework.Controls.MetroButton MetroButtonMeasure;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageAnalogBufferedInput;
        private MetroFramework.Controls.MetroTabPage metroTabPageAnalogOutput;
        private MetroFramework.Controls.MetroTabPage metroTabPageDigitalInput;
        private MetroFramework.Controls.MetroTabPage metroTabPageDigitalOutput;
        private MetroFramework.Controls.MetroTabPage metroTabPageOptions;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroTabPage metroTabPageLastMeasure;
        private MetroFramework.Controls.MetroGrid metroGridTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_4;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabPage metroTabPageWelcome;
        private MetroFramework.Controls.MetroLabel LabelHelloText;
        private MetroFramework.Controls.MetroLink Link1;
        private System.Windows.Forms.PictureBox pictureBoxAdvantech;
        private MetroFramework.Controls.MetroTabPage metroTabPageMeasure;
        private MetroFramework.Controls.MetroTile metroTileDigitalOutput;
        private MetroFramework.Controls.MetroTile metroTileDigitalInput;
        private MetroFramework.Controls.MetroTile metroTileAnalogOutput;
        private MetroFramework.Controls.MetroTile metroTileAnalogInput;
        private MetroFramework.Controls.MetroLabel metroLabelAnalogInput;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroTile metroTileBufferedInput;
        private MetroFramework.Controls.MetroTile metroTileInstantInput;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private MetroFramework.Controls.MetroLabel metroLabelDigitalInput;
        private MetroFramework.Controls.MetroLabel metroLabelDigitalOutput;
        private MetroFramework.Controls.MetroLabel metroLabelAnalogOutput;
        private MetroFramework.Controls.MetroButton metroButtonMeasureReturn;
        private MetroFramework.Controls.MetroLabel metroLabelInstant;
        private MetroFramework.Controls.MetroLabel metroLabelBuffered;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxScanCount;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxIntervalCount;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxChannelStart;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxRate;
    }
}

