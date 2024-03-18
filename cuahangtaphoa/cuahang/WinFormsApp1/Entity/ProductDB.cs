using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Control;

namespace WinFormsApp1.Entity
{

    class ProductDB : ConnectDB
    {
        public ProductDB()
        {
            ConnectDB db = new ConnectDB();
        }
        // 5 phương thức này lấy từ sequence của chức năng product management
        public DataTable getProduct()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM product", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool AddProduct(ProductControl control)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO product(id, name, type, saleprice, purchaseprice, status, quantity) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    control.id, control.name, control.type, control.saleprice, control.purchaseprice, control.status, control.quantity);
                //MessageBox.Show(SQL);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool UpdateProduct(ProductControl control)
        {

            string sql = "";
            try
            {
                conn.Open();
                sql = string.Format("UPDATE product SET id = '{0}', name = '{1}', type= '{2}', saleprice= {3}, purchaseprice= {4}, status= '{5}', quantity= {6}  WHERE id = '{0}' "
                   , control.id, control.name, control.type, control.saleprice, control.purchaseprice, control.status, control.quantity);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool DeleteProduct(string id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("DELETE FROM  product WHERE id = '{0}'", id);
                MySqlCommand mySql = new MySqlCommand(sql, conn);
                if (mySql.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable getType()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM producttype", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // 2 phương thức này lấy từ sequence của sale order
        public DataTable getInformation()
        {
            string sql = "SELECT * FROM product";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable getInforById(string id)
        {
            string sql = "SELECT * FROM product where id = '"+id+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    } 
   }

