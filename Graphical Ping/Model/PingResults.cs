using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Graphical_Ping.Model
{
    /// <summary>
    /// Class to contain results of the pinging.
    /// </summary>
    public class PingResults
    {
        /// <summary>
        /// List to store all ping replies.
        /// </summary>
        public List<PingReply> PingReplies { get; set; }

        /// <summary>
        /// Returns averate time based on total time and how many packets has been sent.
        /// </summary>
        public int AverageTime
        {
            get {
                if (TotalTime == 0 || PacketsSent == 0) return 0;
                return Convert.ToInt32(TotalTime) / PacketsSucceeded;
            }
        }

        /// <summary>
        /// Total time of ping durations in MS.
        /// </summary>
        public long TotalTime { get; set; }

        /// <summary>
        /// Total packets lost count.
        /// </summary>
        public int PacketsLost { get; set; }

        /// <summary>
        ///  Total packets sent count.
        /// </summary>
        public int PacketsSent { get; set; }

        /// <summary>
        /// Total packets succeeded.
        /// </summary>
        public int PacketsSucceeded { get { return PacketsSent - PacketsLost; } }

        /// <summary>
        /// Latest start time of the pinging.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Lastest end time of the pinging.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Constructor that initializes the list and sets counters to zero.
        /// </summary>
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
