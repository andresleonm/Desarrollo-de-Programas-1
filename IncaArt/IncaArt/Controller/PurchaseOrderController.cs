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

        public Result getPurchaseOrders(int idOrder = 0, int idClient = 0, string iniDate = "", string endDate = "")
        {
            List<Parameter> parameters = new List<Parameter>();

            GenericResult result = execute_function("get_purchase_orders", parameters);
            List<PurchaseOrder> sales_orders = new List<PurchaseOrder>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    sales_orders.Add(new PurchaseOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)),
                                                         Double.Parse(r.getColumn(11)),
                                                        r.getColumn(12), null));
                }
                return new Result(sales_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getPurchaseOrder(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));

            GenericResult result = execute_function("get_purchase_order", parameters);

            if (result.success)
            {
                var r = result.data[0];
                PurchaseOrderLineController solc = new PurchaseOrderLineController(user, password);
                var detail = (List<PurchaseOrderLine>)solc.getPurchaseOrderLines(Int32.Parse(r.getColumn(0))).data;

                PurchaseOrder sales_order = new PurchaseOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)),
                                                        Double.Parse(r.getColumn(11)),
                                                        r.getColumn(12), detail);
                sales_order.Igv_percentage = Double.Parse(r.getColumn(13));
                sales_order.Igv_amount =Double.Parse(r.getColumn(14));
                return new Result(sales_order, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result deletePurchaseOrder(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));

            GenericResult result = execute_transaction("delete_purchase_order", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
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
            parameters.Add(new Parameter("status", purchase_order.Status));
            parameters.Add(new Parameter("supplier_doi", purchase_order.Supplier_doi));
            parameters.Add(new Parameter("order_date", purchase_order.Issue_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", purchase_order.Observation));
            parameters.Add(new Parameter("external_number", ""));
            parameters.Add(new Parameter("igv_amount", purchase_order.Igv_amount.ToString()));
            parameters.Add(new Parameter("igv_percentage", purchase_order.Igv_percentage.ToString()));            
            GenericResult result = execute_transaction("insert_purchase_order", parameters);
            int id;
            var solc = new PurchaseOrderLineController(user, password);
            if (result.success)
            {
                try
                {
                    id = Int32.Parse(result.singleValue);
                }
                catch (Exception e)
                {
                    return new Result(null, false, e.Message);
                }

                try
                {
                    int n = 1;
                    foreach (PurchaseOrderLine line in purchase_order.Lines)
                    {
                        if (line.Quantity != 0)
                        {
                            line.Id = n;
                            line.Order_id = id;
                            Result resultLine = solc.insertPurchaseOrderLine(line);
                            if (!resultLine.success)
                            {
                                deletePurchaseOrder(id);
                                return new Result(null, resultLine.success, resultLine.message);
                            }
                            n++;
                        }
                    }
                    return new Result(id, true, "");
                }
                catch (Exception e)
                {
                    deletePurchaseOrder(id);
                    return new Result(null, false, e.Message);
                }
                
            }
            return new Result(null, result.success, result.message);
        }

        public Result updatePurchaseOrder(PurchaseOrder purchase_order)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", purchase_order.Id.ToString()));
            parameters.Add(new Parameter("currency", purchase_order.Currency_id.ToString()));
            parameters.Add(new Parameter("supplier", purchase_order.Supplier_id.ToString()));
            parameters.Add(new Parameter("supplier_name", purchase_order.Supplier_name));
            parameters.Add(new Parameter("supplier_address", purchase_order.Supplier_address));
            parameters.Add(new Parameter("supplier_phone", purchase_order.Supplier_phone));
            parameters.Add(new Parameter("amount", purchase_order.Amount.ToString()));
            parameters.Add(new Parameter("status", purchase_order.Status));
            parameters.Add(new Parameter("supplier_doi", purchase_order.Supplier_doi));
            parameters.Add(new Parameter("order_date", purchase_order.Issue_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", purchase_order.Observation));
            parameters.Add(new Parameter("external_number", ""));
            parameters.Add(new Parameter("igv_amount", purchase_order.Igv_amount.ToString()));
            parameters.Add(new Parameter("igv_percentage", purchase_order.Igv_percentage.ToString()));
            GenericResult result = execute_transaction("update_purchase_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getWarehousesS(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));

            GenericResult result = execute_function("get_materials_by_id", parameters);
            List<Views.Purchase_Module.MaterialWarehouseS> productWarehouses = new List<Views.Purchase_Module.MaterialWarehouseS>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    productWarehouses.Add(new Views.Purchase_Module.MaterialWarehouseS(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)), r.getColumn(8), r.getColumn(9), Int32.Parse(r.getColumn(10)), Double.Parse(r.getColumn(11))));
                }
                return new Result(productWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getPurchaseOrder_by_filter(PurchaseOrder sales_order, DateTime init, DateTime end, Boolean equals)
        {
            List<Parameter> parameters = new List<Parameter>();
            if (sales_order.Id != -1) parameters.Add(new Parameter("id", sales_order.Id.ToString()));
            if (sales_order.Supplier_name != "") parameters.Add(new Parameter("supplier_name", sales_order.Supplier_name));
            if (init != null) parameters.Add(new Parameter("finit", init.ToString("MM/dd/yyyy")));
            if (!equals)
            {
                if (end != null) parameters.Add(new Parameter("fend", end.ToString("MM/dd/yyyy")));
            }
            GenericResult result = execute_function("get_purchase_order_by_filter", parameters);
            List<PurchaseOrder> sales_orders = new List<PurchaseOrder>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                   
                    //var detail = (List<SalesOrderLine>)solc.getSalesOrderLines(Int32.Parse(r.getColumn(0))).data;
                    sales_orders.Add(new PurchaseOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)),
                                                         Double.Parse(r.getColumn(11)),
                                                        r.getColumn(12), null));
                }
                return new Result(sales_orders, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
