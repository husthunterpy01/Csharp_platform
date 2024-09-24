using System.Data.SqlClient;
using CoffeeShopApp.DAO;

namespace CoffeeShopApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadAccountList();
        }

        private void tbFood_Click(object sender, EventArgs e)
        {
            // Your logic for the tbFood button click
        }

        private void IdFoodlbl_Click(object sender, EventArgs e)
        {
            // Your logic for the IdFood label click
        }

        private void tbAccount_Click(object sender, EventArgs e)
        {
            // Your logic for the tbAccount button click
        }

        void LoadAccountList()
        {
            string connectionStr = @"Data Source=DESKTOP-8TK8G1A\MSSQLSERVER01;Initial Catalog=CoffeeShop;User ID=sa;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                string query = "exec dbo.USP_GetAccountByUserName @userName"; // Define your query
                dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]{"Le Van Tam"});
            }
        }

    }


}

