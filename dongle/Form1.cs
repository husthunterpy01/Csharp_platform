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
        public Form1()
        {
            InitializeComponent();
            btn4.Refresh();
        }
        int[] keyHandles = new int[8];
        int[] keyNumber = new int[8];
        private int Rtn = 0;
        SmartApp smart = new SmartApp();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLabel();
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
                string appid = this.txtBox1.Text;
                Rtn = smart.SmartX1Find(appid, keyHandles, keyNumber);
                if (Rtn != 0)
                {
                    this.lb1Input.Text = "No Smart X1 device found";
                    return;
                }
                    this.lb1Input.Text = "Smart X1 device(s) found";
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
         
        }
    }
    }

