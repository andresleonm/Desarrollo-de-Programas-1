using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SalesOrder
    {
        private List<SalesOrderLine> lines;
        private Currency currency;
        private double amount;
        private string status;
        private DateTime issue_date;
        private DateTime delivery_date;
        private int id;

        public List<SalesOrderLine> Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        public Currency Currency
        {
            get { return currency; }
            set { currency = value; }
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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public SalesOrder(List<SalesOrderLine> lines, Currency currency, double amount, string status, DateTime issue_date, DateTime delivery_date)
        {
            this.lines = lines;
            this.currency = currency;
            this.amount = amount;
            this.status = status;
            this.issue_date = issue_date;
            this.delivery_date = delivery_date;
        }

    }
}
