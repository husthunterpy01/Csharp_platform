using CoffeeShopApp.DAO;
using CoffeeShopApp.DTO;
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
            LoadTable();
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

        void LoadTable()
        {
            List<Table> listTable = TableDAO.Instance.LoadTableList();
            foreach (Table item in listTable)
            {
                Button btn = new Button() { Width = TableDAO.tableWidth, Height = TableDAO.tableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                switch (item.Status)
                {
                    case "Empty":
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }

        void showBill(int id)
        {

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            int tableId = (sender as Table).Id;
            showBill(tableId);
        }
    }
}
