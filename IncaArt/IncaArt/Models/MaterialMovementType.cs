using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class MaterialMovementType
    {
        public int id { get; set; }
        public String name { get; set; }
        public char sign { get; set; }
        public int clase { get; set; }
        public String state { get; set; }

        public MaterialMovementType()
        {
        }

        public MaterialMovementType(int id, string name, char sign, int clase, string state)
        {
            this.id = id;
            this.name = name;
            this.sign = sign;
            this.clase = clase;
            this.state = state;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
