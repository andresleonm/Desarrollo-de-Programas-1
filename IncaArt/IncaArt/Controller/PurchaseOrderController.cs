using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class PurchaseOrderController : DatabaseService
    {
        public PurchaseOrderController(string user,string password) : base(user, password)
        {
        }

        public Result getPurchaseOrders()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_purchase_orders",parameters);
            List<PurchaseOrder> purchase_orders = new List<PurchaseOrder>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    purchase_orders.Add(new PurchaseOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)), r.getColumn(3),
                                        r.getColumn(4), r.getColumn(5), double.Parse(r.getColumn(6)), r.getColumn(7), r.getColumn(8), DateTime.Parse(r.getColumn(9)),
                                        r.getColumn(10), r.getColumn(11),double.Parse(r.getColumn(12)),double.Parse(r.getColumn(13))));
                }
                return new Result(purchase_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getPurchaseOrder(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_user", parameters);
            if (result.success)
            {
                var r = result.data[0];
                PurchaseOrder purchase_order = new PurchaseOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)), r.getColumn(3),
                                        r.getColumn(4), r.getColumn(5), double.Parse(r.getColumn(6)), r.getColumn(7), r.getColumn(8), DateTime.Parse(r.getColumn(9)),
                                        r.getColumn(10), r.getColumn(11), double.Parse(r.getColumn(12)), double.Parse(r.getColumn(13)));
                return new Result(purchase_order, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertPurchaseOrder(PurchaseOrder purchase_order)
        {
            List<Parameter> parameters = new List<Parameter>();            
            parameters.Add(new Parameter("currency", purchase_order.Currency_id.ToString()));
            parameters.Add(new Parameter("supplier", purchase_order.Supplier_id.ToString()));
            parameters.Add(new Parameter("supplier_name", purchase_order.Supplier_name));
            parameters.Add(new Parameter("supplier_address", purchase_order.Supplier_address));
            parameters.Add(new Parameter("supplier_phone", purchase_order.Supplier_phone));
            parameters.Add(new Parameter("amount", purchase_order.Amount.ToString()));
            parameters.Add(new Parameter("status", purchase_order.State));
            parameters.Add(new Parameter("supplier_doi", purchase_order.Supplier_doi));
            parameters.Add(new Parameter("order_date", purchase_order.Creation_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", purchase_order.Observation));
            parameters.Add(new Parameter("external_number", purchase_order.External_number));
            parameters.Add(new Parameter("igv_amount", purchase_order.Igv_amount.ToString()));
            parameters.Add(new Parameter("igv_percentage", purchase_order.Igv_percentage.ToString()));            
            GenericResult result = execute_transaction("insert_purchase_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
