using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ThreadGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // Not recommended, usually used in simple case to control thread only
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ThreadStart ts = new ThreadStart(Demo);
            Thread thrd = new Thread(Demo);
            thrd.IsBackground = true;
            thrd.Start();
            //for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            //{
             //label1.Text = i.ToString();
            //}
        }
        void Demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there");
        }
        int speed = 100;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void MovePictureBox()
        {
            new Thread(
                () =>   
                {while (true)
            {
                if (checkBox1.Checked)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                }
                        Thread.Sleep(Convert.ToInt32(textBox1.Text));
            }
        }
        ){IsBackground = true }.Start();
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MovePictureBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox2.Text, out speed))
            {

            }    
        }
    }
}
