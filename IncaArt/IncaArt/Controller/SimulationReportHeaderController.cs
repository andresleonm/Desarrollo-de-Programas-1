using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class SimulationReportHeaderController : DataService.DatabaseService
    {
        public SimulationReportHeaderController(string user, string password) : base(user, password)
        {
        }

        public Result getSimulationReportHeaders()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_simulation_report_headers", parameters);
            List<SimulationReportHeader> simulation_report_headers = new List<SimulationReportHeader>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    simulation_report_headers.Add(new SimulationReportHeader(int.Parse(r.columns[0])));
                }
                return new Result(simulation_report_headers, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSimulationReportHeader()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_transaction("insert_simulation_report_header", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
