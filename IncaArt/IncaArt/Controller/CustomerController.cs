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

        public Result insertCustomer(Models.Customer supplier)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", supplier.Name));
            parameters.Add(new Parameter("address", supplier.Address));
            parameters.Add(new Parameter("doi", supplier.Doi));
            parameters.Add(new Parameter("phone", supplier.Phone));
            parameters.Add(new Parameter("email", supplier.Email));
            parameters.Add(new Parameter("type", supplier.Type));
            parameters.Add(new Parameter("priority", supplier.Priority.ToString()));
            parameters.Add(new Parameter("state", supplier.State));
            GenericResult result = execute_transaction("insert_customer", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result updateCustomer(Models.Customer supplier)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", supplier.Id.ToString()));
            parameters.Add(new Parameter("name", supplier.Name));
            parameters.Add(new Parameter("address", supplier.Address));
            parameters.Add(new Parameter("doi", supplier.Doi));
            parameters.Add(new Parameter("phone", supplier.Phone));
            parameters.Add(new Parameter("email", supplier.Email));
            parameters.Add(new Parameter("type", supplier.Type));
            parameters.Add(new Parameter("priority", supplier.Priority.ToString()));
            parameters.Add(new Parameter("state", supplier.State));
            GenericResult result = execute_transaction("update_customer", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
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

        public Result deleteCustomer(Models.Customer supplier)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", supplier.Id.ToString()));
            GenericResult result = execute_transaction("delete_customer", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getCustomers(Models.Customer customer)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (customer.Name != "") parameters.Add(new Parameter("name", customer.Name));
            if (customer.Doi != "") parameters.Add(new Parameter("doi", customer.Doi));
            if (customer.Type != "") parameters.Add(new Parameter("type", customer.Type));
            if (customer.Priority != 0) parameters.Add(new Parameter("priority", customer.Priority.ToString()));
           
            GenericResult result = execute_function("get_customers2", parameters);
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
