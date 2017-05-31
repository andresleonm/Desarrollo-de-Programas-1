using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PurchaseOrderLine
    {
        int id;
        int purchase_order;
        int unit_of_measure;
        int material;
        int warehouse;
        int deliver_quantity;        
        int quantity;
        double price;
        DateTime scheluded_date;

        public PurchaseOrderLine(int id,int purchase_order,int unit_of_measure,int quantity,double price,DateTime scheluded_date,int deliver_quantity,int material,int warehouse)
        {            
            this.purchase_order = purchase_order;
            this.unit_of_measure = unit_of_measure;
            this.quantity = quantity;
            this.price = price;
            this.scheluded_date = scheluded_date;            
            this.deliver_quantity = deliver_quantity;
            this.material = material;
            this.warehouse = warehouse;
        }

        public PurchaseOrderLine(int purchase_order, int unit_of_measure, int quantity, double price, DateTime scheluded_date,int deliver_quantity, int material, int warehouse)
        {
            this.purchase_order = purchase_order;
            this.unit_of_measure = unit_of_measure;
            this.quantity = quantity;
            this.price = price;
            this.scheluded_date = scheluded_date;            
            this.deliver_quantity = deliver_quantity;
            this.material = material;
            this.warehouse = warehouse;
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

        public int Purchase_order
        {
            get
            {
                return purchase_order;
            }

            set
            {
                purchase_order = value;
            }
        }

        public int Unit_of_measure
        {
            get
            {
                return unit_of_measure;
            }

            set
            {
                unit_of_measure = value;
            }
        }

        public int Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        public int Warehouse
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

        public int Deliver_quantity
        {
            get
            {
                return deliver_quantity;
            }

            set
            {
                deliver_quantity = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public DateTime Scheluded_date
        {
            get
            {
                return scheluded_date;
            }

            set
            {
                scheluded_date = value;
            }
        }

        public PurchaseOrderLine()
        {

        }
    }
}
