using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.Control
{
    public class ConnectDB
    {
        public MySqlConnection conn;



        public ConnectDB()
        {
            string name = "root";
            string pass = "";
            string database = "cuahang";
            string server = "localhost";
            string nameMysql = "SERVER=" + server + ";" +
                "DATABASE=" + database + ";"
            + "UID=" + name + ";"
            + "PASSWORD=" + pass + ";";
            conn = new MySqlConnection(nameMysql);

            

        }
        public void CloseConect()
        {
            conn.Close();
        }
    }
}