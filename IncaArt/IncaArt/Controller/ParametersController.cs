using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ParametersController : DataService.DatabaseService
    {
        public ParametersController(string user, string password) : base(user, password)
        {
        }

        // This is
        public Result getParameters()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_parameters", parameters);
            List<Models.Parameters> parameterL = new List<Models.Parameters>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    parameterL.Add(new Models.Parameters(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)));
                }

                return new Result(parameterL, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getParameter(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_parameter", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Parameters param = new Models.Parameters(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3));
                return new Result(param, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getParameters(Models.Parameters param)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (param.Name != "") parameters.Add(new Parameter("name", param.Name));
           // if (product.Unit_id != 0) parameters.Add(new Parameter("unit_id", product.Unit_id.ToString()));
            GenericResult result = execute_function("get_parameters2", parameters);
            List<Models.Parameters> ps = new List<Models.Parameters>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    ps.Add(new Models.Parameters(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), (r.getColumn(3))));
                }
                return new Result(ps, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result insertParameter(Models.Parameters param)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", param.Name));
            parameters.Add(new Parameter("value", param.Value.ToString()));
            parameters.Add(new Parameter("state", param.State.ToString()));
            GenericResult result = execute_transaction("insert_parameter", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result updateParameter(Models.Parameters param)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", param.Id.ToString()));
            parameters.Add(new Parameter("name", param.Name));
            parameters.Add(new Parameter("value", param.Value));
            parameters.Add(new Parameter("state", param.State));
            GenericResult result = execute_transaction("update_parameter", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteParameter(Models.Parameters param)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", param.Id.ToString()));
            GenericResult result = execute_transaction("delete_parameter", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }


}
