using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Control;

namespace WinFormsApp1.Control
{
    class CustomerDB : ConnectDB
    {
        
        public CustomerDB()
        {
            ConnectDB db = new ConnectDB();
        }
        public DataTable getCustomer()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM customer", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool AddCus(CustomerModel model)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO customer(id, name,address, email, sex, phone) VALUES ('{0}', '{1}', '{2}', '{3}','{4}', '{5}')", 
                    model.id, model.name, model.address, model.email, model.sex, model.phone);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception e)
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
        public bool UpDateCus(CustomerModel model)
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE customer SET id = '{0}', name = '{1}', address= '{2}', email= '{3}', sex='{4}', phone= '{5}'  WHERE id = '{0}' "
                    ,model.id, model.name, model.address, model.email, model.sex, model.phone);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }catch(Exception e)
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
        public bool DeleteCus(string id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("DELETE FROM customer WHERE id = '{0}'", id);
                MySqlCommand mySql = new MySqlCommand(sql, conn);
                if(mySql.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }catch(Exception e)
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
        public DataTable SearchByName(string name) 
        {
            DataTable d = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM customer where name = '" + name +"'";    
                MySqlDataAdapter mySqlData = new MySqlDataAdapter(sql, conn);
                mySqlData.Fill(d);
                return d;

            }catch(Exception e)
            {
                return d;
            }
            
        }
        public bool CheckIdCus(string id)
        {
            string sql = "SELECT * FROM customer WHERE id ='" + id +"'";
            MySqlDataAdapter mySqlData = new MySqlDataAdapter(sql, conn);
            DataTable d = new DataTable();
            mySqlData.Fill(d);
            if(d.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
