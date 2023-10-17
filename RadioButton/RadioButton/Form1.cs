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

namespace RadioButtonGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowResult(Label lb, Panel pnl){
            RadioButton ckb = null;
            foreach (var item in pnl.Controls) {
                //if (item != null)
                //if (item.Checked)
                        //ckb = item;
                        //break;  
            }
            if (ckb != null) {
                lb.Text = ckb.Text;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowResult(label1, pnl1);
            ShowResult(label2, pnl2);
            ShowResult(label3, pnl3);
        }
    }
}
