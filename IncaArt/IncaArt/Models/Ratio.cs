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
        public int produced_quantity { get; set; }
        public int broken_quantity { get; set; }
        public int workstation_id { get; set; }
        public int ratio_type { get; set; }
        public int worker_id { get; set; }
        public int product_id { get; set; }
        public Ratio()
        {

        }


    }
}
