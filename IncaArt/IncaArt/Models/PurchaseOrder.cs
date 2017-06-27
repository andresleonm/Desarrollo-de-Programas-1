using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int Currency_id { get; set; }
        public string Currency_name { get; set; }
        public string Currency_symbol { get; set; }
        public int Supplier_id { get; set; }
        public string Supplier_name { get; set; }
        public string Supplier_address { get; set; }
        public string Supplier_phone { get; set; }
        public string Supplier_doi { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public DateTime Issue_date { get; set; }
        public string Observation { get; set; }
        public List<PurchaseOrderLine> Lines { get; set; }
        public double Igv_amount { get; set; }

        public double Igv_percentage { get; set; }
       


        public PurchaseOrder(int order_id, int currency_id, string currency_name, string currency_symbol, int customer_id, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, double amount, string observation, List<PurchaseOrderLine> lines)
        {
            this.Id = order_id;
            this.Currency_id = currency_id;
            this.Currency_name = currency_name;
            this.Currency_symbol = currency_symbol;
            this.Supplier_id = customer_id;
            this.Supplier_name = cli_name;
            this.Supplier_address = cli_addr;
            this.Supplier_phone = cli_phone;
            this.Supplier_doi = cli_doi;
            this.Status = status;
            this.Issue_date = issue_date;
            this.Amount = amount;
            this.Observation = observation;
            this.Lines = lines;
        }

        public PurchaseOrder(int order_id, string cli_name, string observation, DateTime issue_date, double amount, string status)
        {
            this.Id = order_id;
            this.Supplier_name = cli_name;
            this.Observation = observation;
            this.Issue_date = issue_date;
            this.Amount = amount;
            this.Status = status;
        }
        public PurchaseOrder()
        {

        }

        public int getMaxId()
        {
            int max = 0;
            foreach (PurchaseOrderLine line in Lines)
            {
                if (line.Id > max)
                    max = line.Id;
            }
            return max;
        }
    }
}
