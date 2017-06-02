using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Ratio
    {

        public double value { get; set; }
        public int workstation_id;
        public string type { get; set; }
        public string unit { get; set; }
        public Workstation workstation { get; set; }

        public Ratio()
        {

        }

        public Ratio(double value, string ratio_type, Workstation workstation)
        {
            this.value = value;
            this.type = ratio_type;
            this.workstation = workstation;
        }

    }
}
