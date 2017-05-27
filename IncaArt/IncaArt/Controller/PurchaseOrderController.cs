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
                    purchase_orders.Add(new PurchaseOrder());
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
                PurchaseOrder purchase_order = new PurchaseOrder();
                return new Result(purchase_order, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        //public Result insertPurchaseOrder(PurchaseOrder purchase_order)
        //{
        //    List<Parameter> parameters = new List<Parameter>();
        //    parameters.Add(new Parameter("id", purchase_order.Id.ToString()));
        //    //parameters.Add(new Parameter("order",purchase_order.))
        //}
    }
}
