using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class MaterialMovementType
    {
        public int id;
        public String name;
        public char sign;
        public int clase;
        public String state;

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
    }
}
