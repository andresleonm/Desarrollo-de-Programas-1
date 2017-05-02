using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    [Serializable]
    class Product
    {
        public string name { get; set; }
        public int stock { get; set; }
        public double unit_price { get; set; }
        public List<string> production_line { get; set; }

        public Product()
        {

        }

        public Product(string name,int stock,double unit_price)
        {
            this.name = name;
            this.stock = stock;
            this.unit_price = unit_price;
            if(name == "Ceramico")
            {
                List<string> line = new List<string>();
                line.Add("MoldeadoC");
                line.Add("PintadoC");
                line.Add("Horneado");
                this.production_line = line;
            }
            else if(name == "Piedra")
            {
                List<string> line = new List<string>();
                line.Add("Tallado");
                this.production_line = line;
            }
            else if(name == "Retablo")
            {
                List<string> line = new List<string>();
                line.Add("MoldeadoR");
                line.Add("PintadoR");                
                this.production_line = line;
            }
        }
    }
}
