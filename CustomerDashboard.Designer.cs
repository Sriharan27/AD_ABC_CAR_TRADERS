namespace ABC_Car_Traders
{
    partial class CustomerDashboard
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
            this.OrderPageBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderPageBtn);
            this.panel1.Location = new System.Drawing.Point(32, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 450);
            this.panel1.TabIndex = 1;
            // 
            // OrderPageBtn
            // 
            this.OrderPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPageBtn.Location = new System.Drawing.Point(0, 50);
            this.OrderPageBtn.Name = "OrderPageBtn";
            this.OrderPageBtn.Size = new System.Drawing.Size(218, 32);
            this.OrderPageBtn.TabIndex = 0;
            this.OrderPageBtn.Text = "Order Cars / Car Parts";
            this.OrderPageBtn.UseVisualStyleBackColor = true;
            this.OrderPageBtn.Click += new System.EventHandler(this.OrderPageBtn_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderPageBtn;
    }
}