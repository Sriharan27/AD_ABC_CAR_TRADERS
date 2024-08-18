using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void MngCarsBtn_Click(object sender, EventArgs e)
        {
            ManageCars manageCars = new ManageCars();
            manageCars.Show();
            this.Close();
        }

        private void MngPartsBtn_Click(object sender, EventArgs e)
        {
            ManageParts manageParts = new ManageParts();
            manageParts.Show();
            this.Close();
        }

        private void MngUserCustBtn_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Close();
        }

        private void ManageOrdersBtn_Click(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();
            orders.Show();
            this.Close();
        }
    }
}
