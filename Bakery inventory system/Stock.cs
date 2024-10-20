using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_inventory_system
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void Changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Close();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Stock sto = new Stock();
            sto.Show();
            this.Close();
        }
        private void Report_Click(object sender, EventArgs e)
        {
            Report repo = new Report();
            repo.Show();
            this.Close();
        }
        private void MangeUser_Click(object sender, EventArgs e)
        {
            Mangeuser mang = new Mangeuser();
            mang.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pID = PID.Text.Trim();
            string category = comboBox1.SelectedItem?.ToString();
            string productName = Pname.Text.Trim();

            int currentQuantity = GetProductQuantity(pID, category, productName);

            if (currentQuantity > 0)
            {
                int newQuantity = currentQuantity + 10;
                UpdateProductQuantity(pID, category, productName, newQuantity);

                label5.Text = $"Quantity in stock: {newQuantity}";
            }
            else
            {
                MessageBox.Show("Product not found or has zero quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetProductQuantity(string pID, string category, string productName)
        {
            int quantity = 0;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT Quantity 
                             FROM Products 
                             WHERE ProductID = @ProductID 
                             AND Category = @Category 
                             AND ProductName = @ProductName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", pID);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@ProductName", productName);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            quantity = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving the quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return quantity;
        }

        private void UpdateProductQuantity(string pID, string category, string productName, int newQuantity)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuantityQuery = @"UPDATE Products 
                                           SET Quantity = @NewQuantity 
                                           WHERE ProductID = @ProductID 
                                           AND Category = @Category 
                                           AND ProductName = @ProductName";

                    using (SqlCommand command = new SqlCommand(updateQuantityQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        command.Parameters.AddWithValue("@ProductID", pID);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@ProductName", productName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            UpdateProductAvailability(connection, pID, category, productName);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update quantity. Product may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateProductAvailability(SqlConnection connection, string pID, string category, string productName)
        {
            string updateAvailabilityQuery = @"UPDATE Products 
                                       SET Available = 'Yes' 
                                       WHERE ProductID = @ProductID 
                                       AND Category = @Category 
                                       AND ProductName = @ProductName";

            using (SqlCommand command = new SqlCommand(updateAvailabilityQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductID", pID);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@ProductName", productName);

                command.ExecuteNonQuery();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";

            comboBox1.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Category Name FROM Category";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string category = reader["Category Name"].ToString();
                            comboBox1.Items.Add(category);
                        }

                        reader.Close();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void StackIn_CheckedChanged(object sender, EventArgs e)
        {
            g1.Show();
            g2.Hide();
        }

        private void StockOut_CheckedChanged(object sender, EventArgs e)
        {
            g2.Show();
        }

        private void g2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string productId = textBox3.Text;
            string productName = textBox2.Text;

            // Ensure both Product ID and Product Name are entered
            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter both Product ID and Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL query to update product quantity to 0 and set available status to 'No'
            string query = "UPDATE Products SET Quantity = 0, Available = 'No' WHERE ProductID = @ProductID AND ProductName = @ProductName";

            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@ProductName", productName);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product marked as 'Out of Stock' and availability updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No product found with the given ID and Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void Stock1_Click(object sender, EventArgs e)
        {
            Stock sto = new Stock();
            sto.Show();
            this.Close();
        }

        private void Report_Click_1(object sender, EventArgs e)
        {
            Report sto = new Report();
            sto.Show();
            this.Close();
        }

        private void MangeUser_Click_1(object sender, EventArgs e)
        {
            Mangeuser mang = new Mangeuser();
            mang.Show();
            this.Close();
        }

        private void Changepassword_Click_1(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Close();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}

