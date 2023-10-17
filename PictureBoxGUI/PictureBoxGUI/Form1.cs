using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxGUI
{
    public partial class Form1 : Form
    {
        string extention = ".jpg";
        public Form1()
        {
            InitializeComponent();

            cbImage.SelectedValueChanged += cbImage_SelectedValueChanged;
            LoadImageName();
   
        }
        void LoadImageName(){
            List<string> ListImage = new List<string>(){"1", "2","3"};
            cbImage.DataSource  = ListImage;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbImage_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null) {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);
                pcbImage.Image = bm;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
