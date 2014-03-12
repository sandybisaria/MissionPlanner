using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPython.Hosting;
using System.IO;
using System.Windows.Forms; 
using System.Threading;
using MissionPlanner;

namespace MissionPlanner
{
    public class ScriptVideoInterface
    {

        string command;
        Thread scriptThread;
        System.Threading.Timer timerThread;

        Script script = new Script();
        bool scriptRunning = false;
        DateTime timeout = DateTime.Now;
        static Microsoft.Scripting.Hosting.ScriptEngine engine;
        static Microsoft.Scripting.Hosting.ScriptScope scope;
        CurrentState cs = new CurrentState();
        //private System.Windows.Forms.Timer scriptChecker;

        /*public void startVideoRead()
        {
            //this.scriptChecker = new System.Windows.Forms.Timer(this.components);
            //this.scriptChecker.Tick += new System.EventHandler(this.scriptChecker_Tick);
            while (true)
            {
                script.runScript(command);
                Console.WriteLine("script running: %s", command);
            }
        }*/

        public void testCommand()
        {
            script.SendRC(3, 1000, false);
            script.SendRC(4, 1500, true);
        }

        public void turn(String dir)
        {
            Console.WriteLine("direction: %s", dir);
            switch(dir)
            {                    
                case "right":
                    script.SendRC(4, 1500, true);
                    break;
                case "left":
                    script.SendRC(4, 2000, false);
                    break;
                case "stop":
                    script.SendRC(3, 0, true);
                    break;
            }
        }

        void run_selected_script()
        {
            CustomMessageBox.Show("script test");

            //script = new Script(true);//checkBoxRedirectOutput.Checked);
            //script.runScript(command);


            //scriptrunning = false;
        }

        void run_selected_script_callback(Object state)
        {
            timerThread.Change(Timeout.Infinite, Timeout.Infinite);

            try
            {
                command = File.ReadAllText("videoDirections.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open script file due to exception: " + ex.Message);
                return;
            }


            CustomMessageBox.Show("script callback thread: " + command);

            //*******************Put back in for testing 
            if(cs.connected == true)
                turn(command);

            timerThread.Change(2000, Timeout.Infinite);
            //timerThread.Dispose();            
            
        }

        public void startScriptThread()//object sender, EventArgs e)
        {          
            

            /*try
            {
                command = File.ReadAllText("videoDirections.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open script file due to exception: " + ex.Message);
                return;
            }*/

            /*scriptThread = new System.Threading.Thread(new System.Threading.ThreadStart(run_selected_script))
            {
                IsBackground = true,
                Name = "Script Thread (new)"
            };*/

            timerThread = new System.Threading.Timer(run_selected_script_callback, null, 0, 1000);
            //labelScriptStatus.Text = "Script Status: Running";

            script = null;
            //outputwindowstarted = false;

            //scriptThread.Start();
            scriptRunning = true;
            CustomMessageBox.Show("script thread started");
            //scriptChecker.Enabled = true;
            //checkBoxRedirectOutput.Enabled = false;


            //remember this
            //scriptThread.Abort();
        }

        public void abortScript()//(object sender, EventArgs e)
        {
            //scriptThread.Abort();
            timerThread.Dispose();
            scriptRunning = false;
            CustomMessageBox.Show("aborted background script");
           // BUT_abort_script.Visible = false;
        }
        /*private void scriptChecker_Tick(object sender, EventArgs e)
        {
            if (!scriptRunning)
            {
                //labelScriptStatus.Text = "Script Status: Finished (or aborted)";
                CustomMessageBox.Show("script done");
                scriptChecker.Enabled = false;
                BUT_select_script.Enabled = true;
                BUT_run_script.Enabled = true;
                BUT_abort_script.Visible = false;
                BUT_edit_selected.Enabled = true;
                checkBoxRedirectOutput.Enabled = true;
            }
            else if ((script != null) && (checkBoxRedirectOutput.Checked) && (!outputwindowstarted))
            {
                outputwindowstarted = true;

                ScriptConsole console = new ScriptConsole();
                console.SetScript(script);
                ThemeManager.ApplyThemeTo((Form)console);
                console.Show();
                console.BringToFront();
            }
        }*/

    }

   
}