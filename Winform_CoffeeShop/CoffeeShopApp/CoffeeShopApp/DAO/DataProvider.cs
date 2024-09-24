using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoffeeShopApp.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionStr = @"Data Source=DESKTOP-8TK8G1A\MSSQLSERVER01;Initial Catalog=CoffeeShop;User ID=sa;Integrated Security=True";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set => instance = value; // Keep the private setter here
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable(); // Create a new DataTable
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open(); // Open the connection

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listParam = query.Split(' ');
                        int i = 0;
                        foreach (var item in listParam)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command); // Use the query with the adapter
                    adapter.Fill(data); // Fill the DataTable with data from the database
                }
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); // Display any error
                return null;
            }
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open(); // Open the connection

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listParam = query.Split(' ');
                        int i = 0;
                        foreach (var item in listParam)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();
                }
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); // Display any error
                return 0;
            }
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null; // Initialize to null
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open(); // Open the connection

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listParam = query.Split(' ');
                        int i = 0;
                        foreach (var item in listParam)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();
                }
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); // Display any error
                return null;
            }
        }
    }
}
