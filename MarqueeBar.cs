using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class MarqueeBar : Form
    {

        public delegate void DoWorkEventHandler(object sender, DoWorkEventArgs e);
        public event DoWorkEventHandler DoWork;

        public delegate void RunWorkerCompletedEventHandler(object sender, RunWorkerCompletedEventArgs e);
        public event RunWorkerCompletedEventHandler RunWorkerCompleted;

        public BackgroundWorker bg;

        public MarqueeBar(string title = "", string message = "")
        {
            InitializeComponent();
            this.Text = title;
            label1.Text = message;
            bg = backgroundWorker1;
        }

        public void start()
        {
            this.Visible = true;
            System.Threading.Thread.Sleep(1000);
            bg.RunWorkerAsync();
        }
    }
}
