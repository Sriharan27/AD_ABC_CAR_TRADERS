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
    public partial class ManageCars : Form
    {
        private string connectionString;
        private int CarId = 0;

        public ManageCars()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            LoadCarsData();
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Cars (Make, Model, Year, Price, Description, Stock) VALUES (@Make, @Model, @Year, @Price, @Description, @Stock)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Make", MakeTxtBox.Text);
                        command.Parameters.AddWithValue("@Model", ModelTxtBox.Text);
                        command.Parameters.AddWithValue("@Year", YearTxtBox.Text);
                        command.Parameters.AddWithValue("@Price",PriceBox.Value);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@Stock", StockBox.Value);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car added successfully!");
                        ResetFields();
                        LoadCarsData(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void LoadCarsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);
                CarsGridView.DataSource = carTable;
            }
        }

        private void CarsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = CarsGridView.Rows[e.RowIndex];
                CarId = int.Parse(selectedRow.Cells[0].Value?.ToString());
                MakeTxtBox.Text = selectedRow.Cells[1].Value?.ToString();
                ModelTxtBox.Text = selectedRow.Cells[2].Value?.ToString();
                YearTxtBox.Text = selectedRow.Cells[3].Value?.ToString();
                PriceBox.Value = Convert.ToDecimal(selectedRow.Cells[4].Value);
                DescripTxtBox.Text = selectedRow.Cells[5].Value?.ToString();
                StockBox.Value = Convert.ToInt32(selectedRow.Cells[6].Value);
                UpdateBtn.Visible = true;
                DeleteBtn.Visible = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, Price = @Price, Description = @Description, Stock = @Stock WHERE CarId = @CarId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Make", MakeTxtBox.Text);
                        command.Parameters.AddWithValue("@Model", ModelTxtBox.Text);
                        command.Parameters.AddWithValue("@Year", YearTxtBox.Text);
                        command.Parameters.AddWithValue("@Price", PriceBox.Value);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@Stock", StockBox.Value);
                        command.Parameters.AddWithValue("@CarId", CarId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car updated successfully!");
                        ResetFields();
                        LoadCarsData(); // Refresh the DataGridView
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
            ResetFields();
        }

        private void ResetFields()
        {
            MakeTxtBox.Text = string.Empty;
            ModelTxtBox.Text = string.Empty;
            YearTxtBox.Text = string.Empty;
            PriceBox.Value = PriceBox.Minimum;
            DescripTxtBox.Text = string.Empty;
            StockBox.Value = StockBox.Minimum;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Cars WHERE carID = @CarId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarId", CarId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car deleted successfully!");
                        ResetFields();
                        LoadCarsData(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void ManageCars_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = SearchTxtBox.Text.Trim();
            DataTable carTable = (DataTable)CarsGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(CarID, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(Make, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Model, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Price, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Stock, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Year, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
