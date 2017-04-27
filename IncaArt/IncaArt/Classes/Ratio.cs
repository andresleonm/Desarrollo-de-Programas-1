using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Ratio
    {
        private double value { get; set; }
        private RatioType ratio_type { get; set; }
        private Workstation workstation { get; set; }

        public Ratio(double value,RatioType ratio_type, Workstation workstation)
        {
            this.value = value;
            this.ratio_type = ratio_type;
            this.workstation = workstation;
        }
    }
}
