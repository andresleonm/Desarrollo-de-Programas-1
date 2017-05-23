using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Supplier
    {
        string supplier_name;
        string supplier_addres;

        public Supplier(string supplier_name)
        {
            this.supplier_name = supplier_name;
        }

        public string Supplier_name
        {
            get
            {
                return supplier_name;
            }

            set
            {
                supplier_name = value;
            }
        }

        public string Supplier_addres
        {
            get
            {
                return supplier_addres;
            }

            set
            {
                supplier_addres = value;
            }
        }
    }
}
