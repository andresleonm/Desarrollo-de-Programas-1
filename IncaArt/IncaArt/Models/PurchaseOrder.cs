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
        int warehouse_id;
        int currency_id;
        int supplier_id;
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

        public int Currency_id
        {
            get
            {
                return currency_id;
            }

            set
            {
                currency_id = value;
            }
        }

        public int Supplier_id
        {
            get
            {
                return supplier_id;
            }

            set
            {
                supplier_id = value;
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

        public int Warehouse_id
        {
            get
            {
                return warehouse_id;
            }

            set
            {
                warehouse_id = value;
            }
        }

        public PurchaseOrder()
        {

        }


    }
}
