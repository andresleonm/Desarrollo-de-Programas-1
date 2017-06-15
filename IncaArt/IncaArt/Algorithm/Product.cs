using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorithm
{
    public class Product
    {
        public string name { get; set; }
        public string type { get; set; }
        public int stock { get; set; }
        public double unit_price { get; set; }
        public List<string> production_line { get; set; }

        public Product()
        {

        }

        public Product(string name, int stock, double unit_price)
        {
            this.name = name;
            this.stock = stock;
            this.unit_price = unit_price;
            if (name.ToLower() == "ceramico")
            {
                List<string> line = new List<string>();
                line.Add("MoldeadoC");
                line.Add("PintadoC");
                line.Add("Horneado");
                this.production_line = line;
            }
            else if (name.ToLower() == "piedra")
            {
                List<string> line = new List<string>();
                line.Add("Tallado");
                this.production_line = line;
            }
            else if (name.ToLower() == "retablo")
            {
                List<string> line = new List<string>();
                line.Add("MoldeadoR");
                line.Add("PintadoR");
                this.production_line = line;
            }
        }

        public Product(string name, int stock, double unit_price,string type)
        {
            this.name = name;
            this.stock = stock;
            this.unit_price = unit_price;
            this.type = type;
            if (name.ToLower() == "ceramico")
            {
                List<string> line = new List<string>();
                line.Add("MoldeadoC");
                line.Add("PintadoC");
                line.Add("Horneado");
                this.production_line = line;
            }
            else if (name.ToLower() == "piedra")
            {
                List<string> line = new List<string>();
                line.Add("Tallado");
                this.production_line = line;
            }
            else if (name.ToLower() == "retablo")
            {
                List<string> line = new List<string>();
                line.Add("MoldeadoR");
                line.Add("PintadoR");
                this.production_line = line;
            }
        }
    }


}
