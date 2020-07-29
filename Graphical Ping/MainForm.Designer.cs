namespace Graphical_Ping
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_HostOrIP = new System.Windows.Forms.Label();
            this.textBoxHostOrIP = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.textBoxSecondsBetweenPing = new System.Windows.Forms.TextBox();
            this.labelFrequencyUnit = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxPingsSent = new System.Windows.Forms.TextBox();
            this.textBoxAveragePing = new System.Windows.Forms.TextBox();
            this.textBoxPacketsLost = new System.Windows.Forms.TextBox();
            this.labelPacketsSent = new System.Windows.Forms.Label();
            this.labelLostPings = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label_HostOrIP
            // 
            this.label_HostOrIP.AutoSize = true;
            this.label_HostOrIP.Location = new System.Drawing.Point(13, 13);
            this.label_HostOrIP.Name = "label_HostOrIP";
            this.label_HostOrIP.Size = new System.Drawing.Size(54, 13);
            this.label_HostOrIP.TabIndex = 0;
            this.label_HostOrIP.Text = "Host or IP";
            // 
            // textBoxHostOrIP
            // 
            this.textBoxHostOrIP.Location = new System.Drawing.Point(73, 10);
            this.textBoxHostOrIP.Name = "textBoxHostOrIP";
            this.textBoxHostOrIP.Size = new System.Drawing.Size(249, 20);
            this.textBoxHostOrIP.TabIndex = 1;
            this.textBoxHostOrIP.Text = "8.8.8.8";
            this.textBoxHostOrIP.TextChanged += new System.EventHandler(this.textBoxHostOrIP_TextChanged);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(13, 40);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(57, 13);
            this.labelFrequency.TabIndex = 2;
            this.labelFrequency.Text = "Frequency";
            // 
            // textBoxSecondsBetweenPing
            // 
            this.textBoxSecondsBetweenPing.Location = new System.Drawing.Point(73, 37);
            this.textBoxSecondsBetweenPing.Name = "textBoxSecondsBetweenPing";
            this.textBoxSecondsBetweenPing.Size = new System.Drawing.Size(64, 20);
            this.textBoxSecondsBetweenPing.TabIndex = 3;
            this.textBoxSecondsBetweenPing.Text = "1";
            this.textBoxSecondsBetweenPing.TextChanged += new System.EventHandler(this.textBoxSecondsBetweenPing_TextChanged);
            // 
            // labelFrequencyUnit
            // 
            this.labelFrequencyUnit.AutoSize = true;
            this.labelFrequencyUnit.Location = new System.Drawing.Point(143, 40);
            this.labelFrequencyUnit.Name = "labelFrequencyUnit";
            this.labelFrequencyUnit.Size = new System.Drawing.Size(114, 13);
            this.labelFrequencyUnit.TabIndex = 4;
            this.labelFrequencyUnit.Text = "seconds between ping";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(344, 8);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 5;
            this.buttonStartStop.Text = "StartStop";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // textBoxPingsSent
            // 
            this.textBoxPingsSent.Location = new System.Drawing.Point(73, 90);
            this.textBoxPingsSent.Name = "textBoxPingsSent";
            this.textBoxPingsSent.Size = new System.Drawing.Size(100, 20);
            this.textBoxPingsSent.TabIndex = 6;
            // 
            // textBoxAveragePing
            // 
            this.textBoxAveragePing.Location = new System.Drawing.Point(73, 116);
            this.textBoxAveragePing.Name = "textBoxAveragePing";
            this.textBoxAveragePing.Size = new System.Drawing.Size(100, 20);
            this.textBoxAveragePing.TabIndex = 7;
            // 
            // textBoxPacketsLost
            // 
            this.textBoxPacketsLost.Location = new System.Drawing.Point(319, 90);
            this.textBoxPacketsLost.Name = "textBoxPacketsLost";
            this.textBoxPacketsLost.Size = new System.Drawing.Size(100, 20);
            this.textBoxPacketsLost.TabIndex = 8;
            // 
            // labelPacketsSent
            // 
            this.labelPacketsSent.AutoSize = true;
            this.labelPacketsSent.Location = new System.Drawing.Point(13, 93);
            this.labelPacketsSent.Name = "labelPacketsSent";
            this.labelPacketsSent.Size = new System.Drawing.Size(29, 13);
            this.labelPacketsSent.TabIndex = 9;
            this.labelPacketsSent.Text = "Sent";
            // 
            // labelLostPings
            // 
            this.labelLostPings.AutoSize = true;
            this.labelLostPings.Location = new System.Drawing.Point(286, 93);
            this.labelLostPings.Name = "labelLostPings";
            this.labelLostPings.Size = new System.Drawing.Size(27, 13);
            this.labelLostPings.TabIndex = 10;
            this.labelLostPings.Text = "Lost";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(13, 119);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(47, 13);
            this.labelAverage.TabIndex = 11;
            this.labelAverage.Text = "Average";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Location = new System.Drawing.Point(286, 119);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(27, 13);
            this.labelLast.TabIndex = 12;
            this.labelLast.Text = "Last";
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(319, 116);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 20);
            this.textBoxLast.TabIndex = 13;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(13, 67);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(41, 13);
            this.labelStartTime.TabIndex = 14;
            this.labelStartTime.Text = "Started";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(73, 64);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(144, 20);
            this.textBoxStartTime.TabIndex = 15;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(231, 67);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(38, 13);
            this.labelEndTime.TabIndex = 16;
            this.labelEndTime.Text = "Ended";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(275, 64);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(144, 20);
            this.textBoxEndTime.TabIndex = 17;
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 328);
            
            this.Controls.Add(this.textBoxEndTime);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelLostPings);
            this.Controls.Add(this.labelPacketsSent);
            this.Controls.Add(this.textBoxPacketsLost);
            this.Controls.Add(this.textBoxAveragePing);
            this.Controls.Add(this.textBoxPingsSent);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelFrequencyUnit);
            this.Controls.Add(this.textBoxSecondsBetweenPing);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.textBoxHostOrIP);
            this.Controls.Add(this.label_HostOrIP);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 367);
            this.MinimumSize = new System.Drawing.Size(454, 367);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Graphical Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HostOrIP;
        private System.Windows.Forms.TextBox textBoxHostOrIP;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.TextBox textBoxSecondsBetweenPing;
        private System.Windows.Forms.Label labelFrequencyUnit;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxPingsSent;
        private System.Windows.Forms.TextBox textBoxAveragePing;
        private System.Windows.Forms.TextBox textBoxPacketsLost;
        private System.Windows.Forms.Label labelPacketsSent;
        private System.Windows.Forms.Label labelLostPings;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

