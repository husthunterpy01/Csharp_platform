using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuGUI
{
    public partial class Form1 : Form
    {
        ContextMenuStrip contextMenu;

        public Form1()
        {
            InitializeComponent();

            contextMenu = new ContextMenuStrip();
            contextMenu.Width = 500;
            var item = new ToolStripButton() {Text = "Click me", AutoSize = true};
            contextMenu.Items.Add(item);
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //contextMenu.Show(0,0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //contextMenuStrip1.Show(textBox1, new Point(50,50), ToolStripDropDownDirection.AboveLeft );
            //textBox1.ContextMenuStrip.Show(textBox1, new Point(50, 50), ToolStripDropDownDirection.AboveLeft);
            contextMenu.Show(this, this.PointToClient(MousePosition));
        }
    }
}
