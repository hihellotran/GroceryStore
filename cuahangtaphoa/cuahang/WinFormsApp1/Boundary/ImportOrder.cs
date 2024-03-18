using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Boundary;

namespace WinFormsApp1
{
    public partial class ImportOrder : Form
    {
        public ImportOrder()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhomepage_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage h = new Homepage();
            h.Show();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            this.Close();
            product p = new product();
            p.Show();
        }

        private void btndonban_Click(object sender, EventArgs e)
        {
            this.Close();
            SaleOrder s = new SaleOrder();
            s.Show();
        }

        private void ImportOrder_Load(object sender, EventArgs e)
        {

        }

        private void btntype_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductType t = new ProductType();
            t.Show();
        }
    }
}
