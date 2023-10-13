using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LabelGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bonjour"; // Show dialog 
        }

        void LoadLabel()
        {
            for (int i = 0; i < 10; i++)
            {
                Label lb = new Label();
                lb.Text = "Oh"; // Set the text for each label
                lb.BackColor = Color.Aqua;
                this.Controls.Add(lb); // Add the label to the Form1's controls
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = "Free Education"; 
            Form2 f = new Form2(); 
            /*f.Show(); */ // Pop up new form, new forms can still pop up after continuing pressing the label
            f.ShowDialog(); //Pop up new form, only 1 new form appears and no other boxes will apear, applied for passsword or notification
            f.lb2.Text = "Share to be better";
        }
    }
}
