using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Ratio
    {
        public double value { get; set; }
        public int workstationid;
        public string type { get; set; }
        public string unit { get; set; }
        public Workstation workstation { get; set; }

        public Ratio()
        {

        }

        public Ratio(double value,string ratio_type, Workstation workstation)
        {
            this.value = value;
            this.type = ratio_type;
            this.workstation = workstation;
        }
    }
}
