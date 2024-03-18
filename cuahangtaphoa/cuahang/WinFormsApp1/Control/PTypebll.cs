using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entity;

namespace WinFormsApp1.Control
{
    class PTypebll
    {
        PTypeDB db = new PTypeDB();
        public DataTable getType()
        {
            return db.getType();
        }
        public bool AddType(PTypeControl control)
        {
            return db.AddType(control);
        }
        public bool UpdateType(PTypeControl control)
        {
            return db.UpdateType(control);  
        }
        public bool DeleteType(string id)
        {
           return db.DeleteType(id);
        }
        public DataTable getSupList()
        {
            return db.getSupplierList();
        }
    }
}
