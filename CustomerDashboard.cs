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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void OrderPageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            OrderForm frm = new OrderForm();
            frm.ShowDialog();
        }
    }
}
