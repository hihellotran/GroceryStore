using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Control;
using WinFormsApp1.Model;

namespace WinFormsApp1.Entity
{
    class PTypeDB : ConnectDB
    {
        public PTypeDB()
        {
            ConnectDB db = new ConnectDB();
        }
        public DataTable getType()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM producttype", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool AddType(PTypeControl control)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO producttype(id, name,id_sup) VALUES ('{0}', '{1}', '{2}')",
                    control.id, control.name, control.id_sup);
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
        
        public bool UpdateType(PTypeControl control)
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE producttype SET id = '{0}', name = '{1}', id_sup= '{2}'  WHERE id = '{0}' "
                    , control.id, control.name, control.id_sup);
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
        public bool DeleteType(string id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("DELETE FROM  producttype WHERE id = '{0}'", id);
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
        public DataTable getSupplierList()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM supplier", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
