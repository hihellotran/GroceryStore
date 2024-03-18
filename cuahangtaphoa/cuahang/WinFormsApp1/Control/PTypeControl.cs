using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Control
{
    class PTypeControl
    {
        public string id { get; set; }
        public string name { get; set; }

        public string id_sup { get; set; }

        public PTypeControl(string id, string name, string id_sup)
        {
            this.id = id;
            this.name = name;
            this.id_sup = id_sup;
        }
    }
}
