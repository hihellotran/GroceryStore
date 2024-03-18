using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Control
{
    class SupplierDB : ConnectDB
    {
        public SupplierDB() 
        {
            ConnectDB db = new ConnectDB();
        }
        public DataTable getSup()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM supplier", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool AddSup(SupplierModel model)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO supplier(id, name,address, email, phone) VALUES ('{0}', '{1}', '{2}', '{3}','{4}')",
                    model.id, model.name, model.address, model.email, model.phone);
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
        public bool UpDateSup(SupplierModel model)
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE supplier SET id = '{0}', name = '{1}', address= '{2}', email= '{3}', phone= '{4}'  WHERE id = '{0}' "
                    , model.id, model.name, model.address, model.email,model.phone);
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
        public bool DeleteSup(string id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("DELETE FROM supplier WHERE id = '{0}'", id);
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
    }
}
