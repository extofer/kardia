using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Web.Mail;



namespace HeartBeat
{
    public partial class fHeartBeat : Form
    {
        protected string sSMTP;
        protected string sTo;
        protected string sIPaddress;
        protected string sFileName;
        protected int iInterval;

        
        protected bool IsListening;



        public fHeartBeat()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                this.timer_signal.Enabled = false;
            }
            else
            {
                this.timer_signal.Enabled = true;
            }
        }

        private void notifyIcoHB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void pingInterval_Tick(object sender, EventArgs e)
        {
            using (Ping ping = new Ping())
            {
                PingReply reply = ping.Send(sIPaddress, 10);
                if (reply.Status == IPStatus.Success)
                {
                    Console.Write("OK!");
                }
                else
                {
                    pingInterval.Enabled = false;
                    timer_signal.Enabled = false;  
                    Console.Write("NOT OK!");
                    cmdTestSMTP.Visible = false;
                    SendLog(false);
                    fPowerShell Posh = new fPowerShell();
                    Posh.ServerIsDown(sFileName);


                }
            }
        }

        private void cmdAddIP_Click(object sender, EventArgs e)
        {
            cmdTestSMTP.Visible = true;
            sIPaddress = txtIPaddress.Text.ToString();
            iInterval = Convert.ToInt16(txtInterval.Text);
            iInterval = iInterval * 1000;
            pingInterval.Interval = iInterval;
            pingInterval.Enabled = true;
            timer_signal.Enabled = true;

            sSMTP = txtSMTP.Text.ToString();
            sTo = txtTo.Text.ToString();


            notifyIcoHB.Text = "Listening...";
            IsListening = true;


        }

        private void cmdBrowse_Click_1(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            //Console.Write(openFile.FileName.ToString);
            txtFile.Text = openFile.FileName;
            sFileName = txtFile.Text;
        }

        private void timer_signal_Tick(object sender, EventArgs e)
        {
            if (IsListening == true)
            {

                if (heart_tick.Visible == true)
                {
                    heart_tick.Visible = false;
                }
                else
                {
                    heart_tick.Visible = true;
                }
            }
        }

        private void SendLog(bool IsTest)
        {

            try
            {
            Console.WriteLine("STEP: Semding emails.");
            MailMessage oMsg = new MailMessage();
            SmtpMail.SmtpServer = sSMTP;
            oMsg.To = @sTo;
            //"10.10.11.4"; //209.12.221.12
            //@"gabriel.villa@glacier-tech.com; 9152041973@messaging.sprintpcs.com";
            oMsg.From = @"Beat Monitor <no-reply@" +  sSMTP + ">"; //Glacier Technologies <webadmins@glacier-tech.com>

            if (IsTest == true)
            {
                oMsg.Subject = "TEST MESSAGE:" + sIPaddress + " SERVER DOWN!";
            }
            else 
            {
                oMsg.Subject = sIPaddress + " SERVER DOWN!";
            }

            oMsg.Body = sIPaddress + " SERVER DOWN!" +  "\r\n" + "Sent through the Automated Ping Monitor System";

            SmtpMail.Send(oMsg);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.ToString(),"Sending Email Error");

            }

        }

        private void cmdPosh_Click(object sender, EventArgs e)
        {
            fPowerShell Posh = new fPowerShell();
            Posh.Show();
        }

        private void cmdTestSMTP_Click(object sender, EventArgs e)
        {

            SendLog(true);
 


        }




 

    }
}


