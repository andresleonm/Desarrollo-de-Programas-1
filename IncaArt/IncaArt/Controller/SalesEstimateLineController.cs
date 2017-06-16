using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class SalesEstimateLineController: DataService.DatabaseService
    {
        public SalesEstimateLineController(string user, string password) : base( user, password)
        {            
        }

        public Result getSalesEstimateLines(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("estimate_id", id.ToString()));
            GenericResult result = execute_function("get_sales_estimate_lines", parameters);
            List<SalesEstimateLine> sales_estimate_lines = new List<SalesEstimateLine>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    sales_estimate_lines.Add(new SalesEstimateLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)),
                                                    r.getColumn(3), Int32.Parse(r.getColumn(4)), r.getColumn(5), int.Parse(r.getColumn(6)),
                                                    double.Parse(r.getColumn(7)), Int32.Parse(r.getColumn(8)), r.getColumn(9), r.getColumn(10)));
                }
                return new Result(sales_estimate_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesestimateLine(SalesEstimateLine line)
        {
            if (line.Quantity <= 0)
                return new Result("TRUE", true, "");
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("estimate_id", line.Estimate_id.ToString()));
            parameters.Add(new Parameter("estimate_detail_id", line.Id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure_id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));
            parameters.Add(new Parameter("product_id", line.Product_id.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Prod_warehouse_id.ToString()));
            GenericResult result = execute_transaction("insert_sales_estimate_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateSalesEstimateLine(SalesEstimateLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("estimate_id", line.Estimate_id.ToString()));
            parameters.Add(new Parameter("estimate_detail_id", line.Id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure_id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));
            parameters.Add(new Parameter("product_id", line.Product_id.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Prod_warehouse_id.ToString()));
            GenericResult result = execute_transaction("update_sales_estimate_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
