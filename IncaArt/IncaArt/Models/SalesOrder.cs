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
        private string state;
        private DateTime issue_date;
        private DateTime delivery_date;
        private int id;

        public Currency Currency { get => currency; set => currency = value; }
        public double Amount { get => amount; set => amount = value; }
        public string State { get => state; set => state = value; }
        public DateTime Issue_date { get => issue_date; set => issue_date = value; }
        public DateTime Delivery_date { get => delivery_date; set => delivery_date = value; }
        public int Id { get => id; set => id = value; }
        internal List<SalesOrderLine> Lines { get => lines; set => lines = value; }

        public SalesOrder(List<SalesOrderLine> lines, Currency currency, double amount, string state, DateTime issue_date, DateTime delivery_date)
        {
            this.lines = lines;
            this.currency = currency;
            this.amount = amount;
            this.state = state;
            this.issue_date = issue_date;
            this.delivery_date = delivery_date;
        }

    }
}
