using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AutoServiceApp
{
    public partial class DiagnostForm : Form
    {
        public DiagnostForm()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dbo.[order] (datacreation, orderstatus, paymentstatus, carelement, details, amountdamage, liquids) VALUES (@datacreation, @orderstatus, @paymentstatus, @carelement, @details, @amountdamage, @liquids)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@datacreation", DateTime.Now);
                command.Parameters.AddWithValue("@orderstatus", "Принят");
                command.Parameters.AddWithValue("@paymentstatus", "Не оплачено");
                command.Parameters.AddWithValue("@carelement", txtCarElement.Text);
                command.Parameters.AddWithValue("@details", txtDetails.Text);
                command.Parameters.AddWithValue("@amountdamage", int.Parse(txtAmountDamage.Text));
                command.Parameters.AddWithValue("@liquids", txtLiquids.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Заказ добавлен.");
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
