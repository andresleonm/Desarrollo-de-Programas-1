using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class SalesEstimateController: DataService.DatabaseService
    {
        private SalesEstimateLineController sales_estimate_line_controller;

        public SalesEstimateController(string user, string password) : base( user, password)
        {
            sales_estimate_line_controller = new SalesEstimateLineController(user, password);
        }

        public Result getSalesEstimates(int idEstimate = 0, int idClient = 0, string iniDate = "", string endDate = "")
        {
            List<Parameter> parameters = new List<Parameter>();

            GenericResult result = execute_function("get_sales_estimates", parameters);
            List<SalesEstimate> sales_estimates = new List<SalesEstimate>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesEstimateLineController selc = new SalesEstimateLineController(user, password);
                    //var detail = (List<SalesEstimateLine>)selc.getSalesEstimateLines(Int32.Parse(r.getColumn(0))).data;
                    sales_estimates.Add(new SalesEstimate(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                          r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                          r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                          r.getColumn(9), r.getColumn(10), DateTime.Parse(r.getColumn(11)),
                                                          Double.Parse(r.getColumn(12)), r.getColumn(13), null));
                }
                return new Result(sales_estimates, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesEstimate(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));

            GenericResult result = execute_function("get_sales_estimate", parameters);

            if (result.success)
            {
                var r = result.data[0];
                SalesEstimateLineController selc = new SalesEstimateLineController(user, password);
                var detail = (List<SalesEstimateLine>)selc.getSalesEstimateLines(Int32.Parse(r.getColumn(0))).data;

                SalesEstimate sales_estimate = new SalesEstimate(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                          r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                          r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                          r.getColumn(9), r.getColumn(10), DateTime.Parse(r.getColumn(11)),
                                                          Double.Parse(r.getColumn(12)), r.getColumn(13), detail);
                return new Result(sales_estimate, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesEstimatesByClient(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("client_id", id.ToString()));

            GenericResult result = execute_function("get_sales_estimates_by_client", parameters);
            List<SalesEstimate> sales_estimates = new List<SalesEstimate>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesEstimateLineController selc = new SalesEstimateLineController(user, password);
                    //var detail = (List<SalesEstimateLine>)selc.getSalesEstimateLines(Int32.Parse(r.getColumn(0))).data;
                    sales_estimates.Add(new SalesEstimate(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                          r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                          r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                          r.getColumn(9), r.getColumn(10), DateTime.Parse(r.getColumn(11)),
                                                          Double.Parse(r.getColumn(12)), r.getColumn(13), null));
                }
                return new Result(sales_estimates, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getEstimate_by_text_by_client(string text, int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", text));
            parameters.Add(new Parameter("client_id", id.ToString()));

            GenericResult result = execute_function("get_estimate_by_text_by_client", parameters);
            List<Models.SalesEstimate> estimates = new List<Models.SalesEstimate>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    estimates.Add(new Models.SalesEstimate(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                          r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                          r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                          r.getColumn(9), r.getColumn(10), DateTime.Parse(r.getColumn(11)),
                                                          Double.Parse(r.getColumn(12)), r.getColumn(13), null));
                }

                return new Result(estimates, true, "");
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

        public Result insertSalesEstimate(SalesEstimate sales_estimate)
        {
            List<Parameter> parameters = new List<Parameter>();            
            parameters.Add(new Parameter("customer_id", sales_estimate.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_estimate.Customer_name));
            parameters.Add(new Parameter("customer_doi", sales_estimate.Customer_doi));
            parameters.Add(new Parameter("customer_address", sales_estimate.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_estimate.Customer_phone));
            parameters.Add(new Parameter("currency", sales_estimate.Currency_id.ToString()));
            parameters.Add(new Parameter("amount", sales_estimate.Amount.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));            
            parameters.Add(new Parameter("issue_date", sales_estimate.Issue_date.ToString("MM/dd/yyyy hh:mm:ss")));
            parameters.Add(new Parameter("observation", sales_estimate.Observation));

            GenericResult result = execute_transaction("insert_sales_estimate", parameters);
            int id;

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
                    foreach (SalesEstimateLine line in sales_estimate.Lines)
                    {
                        if (line.Quantity != 0)
                        {
                            line.Id = n;
                            line.Estimate_id = id;
                            Result resultLine = sales_estimate_line_controller.insertSalesestimateLine(line);
                            if (!resultLine.success)
                            {
                                deleteSalesEstimate(id);
                                return new Result(null, resultLine.success, resultLine.message);
                            }
                            n++;
                        }
                    }
                    return new Result(id, true, "");
                }
                catch (Exception e)
                {
                    deleteSalesEstimate(id);
                    return new Result(null, false, e.Message);
                }
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteSalesEstimate(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));

            GenericResult result = execute_transaction("delete_sales_estimate", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateSalesEstimate(SalesEstimate sales_estimate)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", sales_estimate.Id.ToString()));
            parameters.Add(new Parameter("currency", sales_estimate.Currency_id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_estimate.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_estimate.Customer_name));
            parameters.Add(new Parameter("customer_address", sales_estimate.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_estimate.Customer_phone));
            parameters.Add(new Parameter("amount", sales_estimate.Amount.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));
            parameters.Add(new Parameter("customer_doi", sales_estimate.Customer_doi));
            parameters.Add(new Parameter("issue_date", sales_estimate.Issue_date.ToString("MM/dd/yyyy hh:mm:ss")));
            parameters.Add(new Parameter("observation", sales_estimate.Observation));

            GenericResult resultU = execute_transaction("update_sales_estimate", parameters);

            if (resultU.success)
            {

                int id = sales_estimate.Id;
                int i = 1;
                Result result;
                foreach (Models.SalesEstimateLine sel in sales_estimate.Lines)
                {
                    if (sel.Id == 0)
                    {
                        sel.Id = id + 1;
                        sel.Estimate_id = sales_estimate.Id;
                        result = sales_estimate_line_controller.insertSalesestimateLine(sel);
                        id++;
                    }
                    else
                        result = sales_estimate_line_controller.updateSalesEstimateLine(sel);

                    if (!result.success)
                    {
                        return new Result(null, result.success, result.message);
                    }
                    i++;
                }

                return new Result("Actualizado", true, "");
            }
            return new Result(null, resultU.success, resultU.message);
        }

        public Result make_production(SalesEstimate sales_estimate)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id",sales_estimate.Id.ToString()));
            GenericResult result = execute_transaction("make_production", parameters);
            if (result.success)
            {
                ProductionOrderController poc = new ProductionOrderController("dp1admin", "dp1admin");
             
                foreach (SalesEstimateLine line in sales_estimate.Lines)
                {
                    ProductionOrder po = new ProductionOrder();
                    po.Product_id = line.Product_id;
                    po.Warehouse_id = line.Prod_warehouse_id;
                    po.Quantity = line.Quantity;
                    po.Estimate_id = sales_estimate.Id;
                    po.Estimate_line = line.Id;
                    po.Begin = DateTime.Now;
                    po.End = DateTime.Now;
                    po.State = "Registrado";
                    po.Unit_id = line.Unit_measure_id;
                    po.Description = "Orden de Produccion Autogenerada para la Cotizacion Nro " + sales_estimate.Id.ToString() + ", para la linea Nro " + line.Id.ToString();
                    poc.insertProductionOrder(po);
                }
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }



        public Result getSalesEstimate_by_filter(SalesEstimate sales_estimate, DateTime init, DateTime end,Boolean equals)
        {
            List<Parameter> parameters = new List<Parameter>();
            if (sales_estimate.Id != -1) parameters.Add(new Parameter("id", sales_estimate.Id.ToString()));
            if (sales_estimate.Customer_name != "") parameters.Add(new Parameter("customer_name", sales_estimate.Customer_name));
            if (init != null) parameters.Add(new Parameter("finit", init.ToString("MM/dd/yyyy")));
            if (!equals)
            {
                if (end != null) parameters.Add(new Parameter("fend", end.ToString("MM/dd/yyyy")));
            }
            GenericResult result = execute_function("get_sales_estimate_by_filter", parameters);
            List<SalesEstimate> sales_estimates = new List<SalesEstimate>();

            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesEstimateLineController selc = new SalesEstimateLineController(user, password);
                    //var detail = (List<SalesEstimateLine>)selc.getSalesEstimateLines(Int32.Parse(r.getColumn(0))).data;
                    sales_estimates.Add(new SalesEstimate(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                          r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                          r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                          r.getColumn(9), r.getColumn(10), DateTime.Parse(r.getColumn(11)),
                                                          Double.Parse(r.getColumn(12)), r.getColumn(13), null));
                }
                return new Result(sales_estimates, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
