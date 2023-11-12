using SmartX1Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dongle_Checking
{
    public partial class Form2 : Form
    {
        private SmartApp smartApp;
        int[] keyHandles = new int[8];
        int[] keyNumber = new int[1];
        private int Rtn = 0;
        SmartApp smart = new SmartApp();
        public Form2()
        {
            InitializeComponent();
            UpdateTextBox2();
            UpdateTextBox3();
        }
        private void UpdateTextBox2()
        {
            try
            {
                string appid = "MyApp";
                Rtn = smart.SmartX1Find(appid, keyHandles, keyNumber);
                StringBuilder uid = new StringBuilder(32);
                Rtn = smart.SmartX1GetUid(keyHandles[0], uid);
                if (Rtn == 0)
                {
                    this.txtBox2.Text = uid.ToString();
                }
                else
                    this.txtBox2.Text = "Unknown";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTextBox3()
        {
            try
            {
                int[] version = new int[1];
                Rtn = smart.SmartX1GetSoftVersion(keyHandles[0], version);
                if (Rtn == 0)
                {
                    this.txtBox3.Text = version[0].ToString();
                    return;
                }
                else
                    this.txtBox3.Text = "Unknown";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateTextBox2();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
