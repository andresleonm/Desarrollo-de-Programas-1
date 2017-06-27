using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class SimulationReportController : DataService.DatabaseService
    {

        public SimulationReportController(string user, string password) : base(user, password)
        {

        }

        public Result getSimulationReports()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_simulation_reports", parameters);
            List<SimulationReport> simulation_reports = new List<SimulationReport>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    simulation_reports.Add(new SimulationReport(int.Parse(r.columns[0]),r.columns[1],r.columns[2],r.columns[3],r.columns[4],r.columns[5],r.columns[6]));
                }
                return new Result(simulation_reports, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result inserSimulationReport(SimulationReport simulation_report)
        {
            List<Parameter> parameters = new List<Parameter>();            
            parameters.Add(new Parameter("worker", simulation_report.worker));
            parameters.Add(new Parameter("workstation", simulation_report.workstation));
            parameters.Add(new Parameter("product", simulation_report.product));
            parameters.Add(new Parameter("accuracy", simulation_report.accuracy));
            parameters.Add(new Parameter("products_per_hour", simulation_report.products_per_hour));
            parameters.Add(new Parameter("product_line", simulation_report.product_line));
            GenericResult result = execute_transaction("insert_simulation_report", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
