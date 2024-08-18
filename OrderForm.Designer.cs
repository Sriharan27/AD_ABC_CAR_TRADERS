namespace ABC_Car_Traders
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.CarStockTxtBox = new System.Windows.Forms.TextBox();
            this.CarClearCartItemsBtn = new System.Windows.Forms.Button();
            this.CarGetNetTotBtn = new System.Windows.Forms.Button();
            this.CarOrderCartItemsBtn = new System.Windows.Forms.Button();
            this.CarsCartGridView = new System.Windows.Forms.DataGridView();
            this.CarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarOrderQtyBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.CarComboBox = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddToCartCarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.YearTxtBox = new System.Windows.Forms.TextBox();
            this.LoggedUserNameLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClearCartItemsBtn = new System.Windows.Forms.Button();
            this.NetTotalBtn = new System.Windows.Forms.Button();
            this.OrderCartItemsBtn = new System.Windows.Forms.Button();
            this.PartsCartGridView = new System.Windows.Forms.DataGridView();
            this.CarTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.PartsStockTxtBox = new System.Windows.Forms.TextBox();
            this.OrderQtyBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PartsDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PartsPriceTxtBox = new System.Windows.Forms.TextBox();
            this.PartNameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CarPartCarComboBox = new System.Windows.Forms.ComboBox();
            this.PartsResetBtn = new System.Windows.Forms.Button();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PartsPageLbl = new System.Windows.Forms.Label();
            this.OrderTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarOrderQtyBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderQtyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderTabControl
            // 
            this.OrderTabControl.Controls.Add(this.tabPage1);
            this.OrderTabControl.Controls.Add(this.tabPage2);
            this.OrderTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderTabControl.Location = new System.Drawing.Point(0, 0);
            this.OrderTabControl.Name = "OrderTabControl";
            this.OrderTabControl.SelectedIndex = 0;
            this.OrderTabControl.Size = new System.Drawing.Size(1153, 438);
            this.OrderTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.CarStockTxtBox);
            this.tabPage1.Controls.Add(this.CarClearCartItemsBtn);
            this.tabPage1.Controls.Add(this.CarGetNetTotBtn);
            this.tabPage1.Controls.Add(this.CarOrderCartItemsBtn);
            this.tabPage1.Controls.Add(this.CarsCartGridView);
            this.tabPage1.Controls.Add(this.CarOrderQtyBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DescriptionTxtBox);
            this.tabPage1.Controls.Add(this.CarComboBox);
            this.tabPage1.Controls.Add(this.ResetBtn);
            this.tabPage1.Controls.Add(this.AddToCartCarBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.PriceTxtBox);
            this.tabPage1.Controls.Add(this.YearTxtBox);
            this.tabPage1.Controls.Add(this.LoggedUserNameLbl);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1145, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Cars";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Available Quantity";
            // 
            // CarStockTxtBox
            // 
            this.CarStockTxtBox.Location = new System.Drawing.Point(166, 251);
            this.CarStockTxtBox.Name = "CarStockTxtBox";
            this.CarStockTxtBox.ReadOnly = true;
            this.CarStockTxtBox.Size = new System.Drawing.Size(227, 22);
            this.CarStockTxtBox.TabIndex = 91;
            // 
            // CarClearCartItemsBtn
            // 
            this.CarClearCartItemsBtn.Location = new System.Drawing.Point(429, 383);
            this.CarClearCartItemsBtn.Name = "CarClearCartItemsBtn";
            this.CarClearCartItemsBtn.Size = new System.Drawing.Size(163, 23);
            this.CarClearCartItemsBtn.TabIndex = 90;
            this.CarClearCartItemsBtn.Text = "Clear Cart Items";
            this.CarClearCartItemsBtn.UseVisualStyleBackColor = true;
            this.CarClearCartItemsBtn.Click += new System.EventHandler(this.CarClearCartItemsBtn_Click);
            // 
            // CarGetNetTotBtn
            // 
            this.CarGetNetTotBtn.Location = new System.Drawing.Point(707, 383);
            this.CarGetNetTotBtn.Name = "CarGetNetTotBtn";
            this.CarGetNetTotBtn.Size = new System.Drawing.Size(154, 23);
            this.CarGetNetTotBtn.TabIndex = 89;
            this.CarGetNetTotBtn.Text = "Get Net Total";
            this.CarGetNetTotBtn.UseVisualStyleBackColor = true;
            this.CarGetNetTotBtn.Click += new System.EventHandler(this.CarGetNetTotBtn_Click);
            // 
            // CarOrderCartItemsBtn
            // 
            this.CarOrderCartItemsBtn.Location = new System.Drawing.Point(956, 383);
            this.CarOrderCartItemsBtn.Name = "CarOrderCartItemsBtn";
            this.CarOrderCartItemsBtn.Size = new System.Drawing.Size(176, 23);
            this.CarOrderCartItemsBtn.TabIndex = 88;
            this.CarOrderCartItemsBtn.Text = "Order Cart Items";
            this.CarOrderCartItemsBtn.UseVisualStyleBackColor = true;
            this.CarOrderCartItemsBtn.Click += new System.EventHandler(this.CarOrderCartItemsBtn_Click);
            // 
            // CarsCartGridView
            // 
            this.CarsCartGridView.AllowUserToAddRows = false;
            this.CarsCartGridView.AllowUserToDeleteRows = false;
            this.CarsCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarName,
            this.YOM,
            this.Price,
            this.Description,
            this.AvailableStock,
            this.OrderQty,
            this.SubTot,
            this.CarID});
            this.CarsCartGridView.Location = new System.Drawing.Point(429, 0);
            this.CarsCartGridView.Name = "CarsCartGridView";
            this.CarsCartGridView.ReadOnly = true;
            this.CarsCartGridView.Size = new System.Drawing.Size(716, 363);
            this.CarsCartGridView.TabIndex = 64;
            // 
            // CarName
            // 
            this.CarName.HeaderText = "Car Name";
            this.CarName.Name = "CarName";
            this.CarName.ReadOnly = true;
            // 
            // YOM
            // 
            this.YOM.HeaderText = "Year Of Manufacture";
            this.YOM.Name = "YOM";
            this.YOM.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AvailableStock
            // 
            this.AvailableStock.HeaderText = "Available Stock";
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.ReadOnly = true;
            // 
            // OrderQty
            // 
            this.OrderQty.HeaderText = "Order Quantity";
            this.OrderQty.Name = "OrderQty";
            this.OrderQty.ReadOnly = true;
            // 
            // SubTot
            // 
            this.SubTot.HeaderText = "Sub Total";
            this.SubTot.Name = "SubTot";
            this.SubTot.ReadOnly = true;
            // 
            // CarID
            // 
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.Visible = false;
            // 
            // CarOrderQtyBox
            // 
            this.CarOrderQtyBox.Location = new System.Drawing.Point(166, 299);
            this.CarOrderQtyBox.Name = "CarOrderQtyBox";
            this.CarOrderQtyBox.Size = new System.Drawing.Size(120, 22);
            this.CarOrderQtyBox.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Description";
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(166, 167);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.ReadOnly = true;
            this.DescriptionTxtBox.Size = new System.Drawing.Size(227, 57);
            this.DescriptionTxtBox.TabIndex = 59;
            // 
            // CarComboBox
            // 
            this.CarComboBox.FormattingEnabled = true;
            this.CarComboBox.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.CarComboBox.Location = new System.Drawing.Point(166, 38);
            this.CarComboBox.Name = "CarComboBox";
            this.CarComboBox.Size = new System.Drawing.Size(227, 24);
            this.CarComboBox.TabIndex = 58;
            this.CarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarComboBox_SelectedIndexChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(166, 340);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(103, 23);
            this.ResetBtn.TabIndex = 48;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddToCartCarBtn
            // 
            this.AddToCartCarBtn.Location = new System.Drawing.Point(295, 340);
            this.AddToCartCarBtn.Name = "AddToCartCarBtn";
            this.AddToCartCarBtn.Size = new System.Drawing.Size(98, 23);
            this.AddToCartCarBtn.TabIndex = 46;
            this.AddToCartCarBtn.Text = "Add To Cart";
            this.AddToCartCarBtn.UseVisualStyleBackColor = true;
            this.AddToCartCarBtn.Click += new System.EventHandler(this.AddToCartCarBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Year";
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(166, 124);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.ReadOnly = true;
            this.PriceTxtBox.Size = new System.Drawing.Size(227, 22);
            this.PriceTxtBox.TabIndex = 40;
            // 
            // YearTxtBox
            // 
            this.YearTxtBox.Location = new System.Drawing.Point(166, 83);
            this.YearTxtBox.Name = "YearTxtBox";
            this.YearTxtBox.ReadOnly = true;
            this.YearTxtBox.Size = new System.Drawing.Size(227, 22);
            this.YearTxtBox.TabIndex = 39;
            // 
            // LoggedUserNameLbl
            // 
            this.LoggedUserNameLbl.AutoSize = true;
            this.LoggedUserNameLbl.Location = new System.Drawing.Point(3, 3);
            this.LoggedUserNameLbl.Name = "LoggedUserNameLbl";
            this.LoggedUserNameLbl.Size = new System.Drawing.Size(44, 16);
            this.LoggedUserNameLbl.TabIndex = 0;
            this.LoggedUserNameLbl.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClearCartItemsBtn);
            this.tabPage2.Controls.Add(this.NetTotalBtn);
            this.tabPage2.Controls.Add(this.OrderCartItemsBtn);
            this.tabPage2.Controls.Add(this.PartsCartGridView);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.PartsStockTxtBox);
            this.tabPage2.Controls.Add(this.OrderQtyBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PartsDescriptionTxtBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.PartsPriceTxtBox);
            this.tabPage2.Controls.Add(this.PartNameComboBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CarPartCarComboBox);
            this.tabPage2.Controls.Add(this.PartsResetBtn);
            this.tabPage2.Controls.Add(this.AddToCartBtn);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.PartsPageLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1145, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Car Parts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClearCartItemsBtn
            // 
            this.ClearCartItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ClearCartItemsBtn.Location = new System.Drawing.Point(435, 380);
            this.ClearCartItemsBtn.Name = "ClearCartItemsBtn";
            this.ClearCartItemsBtn.Size = new System.Drawing.Size(163, 23);
            this.ClearCartItemsBtn.TabIndex = 87;
            this.ClearCartItemsBtn.Text = "Clear Cart Items";
            this.ClearCartItemsBtn.UseVisualStyleBackColor = true;
            this.ClearCartItemsBtn.Click += new System.EventHandler(this.ClearCartItemsBtn_Click);
            // 
            // NetTotalBtn
            // 
            this.NetTotalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NetTotalBtn.Location = new System.Drawing.Point(713, 380);
            this.NetTotalBtn.Name = "NetTotalBtn";
            this.NetTotalBtn.Size = new System.Drawing.Size(154, 23);
            this.NetTotalBtn.TabIndex = 86;
            this.NetTotalBtn.Text = "Get Net Total";
            this.NetTotalBtn.UseVisualStyleBackColor = true;
            this.NetTotalBtn.Click += new System.EventHandler(this.NetTotalBtn_Click);
            // 
            // OrderCartItemsBtn
            // 
            this.OrderCartItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OrderCartItemsBtn.Location = new System.Drawing.Point(962, 380);
            this.OrderCartItemsBtn.Name = "OrderCartItemsBtn";
            this.OrderCartItemsBtn.Size = new System.Drawing.Size(176, 23);
            this.OrderCartItemsBtn.TabIndex = 85;
            this.OrderCartItemsBtn.Text = "Order Cart Items";
            this.OrderCartItemsBtn.UseVisualStyleBackColor = true;
            this.OrderCartItemsBtn.Click += new System.EventHandler(this.OrderCartItemsBtn_Click);
            // 
            // PartsCartGridView
            // 
            this.PartsCartGridView.AllowUserToAddRows = false;
            this.PartsCartGridView.AllowUserToDeleteRows = false;
            this.PartsCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarTypeColumn,
            this.PartNameColumn,
            this.PriceColumn,
            this.DescriptionColumn,
            this.AvailableQuantityColumn,
            this.OrderQuantityColumn,
            this.SubTotal,
            this.PartId});
            this.PartsCartGridView.Location = new System.Drawing.Point(435, 0);
            this.PartsCartGridView.Name = "PartsCartGridView";
            this.PartsCartGridView.ReadOnly = true;
            this.PartsCartGridView.Size = new System.Drawing.Size(710, 374);
            this.PartsCartGridView.TabIndex = 1;
            // 
            // CarTypeColumn
            // 
            this.CarTypeColumn.HeaderText = "Car Type";
            this.CarTypeColumn.Name = "CarTypeColumn";
            this.CarTypeColumn.ReadOnly = true;
            // 
            // PartNameColumn
            // 
            this.PartNameColumn.HeaderText = "Part Name";
            this.PartNameColumn.Name = "PartNameColumn";
            this.PartNameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // AvailableQuantityColumn
            // 
            this.AvailableQuantityColumn.HeaderText = "Available Quantity";
            this.AvailableQuantityColumn.Name = "AvailableQuantityColumn";
            this.AvailableQuantityColumn.ReadOnly = true;
            // 
            // OrderQuantityColumn
            // 
            this.OrderQuantityColumn.HeaderText = "Order Quantity";
            this.OrderQuantityColumn.Name = "OrderQuantityColumn";
            this.OrderQuantityColumn.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // PartId
            // 
            this.PartId.HeaderText = "PartId";
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            this.PartId.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 20);
            this.label12.TabIndex = 84;
            this.label12.Text = "Available Quantity";
            // 
            // PartsStockTxtBox
            // 
            this.PartsStockTxtBox.Location = new System.Drawing.Point(165, 250);
            this.PartsStockTxtBox.Name = "PartsStockTxtBox";
            this.PartsStockTxtBox.ReadOnly = true;
            this.PartsStockTxtBox.Size = new System.Drawing.Size(227, 20);
            this.PartsStockTxtBox.TabIndex = 83;
            // 
            // OrderQtyBox
            // 
            this.OrderQtyBox.Location = new System.Drawing.Point(165, 295);
            this.OrderQtyBox.Name = "OrderQtyBox";
            this.OrderQtyBox.Size = new System.Drawing.Size(120, 20);
            this.OrderQtyBox.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Order Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Description";
            // 
            // PartsDescriptionTxtBox
            // 
            this.PartsDescriptionTxtBox.Location = new System.Drawing.Point(165, 175);
            this.PartsDescriptionTxtBox.Multiline = true;
            this.PartsDescriptionTxtBox.Name = "PartsDescriptionTxtBox";
            this.PartsDescriptionTxtBox.ReadOnly = true;
            this.PartsDescriptionTxtBox.Size = new System.Drawing.Size(227, 57);
            this.PartsDescriptionTxtBox.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Price";
            // 
            // PartsPriceTxtBox
            // 
            this.PartsPriceTxtBox.Location = new System.Drawing.Point(165, 132);
            this.PartsPriceTxtBox.Name = "PartsPriceTxtBox";
            this.PartsPriceTxtBox.ReadOnly = true;
            this.PartsPriceTxtBox.Size = new System.Drawing.Size(227, 20);
            this.PartsPriceTxtBox.TabIndex = 76;
            // 
            // PartNameComboBox
            // 
            this.PartNameComboBox.FormattingEnabled = true;
            this.PartNameComboBox.Location = new System.Drawing.Point(165, 89);
            this.PartNameComboBox.Name = "PartNameComboBox";
            this.PartNameComboBox.Size = new System.Drawing.Size(227, 21);
            this.PartNameComboBox.TabIndex = 74;
            this.PartNameComboBox.SelectedIndexChanged += new System.EventHandler(this.PartNameComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Part Name";
            // 
            // CarPartCarComboBox
            // 
            this.CarPartCarComboBox.FormattingEnabled = true;
            this.CarPartCarComboBox.Location = new System.Drawing.Point(165, 45);
            this.CarPartCarComboBox.Name = "CarPartCarComboBox";
            this.CarPartCarComboBox.Size = new System.Drawing.Size(227, 21);
            this.CarPartCarComboBox.TabIndex = 72;
            this.CarPartCarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarPartCarComboBox_SelectedIndexChanged);
            // 
            // PartsResetBtn
            // 
            this.PartsResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PartsResetBtn.Location = new System.Drawing.Point(165, 347);
            this.PartsResetBtn.Name = "PartsResetBtn";
            this.PartsResetBtn.Size = new System.Drawing.Size(103, 23);
            this.PartsResetBtn.TabIndex = 68;
            this.PartsResetBtn.Text = "Reset";
            this.PartsResetBtn.UseVisualStyleBackColor = true;
            this.PartsResetBtn.Click += new System.EventHandler(this.PartsResetBtn_Click);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AddToCartBtn.Location = new System.Drawing.Point(294, 347);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(98, 23);
            this.AddToCartBtn.TabIndex = 67;
            this.AddToCartBtn.Text = "Add to Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = true;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Car Type";
            // 
            // PartsPageLbl
            // 
            this.PartsPageLbl.AutoSize = true;
            this.PartsPageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PartsPageLbl.Location = new System.Drawing.Point(3, 3);
            this.PartsPageLbl.Name = "PartsPageLbl";
            this.PartsPageLbl.Size = new System.Drawing.Size(44, 16);
            this.PartsPageLbl.TabIndex = 64;
            this.PartsPageLbl.Text = "label1";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 444);
            this.Controls.Add(this.OrderTabControl);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.OrderTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarOrderQtyBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderQtyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OrderTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LoggedUserNameLbl;
        private System.Windows.Forms.ComboBox CarComboBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button AddToCartCarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.TextBox YearTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.NumericUpDown CarOrderQtyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CarPartCarComboBox;
        private System.Windows.Forms.Button PartsResetBtn;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PartsPageLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PartsDescriptionTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PartsPriceTxtBox;
        private System.Windows.Forms.ComboBox PartNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PartsStockTxtBox;
        private System.Windows.Forms.NumericUpDown OrderQtyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView CarsCartGridView;
        private System.Windows.Forms.DataGridView PartsCartGridView;
        private System.Windows.Forms.Button OrderCartItemsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button NetTotalBtn;
        private System.Windows.Forms.Button ClearCartItemsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.Button CarClearCartItemsBtn;
        private System.Windows.Forms.Button CarGetNetTotBtn;
        private System.Windows.Forms.Button CarOrderCartItemsBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CarStockTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
    }
}