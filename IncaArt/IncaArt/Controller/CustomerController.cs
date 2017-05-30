using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class CustomerController : DataService.DatabaseService
    {
        public CustomerController(string user, string password) : base(user, password)
        {
        }

        public Result getCustomers()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_customers", parameters);
            List<Models.Customer> customers = new List<Models.Customer>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    customers.Add(new Models.Customer(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6),
                                                    Int32.Parse(r.getColumn(7)),r.getColumn(8)));
                }
                
                return new Result(customers, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getCustomer(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_customer", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Customer customer = new Models.Customer(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6),
                                                    Int32.Parse(r.getColumn(7)),r.getColumn(8));
                return new Result(customer, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getCustomer_by_text(string text)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", text));
            GenericResult result = execute_function("get_customer_by_name", parameters);
            List<Models.Customer> customers = new List<Models.Customer>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    customers.Add(new Models.Customer(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3), r.getColumn(4), r.getColumn(5), r.getColumn(6),
                                                    Int32.Parse(r.getColumn(7)), r.getColumn(8)));
                }

                return new Result(customers, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
