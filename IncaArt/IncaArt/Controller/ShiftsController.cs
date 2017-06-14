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
                    shifts.Add(new Models.Shift(int.Parse(r.getColumn(0)), r.getColumn(1),Convert.ToDateTime(r.getColumn(2)),Convert.ToDateTime(r.getColumn(3)), r.getColumn(4)));
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
                Models.Shift shift = new Models.Shift(int.Parse(r.getColumn(0)), r.getColumn(1), Convert.ToDateTime(r.getColumn(2)), Convert.ToDateTime(r.getColumn(3)), r.getColumn(4));
                return new Result(shift, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        // -- Editar desde aqui **************************************************************

        public Result insertShift(Models.Shift shift)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", shift.Description.ToString()));
            parameters.Add(new Parameter("time_begin", shift.Begin_date.ToString("MM/dd/yyyy H:mm")));
            parameters.Add(new Parameter("time_end", shift.End_date.ToString("MM/dd/yyyy H:mm")));
            parameters.Add(new Parameter("state", shift.State.ToString()));

            GenericResult result = execute_transaction("insert_shift", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateShift(Models.Shift shift)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", shift.Id.ToString()));
            parameters.Add(new Parameter("name", shift.Description.ToString()));
            parameters.Add(new Parameter("time_begin", shift.Begin_date.ToString("MM/dd/yyyy HH:mm")));
            parameters.Add(new Parameter("time_end", shift.End_date.ToString("MM/dd/yyyy HH:mm")));

            GenericResult result = execute_transaction("update_shift", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result deleteShift(Models.Shift shift)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", shift.Id.ToString()));
            GenericResult result = execute_transaction("delete_shift", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result getShifts(Models.Shift shift)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            //if (warehouse.Max_capacity != "") parameters.Add(new Parameter("max_capacity", warehouse.Max_capacity));
            if (shift.Description != "") parameters.Add(new Parameter("name", shift.Description.ToString()));
            //if (shift.Begin_date != Convert.ToDateTime("0:00:00")) parameters.Add(new Parameter("time_begin", shift.Begin_date.ToString("MM/dd/yyyy H:mm")));
            //if (shift.End_date != Convert.ToDateTime("0:00:00")) parameters.Add(new Parameter("time_end", shift.End_date.ToString("MM/dd/yyyy H:mm")));
            
            GenericResult result = execute_function("get_shifts2", parameters);
            List<Models.Shift> shifts = new List<Models.Shift>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    shifts.Add(new Models.Shift(int.Parse(r.getColumn(0)), r.getColumn(1), Convert.ToDateTime(r.getColumn(2)), Convert.ToDateTime(r.getColumn(3)), r.getColumn(4)));

                }
                return new Result(shifts, true, "");
            }
            return new Result(null, result.success, result.message);
        }


    }
}
