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
using WinFormsApp1.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class product : Form
    {
        Productbll b = new Productbll();
        public product()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ImportOrder i = new ImportOrder();
            i.Show();
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

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            Supplier r = new Supplier();
            r.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer c = new Customer();
            c.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtgiamua_Click(object sender, EventArgs e)
        {

        }

        private void btntype_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductType p = new ProductType();
            p.Show();
        }
        private bool CheckInput()
        {
            if (txbid.Text.Equals("") || txbname.Text.Equals("") || txbgiaban.Text.Equals("") ||
                txbgiamua.Text.Equals("") || txbstatus.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
            {
                MessageBox.Show("Input do not empty");
                return;
            }
            ProductControl control = new ProductControl(txbid.Text, txbname.Text, cbbtype.SelectedValue.ToString(), int.Parse(txbgiaban.Text), int.Parse(txbgiamua.Text),txbstatus.Text, int.Parse(txbquantity.Text));
            if (b.AddProduct(control))
            {

                MessageBox.Show("Successful");
                dataGridView1.DataSource = b.getProduct();
                //dataGridView1.Rows.Clear();
                // DataTable dt = b.getCus();

            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
            txbid.Text = "";
            txbname.Text = "";
            txtgiaban.Text = "";
            txbgiamua.Text = "";
            txbstatus.Text = "";
            cbbtype.SelectedValue = cbbtype.Items[0].ToString();
        }

        private void loadSup()
        {
            DataTable data = b.getType();
            if (data.Rows.Count > 0)
            {

                cbbtype.DataSource = data;
                cbbtype.DisplayMember = "name";
                cbbtype.ValueMember = "id";
                cbbtype.SelectedIndex = 0;
            }
        }
        private void product_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.getProduct();
            loadSup();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                txbid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txbname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                cbbtype.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txbgiaban.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txbgiamua.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txbstatus.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txbquantity.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                ProductControl control = new ProductControl(txbid.Text, txbname.Text, cbbtype.SelectedValue.ToString(), int.Parse(txbgiaban.Text), int.Parse(txbgiamua.Text), txbstatus.Text,
                    int.Parse(txbquantity.Text));
                if (b.UpdateProduct(control))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = b.getProduct();
                }
                else
                {
                    MessageBox.Show("UnSuccessful");
                }
            }
            txbid.Text = "";
            txbname.Text = "";
            txbgiaban.Text = "";
            txbgiamua.Text = "";
            txbstatus.Text = "";
            txbquantity.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            if (b.DeleteProduct(id))
            {
                MessageBox.Show("Successful");
                dataGridView1.DataSource = b.getProduct();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
            txbid.Text = "";
            txbname.Text = "";
            txbgiaban.Text = "";
            txbgiamua.Text = "";
            txbstatus.Text = "";
            txbquantity.Text = "";
            cbbtype.SelectedIndex = 0;
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string rowfilter = string.Format("{0} like '{1}'", "name", "*" + txbsearch.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
            txbsearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbid.Text = "";
            txbname.Text = "";
            txbgiaban.Text = "";
            txbgiamua.Text = "";
            txbstatus.Text = "";
            txbquantity.Text = "";
        }
    }
}
