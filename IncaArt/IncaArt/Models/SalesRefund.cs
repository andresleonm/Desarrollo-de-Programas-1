using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesRefund
    {        
        private int id;
        private int currency_id;
        private string currency_name;
        private string currency_symbol;
        private int customer_id;
        private string customer_name;
        private string customer_address;
        private string customer_phone;
        private string customer_doi;
        private double amount;
        private string status;
        private DateTime issue_date;
        private string observation;
        private int refund_reason_id;
        private string refund_reason_name;
        private int document_id;
        private List<SalesRefundLine> lines;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }        

        public int Currency_id
        {
            get { return currency_id; }
            set { currency_id = value; }
        }

        public string Currency_name
        {
            get { return currency_name; }
            set { currency_name = value; }
        }

        public string Currency_symbol
        {
            get { return currency_symbol; }
            set { currency_symbol = value; }
        }

        public int Customer_id
        {
            get { return customer_id; }
            set { customer_id = value; }
        }

        public string Customer_name
        {
            get { return customer_name; }
            set { customer_name = value; }
        }

        public string Customer_address
        {
            get { return customer_address; }
            set { customer_address = value; }
        }

        public string Customer_phone
        {
            get { return customer_phone; }
            set { customer_phone = value; }
        }

        public string Customer_doi
        {
            get { return customer_doi; }
            set { customer_doi = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime Issue_date
        {
            get { return issue_date; }
            set { issue_date = value; }
        }

        public string Observation
        {
            get { return observation; }
            set { observation = value; }
        }

        public List<SalesRefundLine> Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        // Construct for controller
        public SalesRefund(int order_id, int currency_id, string currency_name, string currency_symbol, int customer_id, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, double amount, string observation, List<SalesRefundLine> lines)
        {
            this.id = order_id;
            this.currency_id = currency_id;
            this.currency_name = currency_name;
            this.currency_symbol = currency_symbol;
            this.customer_id = customer_id;
            this.customer_name = cli_name;
            this.customer_address = cli_addr;
            this.customer_phone = cli_phone;
            this.customer_doi = cli_doi;
            this.status = status;
            this.issue_date = issue_date;
            this.amount = amount;
            this.observation = observation;
            this.lines = lines;
        }

        public SalesRefund() { }

        // For SalesRefundList
        public SalesRefund(int order_id, string cli_name, string observation, DateTime issue_date, double amount, string status)
        {
            this.id = order_id;
            this.customer_name = cli_name;
            this.observation = observation;
            this.issue_date = issue_date;
            this.amount = amount;
            this.status = status;
        }

    }
}
