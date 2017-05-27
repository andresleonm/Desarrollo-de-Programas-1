using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class UnitController : DataService.DatabaseService
    {
        public UnitController(string user, string password) : base(user, password)
        {
            
        }

        public Result getUnits()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_units", parameters);
            List<Models.UnitOfMeasure> units = new List<Models.UnitOfMeasure>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    units.Add(new Models.UnitOfMeasure(int.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2)));
                }
                return new Result(units, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getUnit(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_unit", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.UnitOfMeasure unit = new Models.UnitOfMeasure(int.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2));
                return new Result(unit, true, "");
            }
            return new Result(null, result.success, result.message);
        }


    }
}
