using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SalesEstimate
    {
        public int Id { get; set; }
        public int Currency_id { get; set; }
        public string Currency_name { get; set; }
        public string Currency_symbol { get; set; }
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_doi { get; set; }
        public string Customer_address { get; set; }
        public string Customer_phone { get; set; }
        public string Customer_type { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public DateTime Issue_date { get; set; }
        public string Observation { get; set; }
        public List<SalesEstimateLine> Lines { get; set; }


        // Construct for controller
        public SalesEstimate(int estimate_id, int currency_id, string currency_name, string currency_symbol, int customer_id, string cli_name, string cli_addr, string cli_phone, string cli_doi, string cli_type, string status, DateTime issue_date, double amount, string observation, List<SalesEstimateLine> lines)
        {
            this.Id = estimate_id;
            this.Currency_id = currency_id;
            this.Currency_name = currency_name;
            this.Currency_symbol = currency_symbol;
            this.Customer_id = customer_id;
            this.Customer_name = cli_name;
            this.Customer_address = cli_addr;
            this.Customer_phone = cli_phone;
            this.Customer_doi = cli_doi;
            this.Customer_type = cli_type;
            this.Status = status;
            this.Issue_date = issue_date;
            this.Amount = amount;
            this.Observation = observation;
            this.Lines = lines;
        }

        public SalesEstimate() { }

        // For SalesEstimateList
        public SalesEstimate(int estimate_id, string cli_name, string observation, DateTime issue_date, double amount, string status)
        {
            this.Id = estimate_id;
            this.Customer_name = cli_name;
            this.Observation = observation;
            this.Issue_date = issue_date;
            this.Amount = amount;
            this.Status = status;
        }

        public int getMaxId()
        {
            int max = 0;
            foreach (SalesEstimateLine line in Lines)
            {
                if (line.Id > max)
                    max = line.Id;
            }
            return max;
        }
    }
}
