using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AutoServiceApp
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT userroleid, namerole FROM dbo.userrole";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmbUserRole.DataSource = table;
                cmbUserRole.DisplayMember = "namerole";
                cmbUserRole.ValueMember = "userroleid";
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dbo.[user] (Login, password, status, lastname, firstname, middlename, userroleid) VALUES (@login, @password, @status, @lastname, @firstname, @middlename, @userroleid)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", txtLogin.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@status", "active");
                command.Parameters.AddWithValue("@lastname", txtLastName.Text);
                command.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                command.Parameters.AddWithValue("@middlename", txtMiddleName.Text);
                command.Parameters.AddWithValue("@userroleid", (int)cmbUserRole.SelectedValue);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Пользователь добавлен.");
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.[order]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewOrders.DataSource = table;
            }
        }
    }
}
