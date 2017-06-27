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

        public Result getSalesRefundLines(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("refund_id", id.ToString()));
             GenericResult result = execute_function("get_sales_refund_lines", parameters);
            List<SalesRefundLine> sales_refund_lines = new List<SalesRefundLine>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    sales_refund_lines.Add(new SalesRefundLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)),
                                                    r.getColumn(3), Int32.Parse(r.getColumn(4)), r.getColumn(5), int.Parse(r.getColumn(6)), 
                                                    double.Parse(r.getColumn(7)), int.Parse(r.getColumn(8)), Int32.Parse(r.getColumn(9)), r.getColumn(10), r.getColumn(11), r.getColumn(12)));
                }
                return new Result(sales_refund_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesRefundLine(SalesRefundLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("refund_id", line.Refund_id.ToString()));
            parameters.Add(new Parameter("refund_detail_id", line.Id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure_id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));
            parameters.Add(new Parameter("refund_quantity",0.ToString()));
            parameters.Add(new Parameter("product_id", line.Product_id.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Prod_warehouse_destiny.ToString()));
            parameters.Add(new Parameter("document_line_id", line.Document_id_line.ToString()));
            GenericResult result = execute_transaction("insert_sales_refund_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateSalesRefundLine(SalesRefundLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("refund_id", line.Refund_id.ToString()));
            parameters.Add(new Parameter("refund_detail_id", line.Id.ToString()));
            parameters.Add(new Parameter("unit_of_measure_id", line.Unit_measure_id.ToString()));
            parameters.Add(new Parameter("quantity", line.Quantity.ToString()));
            parameters.Add(new Parameter("price", line.Unit_price.ToString()));
            parameters.Add(new Parameter("state", "Registrado"));
            parameters.Add(new Parameter("refund_quantity", 0.ToString()));
            parameters.Add(new Parameter("product_id", line.Product_id.ToString()));
            parameters.Add(new Parameter("warehouse_id", line.Prod_warehouse_id.ToString()));
            parameters.Add(new Parameter("document_line_id", line.Document_id_line.ToString()));
            GenericResult result = execute_transaction("update_sales_refund_line", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
