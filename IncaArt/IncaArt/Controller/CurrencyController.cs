using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class CurrencyController: DataService.DatabaseService
    {
        public CurrencyController(string user, string password) : base(user, password)
        {
        }

        public Result getCurrencies()
        {
            
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_currencies", parameters);
            List<Models.Currency> currencies = new List<Models.Currency>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    currencies.Add(new Models.Currency(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)));
                }

                return new Result(currencies, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result getCurrency(int id)
        {
            
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_currency", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Currency currency = new Models.Currency(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3));
                return new Result(currency, true, "");
            }
            return new Result(null, result.success, result.message);
        }



    }
}
