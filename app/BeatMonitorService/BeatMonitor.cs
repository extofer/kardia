using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ServiceProcess;
using System.Net.NetworkInformation;
using System.Web.Mail;


namespace BeatMonitorService
{
    public partial class BeatMonitor : ServiceBase
    {
        
        protected string sSMTP = "209.12.221.241";
        //protected string sIPaddress = "209.12.221.12";
        //protected string sTo = "gabriel.villa@glacier-tech.com; 9152041973@messaging.sprintpcs.com";

        //protected string sSMTP = "10.10.10.64";
        protected string sIPaddress = "10.10.10.74";
        protected string sTo = "gabriel.villa@glacier-tech.com; edward.herrera@glacier-tech.com; 9152033122@messaging.sprintpcs.com; 9152041973@messaging.sprintpcs.com";
        protected bool bSent = false;


        public BeatMonitor()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.pingInterval.Enabled = true;
            this.EventLog.WriteEntry("Started Heart Beat Service", System.Diagnostics.EventLogEntryType.Information, 1, 1);


        }

        protected override void OnStop()
        {
            this.pingInterval.Enabled = false;
            this.EventLog.WriteEntry("Stopped Heart Beat Service");
        }

        private void SendLog()
        {

            try
            {
                Console.WriteLine("STEP: Semding emails.");
                MailMessage oMsg = new MailMessage();

                SmtpMail.SmtpServer = sSMTP;
                
                oMsg.To = @sTo;
                
                oMsg.From = @"Beat Monitor <no-reply@" + sSMTP + ">"; //Glacier Technologies <webadmins@glacier-tech.com>


                oMsg.Subject = sIPaddress + " SERVER DOWN!";


                oMsg.Body = sIPaddress + " SERVER DOWN!" + "\r\n" + "Sent through the Automated Ping Monitor System";

                SmtpMail.Send(oMsg);
            }
            catch (Exception Err)
            {
                Console.WriteLine (Err.ToString(), "Sending Email Error");

            }

        }


        private void pingInterval_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (bSent==false)
            {
                Ping ping = new Ping();

                PingReply reply = ping.Send(sIPaddress, 10);
                if (reply.Status == IPStatus.Success)
                {
                    Console.Write("OK!");
                }
                else
                {
                    SendLog();
                }
            }

        }

    }
}
