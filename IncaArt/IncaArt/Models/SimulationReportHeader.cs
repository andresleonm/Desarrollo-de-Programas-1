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

        public SimulationReportHeader(int id)
        {
            this.simulation_report_header_id = id;
        }

    }
}
