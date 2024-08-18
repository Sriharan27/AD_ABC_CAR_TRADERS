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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders
{
    public partial class ManageParts : Form
    {
        private string connectionString;
        private int PartID = 0;

        public ManageParts()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            LoadCarTypes();
            LoadPartsData();
            CarTypeComboBox.SelectedIndex = -1;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StockBox.Value == 0) 
            {
                MessageBox.Show("Parts Quantity Cannot Be 0!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO CarParts (PartName, carID, Price, Description, Stock) VALUES (@PartName, @carID, @Price, @Description, @Stock)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", PartNameTxtBox.Text);
                        command.Parameters.AddWithValue("@carID", CarTypeComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@Price", PriceBox.Value);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@Stock", StockBox.Value);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Part added successfully!");
                        ResetFields();
                        LoadPartsData(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadPartsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM CarParts";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable carTable = new DataTable();
                    adapter.Fill(carTable);

                    carTable.Columns.Add("CarType", typeof(string));

                    foreach (DataRow row in carTable.Rows)
                    {
                        try
                        {
                            int carID = Convert.ToInt32(row["CarID"]);

                            string carQuery = "SELECT Make, Model FROM Cars WHERE CarID = @CarID";
                            using (SqlCommand command = new SqlCommand(carQuery, connection))
                            {
                                command.Parameters.AddWithValue("@CarID", carID);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    string make = reader["Make"].ToString();
                                    string model = reader["Model"].ToString();
                                    row["CarType"] = make + " " + model;
                                }
                                reader.Close();
                                connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while retrieving Part details: " + ex.Message);
                            connection.Close();
                        }
                    }

                    PartsGridView.DataSource = carTable;

                    PartsGridView.Columns["CarID"].Visible = false;

                    if (PartsGridView.Columns["CarType"] != null)
                    {
                        PartsGridView.Columns["CarType"].Visible = true;
                        PartsGridView.Columns["CarType"].HeaderText = "Car Type";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading car parts data: " + ex.Message);
                    connection.Close();
                }
            }
        }

        private void ResetFields()
        {
            PartNameTxtBox.Text = string.Empty;
            CarTypeComboBox.SelectedIndex = -1;
            PriceBox.Value = PriceBox.Minimum;
            DescripTxtBox.Text = string.Empty;
            StockBox.Value = StockBox.Minimum;
            UpdateBtn.Visible = false;
            DeleteBtn.Visible = false;
        }

        private void LoadCarTypes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CarID, Make, Model FROM Cars";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carTable = new DataTable();
                        carTable.Load(reader);

                        CarTypeComboBox.DisplayMember = "CarDetails";
                        CarTypeComboBox.ValueMember = "CarID";

                        // Create a new DataColumn to hold the combined Make and Model
                        carTable.Columns.Add("CarDetails", typeof(string), "Make + ' ' + Model");

                        CarTypeComboBox.DataSource = carTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE CarParts SET PartName = @PartName, CarID = @CarID, Price = @Price, Description = @Description, Stock = @Stock WHERE PartID = @PartID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartName", PartNameTxtBox.Text);
                        command.Parameters.AddWithValue("@CarID", CarTypeComboBox.SelectedValue);
                        command.Parameters.AddWithValue("@Price", PriceBox.Value);
                        command.Parameters.AddWithValue("@Description", DescripTxtBox.Text);
                        command.Parameters.AddWithValue("@Stock", StockBox.Value);
                        command.Parameters.AddWithValue("@PartID", PartID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Part updated successfully!");
                        ResetFields();
                        LoadPartsData(); // Refresh the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }
        private void PartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PartsGridView.Rows[e.RowIndex];
                PartID = int.Parse(selectedRow.Cells[0].Value?.ToString());
                PartNameTxtBox.Text = selectedRow.Cells[1].Value?.ToString();
                CarTypeComboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells[2].Value);
                PriceBox.Value = Convert.ToDecimal(selectedRow.Cells[3].Value);
                DescripTxtBox.Text = selectedRow.Cells[4].Value?.ToString();
                StockBox.Value = Convert.ToInt32(selectedRow.Cells[5].Value);
                UpdateBtn.Visible = true;
                DeleteBtn.Visible = true;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM CarParts WHERE PartID = @PartID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartID", PartID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Part deleted successfully!");
                        ResetFields();
                        LoadPartsData(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    connection.Close();
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ManageParts_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
        private void SearchTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = SearchTxtBox.Text.Trim();
            DataTable carTable = (DataTable)PartsGridView.DataSource;

            if (string.IsNullOrEmpty(filterText))
            {
                carTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string rowFilter = $"Convert(PartID, 'System.String') LIKE '%{filterText}%' " +
                                   $"OR Convert(PartName, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(Price, 'System.String') LIKE '%{filterText}%'" +
                                   $"OR Convert(CarType, 'System.String') LIKE '%{filterText}%'";
                carTable.DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
