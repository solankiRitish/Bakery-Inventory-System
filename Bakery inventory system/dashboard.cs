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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bakery_inventory_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        private void dashboard_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";

            comboBox1.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT CategoryName FROM Category";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string category = reader["CategoryName"].ToString();
                            comboBox1.Items.Add(category);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
            Report sto = new Report();
            sto.Show();
            this.Close();
        }
        private void MangeUser_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productId = textBox1.Text;
            string productName = textBox2.Text;
            string category = comboBox1.SelectedItem.ToString();
            decimal price = Convert.ToDecimal(textBox3.Text);
            int quantity = Convert.ToInt32(textBox4.Text);

            // SQL command to insert a new product
            string query = "INSERT INTO Products (ProductID, ProductName, Category, Price, Quantity) " +
                           "VALUES (@ProductID, @ProductName, @Category, @Price, @Quantity)";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Quantity", quantity);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string productId = textBox1.Text;
            string productName = textBox2.Text;
            string category = comboBox1.SelectedItem.ToString();
            decimal price = Convert.ToDecimal(textBox3.Text);
            int quantity = Convert.ToInt32(textBox4.Text);

            // SQL command to update the existing product
            string query = "UPDATE Products SET ProductName = @ProductName, Category = @Category, Price = @Price, Quantity = @Quantity " +
                           "WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Quantity", quantity);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productId = textBox1.Text;

            string query = "DELETE FROM Products WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product removed successfully.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string categoryId = textBox6.Text;
            string categoryName = textBox5.Text;

            // SQL command to insert a new category
            string query = "INSERT INTO Category (CategoryID, CategoryName) VALUES (@CategoryID, @CategoryName)";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                command.Parameters.AddWithValue("@CategoryName", categoryName);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Category added successfully.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string categoryId = textBox6.Text;
            string categoryName = textBox5.Text;

            // SQL command to update the existing category
            string query = "UPDATE Category SET CategoryName = @CategoryName WHERE ID = @CategoryID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                command.Parameters.AddWithValue("@CategoryName", categoryName);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Category updated successfully.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string categoryId = textBox6.Text;

            // SQL command to delete the category
            string query = "DELETE FROM Category WHERE ID = @CategoryID";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryID", categoryId);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Category removed successfully.");
            }
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void MangeUser_Click_1(object sender, EventArgs e)
        {
            Mangeuser mang1 = new Mangeuser();
            mang1.Show();
            this.Close();
        }
    }
}


