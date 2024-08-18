using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Login : Form
    {
        string connectionString;

        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT UserID, Role, FirstName, LastName FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserID"));
                            string fullName = reader["FirstName"].ToString() +' '+ reader["LastName"].ToString();
                            string role = reader.GetString(reader.GetOrdinal("Role"));

                            UserSession.FullName = fullName;
                            UserSession.UserId = userId;
                            UserSession.Role = role;

                            MessageBox.Show($"Login successful! You are logged in as {role}.");

                            if (role == "Admin")
                            {
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                            }
                            else if (role == "Customer")
                            {
                                CustomerDashboard customerDashboard = new CustomerDashboard();
                                customerDashboard.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UsernameTxtBox.Text = string.Empty;
            PasswordTxtBox.Text = string.Empty;
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
        }
    }
}
