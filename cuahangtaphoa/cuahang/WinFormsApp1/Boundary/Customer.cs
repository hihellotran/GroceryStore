using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.bll;
using WinFormsApp1.Boundary;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Customer : Form
    {
        Customerbll b = new Customerbll();
        public Customer()
        {
            InitializeComponent();

            dataGridView1.DataSource = b.getCus();


            
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

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            Supplier r = new Supplier();
            r.Show();
        }

        private void btntype_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductType t = new ProductType();
            t.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
        }
        private void LoadAllCustomer()
        {

            DataTable dt = b.getCus();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dt.Rows);
            }
        }
        private bool CheckInput()
        {
            if (txbid.Text.Equals("") || txbname.Text.Equals("") || txbaddress.Text.Equals("")  ||
              txbemail.Text.Equals("") || cbbsex.Text.Equals("") || txbphone.Text.Equals(""))
            {
                //MessageBox.Show("Input do not empty");
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
                CustomerModel model = new CustomerModel(txbid.Text, txbname.Text, txbaddress.Text,
                txbemail.Text, cbbsex.Text, txbphone.Text);
            if (b.AddCus(model))
            {

                MessageBox.Show("Successful");
                dataGridView1.DataSource = b.getCus();
                //dataGridView1.Rows.Clear();
                // DataTable dt = b.getCus();

            }
            else
            {
                MessageBox.Show("ID is duplicated");
            }
            txbid.Text = "";
            txbname.Text = "";
            txbemail.Text = "";
            cbbsex.Text = "";
            txbphone.Text = "";
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                CustomerModel model = new CustomerModel(txbid.Text, txbname.Text, txbaddress.Text,
                    txbemail.Text, cbbsex.Text, txbphone.Text);
                if (b.UpdateCus(model))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = b.getCus();
                }
                else
                {
                    MessageBox.Show("UnSuccessful");
                }
            }
            txbid.Text = "";
            txbname.Text = "";
            txbemail.Text = "";
            cbbsex.Text = "";
            txbphone.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*DataGridViewRow row = dataGridView1.SelectedRows[0];

            txbid.Text = row.Cells[1].Value.ToString();
            txbname.Text = row.Cells[2].Value.ToString();
            txbaddress.Text = row.Cells[3].Value.ToString();
            txbemail.Text = row.Cells[4].Value.ToString();
            cbbsex.Text = row.Cells[5].Value.ToString();
            txbphone.Text = row.Cells[6].Value.ToString();*/
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                txbid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txbname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txbaddress.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txbemail.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                cbbsex.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txbphone.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn row chưa
            if (dataGridView1.SelectedRows.Count == 1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                if (b.DeleteCus(id))
                {
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = b.getCus();
                }
                else
                {
                    MessageBox.Show("Unsuccessful");
                }
                txbid.Text = "";
                txbname.Text = "";
                txbemail.Text = "";
                cbbsex.Text = "";
                txbphone.Text = "";
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //DataTable data = b.SearchByName(txbsearch.Text);
           /* MessageBox.Show(dataGridView1.Rows.Count.ToString());
            dataGridView1.Rows.Clear();
            for(int i=0; i < data.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(data.Rows[0][0].ToString() + data.Rows[0][1].ToString() +
                    data.Rows[0][2].ToString() + data.Rows[0][3].ToString() + data.Rows[0][4].ToString());
            }*/
            
            /*dataGridView1.DataSource = b.SearchByName(txbsearch.Text);
            MessageBox.Show(dataGridView1.Rows.Count.ToString());*/
            string rowfilter = string.Format("{0} like '{1}'", "name", "*" + txbsearch.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
            txbsearch.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
    }
