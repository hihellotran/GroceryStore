using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Control;

namespace WinFormsApp1.bll
{
    class Supplierbll
    {
        SupplierDB supplier = new SupplierDB();
        public DataTable getSup()
        {
            return supplier.getSup();
        }
        public bool AddSup(SupplierModel model)
        {
            return supplier.AddSup(model);
        }
        public bool UpdateSup(SupplierModel model)
        {
            return supplier.UpDateSup(model);
        }
        public bool DeleteSup(string id)
        {
            return supplier.DeleteSup(id);
        }
    }
}
