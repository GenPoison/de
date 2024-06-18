using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AutoServiceApp
{
    public partial class MechanicForm : Form
    {
        public MechanicForm()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.[order] WHERE orderstatus = 'Готовится'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewOrders.DataSource = table;
            }
        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                string orderId = dataGridViewOrders.SelectedRows[0].Cells["orderid"].Value.ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE dbo.[order] SET orderstatus = 'Готов' WHERE orderid = @orderid";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@orderid", orderId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Статус заказа обновлен.");
                }

                btnViewOrders_Click(sender, e); // Обновление списка заказов
            }
        }
    }
}
