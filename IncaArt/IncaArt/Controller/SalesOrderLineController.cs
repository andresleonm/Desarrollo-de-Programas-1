using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
     public class SalesOrderLineController: DataService.DatabaseService
    {
        public SalesOrderLineController(string user, string password) : base( user, password)
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
                    var product = (Product)new ProductsController(user, password).getProduct(Int32.Parse(r.getColumn(0))).data;
                    var unitOfMeasure = (UnitOfMeasure)new UnitController(user, password).getUnit(Int32.Parse(r.getColumn(1))).data;

                    var warehouse = (ProductWarehouse)new ProductWarehouseController(user, password).getProductWarehouse(Int32.Parse(r.getColumn(6))).data;
                    sales_order_lines.Add(new SalesOrderLine(product, unitOfMeasure, int.Parse(r.getColumn(2)),
                                                    double.Parse(r.getColumn(3)), r.getColumn(4), int.Parse(r.getColumn(5)),warehouse));
                }
                return new Result(sales_order_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesOrderLine(SalesOrderLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", line.Order_id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure.Id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", line.Status));
            parameters.Add(new Parameter("deliver_quantity", line.Delivery_quantity.ToString()));
            parameters.Add(new Parameter("product_id", line.Product.Name.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Warehouse.Id.ToString()));
            GenericResult result = execute_transaction("insert_sales_order_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
