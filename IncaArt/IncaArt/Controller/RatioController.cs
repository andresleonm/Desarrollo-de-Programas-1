using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class RatioController : DataService.DatabaseService
    {
        public RatioController(string user, string password) : base(user, password)
        {

        }
        public Result getRatios(string workerid)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("worker_id",workerid));
            GenericResult result = execute_function("get_ratios", parameters);
            List<Models.Ratio> ratios = new List<Models.Ratio>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    Models.Ratio ratio=new Models.Ratio();
                    ratio.worker_id = Int32.Parse( r.getColumn(0));
                    ratio.workstation_id = Int32.Parse(r.getColumn(1));
                    ratio.ratio_type = Int32.Parse(r.getColumn(2));
                    ratio.value = Double.Parse(r.getColumn(3));
                    ratios.Add(ratio);
                }
                return new Result(ratios, true, "");
            }
            return new Result(null, result.success, result.message);
        }

      
    }
}
