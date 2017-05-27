using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProductionOrderProductLine
    {
        private int order_Id;
        private int id;
        private Product product;
        private int quantity;
        private int produced_quantity;
        private int broke_quantity;
        private string status;

        public int Order_Id
        {
            get
            {
                return order_Id;
            }

            set
            {
                order_Id = value;
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

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
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

        public int Produced_quantity
        {
            get
            {
                return produced_quantity;
            }

            set
            {
                produced_quantity = value;
            }
        }

        public int Broke_quantity
        {
            get
            {
                return broke_quantity;
            }

            set
            {
                broke_quantity = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public ProductionOrderProductLine()
        {

        }

    }
}
