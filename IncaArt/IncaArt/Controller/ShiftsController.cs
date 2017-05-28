using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ShiftsController : DataService.DatabaseService
    {
        public ShiftsController(string user, string password) : base(user, password)
        {

        }

        public Result getShifts()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_shifts", parameters);
            List<Models.Shift> shifts = new List<Models.Shift>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    shifts.Add(new Models.Shift(int.Parse(r.getColumn(0)), r.getColumn(1)));
                }
                return new Result(shifts, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getShift(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_shift", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Shift shift = new Models.Shift(int.Parse(r.getColumn(0)), r.getColumn(1));
                return new Result(shift, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
