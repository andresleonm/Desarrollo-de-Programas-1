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

        public Result getSalesOrders(int idOrder=0,int idClient=0,string iniDate="",string endDate = "")
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_sales_orders", parameters);
            List<SalesOrder> sales_orders = new List<SalesOrder>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesOrderLineController solc = new SalesOrderLineController(user, password);
                    //var detail = (List<SalesOrderLine>)solc.getSalesOrderLines(Int32.Parse(r.getColumn(0))).data;
                    sales_orders.Add(new SalesOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
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
            
                SalesOrder sales_order = new SalesOrder(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)), 
                                                        Double.Parse(r.getColumn(11)),
                                                        r.getColumn(12),detail);
                return new Result(sales_order, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getWarehousesS(int id, char class_warehouse)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            parameters.Add(new Parameter("class_warehouse", class_warehouse.ToString()));
            GenericResult result = execute_function("get_productwarehouse_byclass", parameters);
            List<Views.Sales_Module.ProductWarehouseS> productWarehouses = new List<Views.Sales_Module.ProductWarehouseS>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    productWarehouses.Add(new Views.Sales_Module.ProductWarehouseS(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)), r.getColumn(8), r.getColumn(9), Int32.Parse(r.getColumn(10)), Double.Parse(r.getColumn(11))));
                }
                return new Result(productWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesOrder(SalesOrder sales_order)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("currency", sales_order.Currency_id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_order.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_order.Customer_name));
            parameters.Add(new Parameter("customer_address", sales_order.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_order.Customer_phone));
            parameters.Add(new Parameter("amount", sales_order.Amount.ToString()));
            parameters.Add(new Parameter("state", sales_order.Status));
            parameters.Add(new Parameter("customer_doi", sales_order.Customer_doi));
            parameters.Add(new Parameter("issue_date", sales_order.Issue_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", sales_order.Observation));
            GenericResult result = execute_transaction("insert_sales_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateSalesOrder(SalesOrder sales_order)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", sales_order.Id.ToString()));
            parameters.Add(new Parameter("currency", sales_order.Currency_id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_order.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_order.Customer_name));
            parameters.Add(new Parameter("customer_address", sales_order.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_order.Customer_phone));
            parameters.Add(new Parameter("amount", sales_order.Amount.ToString()));
            parameters.Add(new Parameter("state", sales_order.Status));
            parameters.Add(new Parameter("customer_doi", sales_order.Customer_doi));
            parameters.Add(new Parameter("issue_date", sales_order.Issue_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", sales_order.Observation));
            GenericResult result = execute_transaction("update_sales_order", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
