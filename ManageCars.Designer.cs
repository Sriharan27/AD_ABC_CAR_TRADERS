namespace ABC_Car_Traders
{
    partial class ManageCars
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
            this.label5 = new System.Windows.Forms.Label();
            this.MakeTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YearTxtBox = new System.Windows.Forms.TextBox();
            this.ModelTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StockBox = new System.Windows.Forms.NumericUpDown();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CarsGridView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Make";
            // 
            // MakeTxtBox
            // 
            this.MakeTxtBox.Location = new System.Drawing.Point(144, 31);
            this.MakeTxtBox.Name = "MakeTxtBox";
            this.MakeTxtBox.Size = new System.Drawing.Size(227, 20);
            this.MakeTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Model";
            // 
            // YearTxtBox
            // 
            this.YearTxtBox.Location = new System.Drawing.Point(144, 119);
            this.YearTxtBox.Name = "YearTxtBox";
            this.YearTxtBox.Size = new System.Drawing.Size(227, 20);
            this.YearTxtBox.TabIndex = 3;
            // 
            // ModelTxtBox
            // 
            this.ModelTxtBox.Location = new System.Drawing.Point(144, 78);
            this.ModelTxtBox.Name = "ModelTxtBox";
            this.ModelTxtBox.Size = new System.Drawing.Size(227, 20);
            this.ModelTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Description";
            // 
            // DescripTxtBox
            // 
            this.DescripTxtBox.Location = new System.Drawing.Point(144, 214);
            this.DescripTxtBox.Multiline = true;
            this.DescripTxtBox.Name = "DescripTxtBox";
            this.DescripTxtBox.Size = new System.Drawing.Size(227, 58);
            this.DescripTxtBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Stock Qty";
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(144, 296);
            this.StockBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(120, 20);
            this.StockBox.TabIndex = 6;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(144, 337);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(103, 23);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(273, 337);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CarsGridView
            // 
            this.CarsGridView.AllowUserToAddRows = false;
            this.CarsGridView.AllowUserToDeleteRows = false;
            this.CarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsGridView.Location = new System.Drawing.Point(387, 31);
            this.CarsGridView.Name = "CarsGridView";
            this.CarsGridView.ReadOnly = true;
            this.CarsGridView.Size = new System.Drawing.Size(745, 502);
            this.CarsGridView.TabIndex = 30;
            this.CarsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsGridView_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(273, 337);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(98, 23);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.DecimalPlaces = 2;
            this.PriceBox.Location = new System.Drawing.Point(144, 166);
            this.PriceBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(120, 20);
            this.PriceBox.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 337);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Global Search";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(583, 5);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(472, 20);
            this.SearchTxtBox.TabIndex = 51;
            this.SearchTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTxtBox_KeyUp);
            // 
            // ManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CarsGridView);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MakeTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearTxtBox);
            this.Controls.Add(this.ModelTxtBox);
            this.Name = "ManageCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCars";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageCars_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MakeTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YearTxtBox;
        private System.Windows.Forms.TextBox ModelTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown StockBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchTxtBox;
    }
}