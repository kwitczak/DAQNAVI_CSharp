using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQNavi_WF_v1_0_0.Forms
{
    public partial class NoDatabase : MetroForm
    {
        MainWindow mainWindow;
        public NoDatabase(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            mainWindow.WindowState = FormWindowState.Minimized;
            MetroFramework.MetroThemeStyle parentStyle = MainWindow.choosenStyle;
            this.Theme = parentStyle;
            NoDb_textBox_baza.Theme = parentStyle;
            NoDb_textBox_port.Theme = parentStyle;
            NoDb_textBox_login.Theme = parentStyle;
            NoDb_textBox_haslo.Theme = parentStyle;
            NoDb_textBox_nazwa.Theme = parentStyle;
            metroButton1.Theme = parentStyle;
            NoDb_label_adres.Theme = parentStyle;
            NoDb_label_haslo.Theme = parentStyle;
            NoDb_label_info.Theme = parentStyle;
            NoDb_label_login.Theme = parentStyle;
            NoDb_label_nazwa.Theme = parentStyle;
            NoDb_label_port.Theme = parentStyle;
            NoDb_label_login.Select();
            this.Select();
        }

        private void NoDatabase_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Czy jest to pierwsze uruchomienie?
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["dbSET"].Value = "yes";
            config.AppSettings.Settings["DatabaseAddress"].Value = NoDb_textBox_baza.Text;
            config.AppSettings.Settings["Port"].Value = NoDb_textBox_port.Text;
            config.AppSettings.Settings["DatabaseUser"].Value = NoDb_textBox_login.Text;
            config.AppSettings.Settings["DatabasePassword"].Value = NoDb_textBox_haslo.Text;
            config.AppSettings.Settings["DatabaseName"].Value = NoDb_textBox_nazwa.Text;

            //save to apply changes
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            mainWindow.WindowState = FormWindowState.Normal;
            this.Hide();
        }
    }
}
