namespace DAQNavi_WF_v1_0_0
{
    partial class CommentForm
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
            this.TextBox_CommentForm_AdminComment = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_CommentForm_UserComment = new MetroFramework.Controls.MetroTextBox();
            this.RadioButton_CommentForm_txt = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButton_CommentForm_xlsm = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButton_CommentForm_DB = new MetroFramework.Controls.MetroRadioButton();
            this.Panel_CommentForm = new MetroFramework.Controls.MetroPanel();
            this.Button_CommentForm_Export = new MetroFramework.Controls.MetroButton();
            this.Button_CommentForm_Cancel = new MetroFramework.Controls.MetroButton();
            this.Label_CommentForm_AdminComment = new MetroFramework.Controls.MetroLabel();
            this.Label_CommentForm_UserComment = new MetroFramework.Controls.MetroLabel();
            this.Label_CommentForm_FileFormat = new MetroFramework.Controls.MetroLabel();
            this.ProgressBar_CommentForm = new MetroFramework.Controls.MetroProgressBar();
            this.Panel_CommentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_CommentForm_AdminComment
            // 
            this.TextBox_CommentForm_AdminComment.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TextBox_CommentForm_AdminComment.Enabled = false;
            this.TextBox_CommentForm_AdminComment.Lines = new string[0];
            this.TextBox_CommentForm_AdminComment.Location = new System.Drawing.Point(60, 119);
            this.TextBox_CommentForm_AdminComment.MaxLength = 32767;
            this.TextBox_CommentForm_AdminComment.Multiline = true;
            this.TextBox_CommentForm_AdminComment.Name = "TextBox_CommentForm_AdminComment";
            this.TextBox_CommentForm_AdminComment.PasswordChar = '\0';
            this.TextBox_CommentForm_AdminComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_CommentForm_AdminComment.SelectedText = "";
            this.TextBox_CommentForm_AdminComment.Size = new System.Drawing.Size(335, 74);
            this.TextBox_CommentForm_AdminComment.TabIndex = 0;
            this.TextBox_CommentForm_AdminComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_CommentForm_AdminComment.UseSelectable = true;
            // 
            // TextBox_CommentForm_UserComment
            // 
            this.TextBox_CommentForm_UserComment.Lines = new string[0];
            this.TextBox_CommentForm_UserComment.Location = new System.Drawing.Point(60, 241);
            this.TextBox_CommentForm_UserComment.MaxLength = 32767;
            this.TextBox_CommentForm_UserComment.Multiline = true;
            this.TextBox_CommentForm_UserComment.Name = "TextBox_CommentForm_UserComment";
            this.TextBox_CommentForm_UserComment.PasswordChar = '\0';
            this.TextBox_CommentForm_UserComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_CommentForm_UserComment.SelectedText = "";
            this.TextBox_CommentForm_UserComment.Size = new System.Drawing.Size(335, 80);
            this.TextBox_CommentForm_UserComment.TabIndex = 1;
            this.TextBox_CommentForm_UserComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_CommentForm_UserComment.UseSelectable = true;
            // 
            // RadioButton_CommentForm_txt
            // 
            this.RadioButton_CommentForm_txt.AutoSize = true;
            this.RadioButton_CommentForm_txt.Checked = true;
            this.RadioButton_CommentForm_txt.Location = new System.Drawing.Point(36, 21);
            this.RadioButton_CommentForm_txt.Name = "RadioButton_CommentForm_txt";
            this.RadioButton_CommentForm_txt.Size = new System.Drawing.Size(39, 15);
            this.RadioButton_CommentForm_txt.TabIndex = 2;
            this.RadioButton_CommentForm_txt.TabStop = true;
            this.RadioButton_CommentForm_txt.Text = ".txt";
            this.RadioButton_CommentForm_txt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RadioButton_CommentForm_txt.UseSelectable = true;
            // 
            // RadioButton_CommentForm_xlsm
            // 
            this.RadioButton_CommentForm_xlsm.AutoSize = true;
            this.RadioButton_CommentForm_xlsm.Location = new System.Drawing.Point(121, 21);
            this.RadioButton_CommentForm_xlsm.Name = "RadioButton_CommentForm_xlsm";
            this.RadioButton_CommentForm_xlsm.Size = new System.Drawing.Size(50, 15);
            this.RadioButton_CommentForm_xlsm.TabIndex = 3;
            this.RadioButton_CommentForm_xlsm.Text = ".xlsm";
            this.RadioButton_CommentForm_xlsm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RadioButton_CommentForm_xlsm.UseSelectable = true;
            // 
            // RadioButton_CommentForm_DB
            // 
            this.RadioButton_CommentForm_DB.AutoSize = true;
            this.RadioButton_CommentForm_DB.Location = new System.Drawing.Point(222, 21);
            this.RadioButton_CommentForm_DB.Name = "RadioButton_CommentForm_DB";
            this.RadioButton_CommentForm_DB.Size = new System.Drawing.Size(100, 15);
            this.RadioButton_CommentForm_DB.TabIndex = 4;
            this.RadioButton_CommentForm_DB.Text = "only Data Base";
            this.RadioButton_CommentForm_DB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RadioButton_CommentForm_DB.UseSelectable = true;
            // 
            // Panel_CommentForm
            // 
            this.Panel_CommentForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_CommentForm.Controls.Add(this.RadioButton_CommentForm_DB);
            this.Panel_CommentForm.Controls.Add(this.RadioButton_CommentForm_xlsm);
            this.Panel_CommentForm.Controls.Add(this.RadioButton_CommentForm_txt);
            this.Panel_CommentForm.HorizontalScrollbarBarColor = true;
            this.Panel_CommentForm.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel_CommentForm.HorizontalScrollbarSize = 10;
            this.Panel_CommentForm.Location = new System.Drawing.Point(60, 373);
            this.Panel_CommentForm.Name = "Panel_CommentForm";
            this.Panel_CommentForm.Size = new System.Drawing.Size(335, 63);
            this.Panel_CommentForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.Panel_CommentForm.TabIndex = 14;
            this.Panel_CommentForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Panel_CommentForm.VerticalScrollbarBarColor = true;
            this.Panel_CommentForm.VerticalScrollbarHighlightOnWheel = false;
            this.Panel_CommentForm.VerticalScrollbarSize = 10;
            // 
            // Button_CommentForm_Export
            // 
            this.Button_CommentForm_Export.Highlight = true;
            this.Button_CommentForm_Export.Location = new System.Drawing.Point(278, 471);
            this.Button_CommentForm_Export.Name = "Button_CommentForm_Export";
            this.Button_CommentForm_Export.Size = new System.Drawing.Size(142, 47);
            this.Button_CommentForm_Export.TabIndex = 15;
            this.Button_CommentForm_Export.Text = "Export";
            this.Button_CommentForm_Export.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_CommentForm_Export.UseSelectable = true;
            this.Button_CommentForm_Export.Click += new System.EventHandler(this.Button_CommentForm_Export_Click);
            // 
            // Button_CommentForm_Cancel
            // 
            this.Button_CommentForm_Cancel.Location = new System.Drawing.Point(35, 471);
            this.Button_CommentForm_Cancel.Name = "Button_CommentForm_Cancel";
            this.Button_CommentForm_Cancel.Size = new System.Drawing.Size(142, 47);
            this.Button_CommentForm_Cancel.TabIndex = 16;
            this.Button_CommentForm_Cancel.Text = "Cancel";
            this.Button_CommentForm_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_CommentForm_Cancel.UseSelectable = true;
            this.Button_CommentForm_Cancel.Click += new System.EventHandler(this.Button_CommentForm_Cancel_Click);
            // 
            // Label_CommentForm_AdminComment
            // 
            this.Label_CommentForm_AdminComment.AutoSize = true;
            this.Label_CommentForm_AdminComment.Location = new System.Drawing.Point(60, 87);
            this.Label_CommentForm_AdminComment.Name = "Label_CommentForm_AdminComment";
            this.Label_CommentForm_AdminComment.Size = new System.Drawing.Size(108, 19);
            this.Label_CommentForm_AdminComment.TabIndex = 17;
            this.Label_CommentForm_AdminComment.Text = "Admin comment";
            this.Label_CommentForm_AdminComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label_CommentForm_UserComment
            // 
            this.Label_CommentForm_UserComment.AutoSize = true;
            this.Label_CommentForm_UserComment.Location = new System.Drawing.Point(60, 210);
            this.Label_CommentForm_UserComment.Name = "Label_CommentForm_UserComment";
            this.Label_CommentForm_UserComment.Size = new System.Drawing.Size(95, 19);
            this.Label_CommentForm_UserComment.TabIndex = 18;
            this.Label_CommentForm_UserComment.Text = "User comment";
            this.Label_CommentForm_UserComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label_CommentForm_FileFormat
            // 
            this.Label_CommentForm_FileFormat.AutoSize = true;
            this.Label_CommentForm_FileFormat.Location = new System.Drawing.Point(60, 343);
            this.Label_CommentForm_FileFormat.Name = "Label_CommentForm_FileFormat";
            this.Label_CommentForm_FileFormat.Size = new System.Drawing.Size(73, 19);
            this.Label_CommentForm_FileFormat.TabIndex = 19;
            this.Label_CommentForm_FileFormat.Text = "File format";
            this.Label_CommentForm_FileFormat.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ProgressBar_CommentForm
            // 
            this.ProgressBar_CommentForm.Location = new System.Drawing.Point(60, 448);
            this.ProgressBar_CommentForm.Name = "ProgressBar_CommentForm";
            this.ProgressBar_CommentForm.Size = new System.Drawing.Size(334, 10);
            this.ProgressBar_CommentForm.TabIndex = 20;
            this.ProgressBar_CommentForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBar_CommentForm.Value = 10;
            this.ProgressBar_CommentForm.Visible = false;
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 541);
            this.Controls.Add(this.ProgressBar_CommentForm);
            this.Controls.Add(this.Label_CommentForm_FileFormat);
            this.Controls.Add(this.Label_CommentForm_UserComment);
            this.Controls.Add(this.Label_CommentForm_AdminComment);
            this.Controls.Add(this.Button_CommentForm_Cancel);
            this.Controls.Add(this.Button_CommentForm_Export);
            this.Controls.Add(this.Panel_CommentForm);
            this.Controls.Add(this.TextBox_CommentForm_UserComment);
            this.Controls.Add(this.TextBox_CommentForm_AdminComment);
            this.Name = "CommentForm";
            this.Text = "Export to file";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Panel_CommentForm.ResumeLayout(false);
            this.Panel_CommentForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextBox_CommentForm_AdminComment;
        private MetroFramework.Controls.MetroTextBox TextBox_CommentForm_UserComment;
        private MetroFramework.Controls.MetroRadioButton RadioButton_CommentForm_txt;
        private MetroFramework.Controls.MetroRadioButton RadioButton_CommentForm_xlsm;
        private MetroFramework.Controls.MetroRadioButton RadioButton_CommentForm_DB;
        private MetroFramework.Controls.MetroPanel Panel_CommentForm;
        private MetroFramework.Controls.MetroButton Button_CommentForm_Export;
        private MetroFramework.Controls.MetroButton Button_CommentForm_Cancel;
        private MetroFramework.Controls.MetroLabel Label_CommentForm_AdminComment;
        private MetroFramework.Controls.MetroLabel Label_CommentForm_UserComment;
        private MetroFramework.Controls.MetroLabel Label_CommentForm_FileFormat;
        private MetroFramework.Controls.MetroProgressBar ProgressBar_CommentForm;
    }
}