namespace ABC_Car_Traders
{
    partial class ManageParts
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PartsGridView = new System.Windows.Forms.DataGridView();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StockBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PartNameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 279);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 23);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.DecimalPlaces = 2;
            this.PriceBox.Location = new System.Drawing.Point(144, 106);
            this.PriceBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(120, 20);
            this.PriceBox.TabIndex = 3;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(273, 279);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(98, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PartsGridView
            // 
            this.PartsGridView.AllowUserToAddRows = false;
            this.PartsGridView.AllowUserToDeleteRows = false;
            this.PartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsGridView.Location = new System.Drawing.Point(394, 36);
            this.PartsGridView.Name = "PartsGridView";
            this.PartsGridView.ReadOnly = true;
            this.PartsGridView.Size = new System.Drawing.Size(660, 447);
            this.PartsGridView.TabIndex = 47;
            this.PartsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsGridView_CellClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(144, 279);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(103, 23);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(273, 279);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(144, 236);
            this.StockBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(120, 20);
            this.StockBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Stock Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Description";
            // 
            // DescripTxtBox
            // 
            this.DescripTxtBox.Location = new System.Drawing.Point(144, 154);
            this.DescripTxtBox.Multiline = true;
            this.DescripTxtBox.Name = "DescripTxtBox";
            this.DescripTxtBox.Size = new System.Drawing.Size(227, 58);
            this.DescripTxtBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Part Name";
            // 
            // PartNameTxtBox
            // 
            this.PartNameTxtBox.Location = new System.Drawing.Point(144, 15);
            this.PartNameTxtBox.Name = "PartNameTxtBox";
            this.PartNameTxtBox.Size = new System.Drawing.Size(227, 20);
            this.PartNameTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Car Type";
            // 
            // CarTypeComboBox
            // 
            this.CarTypeComboBox.FormattingEnabled = true;
            this.CarTypeComboBox.Location = new System.Drawing.Point(144, 62);
            this.CarTypeComboBox.Name = "CarTypeComboBox";
            this.CarTypeComboBox.Size = new System.Drawing.Size(227, 21);
            this.CarTypeComboBox.TabIndex = 2;
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(596, 9);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(410, 20);
            this.SearchTxtBox.TabIndex = 48;
            this.SearchTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTxtBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Global Search";
            // 
            // ManageParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.CarTypeComboBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.PartsGridView);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PartNameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ManageParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageParts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageParts_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView PartsGridView;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.NumericUpDown StockBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PartNameTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CarTypeComboBox;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label label3;
    }
}