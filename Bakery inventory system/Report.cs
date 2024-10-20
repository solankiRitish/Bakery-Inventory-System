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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";
            string query = "SELECT * FROM Products";

            SqlConnection con = new SqlConnection(constring);

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\solanki ritish\\Desktop\\Bakery inventory system\\login.mdf\";Integrated Security=True";
            string query = "SELECT * FROM emp";

            SqlConnection con = new SqlConnection(constring);

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt2 = new DataTable();
            dataAdapter.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Stock sto = new Stock();
            sto.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Report sto = new Report();
            sto.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Mangeuser mang = new Mangeuser();
            mang.Show();
            this.Close();
        }

        private void Changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

    }
}
