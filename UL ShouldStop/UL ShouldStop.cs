using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.IO;

namespace UL_Assistant
{
    public partial class ShouldStop : Form
    {
        public ShouldStop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 

            //notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon.BalloonTipText = "Welcome to TutorialsPanel.com!!";
            //notifyIcon.BalloonTipTitle = "Welcome Message";
            //notifyIcon.ShowBalloonTip(2000);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            DialogResult dr = MessageBox.Show("Do you want to Stop '" + clickedButton.Name + "' Process ?", "Stop Process", MessageBoxButtons.YesNo);



            if (dr == DialogResult.Yes)
            {
                
            
                
                Process proc = null;
                try
                {
                    string batDir = string.Format(@"C:\Users\user\Desktop\");
                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "Yes.bat";
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.Start();
                    proc.WaitForExit();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show("You Clicked on No");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    Hide();
            //    notifyIcon.Visible = true;
            //}
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            // Path.GetTempPath();
            DialogResult dr = MessageBox.Show( "Do You want to Stop ?", "Confirmation", MessageBoxButtons.YesNo);
            if ( dr == DialogResult.Yes)
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(Path.GetTempPath() + "shouldstop.txt"))
                {
                    file.WriteLine("ULBOT");                    
                }
                MessageBox.Show("Stopped Successfully.");
            }
        }
    }
}
