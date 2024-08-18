namespace ABC_Car_Traders
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManageOrdersBtn = new System.Windows.Forms.Button();
            this.MngUserCustBtn = new System.Windows.Forms.Button();
            this.MngPartsBtn = new System.Windows.Forms.Button();
            this.MngCarsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ManageOrdersBtn);
            this.panel1.Controls.Add(this.MngUserCustBtn);
            this.panel1.Controls.Add(this.MngPartsBtn);
            this.panel1.Controls.Add(this.MngCarsBtn);
            this.panel1.Location = new System.Drawing.Point(74, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 406);
            this.panel1.TabIndex = 0;
            // 
            // ManageOrdersBtn
            // 
            this.ManageOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageOrdersBtn.Location = new System.Drawing.Point(0, 164);
            this.ManageOrdersBtn.Name = "ManageOrdersBtn";
            this.ManageOrdersBtn.Size = new System.Drawing.Size(218, 32);
            this.ManageOrdersBtn.TabIndex = 3;
            this.ManageOrdersBtn.Text = "Manage Orders";
            this.ManageOrdersBtn.UseVisualStyleBackColor = true;
            this.ManageOrdersBtn.Click += new System.EventHandler(this.ManageOrdersBtn_Click);
            // 
            // MngUserCustBtn
            // 
            this.MngUserCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngUserCustBtn.Location = new System.Drawing.Point(0, 126);
            this.MngUserCustBtn.Name = "MngUserCustBtn";
            this.MngUserCustBtn.Size = new System.Drawing.Size(218, 32);
            this.MngUserCustBtn.TabIndex = 2;
            this.MngUserCustBtn.Text = "Manage Users / Customers";
            this.MngUserCustBtn.UseVisualStyleBackColor = true;
            this.MngUserCustBtn.Click += new System.EventHandler(this.MngUserCustBtn_Click);
            // 
            // MngPartsBtn
            // 
            this.MngPartsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngPartsBtn.Location = new System.Drawing.Point(0, 88);
            this.MngPartsBtn.Name = "MngPartsBtn";
            this.MngPartsBtn.Size = new System.Drawing.Size(218, 32);
            this.MngPartsBtn.TabIndex = 1;
            this.MngPartsBtn.Text = "Manage Car Parts";
            this.MngPartsBtn.UseVisualStyleBackColor = true;
            this.MngPartsBtn.Click += new System.EventHandler(this.MngPartsBtn_Click);
            // 
            // MngCarsBtn
            // 
            this.MngCarsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngCarsBtn.Location = new System.Drawing.Point(0, 50);
            this.MngCarsBtn.Name = "MngCarsBtn";
            this.MngCarsBtn.Size = new System.Drawing.Size(218, 32);
            this.MngCarsBtn.TabIndex = 0;
            this.MngCarsBtn.Text = "Manage Cars";
            this.MngCarsBtn.UseVisualStyleBackColor = true;
            this.MngCarsBtn.Click += new System.EventHandler(this.MngCarsBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 406);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MngCarsBtn;
        private System.Windows.Forms.Button ManageOrdersBtn;
        private System.Windows.Forms.Button MngUserCustBtn;
        private System.Windows.Forms.Button MngPartsBtn;
    }
}