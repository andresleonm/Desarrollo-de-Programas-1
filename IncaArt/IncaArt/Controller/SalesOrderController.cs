using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    public class SalesOrderController: DataService.DatabaseService
    {
        public SalesOrderController(string user, string password) : base( user, password)
        {
        }

        public Result getSalesOrders()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_sales_orders", parameters);
            List<SalesOrder> sales_orders = new List<SalesOrder>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    sales_orders.Add(new SalesOrder(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2),
                                                    DateTime.Parse(r.getColumn(3)), DateTime.Parse(r.getColumn(4)), 
                                                    double.Parse(r.getColumn(5)), r.getColumn(6)));
                }
                return new Result(sales_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesOrder(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_sales_order", parameters);
            if (result.success)
            {
                var r = result.data[0];
                SalesOrderLineController solc = new SalesOrderLineController(user, password);
                var detail= (List<SalesOrderLine>)solc.getSalesOrderLines(Int32.Parse(r.getColumn(0))).data;
            
                SalesOrder sales_order = new SalesOrder(Int32.Parse(r.getColumn(0)),null,
                                                        null, r.getColumn(3), r.getColumn(4),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7),
                                                         DateTime.Parse(r.getColumn(8)), DateTime.Parse(r.getColumn(9)),Double.Parse(r.getColumn(10)),
                                                        r.getColumn(11),detail);
                return new Result(sales_order, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesOrder(SalesOrder sales_order)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("currency", sales_order.Currency.Id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_order.Client.Id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_order.Client_name));
            parameters.Add(new Parameter("customer_address", sales_order.Client_address));
            parameters.Add(new Parameter("customer_phone", sales_order.Client_phone));
            parameters.Add(new Parameter("amount", sales_order.Amount.ToString()));
            parameters.Add(new Parameter("state", sales_order.Status));
            parameters.Add(new Parameter("customer_doi", sales_order.Client_doi));
            parameters.Add(new Parameter("date", sales_order.Issue_date.ToShortDateString()));
            parameters.Add(new Parameter("observation", sales_order.Observation));
            parameters.Add(new Parameter("delivery_date", sales_order.Delivery_date.ToShortDateString()));
            GenericResult result = execute_transaction("insert_sales_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
