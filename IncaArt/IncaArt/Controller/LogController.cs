using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class LogController : DatabaseService
    {
        public LogController(string user, string password) : base(user, password)
        {

        }

        public Result getLogs(string startDate, string endDate, string type, string action, string username, string number)
        {
            List<Parameter> parameters = new List<Parameter>();
            if (startDate != "") parameters.Add(new Parameter("start_date", startDate));
            if (endDate != "") parameters.Add(new Parameter("end_date", endDate));
            if (type != "") parameters.Add(new Parameter("type", type));
            if (action != "") parameters.Add(new Parameter("action", action));
            if (username != "") parameters.Add(new Parameter("user_name", username));
            if (number != "") parameters.Add(new Parameter("number", number));

            GenericResult result = execute_function("get_log", parameters);

            if (result.success)
            {
                List<Log> logs = new List<Log>();

                foreach (Row r in result.data)
                {
                    DateTime date = DateTime.ParseExact(r.getColumn(2), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                    logs.Add(new Log(r.getColumn(0), r.getColumn(1), date, r.getColumn(3), r.getColumn(4), r.getColumn(5)));
                }

                return new Result(logs, true, "");
            }

            return new Result(null, false, result.message);
        }
    }
}
