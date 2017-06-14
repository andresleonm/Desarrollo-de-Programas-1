using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class PurchaseOrderLineController : DatabaseService
    {
        public PurchaseOrderLineController(string user, string password):base(user,password){

        }

        public Result getPurchaseOrderLines(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("purchase_order_id", id.ToString()));
            GenericResult result = execute_function("get_purchase_order_lines", parameters);
            List<PurchaseOrderLine> lines = new List<PurchaseOrderLine>();
            if (result.success)
            {
                foreach(Row r in result.data)
                {
                    lines.Add(new PurchaseOrderLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)), int.Parse(r.getColumn(3)),
                              double.Parse(r.getColumn(4)), DateTime.Parse(r.getColumn(5)),r.getColumn(6),Int32.Parse(r.getColumn(7)), Int32.Parse(r.getColumn(8)),
                              Int32.Parse(r.getColumn(10)),double.Parse(r.getColumn(9))));
                }

                return new Result(lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertPurchaseOrderLine(PurchaseOrderLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("purchase_order_id", line.Purchase_order.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_of_measure.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Price.ToString()));
            parameters.Add(new Parameter("scheduled_date", line.Scheluded_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("state", "ACTIVE"));         
            parameters.Add(new Parameter("deliver_quantity", line.Deliver_quantity.ToString()));
            parameters.Add(new Parameter("material_id", line.Material.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Warehouse.ToString()));
            GenericResult result = execute_transaction("insert_purchase_order_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updatePurchaseOrderLine(PurchaseOrderLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("purchase_order_line_id", line.Id.ToString()));
            parameters.Add(new Parameter("purchase_order_id", line.Purchase_order.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_of_measure.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Price.ToString()));
            parameters.Add(new Parameter("scheduled_date", line.Scheluded_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("state", "ACTIVE"));
            parameters.Add(new Parameter("deliver_quantity", line.Deliver_quantity.ToString()));
            parameters.Add(new Parameter("material_id", line.Material.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Warehouse.ToString()));
            parameters.Add(new Parameter("unit_price", line.Warehouse.ToString()));
            GenericResult result = execute_transaction("update_purchase_order_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
