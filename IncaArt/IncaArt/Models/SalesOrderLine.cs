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
        private int product_id;
        private string product_name;
        private int unit_measure_id;
        private string unit_measure_name;
        private int quantity;
        private double unit_price;
        private int delivery_quantity;
        private int prod_warehouse_id;
        private string prod_warehouse_name;
        private double amount;
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

        public int Product_id
        {
            get { return product_id; }
            set { product_id = value; }
        }

        public string Product_name
        {
            get { return product_name; }
            set { product_name = value; }
        }

        public int Unit_measure_id
        {
            get { return unit_measure_id; }
            set { unit_measure_id = value; }
        }

        public string Unit_measure_name
        {
            get { return unit_measure_name; }
            set { unit_measure_name = value; }
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


        public int Prod_warehouse_id
        {
            get { return prod_warehouse_id; }
            set { prod_warehouse_id = value; }
        }

        public string Prod_warehouse_name
        {
            get { return prod_warehouse_name; }
            set { prod_warehouse_name = value; }
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
        

        public SalesOrderLine(int id, int order_id, int product_id, string product_name, int unit_measure_id, string unit_measure_name, int quantity, double price, int del_quantity, int prod_warehouse_id, string prod_warehouse_name)
        {
            this.id = id;
            this.order_id = order_id;
            this.Product_id = product_id;
            this.product_name = product_name;
            this.unit_measure_id = unit_measure_id;
            this.unit_measure_name = unit_measure_name;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.delivery_quantity = del_quantity;
            this.prod_warehouse_id = prod_warehouse_id;
            this.prod_warehouse_name = prod_warehouse_name;
            this.status = "Registrado";
        }

        public SalesOrderLine(int id, int order_id, int product_id, int unit_measure_id, int quantity, double price, int prod_warehouse_id)
        {
            this.id = id;
            this.order_id = order_id;
            this.Product_id = product_id;            
            this.unit_measure_id = unit_measure_id;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.delivery_quantity = 0;
            this.prod_warehouse_id = prod_warehouse_id;
            this.status = "Registrado";
        }

        public SalesOrderLine()
        {
        }

        public SalesOrderLine(WindowsFormsApp1.Views.Sales_Module.ProductWarehouseS prod_WS)
        {
            this.Product_id = prod_WS.Product_id;
            this.Product_name = prod_WS.productName;
            this.Unit_measure_id = prod_WS.unitId;
            this.Unit_measure_name = prod_WS.unitName;
            this.Quantity = prod_WS.quantity;
            this.Unit_price = prod_WS.unit_price;
            this.prod_warehouse_id = prod_WS.Id;
            this.prod_warehouse_name = prod_WS.Name;
            this.amount = prod_WS.quantity * prod_WS.unit_price;
            this.status = "Active";
        }


    }
}
