using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class WorkstationsController : DataService.DatabaseService
    {
        public WorkstationsController(string user, string password) : base(user, password)
        {

        }
        public Result getWorkstations()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_workstations", parameters);
            List<Models.Workstation> workstations = new List<Models.Workstation>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    Models.Workstation workstation=new Models.Workstation();
                    workstation.Id = Int32.Parse(r.getColumn(0));
                    workstation.Product_id = Int32.Parse(r.getColumn(1));
                    workstation.Previous_workstation = Int32.Parse(r.getColumn(2));
                    workstation.Next_workstation = Int32.Parse(r.getColumn(3));
                    workstation.Name = r.getColumn(4);
                    workstations.Add(workstation);
                }
                return new Result(workstations, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getWorkstation(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_workstation", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Workstation workstation = new Models.Workstation();
                workstation.Id = Int32.Parse(r.getColumn(0));
                workstation.Product_id = Int32.Parse(r.getColumn(1));
                workstation.Previous_workstation = Int32.Parse(r.getColumn(2));
                workstation.Next_workstation = Int32.Parse(r.getColumn(3));
                workstation.Name = r.getColumn(4);
                workstation.Quantity = Int32.Parse(r.getColumn(5));
                return new Result(workstation, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertWorkstation(Models.Workstation workstation)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("product_id", workstation.Product_id.ToString()));
            parameters.Add(new Parameter("previous_workstation", workstation.Previous_workstation.ToString()));
            parameters.Add(new Parameter("next_workstation", workstation.Next_workstation.ToString()));
            parameters.Add(new Parameter("name", workstation.Name));
            parameters.Add(new Parameter("quantity", workstation.Quantity.ToString()));
            GenericResult result = execute_transaction("insert_workstation", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateWorkstation(Models.Workstation workstation)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", workstation.Id.ToString()));
            parameters.Add(new Parameter("product_id", workstation.Product_id.ToString()));
            parameters.Add(new Parameter("previous_workstation", workstation.Previous_workstation.ToString()));
            parameters.Add(new Parameter("next_workstation", workstation.Next_workstation.ToString()));
            parameters.Add(new Parameter("name", workstation.Name));
            parameters.Add(new Parameter("quantity", workstation.Quantity.ToString()));
            GenericResult result = execute_transaction("update_workstation", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteWorkstation(Models.Workstation workstation)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", workstation.Id.ToString()));
            GenericResult result = execute_transaction("delete_workstation", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
