using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class FunctionalityController : DatabaseService
    {
        public FunctionalityController(string user, string password) : base(user, password)
        {

        }

        public Result getFunctionalities()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_functionalities", parameters);

            if (result.success)
            {
                List<Functionality> functionalities = new List<Functionality>();

                foreach (Row row in result.data)
                {
                    functionalities.Add(new Functionality(Int32.Parse(row.getColumn(0)), row.getColumn(1), row.getColumn(2)));
                }

                return new Result(functionalities, true, "");
            }

            return new Result(null, false, result.message);
        }
    }
}
