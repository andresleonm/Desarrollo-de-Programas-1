using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesDocumentLine
    {
        private int id;
        private int document_id;
        private int movemement_id_line;
        private int product_id;
        private string product_name;
        private int unit_measure_id;
        private string unit_measure_name;
        private int quantity;
        private double unit_price;
        private int refund_quantity;
        private int prod_warehouse_id;
        private string prod_warehouse_name;
        private double amount;
        private string status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Document_id
        {
            get { return document_id; }
            set { document_id = value; }
        }

        public int Movemement_id_line
        {
            get { return movemement_id_line; }
            set { movemement_id_line = value; }
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

        public int Refund_quantity
        {
            get { return refund_quantity; }
            set { refund_quantity = value; }
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


        // Construct for controller
        public SalesDocumentLine(int id, int document_id,  int product_id, string product_name, int unit_measure_id, string unit_measure_name, int quantity, double price, int ref_quantity, int prod_warehouse_id, string prod_warehouse_name, string status, int movemement_id_line)
        {
            this.id = id;
            this.document_id = document_id;
            this.Product_id = product_id;
            this.product_name = product_name;
            this.unit_measure_id = unit_measure_id;
            this.unit_measure_name = unit_measure_name;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.refund_quantity = ref_quantity;
            this.prod_warehouse_id = prod_warehouse_id;
            this.prod_warehouse_name = prod_warehouse_name;
            this.status = status;
            this.movemement_id_line = movemement_id_line;
        }

        // Parseador
        public SalesDocumentLine(WindowsFormsApp1.Models.ProductMovementLine prodML)
        {
            this.Product_id = prodML.product_id;
            this.Product_name = prodML.product_name;
            this.Unit_measure_id = prodML.unit_id;
            this.Unit_measure_name = prodML.unit_name;
            this.Quantity = prodML.quantity;
            this.Unit_price = prodML.unit_price;
            this.prod_warehouse_id = prodML.warehouse_id;
            this.prod_warehouse_name = prodML.warehouse_name;
            this.amount = prodML.quantity * prodML.unit_price;
            this.status = "Active";
        }
    }
}
