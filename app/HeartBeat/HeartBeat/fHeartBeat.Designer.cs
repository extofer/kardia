namespace HeartBeat
{
    partial class fHeartBeat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHeartBeat));
            this.notifyIcoHB = new System.Windows.Forms.NotifyIcon(this.components);
            this.pingInterval = new System.Windows.Forms.Timer(this.components);
            this.cmdAddIP = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heart_tick = new System.Windows.Forms.PictureBox();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdPosh = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.timer_signal = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdTestSMTP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart_tick)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcoHB
            // 
            this.notifyIcoHB.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcoHB.Icon")));
            this.notifyIcoHB.Text = "Heart Beat";
            this.notifyIcoHB.Visible = true;
            this.notifyIcoHB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcoHB_MouseDoubleClick);
            // 
            // pingInterval
            // 
            this.pingInterval.Interval = 5000;
            this.pingInterval.Tick += new System.EventHandler(this.pingInterval_Tick);
            // 
            // cmdAddIP
            // 
            this.cmdAddIP.Location = new System.Drawing.Point(483, 212);
            this.cmdAddIP.Name = "cmdAddIP";
            this.cmdAddIP.Size = new System.Drawing.Size(75, 23);
            this.cmdAddIP.TabIndex = 3;
            this.cmdAddIP.Text = "Listen";
            this.cmdAddIP.UseVisualStyleBackColor = true;
            this.cmdAddIP.Click += new System.EventHandler(this.cmdAddIP_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.heart_tick);
            this.groupBox1.Controls.Add(this.txtIPaddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Address";
            // 
            // heart_tick
            // 
            this.heart_tick.Image = global::KaridaBeat.Properties.Resources.apple;
            this.heart_tick.Location = new System.Drawing.Point(193, 15);
            this.heart_tick.Name = "heart_tick";
            this.heart_tick.Size = new System.Drawing.Size(36, 39);
            this.heart_tick.TabIndex = 12;
            this.heart_tick.TabStop = false;
            this.heart_tick.Visible = false;
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(16, 19);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(139, 20);
            this.txtIPaddress.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdPosh);
            this.groupBox2.Controls.Add(this.txtFile);
            this.groupBox2.Controls.Add(this.cmdBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File to Execute";
            // 
            // cmdPosh
            // 
            this.cmdPosh.Location = new System.Drawing.Point(6, 48);
            this.cmdPosh.Name = "cmdPosh";
            this.cmdPosh.Size = new System.Drawing.Size(75, 23);
            this.cmdPosh.TabIndex = 11;
            this.cmdPosh.Text = "PowerShell";
            this.cmdPosh.UseVisualStyleBackColor = true;
            this.cmdPosh.Click += new System.EventHandler(this.cmdPosh_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(87, 19);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(136, 20);
            this.txtFile.TabIndex = 10;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(6, 19);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowse.TabIndex = 8;
            this.cmdBrowse.Text = "File";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtInterval);
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 60);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "In Seconds";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(6, 19);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(45, 20);
            this.txtInterval.TabIndex = 2;
            // 
            // timer_signal
            // 
            this.timer_signal.Interval = 1000;
            this.timer_signal.Tick += new System.EventHandler(this.timer_signal_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdTestSMTP);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtTo);
            this.groupBox4.Controls.Add(this.txtSMTP);
            this.groupBox4.Location = new System.Drawing.Point(297, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 135);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message Getup";
            // 
            // cmdTestSMTP
            // 
            this.cmdTestSMTP.Location = new System.Drawing.Point(109, 106);
            this.cmdTestSMTP.Name = "cmdTestSMTP";
            this.cmdTestSMTP.Size = new System.Drawing.Size(75, 23);
            this.cmdTestSMTP.TabIndex = 5;
            this.cmdTestSMTP.Text = "Test SMTP";
            this.cmdTestSMTP.UseVisualStyleBackColor = true;
            this.cmdTestSMTP.Visible = false;
            this.cmdTestSMTP.Click += new System.EventHandler(this.cmdTestSMTP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "sepreated by semi-colon \";\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recipients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SMTP Service IP:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(109, 57);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 1;
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(109, 22);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(100, 20);
            this.txtSMTP.TabIndex = 0;
            // 
            // fHeartBeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 249);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdAddIP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fHeartBeat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart_tick)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcoHB;
        private System.Windows.Forms.Timer pingInterval;
        private System.Windows.Forms.Button cmdAddIP;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_signal;
        private System.Windows.Forms.Button cmdPosh;
        private System.Windows.Forms.PictureBox heart_tick;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdTestSMTP;
    }
}

