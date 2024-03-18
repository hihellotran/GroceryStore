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
using WinFormsApp1.Control;

namespace WinFormsApp1
{
    public partial class SaleOrder : Form
    {
        Productbll b = new Productbll();
        Customerbll cus = new Customerbll();
        Billbll bill = new Billbll();
        public SaleOrder()
        {
            InitializeComponent();
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ImportOrder i = new ImportOrder();
            i.Show();
        }

        private void btndonban_Click(object sender, EventArgs e)
        {
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

       

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No product");
                return;
            }
           if (txtidcustomer.Text.Equals(""))
            {
                MessageBox.Show("No id customer");
                return;
            }
            
            if (!cus.CheckIdCus(txbIdCus.Text))
            {
                MessageBox.Show("Customer is not existed");
                return;
            }
            
            string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
         // MessageBox.Show(txbID.Text + txbIdCus.Text + date);
            bill.CreateBill(txbID.Text, date, txbIdCus.Text);
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bill.AddBillDetail(dataGridView1.Rows[i].Cells[0].Value.ToString(), txbID.Text, dataGridView1.Rows[i].Cells[3].Value.ToString());

            }
            string idb1 = txbID.Text;
            string idd1 = dateTimePicker1.Value.ToString();
            string idc = txbIdCus.Text;
            this.Close();
            InvoiceExport invoice = new InvoiceExport(idb1, idd1, idc);
            //MessageBox.Show(idb1+" "+ idc);
            invoice.Show();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //MessageBox.Show(comboBox1.Text + dataGridView1.Rows[i].Cells[1].ToString());
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(comboBox1.Text))
                {
                    int newQuantity = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())+ int.Parse(numberamount.Value.ToString()); ;
      

                    dataGridView1.Rows[i].Cells[3].Value = newQuantity.ToString();
                    return;

                }
            }
            DataTable data = b.getInforById(comboBox1.SelectedValue.ToString());
                dataGridView1.Rows.Add(data.Rows[0][0].ToString(),data.Rows[0][1].ToString() , data.Rows[0][3].ToString() , numberamount.Value.ToString());
        }


        private void SaleOrder_Load(object sender, EventArgs e)
        {
            Billbll b = new Billbll();
            txbID.Text = b.getNewIdBill();
            LoadComboBox();
            

        }
        void LoadComboBox()
        {
            DataTable data = b.getInformation();
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index); // vi tri cua dong duoc chon dau tien
            }
        }
    }
}
