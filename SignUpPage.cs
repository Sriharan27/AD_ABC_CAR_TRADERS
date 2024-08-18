using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class SignUpPage : Form
    {
        string connectionString;

        public SignUpPage()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string FirstName = FirstNameTxtBox.Text;
            string LastName = LastNameTxtBox.Text;
            string Email = EmailTxtBox.Text;
            string PhNum = PhNumTxtBox.Text;
            string Address = AddressTxtBox.Text;
            string Username = UsernameTxtBox.Text;
            string Password = PasswordTxtBox.Text;

            // Check if the username or password fields are empty
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(PhNum) || string.IsNullOrWhiteSpace(Address) || string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Role, FirstName, LastName, Email, Phone, Address) " +
                               "VALUES (@Username, @Password, @Role, @FirstName, @LastName, @Email, @PhNum, @Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Role", "Customer");
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@PhNum", PhNum);
                command.Parameters.AddWithValue("@Address", Address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully! Please Login to continue.");
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows inserted.");
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
            FirstNameTxtBox.Text = string.Empty;
            LastNameTxtBox.Text = string.Empty;
            EmailTxtBox.Text = string.Empty;
            PhNumTxtBox.Text = string.Empty;
            AddressTxtBox.Text = string.Empty;
            UsernameTxtBox.Text = string.Empty;
            PasswordTxtBox.Text = string.Empty;
        }

        private void SignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
