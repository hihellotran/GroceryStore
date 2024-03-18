using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Control;
using WinFormsApp1.Model;

namespace WinFormsApp1.Boundary
{
    public partial class ProductType : Form
    {
        PTypebll typebll = new PTypebll();
        public ProductType()
        {
            InitializeComponent();
        }

        private void ProductType_Load(object sender, EventArgs e)
        {
            loadSup();
            dataGridView1.DataSource = typebll.getType();

        }
        private void loadSup()
        {
            DataTable data = typebll.getSupList();
            if (data.Rows.Count > 0)
            {

                comboBox1.DataSource = data;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = 0;
            }
        }
        private bool CheckInput()
        {
            if (txbid.Text.Equals("") || txbname.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btntype_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductType l = new ProductType();
            l.Show();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            this.Close();
            product product = new product();
            product.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            Supplier supplier = new Supplier();
            supplier.Show();
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


        private void btnadd_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
            {
                MessageBox.Show("Input do not empty");
                return;
            }
            PTypeControl control = new PTypeControl(txbid.Text, txbname.Text, comboBox1.SelectedValue.ToString());
            if (typebll.AddType(control))
            {

                MessageBox.Show("Successful");
                dataGridView1.DataSource = typebll.getType();
                //dataGridView1.Rows.Clear();
                // DataTable dt = b.getCus();

            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
            txbid.Text = "";
            txbname.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                txbid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txbname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                PTypeControl control = new PTypeControl(txbid.Text, txbname.Text, comboBox1.SelectedValue.ToString());
                if (typebll.UpdateType(control))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = typebll.getType();
                }
                else
                {
                    MessageBox.Show("UnSuccessful");
                }
            }
            txbid.Text = "";
            txbname.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                if (typebll.DeleteType(id))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = typebll.getType();
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
                txbid.Text = "";
                txbname.Text = "";
                comboBox1.SelectedIndex = 0;
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
