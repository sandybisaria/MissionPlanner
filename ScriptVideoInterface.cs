using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPython.Hosting;
using System.IO;
using System.Windows.Forms; 
using System.Threading;
using MissionPlanner;
/*
namespace MissionPlanner
{
    public class ScriptVideoInterface
    {

        Script script = new Script();
        bool scriptRunning = false;
        DateTime timeout = DateTime.Now;
        static Microsoft.Scripting.Hosting.ScriptEngine engine;
        static Microsoft.Scripting.Hosting.ScriptScope scope;

        public void startVideoRead()
        {
            while (true)
            {
                script.runScript(Commands);
            }
        }

        public void turn(String dir)
        {
            switch(dir)
            {
                case "right":
                    script.SendRC(4, 2000, true);
                    break;
                case "left":
                    script.SendRC(4, 2000, true);
                    break;
                case "stop":
                    script.SendRC(3, 0, true);
                    break;
            }
        }

        void run_selected_script()
        {
            script = new Script(true);//checkBoxRedirectOutput.Checked);
            script.runScript(scriptText);
            //scriptrunning = false;
        }

        private void BUT_run_script_Click(object sender, EventArgs e)
        {
            Thread scriptThread;
            string command;

            try
            {
                command = File.ReadAllText("videoDirections.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open script file due to exception: " + ex.Message);
                return;
            }

            scriptThread = new System.Threading.Thread(new System.Threading.ThreadStart(run_selected_script))
            {
                IsBackground = true,
                Name = "Script Thread (new)"
            };
            //labelScriptStatus.Text = "Script Status: Running";

            script = null;
            //outputwindowstarted = false;

            scriptThread.Start();
            scriptRunning = true;
            scriptChecker.Enabled = true;
            checkBoxRedirectOutput.Enabled = false;


            //remember this
            scriptThread.Abort();
        }

    }
}*/