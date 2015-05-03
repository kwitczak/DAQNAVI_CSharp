using Automation.BDaq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQNavi_WF_v1_0_0
{
    public class BufferedAnalogInput
    {
        private int samples;
        private int channels;
        private int channelStart;
        private int intervalCount;
        private int scanCount;
        private int rate;
        private int[] channels_arr;
        private int[] channels_arr_min;
        private int[] channels_arr_max;

        double[] dataDownloadedAI;

        public double[] przygotujPomiar(BufferedAiCtrl bufferedAiCtrl1)
        {
            bufferedAiCtrl1.Streaming = false;
            bufferedAiCtrl1.Prepare();
            bufferedAiCtrl1.ScanChannel.Samples = samples;
            bufferedAiCtrl1.ScanChannel.ChannelCount = channels;
            bufferedAiCtrl1.ScanChannel.ChannelStart = channelStart;
            //bufferedAiCtrl1.ScanChannel.IntervalCount = intervalCount;
            //bufferedAiCtrl1.ScanClock.ScanCount = scanCount;
            bufferedAiCtrl1.ConvertClock.Rate = rate;
            dataDownloadedAI = new double[bufferedAiCtrl1.BufferCapacity];
            bufferedAiCtrl1.Start();
            return dataDownloadedAI;
        }

        public void setChannels_arr(int[] channels_arr)
        {
            this.channels_arr = channels_arr;
        }

        public void setChannels_arr_min(int[] channels_arr_min)
        {
            this.channels_arr_min = channels_arr_min;
        }

        public void setChannels_arr_max(int[] channels_arr_max)
        {
            this.channels_arr_max = channels_arr_max;
        }


        public void setSamples(int samples)
        {
            this.samples = samples;
        }

        public int getSamples()
        {
            return samples;
        }

        public void setChannels(int channels)
        {
            this.channels = channels;
        }

        public void setChannelStart(int channelStart)
        {
            this.channelStart = channelStart;
        }

        public void setIntervalCount(int intervalCount)
        {
            this.intervalCount = intervalCount;
        }

        public void setScanCount(int scanCount)
        {
            this.scanCount = scanCount;
        }

        public void setRate(int rate)
        {
            this.rate = rate;
        }
    }
}
