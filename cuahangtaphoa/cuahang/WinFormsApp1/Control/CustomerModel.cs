using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    class CustomerModel
    {
      public  string id { get; set; }
      public  string name { get; set; }
      public string address { get; set; }
      public string email { get; set; }
      public string sex { get; set; }
      public  string phone { get; set; }
        public CustomerModel(string id, string name, string address, string email, string sex, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.sex = sex;
            this.phone = phone;
        }
        public CustomerModel()
        {

        }

    }
    
}
