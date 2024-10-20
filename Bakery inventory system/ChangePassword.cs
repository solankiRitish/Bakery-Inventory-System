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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();
            this.Hide();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string userID = ID.Text;
            string userName = UserName.Text;
            string newPassword = NewPassword.Text;
            string reEnterPassword = ReEnterPassword.Text;

            if (newPassword != reEnterPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(reEnterPassword))
            {
                MessageBox.Show("Password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Update the password in the database
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE emp SET Password = @NewPassword WHERE ID = @UserID AND UserName = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@UserName", userName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not found. Please check the ID and username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form1 loginForm1 = new Form1();
            loginForm1.Show();
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
            Report reo = new Report();
            reo.Show();
            this.Close();
        }

        private void MangeUser_Click(object sender, EventArgs e)
        {
            Mangeuser mang = new Mangeuser();
            mang.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
