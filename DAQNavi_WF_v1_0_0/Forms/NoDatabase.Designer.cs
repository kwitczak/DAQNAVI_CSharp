namespace DAQNavi_WF_v1_0_0.Forms
{
    partial class NoDatabase
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
            this.NoDb_label_info = new MetroFramework.Controls.MetroLabel();
            this.NoDb_textBox_nazwa = new MetroFramework.Controls.MetroTextBox();
            this.NoDb_label_nazwa = new MetroFramework.Controls.MetroLabel();
            this.NoDb_textBox_port = new MetroFramework.Controls.MetroTextBox();
            this.NoDb_label_port = new MetroFramework.Controls.MetroLabel();
            this.NoDb_textBox_baza = new MetroFramework.Controls.MetroTextBox();
            this.NoDb_label_haslo = new MetroFramework.Controls.MetroLabel();
            this.NoDb_label_adres = new MetroFramework.Controls.MetroLabel();
            this.NoDb_textBox_haslo = new MetroFramework.Controls.MetroTextBox();
            this.NoDb_textBox_login = new MetroFramework.Controls.MetroTextBox();
            this.NoDb_label_login = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // NoDb_label_info
            // 
            this.NoDb_label_info.Location = new System.Drawing.Point(32, 82);
            this.NoDb_label_info.Name = "NoDb_label_info";
            this.NoDb_label_info.Size = new System.Drawing.Size(352, 47);
            this.NoDb_label_info.TabIndex = 0;
            this.NoDb_label_info.Text = "Wykryto pierwsze uruchomienie aplikacji. Wpisz informacje adresowe bazy danych:";
            this.NoDb_label_info.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NoDb_label_info.WrapToLine = true;
            // 
            // NoDb_textBox_nazwa
            // 
            this.NoDb_textBox_nazwa.Lines = new string[] {
        "usb4702_logindb"};
            this.NoDb_textBox_nazwa.Location = new System.Drawing.Point(162, 236);
            this.NoDb_textBox_nazwa.MaxLength = 32767;
            this.NoDb_textBox_nazwa.Name = "NoDb_textBox_nazwa";
            this.NoDb_textBox_nazwa.PasswordChar = '\0';
            this.NoDb_textBox_nazwa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoDb_textBox_nazwa.SelectedText = "";
            this.NoDb_textBox_nazwa.Size = new System.Drawing.Size(222, 20);
            this.NoDb_textBox_nazwa.TabIndex = 36;
            this.NoDb_textBox_nazwa.Text = "usb4702_logindb";
            this.NoDb_textBox_nazwa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NoDb_textBox_nazwa.UseSelectable = true;
            // 
            // NoDb_label_nazwa
            // 
            this.NoDb_label_nazwa.Location = new System.Drawing.Point(32, 236);
            this.NoDb_label_nazwa.Name = "NoDb_label_nazwa";
            this.NoDb_label_nazwa.Size = new System.Drawing.Size(112, 19);
            this.NoDb_label_nazwa.TabIndex = 37;
            this.NoDb_label_nazwa.Text = "Nazwa bazy";
            this.NoDb_label_nazwa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoDb_label_nazwa.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NoDb_textBox_port
            // 
            this.NoDb_textBox_port.Lines = new string[] {
        "3306"};
            this.NoDb_textBox_port.Location = new System.Drawing.Point(162, 201);
            this.NoDb_textBox_port.MaxLength = 32767;
            this.NoDb_textBox_port.Name = "NoDb_textBox_port";
            this.NoDb_textBox_port.PasswordChar = '\0';
            this.NoDb_textBox_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoDb_textBox_port.SelectedText = "";
            this.NoDb_textBox_port.Size = new System.Drawing.Size(222, 20);
            this.NoDb_textBox_port.TabIndex = 34;
            this.NoDb_textBox_port.Text = "3306";
            this.NoDb_textBox_port.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NoDb_textBox_port.UseSelectable = true;
            // 
            // NoDb_label_port
            // 
            this.NoDb_label_port.Location = new System.Drawing.Point(110, 201);
            this.NoDb_label_port.Name = "NoDb_label_port";
            this.NoDb_label_port.Size = new System.Drawing.Size(34, 19);
            this.NoDb_label_port.TabIndex = 35;
            this.NoDb_label_port.Text = "Port";
            this.NoDb_label_port.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoDb_label_port.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NoDb_textBox_baza
            // 
            this.NoDb_textBox_baza.Lines = new string[] {
        "localhost"};
            this.NoDb_textBox_baza.Location = new System.Drawing.Point(162, 169);
            this.NoDb_textBox_baza.MaxLength = 32767;
            this.NoDb_textBox_baza.Name = "NoDb_textBox_baza";
            this.NoDb_textBox_baza.PasswordChar = '\0';
            this.NoDb_textBox_baza.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoDb_textBox_baza.SelectedText = "";
            this.NoDb_textBox_baza.Size = new System.Drawing.Size(222, 20);
            this.NoDb_textBox_baza.TabIndex = 28;
            this.NoDb_textBox_baza.Text = "localhost";
            this.NoDb_textBox_baza.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NoDb_textBox_baza.UseSelectable = true;
            // 
            // NoDb_label_haslo
            // 
            this.NoDb_label_haslo.Location = new System.Drawing.Point(80, 323);
            this.NoDb_label_haslo.Name = "NoDb_label_haslo";
            this.NoDb_label_haslo.Size = new System.Drawing.Size(64, 19);
            this.NoDb_label_haslo.TabIndex = 33;
            this.NoDb_label_haslo.Text = "Hasło";
            this.NoDb_label_haslo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoDb_label_haslo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NoDb_label_adres
            // 
            this.NoDb_label_adres.Location = new System.Drawing.Point(32, 170);
            this.NoDb_label_adres.Name = "NoDb_label_adres";
            this.NoDb_label_adres.Size = new System.Drawing.Size(112, 19);
            this.NoDb_label_adres.TabIndex = 29;
            this.NoDb_label_adres.Text = "Adres bazy";
            this.NoDb_label_adres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoDb_label_adres.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NoDb_textBox_haslo
            // 
            this.NoDb_textBox_haslo.Lines = new string[] {
        "root"};
            this.NoDb_textBox_haslo.Location = new System.Drawing.Point(162, 323);
            this.NoDb_textBox_haslo.MaxLength = 32767;
            this.NoDb_textBox_haslo.Name = "NoDb_textBox_haslo";
            this.NoDb_textBox_haslo.PasswordChar = '●';
            this.NoDb_textBox_haslo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoDb_textBox_haslo.SelectedText = "";
            this.NoDb_textBox_haslo.Size = new System.Drawing.Size(222, 20);
            this.NoDb_textBox_haslo.TabIndex = 32;
            this.NoDb_textBox_haslo.Text = "root";
            this.NoDb_textBox_haslo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NoDb_textBox_haslo.UseSelectable = true;
            this.NoDb_textBox_haslo.UseSystemPasswordChar = true;
            // 
            // NoDb_textBox_login
            // 
            this.NoDb_textBox_login.Lines = new string[] {
        "root"};
            this.NoDb_textBox_login.Location = new System.Drawing.Point(162, 292);
            this.NoDb_textBox_login.MaxLength = 32767;
            this.NoDb_textBox_login.Name = "NoDb_textBox_login";
            this.NoDb_textBox_login.PasswordChar = '\0';
            this.NoDb_textBox_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoDb_textBox_login.SelectedText = "";
            this.NoDb_textBox_login.Size = new System.Drawing.Size(222, 20);
            this.NoDb_textBox_login.TabIndex = 30;
            this.NoDb_textBox_login.Text = "root";
            this.NoDb_textBox_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NoDb_textBox_login.UseSelectable = true;
            // 
            // NoDb_label_login
            // 
            this.NoDb_label_login.Location = new System.Drawing.Point(80, 293);
            this.NoDb_label_login.Name = "NoDb_label_login";
            this.NoDb_label_login.Size = new System.Drawing.Size(64, 19);
            this.NoDb_label_login.TabIndex = 31;
            this.NoDb_label_login.Text = "Login";
            this.NoDb_label_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoDb_label_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(150, 419);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 37);
            this.metroButton1.TabIndex = 38;
            this.metroButton1.Text = "Potwierdź";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // NoDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 479);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.NoDb_textBox_nazwa);
            this.Controls.Add(this.NoDb_label_nazwa);
            this.Controls.Add(this.NoDb_textBox_port);
            this.Controls.Add(this.NoDb_label_port);
            this.Controls.Add(this.NoDb_textBox_baza);
            this.Controls.Add(this.NoDb_label_haslo);
            this.Controls.Add(this.NoDb_label_adres);
            this.Controls.Add(this.NoDb_textBox_haslo);
            this.Controls.Add(this.NoDb_textBox_login);
            this.Controls.Add(this.NoDb_label_login);
            this.Controls.Add(this.NoDb_label_info);
            this.Name = "NoDatabase";
            this.Text = "Witaj,";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.NoDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NoDb_label_info;
        public MetroFramework.Controls.MetroTextBox NoDb_textBox_nazwa;
        public MetroFramework.Controls.MetroLabel NoDb_label_nazwa;
        public MetroFramework.Controls.MetroTextBox NoDb_textBox_port;
        public MetroFramework.Controls.MetroLabel NoDb_label_port;
        public MetroFramework.Controls.MetroTextBox NoDb_textBox_baza;
        public MetroFramework.Controls.MetroLabel NoDb_label_haslo;
        public MetroFramework.Controls.MetroLabel NoDb_label_adres;
        public MetroFramework.Controls.MetroTextBox NoDb_textBox_haslo;
        public MetroFramework.Controls.MetroTextBox NoDb_textBox_login;
        public MetroFramework.Controls.MetroLabel NoDb_label_login;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}