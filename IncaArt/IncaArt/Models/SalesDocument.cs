using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesDocument
    {
        private int id;
        private int order_id;
        private char type_document_id;
        private int movement_id;
        private int currency_id;
        private string currency_name;
        private string currency_symbol;
        private int customer_id;
        private string customer_name;
        private string customer_address;
        private string customer_phone;
        private string customer_doi;
        private double amount;
        private double porc_igv;
        private string status;
        private DateTime issue_date;
        private string observation;
        private string external_number;
        private List<SalesDocumentLine> lines;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }

        public char Type_document_id
        {
            get { return type_document_id; }
            set { type_document_id = value; }
        }

        public int Movement_id
        {
            get { return movement_id; }
            set { movement_id = value; }
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

        public double Porc_igv
        {
            get { return porc_igv; }
            set { porc_igv = value; }
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

        public string External_number
        {
            get { return external_number; }
            set { external_number = value; }
        }

        public List<SalesDocumentLine> Lines
        {
            get { return lines; }
            set { lines = value; }
        }


        // Construct for controller
        public SalesDocument(int document_id, int currency_id, string currency_name, string currency_symbol, int customer_id, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, double amount, double porc_igv, string observation, int movement_id, char type_document_id, string external_number, List<SalesDocumentLine> lines)
        {
            this.id = document_id;
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
            this.porc_igv = porc_igv;
            this.observation = observation;            
            this.movement_id = movement_id;
            this.type_document_id = type_document_id;
            this.external_number = external_number;
            this.lines = lines;
        }

        public SalesDocument() { }
    }
}
