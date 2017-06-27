using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SimulationReportHeader
    {
        public int simulation_report_header_id { get; set; }
        public int accuracy { get; set; }
        public int products { get; set; }

        public SimulationReportHeader(int id,int accuracy,int products)
        {
            this.simulation_report_header_id = id;
            this.accuracy = accuracy;
            this.products = products;
        }

    }
}
