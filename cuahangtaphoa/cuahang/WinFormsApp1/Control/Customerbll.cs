using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Control;
using WinFormsApp1.Model;
namespace WinFormsApp1.bll
{
    class Customerbll
    {
        CustomerDB db = new CustomerDB();
        public DataTable getCus()
        {
            return db.getCustomer();
        }
        public bool AddCus(CustomerModel model)
        {
            return db.AddCus(model);
        }
        public bool UpdateCus(CustomerModel model)
        {
            return db.UpDateCus(model);
        }
        public bool DeleteCus(string id)
        {
            return db.DeleteCus(id);
        }
        public DataTable SearchByName (string name)
        {
            DataTable dt = db.SearchByName(name);
            return dt;
        }
        public bool CheckIdCus(string id)
        {
            return db.CheckIdCus(id);
        }
    }
}
