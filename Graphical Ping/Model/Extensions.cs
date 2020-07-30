using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Graphical_Ping.Model
{
    public static class Extensions
    {
        /// <summary>
        /// Checks if the PingReply was successful.
        /// </summary>
        /// <param name="pingReply"></param>
        /// <returns>boolean</returns>
        public static bool Success (this PingReply pingReply) => pingReply.Status == IPStatus.Success;

        /// <summary>
        /// Invokes an action as delegate to update texbox text.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="text"></param>
        public static void SetText(this TextBox textBox, string text)
        {
            textBox.Invoke((Action)delegate { textBox.Text = text; });
        }
    }
}
