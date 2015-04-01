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
            MainWindow.AII_timerValue = 50;
            MainWindow.AII_choosenChannel = 0;
            MainWindow.AII_numOfChannels = 1;
        }
    }
}

