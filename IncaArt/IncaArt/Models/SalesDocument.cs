using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesDocument
    {
        public int Id { get; set; }
        public int Order_id { get; set; }
        public string type_name;
        public char Type_document_id { get; set; }
        public int Movement_id { get; set; }
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
        public string External_number { get; set; }
        public List<SalesDocumentLine> Lines { get; set; }

        public string Type_name
        {
            get
            {
                if (Type_document_id == 'B') return "Boleta";
                if (Type_document_id == 'F') return "Factura";
                if (Type_document_id == 'N') return "Nota de Crédito";
                return "";
            }
        
            set { type_name = value; }
        }


        // Construct for controller
        public SalesDocument(int document_id, int currency_id, string currency_name, string currency_symbol, int customer_id, string cli_name, string cli_addr, string cli_phone, string cli_doi, string status, DateTime issue_date, double amount, double porc_igv, string observation, int movement_id, char type_document_id, string external_number, List<SalesDocumentLine> lines)
        {
            this.Id = document_id;
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
            this.Movement_id = movement_id;
            this.Type_document_id = type_document_id;
            this.External_number = external_number;
            this.Lines = lines;
        }

        public SalesDocument() { }
    }
}
