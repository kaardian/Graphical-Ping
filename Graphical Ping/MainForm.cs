using Graphical_Ping.Model;
using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphical_Ping
{
    public partial class MainForm : Form
    {
        public Config Config;
        public PingResults PingResults;
        public bool Pinging;
        public Chart chartPing;
        public ChartArea chartArea1;
        public Series series1;
        public double position;
        public double size;

        public MainForm()
        {
            InitializeComponent();
            Config = new Config();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            PingResults = new PingResults();
            Pinging = false;
            buttonStartStop.Text = "Start";
            chartPing = new Chart();
            ((ISupportInitialize)(chartPing)).BeginInit();
            chartArea1 = new ChartArea();
            series1 = new Series();
            position = 0;
            size = Config.ChartHistory;
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartPing.ChartAreas.Add(chartArea1);
            chartPing.Enabled = false;
            chartPing.Location = new System.Drawing.Point(12, 142);
            chartPing.Name = "chartPings";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartPing.Series.Add(series1);
            chartPing.Size = new System.Drawing.Size(407, 174);
            chartPing.TabIndex = 18;
            chartPing.Text = "chart1";
            Controls.Add(chartPing);
            ((ISupportInitialize)(chartPing)).EndInit();
        }

        private void textBoxSecondsBetweenPing_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Config.Seconds = Convert.ToInt32(textBoxSecondsBetweenPing.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Seconds not valid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxHostOrIP_TextChanged(object sender, EventArgs e)
        {
            Config.HostOrIP = textBoxHostOrIP.Text;
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            Pinging = !Pinging;

            if (Pinging)
            {
                chartPing.Series["Series1"].Points.Clear();
                buttonStartStop.Text = "Stop";
                PingResults = new PingResults();
                textBoxStartTime.Text = PingResults.StartTime.ToString();
                textBoxEndTime.Text = "";
                if (backgroundWorker.IsBusy != true) { backgroundWorker.RunWorkerAsync(); }
            }
            if (!Pinging)
            {
                if (backgroundWorker.WorkerSupportsCancellation == true) { backgroundWorker.CancelAsync(); }
                buttonStartStop.Text = "Start";
                PingResults.EndTime = DateTime.Now;
                textBoxEndTime.Text = PingResults.EndTime.ToString();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (Pinging)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else if (Pinging)
                {
                    DoPing();
                    Thread.Sleep(Config.Seconds * 1000);
                }
            }
            Thread.Sleep(Config.Seconds * 1000);
        }

        private void DoPing()
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(Config.HostOrIP);
            PingResults.EndTime = DateTime.Now;
            PingResults.PingReplies.Add(pingReply);
            PingResults.PacketsSent++;
            if (!pingReply.Success())
            {
                PingResults.PacketsLost++;
                textBoxLast.SetText("N/A");
            }
            else
            {
                textBoxLast.SetText(pingReply.RoundtripTime.ToString());
            }
            textBoxPingsSent.SetText(PingResults.PacketsSent.ToString());
            textBoxPacketsLost.SetText(PingResults.PacketsLost.ToString());
            PingResults.TotalTime = PingResults.TotalTime + pingReply.RoundtripTime;
            textBoxAveragePing.SetText(PingResults.AverageTime.ToString());

            chartPing.Invoke((Action)delegate {
                if(chartPing.Series["Series1"].Points.Count > Config.ChartHistory)
                {
                    position++;
                    chartPing.Series["Series1"].Points.RemoveAt(0);
                }
                chartPing.Series["Series1"].Points.AddXY(PingResults.PacketsSent, pingReply.RoundtripTime);
                chartArea1.AxisX.Minimum = position;
                chartArea1.AxisX.Maximum = position+Config.ChartHistory;
            });
        }
    }
}
