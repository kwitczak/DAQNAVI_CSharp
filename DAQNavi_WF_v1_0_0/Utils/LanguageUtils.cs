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
            else
            {
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
            // M
            window.Measure_button_return.Text = ConfigurationManager.AppSettings["Measure_button_return" + lan.ToString()];
            window.TabPage_Measure.Text = ConfigurationManager.AppSettings["TabPage_Measure" + lan.ToString()];

            // Analog Buffered Input Tab
            window.TabPage_AnalogBufferedInput.Text = ConfigurationManager.AppSettings["ABITab" + lan.ToString()];
            window.ABI_label_details.Text = ConfigurationManager.AppSettings["ABI_label_details" + lan.ToString()];
            window.ABI_label_options.Text = ConfigurationManager.AppSettings["ABI_label_options" + lan.ToString()];
            window.ABI_button_back.Text = ConfigurationManager.AppSettings["ABIButtonBack" + lan.ToString()];
            window.ABI_button_measure.Text = ConfigurationManager.AppSettings["ABIButtonMeasure" + lan.ToString()];
            window.ABI_button_measureOptions.Text = ConfigurationManager.AppSettings["ABI_button_measureOptions" + lan.ToString()];
            window.ABI_button_defaults.Text = ConfigurationManager.AppSettings["ABI_button_defaults" + lan.ToString()];
            window.ABI_label_endTime.Text = ConfigurationManager.AppSettings["ABI_label_endTime" + lan.ToString()];
            window.ABI_label_duration.Text = ConfigurationManager.AppSettings["ABI_label_duration" + lan.ToString()];
            window.ABI_button_back.Text = ConfigurationManager.AppSettings["ABI_button_back" + lan.ToString()];
            window.ABI_label_trackBar2.Text = ConfigurationManager.AppSettings["ABI_label_trackBar2" + lan.ToString()];

            // Analog Instant Input
            window.AII_label_options.Text = ConfigurationManager.AppSettings["AII_label_options" + lan.ToString()];
            window.AII_button_editOptions.Text = ConfigurationManager.AppSettings["AII_button_editOptions" + lan.ToString()];
            window.AII_button_defaults.Text = ConfigurationManager.AppSettings["AII_button_defaults" + lan.ToString()];
            window.AII_label_viewOptions.Text = ConfigurationManager.AppSettings["AII_label_viewOptions" + lan.ToString()];
            window.AII_label_movingWindow.Text = ConfigurationManager.AppSettings["AII_label_movingWindow" + lan.ToString()];
            window.AII_label_details.Text = ConfigurationManager.AppSettings["AII_label_details" + lan.ToString()];
            window.AII_label_end.Text = ConfigurationManager.AppSettings["AII_label_end" + lan.ToString()];
            window.AII_label__duration.Text = ConfigurationManager.AppSettings["AII_label__duration" + lan.ToString()];
            window.AII_label_currentPoints.Text = ConfigurationManager.AppSettings["AII_label_currentPoints" + lan.ToString()];
            window.AII_label_channel.Text = ConfigurationManager.AppSettings["AII_label_channel" + lan.ToString()];
            window.AII_label_value.Text = ConfigurationManager.AppSettings["AII_label_value" + lan.ToString()];
            window.AII_button_back.Text = ConfigurationManager.AppSettings["AII_button_back" + lan.ToString()];
            window.AII_button_measure.Text = ConfigurationManager.AppSettings["AII_button_measure" + lan.ToString()];

            // Results
            window.TabPage_LastMeasure.Text = ConfigurationManager.AppSettings["TabPage_LastMeasure" + lan.ToString()];
            window.Results_button_exportToTXT.Text = ConfigurationManager.AppSettings["Results_button_exportToTXT" + lan.ToString()];

        }
    }
}

