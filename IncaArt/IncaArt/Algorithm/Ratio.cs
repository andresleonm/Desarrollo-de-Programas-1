using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Algorithm
{
    public class Ratio
    {

        public double value { get; set; }
        public int workstationid;
        public string type { get; set; }
        public string unit { get; set; }
        public int produced_quantity { get; set; }
        public int broken_quantity { get; set; }
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

        public Ratio(double value, string ratio_type, Workstation workstation, int produced_quantity, int broken_quantity)
        {
            this.value = value;
            this.type = ratio_type;
            this.workstation = workstation;
            this.produced_quantity = produced_quantity;
            this.broken_quantity = broken_quantity;
        }

    }
}
