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

        public static void changeLanguage(DAQNavi_WF_v1_0_0.MainWindow.Language lan, MainWindow window)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // zapisz zmiany do pliku konfiguracyjnego
            config.AppSettings.Settings["defaultLanguage"].Value = "ENG";

            //save to apply changes
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            window.SetLanguage();
        }
    }
}

