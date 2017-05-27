using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesOrderLine
    {
        private int id;
        private int order_id;
        private Product product;
        private UnitOfMeasure unit_measure;        
        private int quantity;            
        private double unit_price;
        private int delivery_quantity;
        private Warehouse warehouse;
        private string status;

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

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public UnitOfMeasure Unit_measure
        {
            get { return unit_measure; }
            set { unit_measure = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Unit_price
        {
            get { return unit_price; }
            set { unit_price = value; }
        }

        public int Delivery_quantity
        {
            get { return delivery_quantity; }
            set { delivery_quantity = value; }
        }

        public Warehouse Warehouse
        {
            get { return warehouse; }
            set { warehouse = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public SalesOrderLine(int order_id, Product product, UnitOfMeasure unit_measure, int quantity, double price, int del_quantity, Warehouse warehouse, string status)
        {
            this.order_id = order_id;
            this.Product = product;
            this.unit_measure = unit_measure;             
            this.Quantity = quantity;
            this.Unit_price = price;
            this.delivery_quantity = del_quantity;
            this.warehouse = warehouse;
            this.status = status;
        }

        // For gridview
        public SalesOrderLine(Product product, UnitOfMeasure unit_measure, int quantity, double price, string status, int del_quantity, Warehouse warehouse)
        {
            this.Product = product;
            this.unit_measure = unit_measure;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.delivery_quantity = del_quantity;
            this.warehouse = warehouse;
            this.status = status;
        }

        public SalesOrderLine()
        {
        }


    }
}
