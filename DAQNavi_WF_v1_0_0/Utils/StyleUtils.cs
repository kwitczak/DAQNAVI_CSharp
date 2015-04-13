using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQNavi_WF_v1_0_0.Utils
{
    class StyleUtils
    {

        public static MetroFramework.MetroThemeStyle getDefaultStyle()
        {
            String style = ConfigurationManager.AppSettings["defaultTheme"];
            if (style.Equals("Dark"))
            {
                return MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                return MetroFramework.MetroThemeStyle.Light;
            }
        }

        public static MetroFramework.MetroThemeStyle findOppositeStyle(MetroFramework.MetroThemeStyle style)
        {
            if (style.Equals(MetroFramework.MetroThemeStyle.Dark)){
                return MetroFramework.MetroThemeStyle.Light;
            } else {
                return MetroFramework.MetroThemeStyle.Dark;
            }
        }

        public static void changeStyle(MetroFramework.MetroThemeStyle style, MainWindow window)
        {
                // This
                window.Theme = style;
                window.TabControl.Theme = style;
                window.ProgressSpinner.Theme = style;

                // Options
                window.TabPage_Options.Theme = style;
                window.Options_toggle_layout.Theme = style;
                window.Options_radioButton_polski.Theme = style;
                window.Options_radioButton_english.Theme = style;
                window.Options_label_baza.Theme = style;
                window.Options_label_password.Theme = style;
                window.Options_label_user.Theme = style;
                window.Options_textBox_baza.Theme = style;
                window.Options_textBox_password.Theme = style;
                window.Options_textBox_user.Theme = style;
                window.Options_textBox_adminComment.Theme = style;
                window.Options_textBox_userComment.Theme = style;
                window.Options_textBox_cardModule.Theme = style;
                window.Options_textBox_cardName.Theme = style;
                window.Options_textBox_cardNumber.Theme = style;
                window.Options_textBox_port.Theme = style;
                window.Options_panel_card.Theme = style;
                window.Options_panel_comments.Theme = style;
                window.Options_panel_database.Theme = style;
                window.Options_panel_language.Theme = style;
                window.Options_panel_theme.Theme = style;
                window.Options_label_theme.Theme = style;
                window.Options_label_language.Theme = style;
                window.Options_label_database.Theme = style;
                window.Options_label_port.Theme = style;
                window.Options_scrollBar.Theme = style;
                window.Options_label_card.Theme = style;
                window.Options_label_cardModule.Theme = style;
                window.Options_label_cardName.Theme = style;
                window.Options_label_cardNumber.Theme = style;
                window.Options_label_adminComment.Theme = style;
                window.Options_label_userComment.Theme = style;
                window.Options_label_commentOptions.Theme = style;
                window.Options_button_applyChanges.Theme = style;
                window.Options_button_backToDefaults.Theme = style;
                window.Options_button_clearResults.Theme = style;

                // AnalogBufferedInput
                window.TabPage_AnalogBufferedInput.Theme = style;
                window.ABI_label_samples.Theme = style;
                window.ABI_label_channels.Theme = style;
                window.ABI_label_channelStart.Theme = style;
                window.ABI_label_intervalCount.Theme = style;
                window.ABI_label_rate.Theme = style;
                window.ABI_label_scanCount.Theme = style;
                window.ABI_textBox_channels.Theme = style;
                window.ABI_textBox_channelStart.Theme = style;
                window.ABI_textBox_intervalCount.Theme = style;
                window.ABI_textBox_rate.Theme = style;
                window.ABI_textBox_scanCount.Theme = style;
                window.ABI_TrackBar_1.Theme = style;
                window.ABI_TrackBar_2.Theme = style;
                window.ABI_button_back.Theme = style;
                window.ABI_button_measure.Theme = style;
                window.ABI_textBox_samples.Theme = style;

                // Analog Instant Input
                window.TabPage_AnalogInstantInput.Theme = style;
                window.AII_trackBar_1.Theme = style;
                window.AII_trackBar_2.Theme = style;
                window.AII_button_back.Theme = style;
                window.AII_button_measure.Theme = style;
                window.AII_button_reset.Theme = style;

                // Results
                window.TabPage_LastMeasure.Theme = style;
                window.LastMeasure_GridTable.Theme = style;
                window.Panel_Results.Theme = style;
                window.Results_button_exportToTXT.Theme = style;

                // Measure
                window.TabPage_Measure.Theme = style;
                window.Measure_label_analogInput.Theme = style;
                window.Measure_label_analogOutput.Theme = style;
                window.Measure_label_buffered.Theme = style;
                window.Measure_label_digitalInput.Theme = style;
                window.Measure_label_digitalOutput.Theme = style;
                window.Measure_label_instant.Theme = style;
                window.Measure_tile_analogInput.Theme = style;
                window.Measure_tile_analogOutput.Theme = style;
                window.Measure_tile_bufferedInput.Theme = style;
                window.Measure_tile_digitalInput.Theme = style;
                window.Measure_tile_digitalOutput.Theme = style;
                window.Measure_tile_instantInput.Theme = style;
                window.Measure_button_return.Theme = style;

                // Tabs
                window.TabPage_DigitalInput.Theme = style;
                window.TabPage_DigitalOutput.Theme = style;

                // Welcome
                window.TabPage_Welcome.Theme = style;
                window.Welcome_button_createNewUser.Theme = style;
                window.Welcome_button_login.Theme = style;
                window.Welcome_label_helloText.Theme = style;
                window.Welcome_label_newUser.Theme = style;
                window.Welcome_label_password.Theme = style;
                window.Welcome_label_username.Theme = style;
                window.Welcome_link.Theme = style;
                window.Welcome_textBox_password.Theme = style;
                window.Welcome_textBox_username.Theme = style;
            //window.Welcome_pictureBox_advantech.Image

                // MyMeasurments
                window.TabPage_MyMeasurements.Theme = style;
                window.MM_button_newMeasure.Theme = style;

                // Results

                window.Refresh();
        }
    }
}
