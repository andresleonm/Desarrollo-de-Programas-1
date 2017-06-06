using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorithm
{
    class RatioType
    {

        public string type { get; set; }
        public string unit { get; set; }

        public RatioType()
        {

        }

        public RatioType(string description, string unit)
        {
            this.type = description;
            this.unit = unit;
        }

    }
}
