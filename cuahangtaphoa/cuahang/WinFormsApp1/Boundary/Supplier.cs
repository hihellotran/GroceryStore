using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;
using WinFormsApp1.bll;
using WinFormsApp1.Boundary;

namespace WinFormsApp1
{
    public partial class Supplier : Form
    {
        Supplierbll bll = new Supplierbll();
        public Supplier()
        {
            InitializeComponent();
            dataGridView1.DataSource = bll.getSup();

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

        private void btnimport_Click(object sender, EventArgs e)
        {
            this.Close();
            ImportOrder p = new ImportOrder();
            p.Show();
        }

        private void btndonban_Click(object sender, EventArgs e)
        {
            this.Close();
            SaleOrder s = new SaleOrder();
            s.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer c = new Customer();
            c.Show();
        }

        private void btntype_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductType t = new ProductType();
            t.Show();
        }

        private bool CheckInput()
        {
            if(txbid.Text.Equals("") || txbname.Text.Equals("") || txtaddress.Text.Equals("") ||
                txtemail.Text.Equals("") || txbphone.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
            {
                MessageBox.Show("Input do not empty");
                return;
            }
            SupplierModel model = new SupplierModel(txbid.Text, txbname.Text, txbaddress.Text,
            txbemail.Text,txbphone.Text);
            if (bll.AddSup(model))
            {

                MessageBox.Show("Successful");
                dataGridView1.DataSource = bll.getSup();
                //dataGridView1.Rows.Clear();
                // DataTable dt = b.getCus();

            }
            else
            {
                MessageBox.Show("ID is duplicated");
            }
            txbid.Text = "";
            txbname.Text = "";
            txbaddress.Text = "";
            txbemail.Text = "";
            txbphone.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                SupplierModel model = new SupplierModel(txbid.Text, txbname.Text, txbaddress.Text,
                    txbemail.Text, txbphone.Text);
                if (bll.UpdateSup(model))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = bll.getSup();
                }
                else
                {
                    MessageBox.Show("UnSuccessful");
                }
            }
            txbid.Text = "";
            txbname.Text = "";
            txbemail.Text = "";
            txbphone.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                txbid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txbname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txbaddress.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txbemail.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txbphone.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                if (bll.DeleteSup(id))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = bll.getSup();
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
                txbid.Text = "";
                txbname.Text = "";
                txbemail.Text = "";
                txbphone.Text = "";
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string rowfilter = string.Format("{0} like '{1}'", "name", "*" + txbsearch.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
            txbsearch.Text = "";
        }

       
    }
}
