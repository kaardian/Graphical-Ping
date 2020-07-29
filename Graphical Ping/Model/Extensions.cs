using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Graphical_Ping.Model
{
    public static class Extensions
    {
        public static bool Success (this PingReply pingReply)
        {
            if (pingReply.Status == IPStatus.Success) return true;
            return false;
        }

        public static void SetText(this TextBox textBox, string text)
        {
            textBox.Invoke((Action)delegate { textBox.Text = text; });
        }
    }
}
