using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SalesEstimateLine
    {
        public int Id { get; set; }
        public int Estimate_id { get; set; }
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Unit_measure_id { get; set; }
        public string Unit_measure_name { get; set; }
        public int Quantity { get; set; }
        public double Unit_price { get; set; }
        public int Prod_warehouse_id { get; set; }
        public string Prod_warehouse_name { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }


        // Construct for controller
        public SalesEstimateLine(int id, int estimate_id, int product_id, string product_name, int unit_measure_id, string unit_measure_name, int quantity, double price, int prod_warehouse_id, string prod_warehouse_name, string status)
        {
            this.Id = id;
            this.Estimate_id = estimate_id;
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Unit_measure_id = unit_measure_id;
            this.Unit_measure_name = unit_measure_name;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.Prod_warehouse_id = prod_warehouse_id;
            this.Prod_warehouse_name = prod_warehouse_name;
            this.Status = status;
        }

        public SalesEstimateLine(int id, int estimate_id, int product_id, int unit_measure_id, int quantity, double price, int prod_warehouse_id)
        {
            this.Id = id;
            this.Estimate_id = estimate_id;
            this.Product_id = product_id;
            this.Unit_measure_id = unit_measure_id;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.Prod_warehouse_id = prod_warehouse_id;
            this.Status = "Registrado";
        }

        public SalesEstimateLine()
        {
        }

        public SalesEstimateLine(WindowsFormsApp1.Views.Sales_Module.ProductWarehouseS prod_WS)
        {
            this.Product_id = prod_WS.Product_id;
            this.Product_name = prod_WS.productName;
            this.Unit_measure_id = prod_WS.unitId;
            this.Unit_measure_name = prod_WS.unitName;
            this.Quantity = prod_WS.quantity;
            this.Unit_price = prod_WS.unit_price;
            this.Prod_warehouse_id = prod_WS.Id;
            this.Prod_warehouse_name = prod_WS.Name;
            this.Amount = prod_WS.quantity * prod_WS.unit_price;
            this.Status = "Registrado";
        }
    }
}
