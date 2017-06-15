using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class KardexController : DatabaseService
    {
        public KardexController(string user, string password) : base(user, password)
        {

        }
        public Result getMovements(string fecha_ini,string fecha_fin)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("fec_ini", fecha_ini));
            parameters.Add(new Parameter("fec_fin", fecha_fin));

            GenericResult result = execute_function("kardex", parameters);

            if (result.success)
            {
                List<KardexLine> functionalities = new List<KardexLine>();

                foreach (Row row in result.data)
                {
                    functionalities.Add(new KardexLine(row.getColumn(0), row.getColumn(1), row.getColumn(2),
                                                    row.getColumn(3), row.getColumn(4), Int32.Parse(row.getColumn(5)),
                                                    row.getColumn(6), row.getColumn(7)
                        ));
                }

                return new Result(functionalities, true, "");
            }

            return new Result(null, false, result.message);
        }
    }
}
