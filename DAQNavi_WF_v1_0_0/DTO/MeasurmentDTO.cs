using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQNavi_WF_v1_0_0.DTO
{
    class MeasurmentDTO
    {
        public string idmeasurments { get; set; }
        public string idusers { get; set; }
        public string timestart { get; set; }
        public string timeend { get; set; }
        public string date { get; set; }
        public string task { get; set; }
        public string week { get; set; }
        public string duration { get; set; }
        public string samples { get; set; }
        public string numberofchannels { get; set; }
        public string startchannel { get; set; }
    }
}
