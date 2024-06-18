using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace AutoServiceApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT u.*, r.namerole FROM dbo.[user] u INNER JOIN dbo.userrole r ON u.userroleid = r.userroleid WHERE u.Login = @login AND u.password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["namerole"].ToString();
                    this.Hide();
                    switch (role)
                    {
                        case "Мастер приемщик":
                            new MasterForm().Show();
                            break;
                        case "Автомеханик":
                            new MechanicForm().Show();
                            break;
                        case "Автодиагност":
                            new DiagnostForm().Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.");
                }
            }
        }
    }
}

