using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesDocumentLine
    {
        public int Id { get; set; }
        public int Document_id { get; set; }
        public int Movement_id_line { get; set; }
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Unit_measure_id { get; set; }
        public string Unit_measure_name { get; set; }
        public int Quantity { get; set; }
        public double Unit_price { get; set; }
        public int Refund_quantity { get; set; }
        public int Prod_warehouse_id { get; set; }
        public string Prod_warehouse_name { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }

        
        // Construct for controller
        public SalesDocumentLine(int id, int document_id,  int product_id, string product_name, int unit_measure_id, string unit_measure_name, int quantity, double price, int ref_quantity, int prod_warehouse_id, string prod_warehouse_name, string status, int movemement_id_line)
        {
            this.Id = id;
            this.Document_id = document_id;
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Unit_measure_id = unit_measure_id;
            this.Unit_measure_name = unit_measure_name;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.Refund_quantity = ref_quantity;
            this.Prod_warehouse_id = prod_warehouse_id;
            this.Prod_warehouse_name = prod_warehouse_name;
            this.Status = status;
            this.Movement_id_line = movemement_id_line;
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
            this.Prod_warehouse_id = prodML.warehouse_id;
            this.Prod_warehouse_name = prodML.warehouse_name;
            this.Amount = prodML.quantity * prodML.unit_price;
            this.Movement_id_line = prodML.id;
            this.Status = "Registrado";
        }
    }
}
