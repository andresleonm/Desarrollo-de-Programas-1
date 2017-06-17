using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesRefundLine 
    {
        public int Id { get; set; }
        public int Refund_id { get; set; }
        public int Document_id_line { get; set; }
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Unit_measure_id { get; set; }
        public string Unit_measure_name { get; set; }
        public int Quantity_available { get; set; }
        public int Quantity { get; set; }
        public double Unit_price { get; set; }
        public int Refund_quantity { get; set; }
        public int Prod_warehouse_id { get; set; }
        public string Prod_warehouse_name { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }

        
        // Construct for controller
        public SalesRefundLine(int id, int refund_id, int product_id, string product_name, int unit_measure_id, string unit_measure_name, int quantity, double price, int ref_quantity, int prod_warehouse_id, string prod_warehouse_name, string status)
        {
            this.Id = id;
            this.Refund_id = refund_id;
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
        }

        public SalesRefundLine(int id, int refund_id, int product_id, int unit_measure_id, int quantity, double price, int prod_warehouse_id)
        {
            this.Id = id;
            this.Refund_id = refund_id;
            this.Product_id = product_id;            
            this.Unit_measure_id = unit_measure_id;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.Refund_quantity = 0;
            this.Prod_warehouse_id = prod_warehouse_id;
            this.Status = "Registrado";
        }

        public SalesRefundLine()
        {
        }

        public SalesRefundLine(WindowsFormsApp1.Models.SalesDocumentLine sdl)
        {
            this.Product_id = sdl.Product_id;
            this.Product_name = sdl.Product_name;
            this.Unit_measure_id = sdl.Unit_measure_id;
            this.Unit_measure_name = sdl.Unit_measure_name;
            this.Quantity = 0;
            this.Quantity_available = sdl.Quantity - sdl.Refund_quantity;
            this.Unit_price = sdl.Unit_price;
            this.Prod_warehouse_id = sdl.Prod_warehouse_id;
            this.Prod_warehouse_name = sdl.Prod_warehouse_name;
            this.Amount = sdl.Quantity * sdl.Unit_price;
            this.Document_id_line = sdl.Id;
            this.Status = "Registrado";
        }


    }
}
