namespace BeatMonitorService
{
    partial class BeatMonitor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pingInterval = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.pingInterval)).BeginInit();
            // 
            // pingInterval
            // 
            this.pingInterval.Enabled = true;
            this.pingInterval.Interval = 60000;
            this.pingInterval.Elapsed += new System.Timers.ElapsedEventHandler(this.pingInterval_Elapsed);
            // 
            // BeatMonitor
            // 
            this.ServiceName = "Beat Monitor Service";
            ((System.ComponentModel.ISupportInitialize)(this.pingInterval)).EndInit();

        }

        #endregion

        private System.Timers.Timer pingInterval;


    }
}
