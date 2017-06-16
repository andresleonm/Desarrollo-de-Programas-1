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

        public Result getCurrencies(Models.Currency param)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (param.Name != "") parameters.Add(new Parameter("name", param.Name));
            if (param.Symbol != "") parameters.Add(new Parameter("symbol", param.Name));
            
            GenericResult result = execute_function("get_currencies2", parameters);
            List<Models.Currency> ps = new List<Models.Currency>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    ps.Add(new Models.Currency(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)));
                }
                return new Result(ps, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertCurrency(Models.Currency currency)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("symbol", currency.Symbol));
            parameters.Add(new Parameter("name", currency.Name));
            parameters.Add(new Parameter("state", currency.State.ToString()));
            GenericResult result = execute_transaction("insert_currency", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateCurrency(Models.Currency currency)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", currency.Id.ToString()));
            parameters.Add(new Parameter("symbol", currency.Symbol));
            parameters.Add(new Parameter("name", currency.Name));
            parameters.Add(new Parameter("state", currency.State));
            GenericResult result = execute_transaction("update_currency", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result deleteCurrency(Models.Currency param)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", param.Id.ToString()));
            GenericResult result = execute_transaction("delete_currency", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
