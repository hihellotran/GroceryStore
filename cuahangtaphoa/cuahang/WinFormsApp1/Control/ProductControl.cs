using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Control
{
    class ProductControl
    {
        public string id { get; set; }
        public string name { get; set; }    
        public string type { get; set; }
        public int saleprice { get; set; }
        public int purchaseprice { get; set; }
        public string status { get; set; }
        public int quantity { get; set; }

       public ProductControl(string id, string name, string type, int saleprice, int purchaseprice, string status, int quantity)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.saleprice = saleprice;
            this.purchaseprice = purchaseprice;
            this.status = status;
            this.quantity = quantity;
        }
    }
}
