using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesOrder
    {        
        private int id;
        private Currency currency;
        private Customer customer;
        private string customer_name;
        private string customer_address;
        private string customer_phone;
        private string customer_doi;
        private double amount;
        private string status;
        private DateTime issue_date;
        private DateTime delivery_date;
        private string observation;
        private List<SalesOrderLine> lines;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }        

        public Currency Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
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

        public DateTime Delivery_date
        {
            get { return delivery_date; }
            set { delivery_date = value; }
        }

        public string Observation
        {
            get { return observation; }
            set { observation = value; }
        }

        public List<SalesOrderLine> Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        public SalesOrder(int order_id, Currency currency, Customer customer, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, DateTime delivery_date, double amount, string observation, List<SalesOrderLine> lines)
        {
            this.id = order_id;
            this.currency = currency;
            this.customer = customer;
            this.customer_name = cli_name;
            this.customer_address = cli_addr;
            this.customer_phone = cli_phone;
            this.customer_doi = cli_doi;
            this.status = status;
            this.issue_date = issue_date;
            this.delivery_date = delivery_date;
            this.amount = amount;
            this.observation = observation;
            this.lines = lines;
        }

        public SalesOrder() { }

        // For SalesOrderList
        public SalesOrder(int order_id, string cli_name, string observation, DateTime issue_date, DateTime delivery_date, double amount, string status)
        {
            this.id = order_id;
            this.customer_name = cli_name;
            this.observation = observation;
            this.issue_date = issue_date;
            this.delivery_date = delivery_date;
            this.amount = amount;
            this.status = status;
        }

    }
}
