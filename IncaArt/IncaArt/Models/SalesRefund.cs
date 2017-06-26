using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesRefund
    {        
        public int Id { get; set; }
        public int Currency_id { get; set; }
        public string Currency_name { get; set; }
        public string Currency_symbol { get; set; }
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_address { get; set; }
        public string Customer_phone { get; set; }
        public string Customer_doi { get; set; }
        public double Amount { get; set; }
        public double Porc_igv { get; set; }
        public string Status { get; set; }
        public DateTime Issue_date { get; set; }
        public string Observation { get; set; }
        public int Refund_reason_id { get; set; }
        public string Refund_reason_name { get; set; }
        public int Document_id { get; set; }
        public List<SalesRefundLine> Lines { get; set; }


        // Construct for controller
        public SalesRefund(int order_id, int currency_id, string currency_name, string currency_symbol, int customer_id, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, double amount,double porc_igv, string observation, int doc_id, List<SalesRefundLine> lines)
        {
            this.Id = order_id;
            this.Currency_id = currency_id;
            this.Currency_name = currency_name;
            this.Currency_symbol = currency_symbol;
            this.Customer_id = customer_id;
            this.Customer_name = cli_name;
            this.Customer_address = cli_addr;
            this.Customer_phone = cli_phone;
            this.Customer_doi = cli_doi;
            this.Status = status;
            this.Issue_date = issue_date;
            this.Amount = amount;
            this.Porc_igv = porc_igv;
            this.Observation = observation;
            this.Document_id = doc_id;
            this.Lines = lines;
        }

        public SalesRefund() { }

        // For SalesRefundList
        public SalesRefund(int order_id, string cli_name, string observation, DateTime issue_date, double amount, string status)
        {
            this.Id = order_id;
            this.Customer_name = cli_name;
            this.Observation = observation;
            this.Issue_date = issue_date;
            this.Amount = amount;
            this.Status = status;
        }

    }
}
