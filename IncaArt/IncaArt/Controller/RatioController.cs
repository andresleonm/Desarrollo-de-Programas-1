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

        public Result getRatios(string worker_name,string paternal,string maternal,int workstation_id,int product_id,int radio_type_id)
        {
            List<Parameter> parameters = new List<Parameter>();
            if (!worker_name.Equals(""))parameters.Add(new Parameter("worker_name", worker_name));
            if (!paternal.Equals("")) parameters.Add(new Parameter("paternal_name", paternal));
            if (!maternal.Equals("")) parameters.Add(new Parameter("maternal_name", maternal));
            if (workstation_id!=0) parameters.Add(new Parameter("workstation_id", workstation_id.ToString()));
            if (product_id!=0) parameters.Add(new Parameter("product_id", product_id.ToString()));
            if (radio_type_id!=0) parameters.Add(new Parameter("ratio_type_id", radio_type_id.ToString()));
            GenericResult result = execute_function("get_ratios2", parameters);
            List<Models.Ratio> ratios = new List<Models.Ratio>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //W."WORKER_ID",        0
                    //P."PRODUCT_ID",       1
                    //WS."WORKSTATION_ID",  2
                    //RT."RATIO_TYPE_ID",   3
                    //R."RATIO_TYPE_VALUE"  4
                    Models.Ratio ratio = new Models.Ratio();
                    ratio.worker_id = Int32.Parse(r.getColumn(0));
                    ratio.product_id = Int32.Parse(r.getColumn(1));
                    ratio.workstation_id = Int32.Parse(r.getColumn(2));
                    ratio.ratio_type = Int32.Parse(r.getColumn(3));
                    ratio.value = Double.Parse(r.getColumn(4));
                    ratios.Add(ratio);
                }
                return new Result(ratios, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateRatio(string worker,string product,string workstation,string ratio_type,double ratio_value)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("worker_name", worker));
            parameters.Add(new Parameter("product_name", product));
            parameters.Add(new Parameter("workstation_name", workstation));
            parameters.Add(new Parameter("ratio_type", ratio_type));
            parameters.Add(new Parameter("ratio_value", ratio_value.ToString()));
            GenericResult result = execute_transaction("update_ratio", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
