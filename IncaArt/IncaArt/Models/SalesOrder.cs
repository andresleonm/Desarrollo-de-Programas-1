using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SalesOrder
    {        
        private int id;
        private Currency currency;
        private Client client;
        private string client_name;
        private string client_address;
        private string client_phone;
        private string client_doi;
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

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public string Client_name
        {
            get { return client_name; }
            set { client_name = value; }
        }

        public string Client_address
        {
            get { return client_address; }
            set { client_address = value; }
        }

        public string Client_phone
        {
            get { return client_phone; }
            set { client_phone = value; }
        }

        public string Client_doi
        {
            get { return client_doi; }
            set { client_doi = value; }
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

        public SalesOrder(Currency currency, Client client, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, DateTime delivery_date, double amount, string observation, List<SalesOrderLine> lines)
        {            
            this.currency = currency;
            this.client = client;
            this.client_name = cli_name;
            this.client_address = cli_addr;
            this.client_phone = cli_phone;
            this.client_doi = cli_doi;
            this.status = status;
            this.issue_date = issue_date;
            this.delivery_date = delivery_date;
            this.amount = amount;
            this.observation = observation;
            this.lines = lines;
        }

    }
}
