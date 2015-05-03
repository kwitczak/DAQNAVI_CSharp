namespace DAQNavi_WF_v1_0_0.Forms
{
    partial class ABIMeasureOptionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ABIOP_button_Save = new MetroFramework.Controls.MetroButton();
            this.ABIOP_label_Interval_2 = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_label_Interval_1 = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_comboBox_NumberOfChannels = new MetroFramework.Controls.MetroComboBox();
            this.ABIOP_comboBox_StartChannel = new MetroFramework.Controls.MetroComboBox();
            this.ABIOP_label_NumberOfChannels = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_label_StartChannel = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_trackBar_SampleInterval = new MetroFramework.Controls.MetroTrackBar();
            this.ABIOP_textBox_samples = new MetroFramework.Controls.MetroTextBox();
            this.ABIOP_label_samples = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_grid = new System.Windows.Forms.DataGridView();
            this.ABIOP_label_channelRange = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_label_int1 = new MetroFramework.Controls.MetroLabel();
            this.ABIOP_label_int2 = new MetroFramework.Controls.MetroLabel();
            this.Samplesn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ABIOP_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ABIOP_button_Save
            // 
            this.ABIOP_button_Save.Highlight = true;
            this.ABIOP_button_Save.Location = new System.Drawing.Point(276, 480);
            this.ABIOP_button_Save.Name = "ABIOP_button_Save";
            this.ABIOP_button_Save.Size = new System.Drawing.Size(105, 38);
            this.ABIOP_button_Save.TabIndex = 68;
            this.ABIOP_button_Save.Text = "Save";
            this.ABIOP_button_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ABIOP_button_Save.UseSelectable = true;
            this.ABIOP_button_Save.Click += new System.EventHandler(this.ABIOP_button_Save_Click);
            // 
            // ABIOP_label_Interval_2
            // 
            this.ABIOP_label_Interval_2.AutoSize = true;
            this.ABIOP_label_Interval_2.Location = new System.Drawing.Point(286, 76);
            this.ABIOP_label_Interval_2.Name = "ABIOP_label_Interval_2";
            this.ABIOP_label_Interval_2.Size = new System.Drawing.Size(51, 19);
            this.ABIOP_label_Interval_2.TabIndex = 67;
            this.ABIOP_label_Interval_2.Text = "Interval";
            this.ABIOP_label_Interval_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_label_Interval_1
            // 
            this.ABIOP_label_Interval_1.AutoSize = true;
            this.ABIOP_label_Interval_1.Location = new System.Drawing.Point(27, 76);
            this.ABIOP_label_Interval_1.Name = "ABIOP_label_Interval_1";
            this.ABIOP_label_Interval_1.Size = new System.Drawing.Size(51, 19);
            this.ABIOP_label_Interval_1.TabIndex = 66;
            this.ABIOP_label_Interval_1.Text = "Interval";
            this.ABIOP_label_Interval_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_comboBox_NumberOfChannels
            // 
            this.ABIOP_comboBox_NumberOfChannels.FormattingEnabled = true;
            this.ABIOP_comboBox_NumberOfChannels.ItemHeight = 23;
            this.ABIOP_comboBox_NumberOfChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ABIOP_comboBox_NumberOfChannels.Location = new System.Drawing.Point(215, 163);
            this.ABIOP_comboBox_NumberOfChannels.Name = "ABIOP_comboBox_NumberOfChannels";
            this.ABIOP_comboBox_NumberOfChannels.Size = new System.Drawing.Size(122, 29);
            this.ABIOP_comboBox_NumberOfChannels.TabIndex = 65;
            this.ABIOP_comboBox_NumberOfChannels.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ABIOP_comboBox_NumberOfChannels.UseSelectable = true;
            this.ABIOP_comboBox_NumberOfChannels.SelectedIndexChanged += new System.EventHandler(this.ABIOP_comboBox_NumberOfChannels_SelectedIndexChanged);
            // 
            // ABIOP_comboBox_StartChannel
            // 
            this.ABIOP_comboBox_StartChannel.FormattingEnabled = true;
            this.ABIOP_comboBox_StartChannel.ItemHeight = 23;
            this.ABIOP_comboBox_StartChannel.Items.AddRange(new object[] {
            "Channel 0",
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7"});
            this.ABIOP_comboBox_StartChannel.Location = new System.Drawing.Point(35, 163);
            this.ABIOP_comboBox_StartChannel.Name = "ABIOP_comboBox_StartChannel";
            this.ABIOP_comboBox_StartChannel.Size = new System.Drawing.Size(122, 29);
            this.ABIOP_comboBox_StartChannel.TabIndex = 64;
            this.ABIOP_comboBox_StartChannel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ABIOP_comboBox_StartChannel.UseSelectable = true;
            this.ABIOP_comboBox_StartChannel.SelectedIndexChanged += new System.EventHandler(this.ABIOP_comboBox_StartChannel_SelectedIndexChanged);
            // 
            // ABIOP_label_NumberOfChannels
            // 
            this.ABIOP_label_NumberOfChannels.AutoSize = true;
            this.ABIOP_label_NumberOfChannels.Location = new System.Drawing.Point(207, 141);
            this.ABIOP_label_NumberOfChannels.Name = "ABIOP_label_NumberOfChannels";
            this.ABIOP_label_NumberOfChannels.Size = new System.Drawing.Size(130, 19);
            this.ABIOP_label_NumberOfChannels.TabIndex = 63;
            this.ABIOP_label_NumberOfChannels.Text = "Number of Channels";
            this.ABIOP_label_NumberOfChannels.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_label_StartChannel
            // 
            this.ABIOP_label_StartChannel.AutoSize = true;
            this.ABIOP_label_StartChannel.Location = new System.Drawing.Point(27, 141);
            this.ABIOP_label_StartChannel.Name = "ABIOP_label_StartChannel";
            this.ABIOP_label_StartChannel.Size = new System.Drawing.Size(87, 19);
            this.ABIOP_label_StartChannel.TabIndex = 62;
            this.ABIOP_label_StartChannel.Text = "Start Channel";
            this.ABIOP_label_StartChannel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_trackBar_SampleInterval
            // 
            this.ABIOP_trackBar_SampleInterval.BackColor = System.Drawing.Color.Transparent;
            this.ABIOP_trackBar_SampleInterval.Location = new System.Drawing.Point(32, 98);
            this.ABIOP_trackBar_SampleInterval.Name = "ABIOP_trackBar_SampleInterval";
            this.ABIOP_trackBar_SampleInterval.Size = new System.Drawing.Size(305, 26);
            this.ABIOP_trackBar_SampleInterval.TabIndex = 61;
            this.ABIOP_trackBar_SampleInterval.Text = "metroTrackBar2";
            this.ABIOP_trackBar_SampleInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ABIOP_trackBar_SampleInterval.ValueChanged += new System.EventHandler(this.ABIOP_trackBar_SampleInterval_ValueChanged);
            // 
            // ABIOP_textBox_samples
            // 
            this.ABIOP_textBox_samples.Lines = new string[] {
        "10"};
            this.ABIOP_textBox_samples.Location = new System.Drawing.Point(46, 231);
            this.ABIOP_textBox_samples.MaxLength = 32767;
            this.ABIOP_textBox_samples.Name = "ABIOP_textBox_samples";
            this.ABIOP_textBox_samples.PasswordChar = '\0';
            this.ABIOP_textBox_samples.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ABIOP_textBox_samples.SelectedText = "";
            this.ABIOP_textBox_samples.Size = new System.Drawing.Size(111, 20);
            this.ABIOP_textBox_samples.TabIndex = 70;
            this.ABIOP_textBox_samples.Text = "10";
            this.ABIOP_textBox_samples.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ABIOP_textBox_samples.UseSelectable = true;
            // 
            // ABIOP_label_samples
            // 
            this.ABIOP_label_samples.Location = new System.Drawing.Point(27, 209);
            this.ABIOP_label_samples.Name = "ABIOP_label_samples";
            this.ABIOP_label_samples.Size = new System.Drawing.Size(134, 19);
            this.ABIOP_label_samples.TabIndex = 69;
            this.ABIOP_label_samples.Text = "Samples per channel";
            this.ABIOP_label_samples.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ABIOP_label_samples.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_grid
            // 
            this.ABIOP_grid.AllowUserToAddRows = false;
            this.ABIOP_grid.AllowUserToDeleteRows = false;
            this.ABIOP_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ABIOP_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ABIOP_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ABIOP_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ABIOP_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ABIOP_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ABIOP_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Samplesn,
            this.Channel1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ABIOP_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ABIOP_grid.EnableHeadersVisualStyles = false;
            this.ABIOP_grid.GridColor = System.Drawing.Color.Black;
            this.ABIOP_grid.Location = new System.Drawing.Point(35, 293);
            this.ABIOP_grid.Name = "ABIOP_grid";
            this.ABIOP_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ABIOP_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ABIOP_grid.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ABIOP_grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ABIOP_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ABIOP_grid.Size = new System.Drawing.Size(346, 124);
            this.ABIOP_grid.TabIndex = 82;
            // 
            // ABIOP_label_channelRange
            // 
            this.ABIOP_label_channelRange.Location = new System.Drawing.Point(32, 271);
            this.ABIOP_label_channelRange.Name = "ABIOP_label_channelRange";
            this.ABIOP_label_channelRange.Size = new System.Drawing.Size(134, 19);
            this.ABIOP_label_channelRange.TabIndex = 83;
            this.ABIOP_label_channelRange.Text = "Channel range";
            this.ABIOP_label_channelRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ABIOP_label_channelRange.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_label_int1
            // 
            this.ABIOP_label_int1.AutoSize = true;
            this.ABIOP_label_int1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ABIOP_label_int1.Location = new System.Drawing.Point(30, 116);
            this.ABIOP_label_int1.Name = "ABIOP_label_int1";
            this.ABIOP_label_int1.Size = new System.Drawing.Size(42, 15);
            this.ABIOP_label_int1.TabIndex = 84;
            this.ABIOP_label_int1.Text = "100 Hz";
            this.ABIOP_label_int1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ABIOP_label_int2
            // 
            this.ABIOP_label_int2.AutoSize = true;
            this.ABIOP_label_int2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ABIOP_label_int2.Location = new System.Drawing.Point(285, 116);
            this.ABIOP_label_int2.Name = "ABIOP_label_int2";
            this.ABIOP_label_int2.Size = new System.Drawing.Size(57, 15);
            this.ABIOP_label_int2.TabIndex = 85;
            this.ABIOP_label_int2.Text = "10 000 Hz";
            this.ABIOP_label_int2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Samplesn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Samplesn.DefaultCellStyle = dataGridViewCellStyle2;
            this.Samplesn.Frozen = true;
            this.Samplesn.HeaderText = "Channel";
            this.Samplesn.Name = "Samplesn";
            this.Samplesn.Width = 60;
            // 
            // Channel1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.Channel1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Channel1.Frozen = true;
            this.Channel1.HeaderText = "Value Range";
            this.Channel1.Items.AddRange(new object[] {
            "V_Neg15To15 ",
            "V_Neg10To10",
            "V_Neg5To5 ",
            "V_Neg2pt5To2pt5",
            "V_Neg1pt25To1pt25",
            "V_Neg1To1",
            "V_0To15 ",
            "V_0To10",
            "V_0To5",
            "V_0To2pt5",
            "V_0To1pt25",
            "V_0To1",
            "V_Neg2To2",
            "V_Neg4To4",
            "V_Neg20To20"});
            this.Channel1.Name = "Channel1";
            this.Channel1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Channel1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Channel1.Width = 220;
            // 
            // ABIMeasureOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 541);
            this.Controls.Add(this.ABIOP_label_int2);
            this.Controls.Add(this.ABIOP_label_int1);
            this.Controls.Add(this.ABIOP_label_channelRange);
            this.Controls.Add(this.ABIOP_grid);
            this.Controls.Add(this.ABIOP_textBox_samples);
            this.Controls.Add(this.ABIOP_label_samples);
            this.Controls.Add(this.ABIOP_button_Save);
            this.Controls.Add(this.ABIOP_label_Interval_2);
            this.Controls.Add(this.ABIOP_label_Interval_1);
            this.Controls.Add(this.ABIOP_comboBox_NumberOfChannels);
            this.Controls.Add(this.ABIOP_comboBox_StartChannel);
            this.Controls.Add(this.ABIOP_label_NumberOfChannels);
            this.Controls.Add(this.ABIOP_label_StartChannel);
            this.Controls.Add(this.ABIOP_trackBar_SampleInterval);
            this.Name = "ABIMeasureOptionsForm";
            this.Text = "ABI Options";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.ABIOP_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ABIOP_button_Save;
        private MetroFramework.Controls.MetroLabel ABIOP_label_Interval_2;
        private MetroFramework.Controls.MetroLabel ABIOP_label_Interval_1;
        private MetroFramework.Controls.MetroComboBox ABIOP_comboBox_NumberOfChannels;
        private MetroFramework.Controls.MetroComboBox ABIOP_comboBox_StartChannel;
        private MetroFramework.Controls.MetroLabel ABIOP_label_NumberOfChannels;
        private MetroFramework.Controls.MetroLabel ABIOP_label_StartChannel;
        private MetroFramework.Controls.MetroTrackBar ABIOP_trackBar_SampleInterval;
        public MetroFramework.Controls.MetroTextBox ABIOP_textBox_samples;
        public MetroFramework.Controls.MetroLabel ABIOP_label_samples;
        private System.Windows.Forms.DataGridView ABIOP_grid;
        public MetroFramework.Controls.MetroLabel ABIOP_label_channelRange;
        private MetroFramework.Controls.MetroLabel ABIOP_label_int1;
        private MetroFramework.Controls.MetroLabel ABIOP_label_int2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samplesn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Channel1;

    }
}