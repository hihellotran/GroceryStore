using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entity;

namespace WinFormsApp1.Control
{
    class Billbll
    {
        BillDB db = new BillDB();
        public string getNewIdBill()
        {
           return db.getNewID();
        }
        public void CreateBill (string id, string date, string id_cus)
        {
            db.CreateNewBill(id, date, id_cus);
        }
        public void AddBillDetail(string id_product, string id_bill, string quantity)
        {
            db.AddBillDetail(id_product, id_bill, quantity);
        }
        public DataTable getDetailsOfBillById(string id)
        {
            return db.getDetailsOfBillById(id);      
        }
    }
}
