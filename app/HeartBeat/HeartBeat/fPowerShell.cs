using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.IO;


namespace HeartBeat
{

    public partial class fPowerShell : Form
    {

        public void ServerIsDown(string aScript)
        {

            FileStream oFSO = new FileStream(aScript, FileMode.Open);
            StreamReader oR = new StreamReader(oFSO);
            string sLine;
            
            int i;
            i = 0;
            this.Show();

           // txtScript.Clear();

            while ((sLine = oR.ReadLine()) != null)
            {
                txtScript.Text = sLine;

                if (sLine != "")
                {
                    //RunScript(sLine);
                    txtOutput.Text = RunScript(txtScript.Text);
                }

                Console.WriteLine(sLine);
                i = i + 1;

            }




            //try
            //{
            //    txtOutput.Clear();

            //    if (aScript == null)
            //    { 
            //        txtOutput.Text = RunScript(txtScript.Text); 
            //    }
            //    else 
            //    {
            //        RunScript(aScript);
            //    }
            //}

            //catch (Exception error)
            //{
            //    txtOutput.Text += String.Format("\r\nError in script : {0}\r\n", error.Message);
            //}

            

        }

        public fPowerShell()
        {
            InitializeComponent();
        }


        private void fPowerShell_Load(object sender, EventArgs e)
        {
        }

        private string RunScript(string scriptText)
        {
            // create Powershell runspace
            Runspace runspace = RunspaceFactory.CreateRunspace();

            // open it
            runspace.Open();

            // create a pipeline and feed it the script text
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(scriptText);

            // add an extra command to transform the script output objects into nicely formatted strings
            // remove this line to get the actual objects that the script returns. For example, the script
            // "Get-Process" returns a collection of System.Diagnostics.Process instances.
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();

            // close the runspace
            runspace.Close();

            // convert the script result into a single string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            return stringBuilder.ToString();
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            txtOutput.Text = RunScript(txtScript.Text);

        }


    }
}
