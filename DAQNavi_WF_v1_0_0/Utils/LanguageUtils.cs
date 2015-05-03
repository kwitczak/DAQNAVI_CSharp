using System;
using System.Configuration;

namespace DAQNavi_WF_v1_0_0
{
    public class LanguageUtils
    {
        private LanguageUtils()
        {
            // Util class - private constructor
        }

        public static DAQNavi_WF_v1_0_0.MainWindow.Language getDefaultLanguage()
        {
            String lan = ConfigurationManager.AppSettings["defaultLanguage"];
            if (lan.Equals("ENG"))
            {
                return DAQNavi_WF_v1_0_0.MainWindow.Language.ENG;
            }
            else {
                return DAQNavi_WF_v1_0_0.MainWindow.Language.PL;
            }
        }

        public static void changeLanguage(DAQNavi_WF_v1_0_0.MainWindow.Language lan, MainWindow window)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // zapisz zmiany do pliku konfiguracyjnego
            config.AppSettings.Settings["defaultLanguage"].Value = "ENG";

            //save to apply changes
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            setLanguage(lan, window);
        }

        public static void setLanguage(DAQNavi_WF_v1_0_0.MainWindow.Language lan, MainWindow window)
        {
            // Welcome Tab
            window.TabPage_Welcome.Text = ConfigurationManager.AppSettings["WelcomeTabName" + lan.ToString()];
            window.Welcome_label_username.Text = ConfigurationManager.AppSettings["WelcomeLabelUsername" + lan.ToString()];
            window.Welcome_label_password.Text = ConfigurationManager.AppSettings["WelcomeLabelPassword" + lan.ToString()];
            window.Welcome_button_login.Text = ConfigurationManager.AppSettings["WelcomeButtonLogin" + lan.ToString()];
            // Analog Buffered Input Tab
            window.TabPage_AnalogBufferedInput.Text = ConfigurationManager.AppSettings["ABITab" + lan.ToString()];
            //window.ABI_label_samples.Text = ConfigurationManager.AppSettings["ABISamples" + lan.ToString()];
            //window.ABI_label_channels.Text = ConfigurationManager.AppSettings["ABIChannels" + lan.ToString()];
            //window.ABI_label_channelStart.Text = ConfigurationManager.AppSettings["ABIChannelStart" + lan.ToString()];
            //window.ABI_label_intervalCount.Text = ConfigurationManager.AppSettings["ABIIntervalCount" + lan.ToString()];
            //window.ABI_label_scanCount.Text = ConfigurationManager.AppSettings["ABIScanCount" + lan.ToString()];
            //window.ABI_label_rate.Text = ConfigurationManager.AppSettings["ABIRate" + lan.ToString()];
            window.ABI_button_back.Text = ConfigurationManager.AppSettings["ABIButtonBack" + lan.ToString()];
            window.ABI_button_measure.Text = ConfigurationManager.AppSettings["ABIButtonMeasure" + lan.ToString()];
        }
    }
}

