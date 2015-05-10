namespace DAQNavi_WF_v1_0_0
{
    partial class AIIMeasureOptionsForm
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
            this.AAIOP_label_Interval_2 = new MetroFramework.Controls.MetroLabel();
            this.AAIOP_label_Interval_1 = new MetroFramework.Controls.MetroLabel();
            this.AIIOP_comboBox_NumberOfChannels = new MetroFramework.Controls.MetroComboBox();
            this.AIIOP_comboBox_StartChannel = new MetroFramework.Controls.MetroComboBox();
            this.AIIOP_label_NumberOfChannels = new MetroFramework.Controls.MetroLabel();
            this.AIIOP_label_StartChannel = new MetroFramework.Controls.MetroLabel();
            this.AIIOP_trackBar_SampleInterval = new MetroFramework.Controls.MetroTrackBar();
            this.Button_AIMOptions_Save = new MetroFramework.Controls.MetroButton();
            this.AIIOP_label_int2 = new MetroFramework.Controls.MetroLabel();
            this.AIIOP_label_int1 = new MetroFramework.Controls.MetroLabel();
            this.AIIOP_label_channelRange = new MetroFramework.Controls.MetroLabel();
            this.AIIOP_grid = new System.Windows.Forms.DataGridView();
            this.Samplesn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AIIOP_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // AAIOP_label_Interval_2
            // 
            this.AAIOP_label_Interval_2.AutoSize = true;
            this.AAIOP_label_Interval_2.Location = new System.Drawing.Point(317, 73);
            this.AAIOP_label_Interval_2.Name = "AAIOP_label_Interval_2";
            this.AAIOP_label_Interval_2.Size = new System.Drawing.Size(51, 19);
            this.AAIOP_label_Interval_2.TabIndex = 59;
            this.AAIOP_label_Interval_2.Text = "Interval";
            this.AAIOP_label_Interval_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AAIOP_label_Interval_1
            // 
            this.AAIOP_label_Interval_1.AutoSize = true;
            this.AAIOP_label_Interval_1.Location = new System.Drawing.Point(34, 73);
            this.AAIOP_label_Interval_1.Name = "AAIOP_label_Interval_1";
            this.AAIOP_label_Interval_1.Size = new System.Drawing.Size(51, 19);
            this.AAIOP_label_Interval_1.TabIndex = 58;
            this.AAIOP_label_Interval_1.Text = "Interval";
            this.AAIOP_label_Interval_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AIIOP_comboBox_NumberOfChannels
            // 
            this.AIIOP_comboBox_NumberOfChannels.FormattingEnabled = true;
            this.AIIOP_comboBox_NumberOfChannels.ItemHeight = 23;
            this.AIIOP_comboBox_NumberOfChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.AIIOP_comboBox_NumberOfChannels.Location = new System.Drawing.Point(244, 172);
            this.AIIOP_comboBox_NumberOfChannels.Name = "AIIOP_comboBox_NumberOfChannels";
            this.AIIOP_comboBox_NumberOfChannels.Size = new System.Drawing.Size(122, 29);
            this.AIIOP_comboBox_NumberOfChannels.TabIndex = 57;
            this.AIIOP_comboBox_NumberOfChannels.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AIIOP_comboBox_NumberOfChannels.UseSelectable = true;
            this.AIIOP_comboBox_NumberOfChannels.SelectedIndexChanged += new System.EventHandler(this.AIIOP_comboBox_NumberOfChannels_SelectedIndexChanged);
            // 
            // AIIOP_comboBox_StartChannel
            // 
            this.AIIOP_comboBox_StartChannel.FormattingEnabled = true;
            this.AIIOP_comboBox_StartChannel.ItemHeight = 23;
            this.AIIOP_comboBox_StartChannel.Items.AddRange(new object[] {
            "Channel 0",
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7"});
            this.AIIOP_comboBox_StartChannel.Location = new System.Drawing.Point(44, 172);
            this.AIIOP_comboBox_StartChannel.Name = "AIIOP_comboBox_StartChannel";
            this.AIIOP_comboBox_StartChannel.Size = new System.Drawing.Size(122, 29);
            this.AIIOP_comboBox_StartChannel.TabIndex = 56;
            this.AIIOP_comboBox_StartChannel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AIIOP_comboBox_StartChannel.UseSelectable = true;
            this.AIIOP_comboBox_StartChannel.SelectedIndexChanged += new System.EventHandler(this.ComboBox_AnalogInstantInput_StartChannel_SelectedIndexChanged);
            // 
            // AIIOP_label_NumberOfChannels
            // 
            this.AIIOP_label_NumberOfChannels.AutoSize = true;
            this.AIIOP_label_NumberOfChannels.Location = new System.Drawing.Point(236, 150);
            this.AIIOP_label_NumberOfChannels.Name = "AIIOP_label_NumberOfChannels";
            this.AIIOP_label_NumberOfChannels.Size = new System.Drawing.Size(130, 19);
            this.AIIOP_label_NumberOfChannels.TabIndex = 55;
            this.AIIOP_label_NumberOfChannels.Text = "Number of Channels";
            this.AIIOP_label_NumberOfChannels.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AIIOP_label_StartChannel
            // 
            this.AIIOP_label_StartChannel.AutoSize = true;
            this.AIIOP_label_StartChannel.Location = new System.Drawing.Point(34, 150);
            this.AIIOP_label_StartChannel.Name = "AIIOP_label_StartChannel";
            this.AIIOP_label_StartChannel.Size = new System.Drawing.Size(87, 19);
            this.AIIOP_label_StartChannel.TabIndex = 54;
            this.AIIOP_label_StartChannel.Text = "Start Channel";
            this.AIIOP_label_StartChannel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AIIOP_trackBar_SampleInterval
            // 
            this.AIIOP_trackBar_SampleInterval.BackColor = System.Drawing.Color.Transparent;
            this.AIIOP_trackBar_SampleInterval.Location = new System.Drawing.Point(39, 95);
            this.AIIOP_trackBar_SampleInterval.Name = "AIIOP_trackBar_SampleInterval";
            this.AIIOP_trackBar_SampleInterval.Size = new System.Drawing.Size(329, 26);
            this.AIIOP_trackBar_SampleInterval.TabIndex = 53;
            this.AIIOP_trackBar_SampleInterval.Text = "metroTrackBar2";
            this.AIIOP_trackBar_SampleInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AIIOP_trackBar_SampleInterval.ValueChanged += new System.EventHandler(this.AAIOP_trackBar_SampleInterval_ValueChanged);
            // 
            // Button_AIMOptions_Save
            // 
            this.Button_AIMOptions_Save.Highlight = true;
            this.Button_AIMOptions_Save.Location = new System.Drawing.Point(273, 480);
            this.Button_AIMOptions_Save.Name = "Button_AIMOptions_Save";
            this.Button_AIMOptions_Save.Size = new System.Drawing.Size(105, 38);
            this.Button_AIMOptions_Save.TabIndex = 60;
            this.Button_AIMOptions_Save.Text = "Save";
            this.Button_AIMOptions_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_AIMOptions_Save.UseSelectable = true;
            this.Button_AIMOptions_Save.Click += new System.EventHandler(this.Button_AIMOptions_Save_Click);
            // 
            // AIIOP_label_int2
            // 
            this.AIIOP_label_int2.AutoSize = true;
            this.AIIOP_label_int2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.AIIOP_label_int2.Location = new System.Drawing.Point(311, 113);
            this.AIIOP_label_int2.Name = "AIIOP_label_int2";
            this.AIIOP_label_int2.Size = new System.Drawing.Size(48, 15);
            this.AIIOP_label_int2.TabIndex = 89;
            this.AIIOP_label_int2.Text = "1000 Hz";
            this.AIIOP_label_int2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AIIOP_label_int1
            // 
            this.AIIOP_label_int1.AutoSize = true;
            this.AIIOP_label_int1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.AIIOP_label_int1.Location = new System.Drawing.Point(34, 113);
            this.AIIOP_label_int1.Name = "AIIOP_label_int1";
            this.AIIOP_label_int1.Size = new System.Drawing.Size(30, 15);
            this.AIIOP_label_int1.TabIndex = 88;
            this.AIIOP_label_int1.Text = "1 Hz";
            this.AIIOP_label_int1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AIIOP_label_channelRange
            // 
            this.AIIOP_label_channelRange.Location = new System.Drawing.Point(39, 247);
            this.AIIOP_label_channelRange.Name = "AIIOP_label_channelRange";
            this.AIIOP_label_channelRange.Size = new System.Drawing.Size(134, 19);
            this.AIIOP_label_channelRange.TabIndex = 87;
            this.AIIOP_label_channelRange.Text = "Channel range";
            this.AIIOP_label_channelRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AIIOP_label_channelRange.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AIIOP_grid
            // 
            this.AIIOP_grid.AllowUserToAddRows = false;
            this.AIIOP_grid.AllowUserToDeleteRows = false;
            this.AIIOP_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.AIIOP_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AIIOP_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AIIOP_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AIIOP_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AIIOP_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AIIOP_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Samplesn,
            this.Channel1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AIIOP_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.AIIOP_grid.EnableHeadersVisualStyles = false;
            this.AIIOP_grid.GridColor = System.Drawing.Color.Black;
            this.AIIOP_grid.Location = new System.Drawing.Point(39, 272);
            this.AIIOP_grid.Name = "AIIOP_grid";
            this.AIIOP_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AIIOP_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AIIOP_grid.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AIIOP_grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AIIOP_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AIIOP_grid.Size = new System.Drawing.Size(346, 190);
            this.AIIOP_grid.TabIndex = 86;
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
            // AIIMeasureOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 541);
            this.Controls.Add(this.AIIOP_label_int2);
            this.Controls.Add(this.AIIOP_label_int1);
            this.Controls.Add(this.AIIOP_label_channelRange);
            this.Controls.Add(this.AIIOP_grid);
            this.Controls.Add(this.Button_AIMOptions_Save);
            this.Controls.Add(this.AAIOP_label_Interval_2);
            this.Controls.Add(this.AAIOP_label_Interval_1);
            this.Controls.Add(this.AIIOP_comboBox_NumberOfChannels);
            this.Controls.Add(this.AIIOP_comboBox_StartChannel);
            this.Controls.Add(this.AIIOP_label_NumberOfChannels);
            this.Controls.Add(this.AIIOP_label_StartChannel);
            this.Controls.Add(this.AIIOP_trackBar_SampleInterval);
            this.Name = "AIIMeasureOptionsForm";
            this.Text = "AII Options";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AnalogInstantMeasureOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AIIOP_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel AAIOP_label_Interval_2;
        private MetroFramework.Controls.MetroLabel AAIOP_label_Interval_1;
        private MetroFramework.Controls.MetroComboBox AIIOP_comboBox_NumberOfChannels;
        private MetroFramework.Controls.MetroComboBox AIIOP_comboBox_StartChannel;
        private MetroFramework.Controls.MetroLabel AIIOP_label_NumberOfChannels;
        private MetroFramework.Controls.MetroLabel AIIOP_label_StartChannel;
        private MetroFramework.Controls.MetroTrackBar AIIOP_trackBar_SampleInterval;
        private MetroFramework.Controls.MetroButton Button_AIMOptions_Save;
        private MetroFramework.Controls.MetroLabel AIIOP_label_int2;
        private MetroFramework.Controls.MetroLabel AIIOP_label_int1;
        public MetroFramework.Controls.MetroLabel AIIOP_label_channelRange;
        private System.Windows.Forms.DataGridView AIIOP_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samplesn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Channel1;
    }
}