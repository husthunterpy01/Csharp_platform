using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32;
using SmartX1Demo;


namespace dongle_Checking
{
    public partial class Form1 : Form
    {
        private SmartApp smartApp;
        int[] keyHandles = new int[8];
        int[] keyNumber = new int[1];
        private int Rtn = 0;
        SmartApp smart = new SmartApp();
        private Timer timer;




        public Form1()
        {
            InitializeComponent();
            btn4.Refresh();
            smartApp = new SmartApp();
            this.Shown += Form1_Load;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void UpdateTextBox1()
        {
            try
            {
                StringBuilder uid = new StringBuilder(32);
                Rtn = smart.SmartX1GetUid(keyHandles[0], uid);
                if (Rtn == 0)
                {
                    this.txtBox1.Text = uid.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Periodically check the dongle status and update the label
            loadLabel();
            UpdateTextBox1();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StringBuilder uid = new StringBuilder(32);
            Rtn = smart.SmartX1GetUid(keyHandles[0], uid);
            this.txtBox1.Text = uid.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "admin")
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLabel();
        }
        private void UpdateTextBox2()
        {
            try
            {
                StringBuilder uid = new StringBuilder(32);
                Rtn = smart.SmartX1GetUid(keyHandles[0], uid);
                if (Rtn == 0)
                {
                    this.txtBox2.Text = uid.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.Update();
        }

        private void lb1Input_Click(object sender, EventArgs e)
        {
          
        
        }
        void loadLabel()
        {
            try
            {
                string appid = "MyApp";
                Rtn = smart.SmartX1Find(appid, keyHandles, keyNumber);
                if (Rtn != 0)
                {
                    this.lb1Input.Text = "No Smart X1 device found, Error: " + Rtn.ToString();
                    return;
                }
                    this.lb1Input.Text = "Smart X1 device(s) found";
                    
                    System.Threading.Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder uid = new StringBuilder(32);
                Rtn = smart.SmartX1GetUid(keyHandles[0], uid);
                if (Rtn == 0)
                {
                    this.txtBox1.Text = uid.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

