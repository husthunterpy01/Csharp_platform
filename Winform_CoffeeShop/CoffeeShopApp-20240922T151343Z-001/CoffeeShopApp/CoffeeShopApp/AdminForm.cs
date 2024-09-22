using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string connectionStr = @"Data Source=DESKTOP-8TK8G1A\MSSQLSERVER01;Initial Catalog=CoffeeShop;User ID=sa;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open(); // Open the connection
                    string query = "SELECT * FROM dbo.Account"; // Define your query
                    DataTable data = new DataTable(); // Create a new DataTable

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command); // Use the query with the adapter

                    adapter.Fill(data); // Fill the DataTable with data from the database

                    dtgvAccount.DataSource = data; // Bind the DataTable to the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}"); // Display any error
                }
            }
        }

    }


}

