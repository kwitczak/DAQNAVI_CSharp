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
            window.Welcome_button_createNewUser.Text = ConfigurationManager.AppSettings["WelcomeButtonRegister" + lan.ToString()];
            window.Welcome_label_newUser.Text = ConfigurationManager.AppSettings["WelcomeLabelRegister" + lan.ToString()];
            // Options
            window.TabPage_Options.Text = ConfigurationManager.AppSettings["TabPage_Options" + lan.ToString()];
            window.Options_label_baza.Text = ConfigurationManager.AppSettings["Options_label_baza" + lan.ToString()];
            window.Options_label_password.Text = ConfigurationManager.AppSettings["Options_label_password" + lan.ToString()];
            window.Options_label_user.Text = ConfigurationManager.AppSettings["Options_label_user" + lan.ToString()];
            window.Options_label_theme.Text = ConfigurationManager.AppSettings["Options_label_theme" + lan.ToString()];
            window.Options_label_language.Text = ConfigurationManager.AppSettings["Options_label_language" + lan.ToString()];
            window.Options_label_database.Text = ConfigurationManager.AppSettings["Options_label_database" + lan.ToString()];
            window.Options_label_card.Text = ConfigurationManager.AppSettings["Options_label_card" + lan.ToString()];
            window.Options_label_cardModule.Text = ConfigurationManager.AppSettings["Options_label_cardModule" + lan.ToString()];
            window.Options_label_cardName.Text = ConfigurationManager.AppSettings["Options_label_cardName" + lan.ToString()];
            window.Options_label_cardNumber.Text = ConfigurationManager.AppSettings["Options_label_cardNumber" + lan.ToString()];
            window.Options_label_adminComment.Text = ConfigurationManager.AppSettings["Options_label_adminComment" + lan.ToString()];
            window.Options_label_userComment.Text = ConfigurationManager.AppSettings["Options_label_userComment" + lan.ToString()];
            window.Options_label_commentOptions.Text = ConfigurationManager.AppSettings["Options_label_commentOptions" + lan.ToString()];
            window.Options_button_applyChanges.Text = ConfigurationManager.AppSettings["Options_button_applyChanges" + lan.ToString()];
            window.Options_button_backToDefaults.Text = ConfigurationManager.AppSettings["Options_button_backToDefaults" + lan.ToString()];
            window.Options_button_clearResults.Text = ConfigurationManager.AppSettings["Options_button_clearResults" + lan.ToString()];
            // MM
            window.TabPage_MyMeasurements.Text = ConfigurationManager.AppSettings["TabPage_MyMeasurements" + lan.ToString()];
            window.MM_button_newMeasure.Text = ConfigurationManager.AppSettings["MM_button_newMeasure" + lan.ToString()];
           

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

