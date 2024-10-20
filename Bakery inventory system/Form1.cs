using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bakery_inventory_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";
            using (Microsoft.Data.SqlClient.SqlConnection connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM emp WHERE Username = @Username AND Password = @Password";

                using (Microsoft.Data.SqlClient.SqlCommand command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    // Use Add with the correct type for each parameter
                    command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar).Value = username.Text;
                    command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar).Value = password.Text;  

                    try
                    {
                        connection.Open();

                        // Execute the query and get the result (COUNT(*))
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // If the count is 1, login is successful
                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dashboard dashboard = new dashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
