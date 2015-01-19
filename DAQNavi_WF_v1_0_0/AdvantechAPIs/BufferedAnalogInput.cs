﻿using Automation.BDaq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQNavi_WF_v1_0_0
{
    class BufferedAnalogInput
    {
        private int samples;
        private int channels;
        private int channelStart;
        private int intervalCount;
        private int scanCount;
        private int rate;

        double[] dataDownloadedAI;

        public double[] przygotujPomiar(BufferedAiCtrl bufferedAiCtrl1)
        {
            bufferedAiCtrl1.Streaming = false;
            bufferedAiCtrl1.Prepare();
            bufferedAiCtrl1.ScanChannel.Samples = samples;
            bufferedAiCtrl1.ScanChannel.ChannelCount = channels;
            bufferedAiCtrl1.ScanChannel.ChannelStart = channelStart;
            bufferedAiCtrl1.ScanChannel.IntervalCount = intervalCount;
            bufferedAiCtrl1.ScanClock.ScanCount = scanCount;
            bufferedAiCtrl1.ScanClock.Rate = rate;
            dataDownloadedAI = new double[bufferedAiCtrl1.BufferCapacity];
            bufferedAiCtrl1.Start();
            return dataDownloadedAI;
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