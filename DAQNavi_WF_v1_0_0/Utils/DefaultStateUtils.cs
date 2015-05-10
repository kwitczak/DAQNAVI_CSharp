using System;

namespace DAQNavi_WF_v1_0_0
{
    public class DefaultStateUtils
    {
        private DefaultStateUtils()
        {
        }

        public static void setDefaultAII()
        {
            MainWindow.AII_timerValue = 1;
            MainWindow.AII_startChannel = 0;
            MainWindow.AII_numOfChannels = 1;
        }

        public static void setDefaultABI()
        {
            MainWindow.ABI_rate = 1000;
            MainWindow.ABI_startChannel = 0;
            MainWindow.ABI_numOfChannels = 1;
            MainWindow.ABI_samplesPerChannel = 100;
        }
    }
}

