using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PurchaseOrder
    {
        List<PurchaseOrderLine> lines;
        Warehouse warehouse;
        Currency currency;
        Supplier supplier;
        Double amount;
        string state;
        DateTime due_date;
        DateTime creation_date;
        int id;

        public List<PurchaseOrderLine> Lines
        {
            get
            {
                return lines;
            }

            set
            {
                lines = value;
            }
        }

        public Currency Currency
        {
            get
            {
                return currency;
            }

            set
            {
                currency = value;
            }
        }

        public Supplier Supplier
        {
            get
            {
                return supplier;
            }

            set
            {
                supplier = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public DateTime Due_date
        {
            get
            {
                return due_date;
            }

            set
            {
                due_date = value;
            }
        }

        public DateTime Creation_date
        {
            get
            {
                return creation_date;
            }

            set
            {
                creation_date = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Warehouse Warehouse
        {
            get
            {
                return warehouse;
            }

            set
            {
                warehouse = value;
            }
        }

        public PurchaseOrder()
        {

        }


    }
}
