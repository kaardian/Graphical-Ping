using Graphical_Ping.Model;
using System;
using System.Threading;
using System.ComponentModel;
using System.Net.NetworkInformation;
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
            
            initializeDialogs();
        }

        private void initializeDialogs()
        {
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

        /// <summary>
        /// Background worker main action, sleeps for the configured time in seconds, and does a ping.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Host name changing action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxHostOrIP_TextChanged(object sender, EventArgs e)
        {
            Config.HostOrIP = textBoxHostOrIP.Text;
        }

        /// <summary>
        /// Starts or stops pinging.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            // Flip the pinging status.
            Pinging = !Pinging;

            // Based on the status, call method to start or stop pinging.
            if (Pinging)
            {
                startPinging();
            }
            else
            {
                stopPinging();
            }
        }

        /// <summary>
        /// Starts the pinging cycle.
        /// </summary>
        private void startPinging()
        {
            chartPing.Series["Series1"].Points.Clear();
            buttonStartStop.Text = "Stop";
            PingResults = new PingResults();
            textBoxStartTime.Text = PingResults.StartTime.ToString();
            textBoxEndTime.Text = "";
            if (backgroundWorker.IsBusy != true) { backgroundWorker.RunWorkerAsync(); }
        }

        /// <summary>
        /// Stops pinging cycle.
        /// </summary>
        private void stopPinging()
        {
            if (backgroundWorker.WorkerSupportsCancellation == true) { backgroundWorker.CancelAsync(); }
            buttonStartStop.Text = "Start";
            PingResults.EndTime = DateTime.Now;
            textBoxEndTime.Text = PingResults.EndTime.ToString();
        }

        /// <summary>
        /// Does one ping. Stops pinging if application throws an error.
        /// </summary>
        private void DoPing()
        {
            try
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
                    if (chartPing.Series["Series1"].Points.Count > Config.ChartHistory)
                    {
                        position++;
                        chartPing.Series["Series1"].Points.RemoveAt(0);
                    }
                    chartPing.Series["Series1"].Points.AddXY(PingResults.PacketsSent, pingReply.RoundtripTime);
                    chartArea1.AxisX.Minimum = position;
                    chartArea1.AxisX.Maximum = position + Config.ChartHistory;
                });
            }
            catch (Exception ex)
            {
                // Stop pinging.
                Pinging = false;
                stopPinging();
                MessageBox.Show(ex.Message, "Ping failed to process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
