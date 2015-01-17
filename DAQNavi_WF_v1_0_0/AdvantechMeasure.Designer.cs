namespace DAQNavi_WF_v1_0_0
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bufferedAiCtrl1 = new Automation.BDaq.BufferedAiCtrl(this.components);
            this.Chart_AnalogBufferedInput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabelSamples = new MetroFramework.Controls.MetroLabel();
            this.metroLabelChannels = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Samples = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Channels = new MetroFramework.Controls.MetroTextBox();
            this.Button_AnalogBufferedInput_Measure = new MetroFramework.Controls.MetroButton();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageWelcome = new MetroFramework.Controls.MetroTabPage();
            this.Button_Login = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.pictureBoxAdvantech = new System.Windows.Forms.PictureBox();
            this.Link1 = new MetroFramework.Controls.MetroLink();
            this.Label_HelloText = new MetroFramework.Controls.MetroLabel();
            this.TabPage_AnalogBufferedInput = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Rate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ScanCount = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_IntervalCount = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ChannelStart = new MetroFramework.Controls.MetroTextBox();
            this.AnalogBufferedInput_ProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.TrackBar_AnalogBufferedInput_1 = new MetroFramework.Controls.MetroTrackBar();
            this.TrackBar_AnalogBufferedInput_2 = new MetroFramework.Controls.MetroTrackBar();
            this.TabPage_Options = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.TabPage_AnalogOutput = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.TabPage_LastMeasure = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGridTable = new MetroFramework.Controls.MetroGrid();
            this.Channel_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage_Measure = new MetroFramework.Controls.MetroTabPage();
            this.Label_Instant = new MetroFramework.Controls.MetroLabel();
            this.Label_Buffered = new MetroFramework.Controls.MetroLabel();
            this.Button_MeasureReturn = new MetroFramework.Controls.MetroButton();
            this.Label_DigitalOutput = new MetroFramework.Controls.MetroLabel();
            this.Label_AnalogOutput = new MetroFramework.Controls.MetroLabel();
            this.Label_DigitalInput = new MetroFramework.Controls.MetroLabel();
            this.Tile_BufferedInput = new MetroFramework.Controls.MetroTile();
            this.Tile_InstantInput = new MetroFramework.Controls.MetroTile();
            this.Label_AnalogInput = new MetroFramework.Controls.MetroLabel();
            this.Tile_DigitalOutput = new MetroFramework.Controls.MetroTile();
            this.Tile_DigitalInput = new MetroFramework.Controls.MetroTile();
            this.Tile_AnalogOutput = new MetroFramework.Controls.MetroTile();
            this.Tile_AnalogInput = new MetroFramework.Controls.MetroTile();
            this.TabPage_DigitalOutput = new MetroFramework.Controls.MetroTabPage();
            this.TabPage_DigitalInput = new MetroFramework.Controls.MetroTabPage();
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.ToolTip_AnalogBufferedChart = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_AnalogBufferedInput)).BeginInit();
            this.TabControl.SuspendLayout();
            this.metroTabPageWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvantech)).BeginInit();
            this.TabPage_AnalogBufferedInput.SuspendLayout();
            this.TabPage_Options.SuspendLayout();
            this.TabPage_AnalogOutput.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.TabPage_LastMeasure.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTable)).BeginInit();
            this.TabPage_Measure.SuspendLayout();
            this.SuspendLayout();
            // 
            // bufferedAiCtrl1
            // 
            this.bufferedAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("bufferedAiCtrl1._StateStream")));
            this.bufferedAiCtrl1.DataReady += new System.EventHandler<Automation.BDaq.BfdAiEventArgs>(this.bufferedAiCtrl1_DataReady);
            // 
            // Chart_AnalogBufferedInput
            // 
            this.Chart_AnalogBufferedInput.BackColor = System.Drawing.Color.Transparent;
            this.Chart_AnalogBufferedInput.BorderSkin.BackColor = System.Drawing.Color.Transparent;
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
            this.Chart_AnalogBufferedInput.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Chart_AnalogBufferedInput.Legends.Add(legend1);
            this.Chart_AnalogBufferedInput.Location = new System.Drawing.Point(244, 3);
            this.Chart_AnalogBufferedInput.Name = "Chart_AnalogBufferedInput";
            this.Chart_AnalogBufferedInput.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            series1.MarkerSize = 0;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.MarkerSize = 0;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Yellow;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series3.MarkerColor = System.Drawing.Color.Yellow;
            series3.MarkerSize = 0;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Lime;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series4.MarkerColor = System.Drawing.Color.Lime;
            series4.MarkerSize = 0;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.MarkerSize = 0;
            series5.Name = "Series5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.MarkerSize = 0;
            series6.Name = "Series6";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.MarkerSize = 0;
            series7.Name = "Series7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsXValueIndexed = true;
            series8.Legend = "Legend1";
            series8.MarkerSize = 0;
            series8.Name = "Series8";
            this.Chart_AnalogBufferedInput.Series.Add(series1);
            this.Chart_AnalogBufferedInput.Series.Add(series2);
            this.Chart_AnalogBufferedInput.Series.Add(series3);
            this.Chart_AnalogBufferedInput.Series.Add(series4);
            this.Chart_AnalogBufferedInput.Series.Add(series5);
            this.Chart_AnalogBufferedInput.Series.Add(series6);
            this.Chart_AnalogBufferedInput.Series.Add(series7);
            this.Chart_AnalogBufferedInput.Series.Add(series8);
            this.Chart_AnalogBufferedInput.Size = new System.Drawing.Size(673, 380);
            this.Chart_AnalogBufferedInput.TabIndex = 3;
            this.Chart_AnalogBufferedInput.Text = "chart2";
            this.Chart_AnalogBufferedInput.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.Chart_AnalogBufferedInput_AxisViewChanged);
            this.Chart_AnalogBufferedInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Chart_AnalogBufferedInput_MouseClick);
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
            // TextBox_Samples
            // 
            this.TextBox_Samples.Lines = new string[] {
        "10"};
            this.TextBox_Samples.Location = new System.Drawing.Point(117, 22);
            this.TextBox_Samples.MaxLength = 32767;
            this.TextBox_Samples.Name = "TextBox_Samples";
            this.TextBox_Samples.PasswordChar = '\0';
            this.TextBox_Samples.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Samples.SelectedText = "";
            this.TextBox_Samples.Size = new System.Drawing.Size(97, 20);
            this.TextBox_Samples.TabIndex = 10;
            this.TextBox_Samples.Text = "10";
            this.TextBox_Samples.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Samples.UseSelectable = true;
            // 
            // TextBox_Channels
            // 
            this.TextBox_Channels.Lines = new string[] {
        "1"};
            this.TextBox_Channels.Location = new System.Drawing.Point(117, 49);
            this.TextBox_Channels.MaxLength = 32767;
            this.TextBox_Channels.Name = "TextBox_Channels";
            this.TextBox_Channels.PasswordChar = '\0';
            this.TextBox_Channels.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Channels.SelectedText = "";
            this.TextBox_Channels.Size = new System.Drawing.Size(97, 20);
            this.TextBox_Channels.TabIndex = 11;
            this.TextBox_Channels.Text = "1";
            this.TextBox_Channels.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Channels.UseSelectable = true;
            // 
            // Button_AnalogBufferedInput_Measure
            // 
            this.Button_AnalogBufferedInput_Measure.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Button_AnalogBufferedInput_Measure.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_AnalogBufferedInput_Measure.Location = new System.Drawing.Point(3, 364);
            this.Button_AnalogBufferedInput_Measure.Name = "Button_AnalogBufferedInput_Measure";
            this.Button_AnalogBufferedInput_Measure.Size = new System.Drawing.Size(150, 69);
            this.Button_AnalogBufferedInput_Measure.TabIndex = 12;
            this.Button_AnalogBufferedInput_Measure.Text = "Measure";
            this.Button_AnalogBufferedInput_Measure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_AnalogBufferedInput_Measure.UseSelectable = true;
            this.Button_AnalogBufferedInput_Measure.UseStyleColors = true;
            this.Button_AnalogBufferedInput_Measure.Click += new System.EventHandler(this.buttonAnalogBufferedInput_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPageWelcome);
            this.TabControl.Controls.Add(this.TabPage_AnalogBufferedInput);
            this.TabControl.Controls.Add(this.TabPage_Options);
            this.TabControl.Controls.Add(this.TabPage_AnalogOutput);
            this.TabControl.Controls.Add(this.TabPage_LastMeasure);
            this.TabControl.Controls.Add(this.TabPage_Measure);
            this.TabControl.Controls.Add(this.TabPage_DigitalOutput);
            this.TabControl.Controls.Add(this.TabPage_DigitalInput);
            this.TabControl.Location = new System.Drawing.Point(23, 63);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(925, 486);
            this.TabControl.TabIndex = 40;
            this.TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl.UseSelectable = true;
            // 
            // metroTabPageWelcome
            // 
            this.metroTabPageWelcome.Controls.Add(this.Button_Login);
            this.metroTabPageWelcome.Controls.Add(this.metroLabel4);
            this.metroTabPageWelcome.Controls.Add(this.metroLabel3);
            this.metroTabPageWelcome.Controls.Add(this.metroTextBoxPassword);
            this.metroTabPageWelcome.Controls.Add(this.TextBox_Username);
            this.metroTabPageWelcome.Controls.Add(this.pictureBoxAdvantech);
            this.metroTabPageWelcome.Controls.Add(this.Link1);
            this.metroTabPageWelcome.Controls.Add(this.Label_HelloText);
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
            // Button_Login
            // 
            this.Button_Login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Button_Login.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_Login.Location = new System.Drawing.Point(96, 249);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(114, 39);
            this.Button_Login.TabIndex = 11;
            this.Button_Login.Text = "Login";
            this.Button_Login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_Login.UseSelectable = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
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
            // TextBox_Username
            // 
            this.TextBox_Username.Lines = new string[0];
            this.TextBox_Username.Location = new System.Drawing.Point(73, 112);
            this.TextBox_Username.MaxLength = 32767;
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PasswordChar = '\0';
            this.TextBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Username.SelectedText = "";
            this.TextBox_Username.Size = new System.Drawing.Size(162, 24);
            this.TextBox_Username.TabIndex = 5;
            this.TextBox_Username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Username.UseSelectable = true;
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
            // Label_HelloText
            // 
            this.Label_HelloText.AutoSize = true;
            this.Label_HelloText.Location = new System.Drawing.Point(400, 90);
            this.Label_HelloText.Name = "Label_HelloText";
            this.Label_HelloText.Size = new System.Drawing.Size(371, 19);
            this.Label_HelloText.TabIndex = 2;
            this.Label_HelloText.Text = "\"Welcome in AdvantechMeasure application. \\n\\nTo start, \" + ";
            this.Label_HelloText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TabPage_AnalogBufferedInput
            // 
            this.TabPage_AnalogBufferedInput.Controls.Add(this.metroLabel6);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TextBox_Rate);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.metroLabel5);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.metroLabel2);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.metroLabel1);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TextBox_ScanCount);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TextBox_IntervalCount);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TextBox_ChannelStart);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.AnalogBufferedInput_ProgressSpinner);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TrackBar_AnalogBufferedInput_1);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TrackBar_AnalogBufferedInput_2);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.Button_AnalogBufferedInput_Measure);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TextBox_Channels);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.TextBox_Samples);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.Chart_AnalogBufferedInput);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.metroLabelChannels);
            this.TabPage_AnalogBufferedInput.Controls.Add(this.metroLabelSamples);
            this.TabPage_AnalogBufferedInput.HorizontalScrollbarBarColor = true;
            this.TabPage_AnalogBufferedInput.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_AnalogBufferedInput.HorizontalScrollbarSize = 10;
            this.TabPage_AnalogBufferedInput.Location = new System.Drawing.Point(4, 38);
            this.TabPage_AnalogBufferedInput.Name = "TabPage_AnalogBufferedInput";
            this.TabPage_AnalogBufferedInput.Size = new System.Drawing.Size(917, 444);
            this.TabPage_AnalogBufferedInput.TabIndex = 0;
            this.TabPage_AnalogBufferedInput.Text = "Analog Buffered Input";
            this.TabPage_AnalogBufferedInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_AnalogBufferedInput.VerticalScrollbarBarColor = true;
            this.TabPage_AnalogBufferedInput.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_AnalogBufferedInput.VerticalScrollbarSize = 10;
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
            // TextBox_Rate
            // 
            this.TextBox_Rate.Lines = new string[] {
        "100"};
            this.TextBox_Rate.Location = new System.Drawing.Point(117, 154);
            this.TextBox_Rate.MaxLength = 32767;
            this.TextBox_Rate.Name = "TextBox_Rate";
            this.TextBox_Rate.PasswordChar = '\0';
            this.TextBox_Rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Rate.SelectedText = "";
            this.TextBox_Rate.Size = new System.Drawing.Size(97, 20);
            this.TextBox_Rate.TabIndex = 47;
            this.TextBox_Rate.Text = "100";
            this.TextBox_Rate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Rate.UseSelectable = true;
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
            // TextBox_ScanCount
            // 
            this.TextBox_ScanCount.Lines = new string[] {
        "10"};
            this.TextBox_ScanCount.Location = new System.Drawing.Point(117, 128);
            this.TextBox_ScanCount.MaxLength = 32767;
            this.TextBox_ScanCount.Name = "TextBox_ScanCount";
            this.TextBox_ScanCount.PasswordChar = '\0';
            this.TextBox_ScanCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_ScanCount.SelectedText = "";
            this.TextBox_ScanCount.Size = new System.Drawing.Size(97, 20);
            this.TextBox_ScanCount.TabIndex = 43;
            this.TextBox_ScanCount.Text = "10";
            this.TextBox_ScanCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_ScanCount.UseSelectable = true;
            // 
            // TextBox_IntervalCount
            // 
            this.TextBox_IntervalCount.Lines = new string[] {
        "512"};
            this.TextBox_IntervalCount.Location = new System.Drawing.Point(117, 102);
            this.TextBox_IntervalCount.MaxLength = 32767;
            this.TextBox_IntervalCount.Name = "TextBox_IntervalCount";
            this.TextBox_IntervalCount.PasswordChar = '\0';
            this.TextBox_IntervalCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_IntervalCount.SelectedText = "";
            this.TextBox_IntervalCount.Size = new System.Drawing.Size(97, 20);
            this.TextBox_IntervalCount.TabIndex = 42;
            this.TextBox_IntervalCount.Text = "512";
            this.TextBox_IntervalCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_IntervalCount.UseSelectable = true;
            // 
            // TextBox_ChannelStart
            // 
            this.TextBox_ChannelStart.Lines = new string[] {
        "0"};
            this.TextBox_ChannelStart.Location = new System.Drawing.Point(117, 75);
            this.TextBox_ChannelStart.MaxLength = 32767;
            this.TextBox_ChannelStart.Name = "TextBox_ChannelStart";
            this.TextBox_ChannelStart.PasswordChar = '\0';
            this.TextBox_ChannelStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_ChannelStart.SelectedText = "";
            this.TextBox_ChannelStart.Size = new System.Drawing.Size(97, 20);
            this.TextBox_ChannelStart.TabIndex = 41;
            this.TextBox_ChannelStart.Text = "0";
            this.TextBox_ChannelStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_ChannelStart.UseSelectable = true;
            // 
            // AnalogBufferedInput_ProgressSpinner
            // 
            this.AnalogBufferedInput_ProgressSpinner.Location = new System.Drawing.Point(159, 382);
            this.AnalogBufferedInput_ProgressSpinner.Maximum = 100;
            this.AnalogBufferedInput_ProgressSpinner.Name = "AnalogBufferedInput_ProgressSpinner";
            this.AnalogBufferedInput_ProgressSpinner.Size = new System.Drawing.Size(55, 51);
            this.AnalogBufferedInput_ProgressSpinner.Speed = 2F;
            this.AnalogBufferedInput_ProgressSpinner.TabIndex = 40;
            this.AnalogBufferedInput_ProgressSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AnalogBufferedInput_ProgressSpinner.UseSelectable = true;
            this.AnalogBufferedInput_ProgressSpinner.Value = 30;
            this.AnalogBufferedInput_ProgressSpinner.Visible = false;
            // 
            // TrackBar_AnalogBufferedInput_1
            // 
            this.TrackBar_AnalogBufferedInput_1.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar_AnalogBufferedInput_1.Location = new System.Drawing.Point(311, 402);
            this.TrackBar_AnalogBufferedInput_1.Name = "TrackBar_AnalogBufferedInput_1";
            this.TrackBar_AnalogBufferedInput_1.Size = new System.Drawing.Size(584, 10);
            this.TrackBar_AnalogBufferedInput_1.TabIndex = 15;
            this.TrackBar_AnalogBufferedInput_1.Text = "metroTrackBar2";
            this.TrackBar_AnalogBufferedInput_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TrackBar_AnalogBufferedInput_1.ValueChanged += new System.EventHandler(this.TrackBar_AnalogBufferedInput_1_ValueChanged);
            // 
            // TrackBar_AnalogBufferedInput_2
            // 
            this.TrackBar_AnalogBufferedInput_2.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar_AnalogBufferedInput_2.Location = new System.Drawing.Point(312, 423);
            this.TrackBar_AnalogBufferedInput_2.Name = "TrackBar_AnalogBufferedInput_2";
            this.TrackBar_AnalogBufferedInput_2.Size = new System.Drawing.Size(583, 10);
            this.TrackBar_AnalogBufferedInput_2.TabIndex = 14;
            this.TrackBar_AnalogBufferedInput_2.Text = "metroTrackBar1";
            this.TrackBar_AnalogBufferedInput_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TrackBar_AnalogBufferedInput_2.ValueChanged += new System.EventHandler(this.TrackBar_AnalogBufferedInput_2_ValueChanged);
            // 
            // TabPage_Options
            // 
            this.TabPage_Options.Controls.Add(this.metroRadioButton2);
            this.TabPage_Options.Controls.Add(this.metroRadioButton1);
            this.TabPage_Options.Controls.Add(this.metroToggle1);
            this.TabPage_Options.HorizontalScrollbarBarColor = true;
            this.TabPage_Options.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_Options.HorizontalScrollbarSize = 10;
            this.TabPage_Options.Location = new System.Drawing.Point(4, 38);
            this.TabPage_Options.Name = "TabPage_Options";
            this.TabPage_Options.Size = new System.Drawing.Size(917, 444);
            this.TabPage_Options.TabIndex = 4;
            this.TabPage_Options.Text = "Options";
            this.TabPage_Options.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_Options.VerticalScrollbarBarColor = true;
            this.TabPage_Options.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_Options.VerticalScrollbarSize = 10;
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
            // TabPage_AnalogOutput
            // 
            this.TabPage_AnalogOutput.Controls.Add(this.metroTabControl2);
            this.TabPage_AnalogOutput.HorizontalScrollbarBarColor = true;
            this.TabPage_AnalogOutput.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_AnalogOutput.HorizontalScrollbarSize = 10;
            this.TabPage_AnalogOutput.Location = new System.Drawing.Point(4, 38);
            this.TabPage_AnalogOutput.Name = "TabPage_AnalogOutput";
            this.TabPage_AnalogOutput.Size = new System.Drawing.Size(917, 444);
            this.TabPage_AnalogOutput.TabIndex = 1;
            this.TabPage_AnalogOutput.Text = "Analog Output";
            this.TabPage_AnalogOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_AnalogOutput.VerticalScrollbarBarColor = true;
            this.TabPage_AnalogOutput.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_AnalogOutput.VerticalScrollbarSize = 10;
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
            // TabPage_LastMeasure
            // 
            this.TabPage_LastMeasure.Controls.Add(this.metroPanel1);
            this.TabPage_LastMeasure.HorizontalScrollbarBarColor = true;
            this.TabPage_LastMeasure.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_LastMeasure.HorizontalScrollbarSize = 10;
            this.TabPage_LastMeasure.Location = new System.Drawing.Point(4, 38);
            this.TabPage_LastMeasure.Name = "TabPage_LastMeasure";
            this.TabPage_LastMeasure.Size = new System.Drawing.Size(917, 444);
            this.TabPage_LastMeasure.TabIndex = 5;
            this.TabPage_LastMeasure.Text = "LastMeasure";
            this.TabPage_LastMeasure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_LastMeasure.VerticalScrollbarBarColor = true;
            this.TabPage_LastMeasure.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_LastMeasure.VerticalScrollbarSize = 10;
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
            // TabPage_Measure
            // 
            this.TabPage_Measure.Controls.Add(this.Label_Instant);
            this.TabPage_Measure.Controls.Add(this.Label_Buffered);
            this.TabPage_Measure.Controls.Add(this.Button_MeasureReturn);
            this.TabPage_Measure.Controls.Add(this.Label_DigitalOutput);
            this.TabPage_Measure.Controls.Add(this.Label_AnalogOutput);
            this.TabPage_Measure.Controls.Add(this.Label_DigitalInput);
            this.TabPage_Measure.Controls.Add(this.Tile_BufferedInput);
            this.TabPage_Measure.Controls.Add(this.Tile_InstantInput);
            this.TabPage_Measure.Controls.Add(this.Label_AnalogInput);
            this.TabPage_Measure.Controls.Add(this.Tile_DigitalOutput);
            this.TabPage_Measure.Controls.Add(this.Tile_DigitalInput);
            this.TabPage_Measure.Controls.Add(this.Tile_AnalogOutput);
            this.TabPage_Measure.Controls.Add(this.Tile_AnalogInput);
            this.TabPage_Measure.HorizontalScrollbarBarColor = true;
            this.TabPage_Measure.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_Measure.HorizontalScrollbarSize = 10;
            this.TabPage_Measure.Location = new System.Drawing.Point(4, 38);
            this.TabPage_Measure.Name = "TabPage_Measure";
            this.TabPage_Measure.Size = new System.Drawing.Size(917, 444);
            this.TabPage_Measure.TabIndex = 7;
            this.TabPage_Measure.Text = "Measure";
            this.TabPage_Measure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_Measure.VerticalScrollbarBarColor = true;
            this.TabPage_Measure.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_Measure.VerticalScrollbarSize = 10;
            // 
            // Label_Instant
            // 
            this.Label_Instant.AutoSize = true;
            this.Label_Instant.Location = new System.Drawing.Point(113, 206);
            this.Label_Instant.Name = "Label_Instant";
            this.Label_Instant.Size = new System.Drawing.Size(74, 19);
            this.Label_Instant.TabIndex = 14;
            this.Label_Instant.Text = "Instant opis";
            this.Label_Instant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_Instant.Visible = false;
            // 
            // Label_Buffered
            // 
            this.Label_Buffered.AutoSize = true;
            this.Label_Buffered.Location = new System.Drawing.Point(681, 206);
            this.Label_Buffered.Name = "Label_Buffered";
            this.Label_Buffered.Size = new System.Drawing.Size(87, 19);
            this.Label_Buffered.TabIndex = 13;
            this.Label_Buffered.Text = "Buffered opis";
            this.Label_Buffered.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_Buffered.Visible = false;
            // 
            // Button_MeasureReturn
            // 
            this.Button_MeasureReturn.Location = new System.Drawing.Point(784, 389);
            this.Button_MeasureReturn.Name = "Button_MeasureReturn";
            this.Button_MeasureReturn.Size = new System.Drawing.Size(133, 52);
            this.Button_MeasureReturn.TabIndex = 12;
            this.Button_MeasureReturn.Text = "Return";
            this.Button_MeasureReturn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_MeasureReturn.UseSelectable = true;
            this.Button_MeasureReturn.Click += new System.EventHandler(this.Button_MeasureReturn_Click);
            // 
            // Label_DigitalOutput
            // 
            this.Label_DigitalOutput.AutoSize = true;
            this.Label_DigitalOutput.Location = new System.Drawing.Point(681, 262);
            this.Label_DigitalOutput.Name = "Label_DigitalOutput";
            this.Label_DigitalOutput.Size = new System.Drawing.Size(119, 19);
            this.Label_DigitalOutput.TabIndex = 11;
            this.Label_DigitalOutput.Text = "Digital Output opis";
            this.Label_DigitalOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_DigitalOutput.Visible = false;
            // 
            // Label_AnalogOutput
            // 
            this.Label_AnalogOutput.AutoSize = true;
            this.Label_AnalogOutput.Location = new System.Drawing.Point(681, 116);
            this.Label_AnalogOutput.Name = "Label_AnalogOutput";
            this.Label_AnalogOutput.Size = new System.Drawing.Size(124, 19);
            this.Label_AnalogOutput.TabIndex = 10;
            this.Label_AnalogOutput.Text = "Analog Output opis";
            this.Label_AnalogOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_AnalogOutput.Visible = false;
            // 
            // Label_DigitalInput
            // 
            this.Label_DigitalInput.AutoSize = true;
            this.Label_DigitalInput.Location = new System.Drawing.Point(113, 262);
            this.Label_DigitalInput.Name = "Label_DigitalInput";
            this.Label_DigitalInput.Size = new System.Drawing.Size(107, 19);
            this.Label_DigitalInput.TabIndex = 9;
            this.Label_DigitalInput.Text = "Digital Input opis";
            this.Label_DigitalInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_DigitalInput.Visible = false;
            // 
            // Tile_BufferedInput
            // 
            this.Tile_BufferedInput.ActiveControl = null;
            this.Tile_BufferedInput.Location = new System.Drawing.Point(460, 179);
            this.Tile_BufferedInput.Name = "Tile_BufferedInput";
            this.Tile_BufferedInput.Size = new System.Drawing.Size(168, 86);
            this.Tile_BufferedInput.Style = MetroFramework.MetroColorStyle.Purple;
            this.Tile_BufferedInput.TabIndex = 8;
            this.Tile_BufferedInput.Text = "Buffered Input";
            this.Tile_BufferedInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_BufferedInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tile_BufferedInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_BufferedInput.UseSelectable = true;
            this.Tile_BufferedInput.Visible = false;
            this.Tile_BufferedInput.Click += new System.EventHandler(this.metroTile6_Click);
            this.Tile_BufferedInput.MouseEnter += new System.EventHandler(this.metroTileBufferedInput_MouseEnter);
            this.Tile_BufferedInput.MouseLeave += new System.EventHandler(this.metroTileBufferedInput_MouseLeave);
            // 
            // Tile_InstantInput
            // 
            this.Tile_InstantInput.ActiveControl = null;
            this.Tile_InstantInput.Location = new System.Drawing.Point(243, 179);
            this.Tile_InstantInput.Name = "Tile_InstantInput";
            this.Tile_InstantInput.Size = new System.Drawing.Size(168, 86);
            this.Tile_InstantInput.Style = MetroFramework.MetroColorStyle.Purple;
            this.Tile_InstantInput.TabIndex = 7;
            this.Tile_InstantInput.Text = "Instant Input";
            this.Tile_InstantInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_InstantInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tile_InstantInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_InstantInput.UseSelectable = true;
            this.Tile_InstantInput.Visible = false;
            this.Tile_InstantInput.MouseEnter += new System.EventHandler(this.metroTileInstantInput_MouseEnter);
            this.Tile_InstantInput.MouseLeave += new System.EventHandler(this.metroTileInstantInput_MouseLeave);
            // 
            // Label_AnalogInput
            // 
            this.Label_AnalogInput.AutoSize = true;
            this.Label_AnalogInput.Location = new System.Drawing.Point(113, 116);
            this.Label_AnalogInput.Name = "Label_AnalogInput";
            this.Label_AnalogInput.Size = new System.Drawing.Size(112, 19);
            this.Label_AnalogInput.TabIndex = 6;
            this.Label_AnalogInput.Text = "Analog Input opis";
            this.Label_AnalogInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_AnalogInput.Visible = false;
            // 
            // Tile_DigitalOutput
            // 
            this.Tile_DigitalOutput.ActiveControl = null;
            this.Tile_DigitalOutput.Location = new System.Drawing.Point(460, 244);
            this.Tile_DigitalOutput.Name = "Tile_DigitalOutput";
            this.Tile_DigitalOutput.Size = new System.Drawing.Size(168, 86);
            this.Tile_DigitalOutput.Style = MetroFramework.MetroColorStyle.Green;
            this.Tile_DigitalOutput.TabIndex = 5;
            this.Tile_DigitalOutput.Text = "Digital Output";
            this.Tile_DigitalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_DigitalOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tile_DigitalOutput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_DigitalOutput.UseSelectable = true;
            this.Tile_DigitalOutput.Click += new System.EventHandler(this.Tile_AnalogInput_Click);
            this.Tile_DigitalOutput.MouseEnter += new System.EventHandler(this.metroTileDigitalOutput_MouseEnter);
            this.Tile_DigitalOutput.MouseLeave += new System.EventHandler(this.metroTileDigitalOutput_MouseLeave);
            // 
            // Tile_DigitalInput
            // 
            this.Tile_DigitalInput.ActiveControl = null;
            this.Tile_DigitalInput.Location = new System.Drawing.Point(243, 244);
            this.Tile_DigitalInput.Name = "Tile_DigitalInput";
            this.Tile_DigitalInput.Size = new System.Drawing.Size(168, 86);
            this.Tile_DigitalInput.Style = MetroFramework.MetroColorStyle.Green;
            this.Tile_DigitalInput.TabIndex = 4;
            this.Tile_DigitalInput.Text = "Digital Input";
            this.Tile_DigitalInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_DigitalInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tile_DigitalInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_DigitalInput.UseSelectable = true;
            this.Tile_DigitalInput.Click += new System.EventHandler(this.Tile_AnalogInput_Click);
            this.Tile_DigitalInput.MouseEnter += new System.EventHandler(this.metroTileDigitalInput_MouseHover);
            this.Tile_DigitalInput.MouseLeave += new System.EventHandler(this.metroTileDigitalInput_MouseLeave);
            // 
            // Tile_AnalogOutput
            // 
            this.Tile_AnalogOutput.ActiveControl = null;
            this.Tile_AnalogOutput.Location = new System.Drawing.Point(460, 120);
            this.Tile_AnalogOutput.Name = "Tile_AnalogOutput";
            this.Tile_AnalogOutput.Size = new System.Drawing.Size(168, 86);
            this.Tile_AnalogOutput.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tile_AnalogOutput.TabIndex = 3;
            this.Tile_AnalogOutput.Text = "Analog Output";
            this.Tile_AnalogOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_AnalogOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tile_AnalogOutput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_AnalogOutput.UseSelectable = true;
            this.Tile_AnalogOutput.Click += new System.EventHandler(this.Tile_AnalogInput_Click);
            this.Tile_AnalogOutput.MouseEnter += new System.EventHandler(this.metroTileAnalogOutput_MouseEnter);
            this.Tile_AnalogOutput.MouseLeave += new System.EventHandler(this.metroTileAnalogOutput_MouseLeave);
            // 
            // Tile_AnalogInput
            // 
            this.Tile_AnalogInput.ActiveControl = null;
            this.Tile_AnalogInput.Location = new System.Drawing.Point(243, 120);
            this.Tile_AnalogInput.Name = "Tile_AnalogInput";
            this.Tile_AnalogInput.Size = new System.Drawing.Size(168, 86);
            this.Tile_AnalogInput.Style = MetroFramework.MetroColorStyle.Teal;
            this.Tile_AnalogInput.TabIndex = 2;
            this.Tile_AnalogInput.Text = "Analog Input";
            this.Tile_AnalogInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tile_AnalogInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tile_AnalogInput.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Tile_AnalogInput.UseSelectable = true;
            this.Tile_AnalogInput.Click += new System.EventHandler(this.Tile_AnalogInput_Click);
            this.Tile_AnalogInput.MouseEnter += new System.EventHandler(this.metroTile1_MouseHover);
            this.Tile_AnalogInput.MouseLeave += new System.EventHandler(this.metroTile1_MouseLeave);
            // 
            // TabPage_DigitalOutput
            // 
            this.TabPage_DigitalOutput.HorizontalScrollbarBarColor = true;
            this.TabPage_DigitalOutput.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_DigitalOutput.HorizontalScrollbarSize = 10;
            this.TabPage_DigitalOutput.Location = new System.Drawing.Point(4, 38);
            this.TabPage_DigitalOutput.Name = "TabPage_DigitalOutput";
            this.TabPage_DigitalOutput.Size = new System.Drawing.Size(917, 444);
            this.TabPage_DigitalOutput.TabIndex = 3;
            this.TabPage_DigitalOutput.Text = "Digital Output";
            this.TabPage_DigitalOutput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_DigitalOutput.VerticalScrollbarBarColor = true;
            this.TabPage_DigitalOutput.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_DigitalOutput.VerticalScrollbarSize = 10;
            // 
            // TabPage_DigitalInput
            // 
            this.TabPage_DigitalInput.HorizontalScrollbarBarColor = true;
            this.TabPage_DigitalInput.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPage_DigitalInput.HorizontalScrollbarSize = 10;
            this.TabPage_DigitalInput.Location = new System.Drawing.Point(4, 38);
            this.TabPage_DigitalInput.Name = "TabPage_DigitalInput";
            this.TabPage_DigitalInput.Size = new System.Drawing.Size(917, 444);
            this.TabPage_DigitalInput.TabIndex = 2;
            this.TabPage_DigitalInput.Text = "Digital Input";
            this.TabPage_DigitalInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabPage_DigitalInput.VerticalScrollbarBarColor = true;
            this.TabPage_DigitalInput.VerticalScrollbarHighlightOnWheel = false;
            this.TabPage_DigitalInput.VerticalScrollbarSize = 10;
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // ToolTip_AnalogBufferedChart
            // 
            this.ToolTip_AnalogBufferedChart.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip_AnalogBufferedChart.StyleManager = null;
            this.ToolTip_AnalogBufferedChart.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 572);
            this.Controls.Add(this.TabControl);
            this.Name = "MainWindow";
            this.Text = "Advantech Measure";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.Chart_AnalogBufferedInput)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.metroTabPageWelcome.ResumeLayout(false);
            this.metroTabPageWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvantech)).EndInit();
            this.TabPage_AnalogBufferedInput.ResumeLayout(false);
            this.TabPage_AnalogBufferedInput.PerformLayout();
            this.TabPage_Options.ResumeLayout(false);
            this.TabPage_Options.PerformLayout();
            this.TabPage_AnalogOutput.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.TabPage_LastMeasure.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTable)).EndInit();
            this.TabPage_Measure.ResumeLayout(false);
            this.TabPage_Measure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Automation.BDaq.BufferedAiCtrl bufferedAiCtrl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_AnalogBufferedInput;
        private MetroFramework.Controls.MetroLabel metroLabelSamples;
        private MetroFramework.Controls.MetroLabel metroLabelChannels;
        private MetroFramework.Controls.MetroTextBox TextBox_Samples;
        private MetroFramework.Controls.MetroTextBox TextBox_Channels;
        private MetroFramework.Controls.MetroButton Button_AnalogBufferedInput_Measure;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage TabPage_AnalogBufferedInput;
        private MetroFramework.Controls.MetroTabPage TabPage_AnalogOutput;
        private MetroFramework.Controls.MetroTabPage TabPage_DigitalInput;
        private MetroFramework.Controls.MetroTabPage TabPage_DigitalOutput;
        private MetroFramework.Controls.MetroTabPage TabPage_Options;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroTabPage TabPage_LastMeasure;
        private MetroFramework.Controls.MetroGrid metroGridTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel_4;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private MetroFramework.Controls.MetroTrackBar TrackBar_AnalogBufferedInput_1;
        private MetroFramework.Controls.MetroTrackBar TrackBar_AnalogBufferedInput_2;
        private MetroFramework.Controls.MetroProgressSpinner AnalogBufferedInput_ProgressSpinner;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabPage metroTabPageWelcome;
        private MetroFramework.Controls.MetroLabel Label_HelloText;
        private MetroFramework.Controls.MetroLink Link1;
        private System.Windows.Forms.PictureBox pictureBoxAdvantech;
        private MetroFramework.Controls.MetroTabPage TabPage_Measure;
        private MetroFramework.Controls.MetroTile Tile_DigitalOutput;
        private MetroFramework.Controls.MetroTile Tile_DigitalInput;
        private MetroFramework.Controls.MetroTile Tile_AnalogOutput;
        private MetroFramework.Controls.MetroTile Tile_AnalogInput;
        private MetroFramework.Controls.MetroLabel Label_AnalogInput;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox TextBox_Username;
        private MetroFramework.Controls.MetroButton Button_Login;
        private MetroFramework.Controls.MetroTile Tile_BufferedInput;
        private MetroFramework.Controls.MetroTile Tile_InstantInput;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private MetroFramework.Controls.MetroLabel Label_DigitalInput;
        private MetroFramework.Controls.MetroLabel Label_DigitalOutput;
        private MetroFramework.Controls.MetroLabel Label_AnalogOutput;
        private MetroFramework.Controls.MetroButton Button_MeasureReturn;
        private MetroFramework.Controls.MetroLabel Label_Instant;
        private MetroFramework.Controls.MetroLabel Label_Buffered;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBox_ScanCount;
        private MetroFramework.Controls.MetroTextBox TextBox_IntervalCount;
        private MetroFramework.Controls.MetroTextBox TextBox_ChannelStart;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TextBox_Rate;
        private MetroFramework.Components.MetroToolTip ToolTip_AnalogBufferedChart;
    }
}

