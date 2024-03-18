using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entity;

namespace WinFormsApp1.Control
{
    internal class Productbll
    {

        ProductDB db = new ProductDB();
        // 5 phương thức sử dụng cho product management
        public DataTable getProduct()
        {
            return db.getProduct();
        }
        public bool AddProduct(ProductControl control)
        {
            return db.AddProduct(control);
        }
        public bool UpdateProduct(ProductControl control)
        {
            return db.UpdateProduct(control);
        }
        public bool DeleteProduct(string id)
        {
            return db.DeleteProduct(id);
        }
        public DataTable getType()
        {
            return db.getType();
        }
        // 2 phương thức sử dụng cho sale order
        public DataTable getInformation()
        {
            return db.getInformation();
        }
        public DataTable getInforById(String id)
        {
            return db.getInforById(id);
        }
    }
}
