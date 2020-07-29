using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Graphical_Ping.Model
{
    public class PingResults
    {
        public List<PingReply> PingReplies { get; set; }
        public int AverageTime
        {
            get {
                if (TotalTime == 0 || PacketsSent == 0) return 0;
                return Convert.ToInt32(TotalTime) / PacketsSent;
            }
        }
        public long TotalTime { get; set; }
        public int PacketsLost { get; set; }
        public int PacketsSent { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public PingResults()
        {
            PingReplies = new List<PingReply>();
            TotalTime = 0;
            PacketsLost = 0;
            PacketsSent = 0;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
        }
    }
}
