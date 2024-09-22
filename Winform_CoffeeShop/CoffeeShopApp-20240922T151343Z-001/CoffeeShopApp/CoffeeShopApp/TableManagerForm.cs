using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class TableManagerForm : Form
    {
        public TableManagerForm()
        {
            InitializeComponent();
        }

        private void TableManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personInfoForm personInfo = new personInfoForm();
            personInfo.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
            this.Close();
        }
        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
