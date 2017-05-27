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
                    sales_orders.Add(new SalesOrder(Int32.Parse(r.getColumn(0)), r.getColumn(3), r.getColumn(10), DateTime.Parse(r.getColumn(9)), DateTime.Parse(r.getColumn(11)), Double.Parse(r.getColumn(6)), r.getColumn(7)));
                }
                return new Result(sales_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
