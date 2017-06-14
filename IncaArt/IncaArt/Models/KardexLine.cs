using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class KardexLine
    {
        public string codeProduct { get; set; }
        public string product { get; set; }
        public string warehouse { get; set; }
        public string movement_type { get; set; }
        public string sign { get; set; }
        public int quantity { get; set; }
        public string fecha { get; set; }
        public int sal_ini { get; set; }
        public KardexLine(string codeProduct, string product, string warehouse, string movement_type, string sign,
                        int quantity, string fecha,string sal_ini)
        {
            this.codeProduct = codeProduct;
            this.product = product;
            this.warehouse = warehouse;
            this.movement_type = movement_type;
            this.sign = sign;
            this.quantity = quantity;
            this.fecha = fecha;
            if (sal_ini == "")
                this.sal_ini = 0;
            else
                this.sal_ini = Int32.Parse(sal_ini);
        }

        public string  Cells(int j)
        {
            
            if (j == 0) return warehouse;
            if (j == 1) return movement_type;
            if (j == 2) return quantity.ToString();
            if (j == 3) return fecha.ToString();
            return "";
        }
    }
}

