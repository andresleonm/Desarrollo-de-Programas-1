using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Ratio
    {
        internal double value { get; set; }
        internal RatioType ratio_type { get; set; }
        internal Workstation workstation { get; set; }

        public Ratio(double value,RatioType ratio_type, Workstation workstation)
        {
            this.value = value;
            this.ratio_type = ratio_type;
            this.workstation = workstation;
        }
    }
}
