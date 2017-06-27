using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SimulationReport
    {
        public int simulation_report_id { get; set; }
        public string worker { get; set; }
        public string workstation { get; set; }
        public string product { get; set; }
        public string accuracy { get; set; }
        public string products_per_hour { get; set; }
        public string product_line { get; set; }

        public SimulationReport(int simulation_report_id,string worker,string workstation,string product,string accuracy,string products_per_hour,string product_line)
        {
            this.simulation_report_id = simulation_report_id;
            this.worker = worker;
            this.workstation = workstation;
            this.product = product;
            this.accuracy = accuracy;
            this.products_per_hour = products_per_hour;
            this.product_line = product_line;
        }


    }
}
