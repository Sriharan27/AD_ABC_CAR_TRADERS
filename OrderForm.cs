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
    public partial class OrderForm : Form
    {
        private string connectionString;
        decimal netTotal = 0;
        decimal CarNetTotal = 0;
        public OrderForm()
        {
            InitializeComponent();
            CarsCartGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            PartsCartGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            LoadCarData();
            PartsPageLbl.Text = "Hi "+UserSession.FullName;
            LoggedUserNameLbl.Text = "Hi " + UserSession.FullName;
            ClearInputFields();
            CarClearInputFields();
        }

        private void CarPartCarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarPartCarComboBox.SelectedValue != null)
            {
                int selectedCarId = (int)CarPartCarComboBox.SelectedValue;
                LoadPartsData(selectedCarId);
            }
        }
        private void LoadCarData()
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

                        // Create a new column to combine Make and Model
                        carTable.Columns.Add("CarDetails", typeof(string), "Make + ' ' + Model");
                        //CarPart Page
                        CarPartCarComboBox.DisplayMember = "CarDetails";
                        CarPartCarComboBox.ValueMember = "CarID";
                        CarPartCarComboBox.DataSource = carTable;
                        //Car Page
                        CarComboBox.DisplayMember = "CarDetails";
                        CarComboBox.ValueMember = "CarID";
                        CarComboBox.DataSource = carTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void LoadPartsData(int carId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PartID, PartName FROM CarParts WHERE CarID = "+ carId + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable carPartTable = new DataTable();
                        carPartTable.Load(reader);

                        PartNameComboBox.DisplayMember = "PartName";
                        PartNameComboBox.ValueMember = "PartID";
                        PartNameComboBox.DataSource = carPartTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void PartNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PartNameComboBox.SelectedValue != null)
            {
                int selectedPartId = (int)PartNameComboBox.SelectedValue;
                FillFields(selectedPartId);
            }
        }

        private void FillFields(int PartId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Price, Description, Stock FROM CarParts WHERE PartID = " + PartId + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                PartsPriceTxtBox.Text = reader["Price"].ToString();
                                PartsDescriptionTxtBox.Text = reader["Description"].ToString();
                                PartsStockTxtBox.Text = reader["Stock"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified PartID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            RemoveNetTotalRow();

            int availableQuantity = int.Parse(PartsStockTxtBox.Text);
            decimal price = decimal.Parse(PartsPriceTxtBox.Text);
            decimal subTotal = price * OrderQtyBox.Value;

            if (OrderQtyBox.Value == 0) 
            {
                MessageBox.Show("Order Quantity cannot be 0!");
                return;
            }

            if (OrderQtyBox.Value > availableQuantity)
            {
                MessageBox.Show("Order Quantity cannot exceed Available Quantity!");
                return;
            } 

            int rowIndex = PartsCartGridView.Rows.Add();

            PartsCartGridView.Rows[rowIndex].Cells["CarTypeColumn"].Value = CarPartCarComboBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["PartNameColumn"].Value = PartNameComboBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["PriceColumn"].Value = PartsPriceTxtBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["DescriptionColumn"].Value = PartsDescriptionTxtBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["AvailableQuantityColumn"].Value = PartsStockTxtBox.Text;
            PartsCartGridView.Rows[rowIndex].Cells["OrderQuantityColumn"].Value = OrderQtyBox.Value.ToString();
            PartsCartGridView.Rows[rowIndex].Cells["SubTotal"].Value = subTotal.ToString();
            PartsCartGridView.Rows[rowIndex].Cells["PartId"].Value = PartNameComboBox.SelectedValue;


            ClearInputFields();
        }

        private void ClearInputFields()
        {
            CarPartCarComboBox.SelectedIndex = -1;
            PartNameComboBox.SelectedIndex = -1;
            PartsPriceTxtBox.Clear();
            PartsDescriptionTxtBox.Clear();
            PartsStockTxtBox.Clear();
            OrderQtyBox.Value = 0;
        }

        private void PartsResetBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void OrderCartItemsBtn_Click(object sender, EventArgs e)
        {
            if (PartsCartGridView.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty. Add items before placing an order.");
                return;
            }

            if (GetNetTotalRow() == null)
            {
                MessageBox.Show("Please Get the Net Total before Ordering.");
                return;
            }

            int userId = UserSession.UserId;
            DateTime orderDate = DateTime.Now;
            string itemType = "CarParts";
            decimal totalAmount = netTotal;
            string orderStatus = "Processing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Begin a transaction
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Insert the order into the Orders table
                    string insertOrderQuery = "INSERT INTO Orders (UserID, OrderDate, ItemType, TotalAmount, OrderStatus) " +
                                              "VALUES (@UserID, @OrderDate, @ItemType, @TotalAmount, @OrderStatus); " +
                                              "SELECT SCOPE_IDENTITY();"; // Get the newly inserted OrderID

                    int orderId;

                    using (SqlCommand command = new SqlCommand(insertOrderQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@ItemType", itemType);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@OrderStatus", orderStatus);

                        orderId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    string insertOrderItemQuery = "INSERT INTO OrderItems (OrderID, ItemID, Quantity, UnitPrice, TotalPrice) " +
                                                  "VALUES (@OrderID, @ItemID, @Quantity, @UnitPrice, @TotalPrice)";

                    string updateStockQuery = "UPDATE CarParts SET Stock = Stock - @Quantity WHERE PartID = @PartID";

                    foreach (DataGridViewRow row in PartsCartGridView.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["OrderQuantityColumn"].Value);
                        int partId = Convert.ToInt32(row.Cells["PartId"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["PriceColumn"].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                        string carName = row.Cells["CarName"].Value.ToString();

                        if (carName != "Net Total : ")
                        {
                            // Insert order item
                            using (SqlCommand command = new SqlCommand(insertOrderItemQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OrderID", orderId);
                                command.Parameters.AddWithValue("@ItemID", partId);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                                command.ExecuteNonQuery();
                            }

                            // Update stock
                            using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@PartID", partId);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();

                    ClearCartItemsBtn_Click(sender, e);

                    MessageBox.Show("Order placed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message);
                }
            }
        }

        private void NetTotalBtn_Click(object sender, EventArgs e)
        {
            if (GetNetTotalRow() != null)
            {
                MessageBox.Show("Net total doesn't change since no change in order items.");
            }
            else
            {
                AddNetTotalRow();
            }
        }

        private void AddNetTotalRow()
        {
            foreach (DataGridViewRow row in PartsCartGridView.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    netTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                }
            }

            int rowIndex = PartsCartGridView.Rows.Add();
            DataGridViewRow netTotalRow = PartsCartGridView.Rows[rowIndex];

            netTotalRow.Cells["CarTypeColumn"].Value = "Net Total : ";
            netTotalRow.Cells["SubTotal"].Value = netTotal.ToString(); 

            netTotalRow.DefaultCellStyle.Font = new Font(PartsCartGridView.Font, FontStyle.Bold);
            netTotalRow.DefaultCellStyle.BackColor = Color.LightGray;
        }
        private void RemoveNetTotalRow()
        {
            DataGridViewRow netTotalRow = GetNetTotalRow();
            if (netTotalRow != null)
            {
                PartsCartGridView.Rows.Remove(netTotalRow);
                netTotal = 0;
            }
        }

        private DataGridViewRow GetNetTotalRow()
        {
            foreach (DataGridViewRow row in PartsCartGridView.Rows)
            {
                if (row.Cells["CarTypeColumn"].Value != null && row.Cells["CarTypeColumn"].Value.ToString().Contains("Net Total"))
                {
                    return row;
                }
            }
            return null;
        }

        private void ClearCartItemsBtn_Click(object sender, EventArgs e)
        {
            PartsCartGridView.Rows.Clear();

            MessageBox.Show("Cart items have been cleared.");
        }
//----------------------------------------------------------------------------------------------------------------------------
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            CarClearInputFields();
        }

        private void  CarClearInputFields()
        {
            CarComboBox.SelectedIndex = -1;
            YearTxtBox.Clear();
            PriceTxtBox.Clear();
            DescriptionTxtBox.Clear();
            CarStockTxtBox.Clear();
            CarOrderQtyBox.Value = 0;
        }

        private void CarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarComboBox.SelectedValue != null)
            {
                int selectedCarId = (int)CarComboBox.SelectedValue;
                CarFillFields(selectedCarId);
            }
        }

        private void CarFillFields(int CarId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Year, Price, Description, Stock FROM Cars WHERE CarID = " + CarId + "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                YearTxtBox.Text = reader["Year"].ToString();
                                PriceTxtBox.Text = reader["Price"].ToString();
                                DescriptionTxtBox.Text = reader["Description"].ToString();
                                CarStockTxtBox.Text = reader["Stock"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified CarId.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddToCartCarBtn_Click(object sender, EventArgs e)
        {
            CarRemoveNetTotalRow();

            int availableQuantity = int.Parse(CarStockTxtBox.Text);
            decimal price = decimal.Parse(PriceTxtBox.Text);
            decimal subTotal = price * CarOrderQtyBox.Value;

            if (CarOrderQtyBox.Value == 0)
            {
                MessageBox.Show("Order Quantity cannot be 0!");
                return;
            }

            if (CarOrderQtyBox.Value > availableQuantity)
            {
                MessageBox.Show("Order Quantity cannot exceed Available Quantity!");
                return;
            }

            int rowIndex = CarsCartGridView.Rows.Add();

            CarsCartGridView.Rows[rowIndex].Cells["CarName"].Value = CarComboBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["YOM"].Value = YearTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["Price"].Value = PriceTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["Description"].Value = DescriptionTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["AvailableStock"].Value = CarStockTxtBox.Text;
            CarsCartGridView.Rows[rowIndex].Cells["OrderQty"].Value = CarOrderQtyBox.Value.ToString();
            CarsCartGridView.Rows[rowIndex].Cells["SubTot"].Value = subTotal.ToString();
            CarsCartGridView.Rows[rowIndex].Cells["CarID"].Value = CarComboBox.SelectedValue;


            CarClearInputFields();
        }
        private void CarAddNetTotalRow()
        {
            foreach (DataGridViewRow row in CarsCartGridView.Rows)
            {
                if (row.Cells["SubTot"].Value != null)
                {
                    CarNetTotal += decimal.Parse(row.Cells["SubTot"].Value.ToString());
                }
            }

            int rowIndex = CarsCartGridView.Rows.Add();
            DataGridViewRow netTotalRow = CarsCartGridView.Rows[rowIndex];

            netTotalRow.Cells["CarName"].Value = "Net Total : ";
            netTotalRow.Cells["SubTot"].Value = CarNetTotal.ToString();

            netTotalRow.DefaultCellStyle.Font = new Font(CarsCartGridView.Font, FontStyle.Bold);
            netTotalRow.DefaultCellStyle.BackColor = Color.LightGray;
        }
        private void CarRemoveNetTotalRow()
        {
            DataGridViewRow netTotalRow = CarGetNetTotalRow();
            if (netTotalRow != null)
            {
                CarsCartGridView.Rows.Remove(netTotalRow);
                CarNetTotal = 0;
            }
        }
        private DataGridViewRow CarGetNetTotalRow()
        {
            foreach (DataGridViewRow row in CarsCartGridView.Rows)
            {
                if (row.Cells["CarName"].Value != null && row.Cells["CarName"].Value.ToString().Contains("Net Total"))
                {
                    return row;
                }
            }
            return null;
        }

        private void CarGetNetTotBtn_Click(object sender, EventArgs e)
        {
            if (CarGetNetTotalRow() != null)
            {
                MessageBox.Show("Net total doesn't change since no change in order items.");
            }
            else
            {
                CarAddNetTotalRow();
            }
        }

        private void CarClearCartItemsBtn_Click(object sender, EventArgs e)
        {
            CarsCartGridView.Rows.Clear();

            MessageBox.Show("Cart items have been cleared.");
        }

        private void CarOrderCartItemsBtn_Click(object sender, EventArgs e)
        {
            if (CarsCartGridView.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty. Add items before placing an order.");
                return;
            }

            if (CarGetNetTotalRow() == null)
            {
                MessageBox.Show("Please Get the Net Total before Ordering.");
                return;
            }

            int userId = UserSession.UserId;
            DateTime orderDate = DateTime.Now;
            string itemType = "Cars";
            decimal totalAmount = CarNetTotal;
            string orderStatus = "Processing";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Begin a transaction
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Insert the order into the Orders table
                    string insertOrderQuery = "INSERT INTO Orders (UserID, OrderDate, ItemType, TotalAmount, OrderStatus) " +
                                              "VALUES (@UserID, @OrderDate, @ItemType, @TotalAmount, @OrderStatus); " +
                                              "SELECT SCOPE_IDENTITY();"; // Get the newly inserted OrderID

                    int orderId;

                    using (SqlCommand command = new SqlCommand(insertOrderQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@ItemType", itemType);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@OrderStatus", orderStatus);

                        // Execute the command and get the newly inserted OrderID
                        orderId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    // Insert each item into the OrderItems table
                    string insertOrderItemQuery = "INSERT INTO OrderItems (OrderID, ItemID, Quantity, UnitPrice, TotalPrice) " +
                                                  "VALUES (@OrderID, @ItemID, @Quantity, @UnitPrice, @TotalPrice)";

                    string updateStockQuery = "UPDATE Cars SET Stock = Stock - @Quantity WHERE CarID = @CarID";

                    foreach (DataGridViewRow row in CarsCartGridView.Rows)
                    {
                        int quantity = Convert.ToInt32(row.Cells["OrderQty"].Value);
                        int carId = Convert.ToInt32(row.Cells["CarID"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells["SubTot"].Value);
                        string carName = row.Cells["CarName"].Value.ToString();

                        if(carName != "Net Total : ")
                        {
                            // Insert order item
                            using (SqlCommand command = new SqlCommand(insertOrderItemQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OrderID", orderId);
                                command.Parameters.AddWithValue("@ItemID", carId);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                                command.ExecuteNonQuery();
                            }

                            // Update stock
                            using (SqlCommand command = new SqlCommand(updateStockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@CarID", carId);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    // Commit the transaction
                    transaction.Commit();

                    // Clear the cart and reset total
                    CarClearCartItemsBtn_Click(sender, e);

                    MessageBox.Show("Order placed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message);
                }
            }
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
        }
    }
}
