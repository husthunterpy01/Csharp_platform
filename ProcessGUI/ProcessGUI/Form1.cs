using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetProcesses()
        {
            Process[] processArr = Process.GetProcesses();
           // var item = Process.GetCurrentProcess();
            foreach (Process item in processArr)
            {
                txbLog.Text = item.ProcessName + "\n" + txbLog.Text; // Print all the processes in the computer 
               
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start(Application.StartupPath + "\\ProcessGUI"); // Open program as from window + r
            Process.Start(@"https://vnexpress.net/"); // Open website in absolute path @ to understand special char as //
        }                                              // Window style is not available for websites

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = Application.StartupPath + "\\ProcessGUI.exe";
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Hidden program 
            proc.Start();
        }
    }
}
