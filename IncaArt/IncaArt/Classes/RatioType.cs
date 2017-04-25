using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class RatioType
    {
        private string description { get; set; }
        private string unit { get; set; }

        public RatioType(string description,string unit)
        {
            this.description = description;
            this.unit = unit;
        }
    }
}
