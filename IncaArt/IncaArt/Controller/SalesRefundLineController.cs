using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
     public class SalesRefundLineController: DataService.DatabaseService
    {
        public SalesRefundLineController(string user, string password) : base( user, password)
        {
        }

        public Result getSalesOrderLines(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", id.ToString()));
             GenericResult result = execute_function("get_sales_order_lines", parameters);
            List<SalesOrderLine> sales_order_lines = new List<SalesOrderLine>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    sales_order_lines.Add(new SalesOrderLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)),
                                                    r.getColumn(3), Int32.Parse(r.getColumn(4)), r.getColumn(5), int.Parse(r.getColumn(6)), 
                                                    double.Parse(r.getColumn(7)), int.Parse(r.getColumn(8)), Int32.Parse(r.getColumn(9)), r.getColumn(10), r.getColumn(11)));
                }
                return new Result(sales_order_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesOrderLine(SalesOrderLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", line.Order_id.ToString()));
            parameters.Add(new Parameter("order_detail_id", line.Id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure_id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", line.Status));
            parameters.Add(new Parameter("deliver_quantity", line.Delivery_quantity.ToString()));
            parameters.Add(new Parameter("product_id", line.Product_id.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Prod_warehouse_id.ToString()));
            GenericResult result = execute_transaction("insert_sales_order_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateSalesOrderLine(SalesOrderLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", line.Order_id.ToString()));
            parameters.Add(new Parameter("order_detail_id", line.Id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure_id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", line.Status));
            parameters.Add(new Parameter("deliver_quantity", line.Delivery_quantity.ToString()));
            parameters.Add(new Parameter("product_id", line.Product_id.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Prod_warehouse_id.ToString()));
            GenericResult result = execute_transaction("update_sales_order_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
