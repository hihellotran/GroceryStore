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
using WinFormsApp1.Control;

namespace WinFormsApp1
{
    public partial class InvoiceExport : Form
    {
       
        Billbll b = new Billbll();
        public InvoiceExport(string id_bill, string date, string id_cus)
        {

            InitializeComponent();
            tbId.Text = id_bill;
            tbdate.Text = date;
            tbcus.Text = id_cus;
            //MessageBox.Show(id_bill + " " + tbId.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void getData() // su dung bien toan cuc nen khong can truyen tham so
        {
            DataTable dt = new DataTable();
            dt = b.getDetailsOfBillById(tbId.Text);
            dataGridView1.DataSource = dt;
        }
        private void getTotal()
        {
            int sum = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int temp = int.Parse (dataGridView1.Rows[i].Cells[3].Value.ToString());
                sum += temp;
            }
            txbtotal.Text = sum.ToString();
        }
        private void InvoiceExport_Load(object sender, EventArgs e)
        {
            getData();
            getTotal();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintTransaction();
            MessageBox.Show("Successful !");
        }

        public void PrintTransaction()
        {
            try
            {
                FileStream f = new FileStream(@"..\..\..\Entity\transaction.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(f);
                writer.WriteLine("IDBILL:" + tbId.Text + "   Id customer:" + tbcus.Text + "  Date:" + tbdate.Text);
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    writer.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString()+ " " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " " +dataGridView1.Rows[i].Cells[2].Value.ToString() +" "+dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                writer.WriteLine(txbtotal.Text);

                writer.Close();
                f.Close();

            }
            catch (Exception ex)
            {


            }

        }
    }
    
}
