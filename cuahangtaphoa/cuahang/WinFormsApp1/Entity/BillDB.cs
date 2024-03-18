using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Control;

namespace WinFormsApp1.Entity
{
     class BillDB : ConnectDB
    {
        public string getNewID()
        {
            string sql = " SELECT id FROM bill ORDER By id ASC";
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(sql, conn);
            DataTable data = new DataTable();
            mySqlData.Fill(data);
            if (data.Rows.Count == 0)
                return "1";
            else
            {
                int temp = int.Parse(data.Rows[data.Rows.Count - 1][0].ToString())+1; 
                //MessageBox.Show(data.Rows[data.Rows.Count - 1][0].ToString());
                return temp.ToString();
            }
        } 
       public void CreateNewBill(string id, string date, string id_cus)
        {
            try
            {
                string sql = string.Format("insert into bill values ('{0}','{1}','{2}')", id, date, id_cus);
                MySqlCommand mySql = new MySqlCommand(sql, conn);
                conn.Open();
                mySql.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void AddBillDetail(string id_sp, string id_bill, string quantity)
        {

            string sql = string.Format("insert into billdetail values ('{0}','{1}',{2})", id_sp, id_bill, quantity);
            MySqlCommand mySql = new MySqlCommand(sql, conn);
            conn.Open();
            mySql.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getDetailsOfBillById(string id)
        {
            string sql = "SELECT product.name, product.saleprice, billdetail.quantity, (product.saleprice * billdetail.quantity) AS total\r\nFROM product, bill, billdetail " +
                "WHERE product.id = billdetail.id_sp AND bill.id = billdetail.id_bill AND bill.id = '"+id+"'";
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            mySqlData.Fill(dataTable);
            return dataTable;
        }
    }
}
