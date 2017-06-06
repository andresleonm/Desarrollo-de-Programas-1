using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    public class SalesRefundController: DataService.DatabaseService
    {
        public SalesRefundController(string user, string password) : base( user, password)
        {
        }

        public Result getSalesRefunds()
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_sales_refunds", parameters);
            List<SalesRefund> refunds = new List<SalesRefund>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    SalesRefundLineController rlc = new SalesRefundLineController(user, password);
                    //var detail = (List<SalesOrderLine>)solc.getSalesOrderLines(Int32.Parse(r.getColumn(0))).data;
                    refunds.Add(new SalesRefund(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10))
                                                        , Double.Parse(r.getColumn(11)), r.getColumn(12),
                                                        Int32.Parse(r.getColumn(13)), null));
                }
                return new Result(refunds, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getSalesRefund(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_sales_refund", parameters);
            if (result.success)
            {
                var r = result.data[0];
                SalesRefundLineController rlc = new SalesRefundLineController(user, password);
                var detail= (List<SalesRefundLine>)rlc.getSalesRefundLines(Int32.Parse(r.getColumn(0))).data;            
                SalesRefund refund = new SalesRefund(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        r.getColumn(2), r.getColumn(3), Int32.Parse(r.getColumn(4)),
                                                        r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8),
                                                        r.getColumn(9), DateTime.Parse(r.getColumn(10)), 
                                                         Double.Parse(r.getColumn(11)),
                                                        r.getColumn(12), Int32.Parse(r.getColumn(13)), detail);
                return new Result(refund, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertSalesRefund(SalesRefund sales_refund)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("currency_id", sales_refund.Currency_id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_refund.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_refund.Customer_name));
            parameters.Add(new Parameter("customer_address", sales_refund.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_refund.Customer_phone));
            parameters.Add(new Parameter("amount", sales_refund.Amount.ToString()));
            parameters.Add(new Parameter("state", sales_refund.Status));
            parameters.Add(new Parameter("customer_doi", sales_refund.Customer_doi));
            parameters.Add(new Parameter("date", sales_refund.Issue_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", sales_refund.Observation));
            parameters.Add(new Parameter("document_id", sales_refund.Refund_reason_id.ToString()));
            GenericResult result = execute_transaction("insert_sales_refund", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateSalesRefund(SalesRefund sales_refund)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", sales_refund.Id.ToString()));
            parameters.Add(new Parameter("currency_id", sales_refund.Currency_id.ToString()));
            parameters.Add(new Parameter("customer_id", sales_refund.Customer_id.ToString()));
            parameters.Add(new Parameter("customer_name", sales_refund.Customer_name));
            parameters.Add(new Parameter("customer_address", sales_refund.Customer_address));
            parameters.Add(new Parameter("customer_phone", sales_refund.Customer_phone));
            parameters.Add(new Parameter("amount", sales_refund.Amount.ToString()));
            parameters.Add(new Parameter("state", sales_refund.Status));
            parameters.Add(new Parameter("customer_doi", sales_refund.Customer_doi));
            parameters.Add(new Parameter("date", sales_refund.Issue_date.ToString("MM/dd/yyyy")));
            parameters.Add(new Parameter("observation", sales_refund.Observation));
            parameters.Add(new Parameter("document_id", sales_refund.Refund_reason_id.ToString()));
            GenericResult result = execute_transaction("update_sales_refund", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
