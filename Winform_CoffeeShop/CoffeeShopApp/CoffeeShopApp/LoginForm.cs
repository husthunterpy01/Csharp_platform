using CoffeeShopApp.DAO;

namespace CoffeeShopApp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string pwd = txbPassword.Text;
            if (CheckLogin(userName, pwd))
            {
                TableManagerForm tableManager = new TableManagerForm();
                this.Hide();
                tableManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalide username or password!");
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to escape the program ? ", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private bool CheckLogin(string userName, string pwd)
        {
            return AccountDAO.Instance.VerifyLogin(userName, pwd);
        }
    }
}
