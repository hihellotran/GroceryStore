using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            this.Close();
            product p = new product();
            p.Show();
        }

        private void btnorder_Click_1(object sender, EventArgs e)
        {
            this.Close();
            SaleOrder s = new SaleOrder();
            s.Show();
        }

        private void btncustomer_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Customer c = new Customer();
            c.Show();
        }

        private void btnsuplier_Click(object sender, EventArgs e)
        {
            this.Close();
            Supplier r = new Supplier();
            r.Show();
        }
    }
}
