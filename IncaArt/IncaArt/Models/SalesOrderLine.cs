using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class SalesOrderLine
    {
        public int Id { get; set; }
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Unit_measure_id { get; set; }
        public string Unit_measure_name { get; set; }
        public int Quantity { get; set; }
        public double Unit_price { get; set; }
        public int Delivery_quantity { get; set; }
        public int Prod_warehouse_id { get; set; }
        public string Prod_warehouse_name { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }

       
        // Construct for controller
        public SalesOrderLine(int id, int order_id, int product_id, string product_name, int unit_measure_id, string unit_measure_name, int quantity, double price, int del_quantity, int prod_warehouse_id, string prod_warehouse_name, string status)
        {
            this.Id = id;
            this.Order_id = order_id;
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Unit_measure_id = unit_measure_id;
            this.Unit_measure_name = unit_measure_name;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.Delivery_quantity = del_quantity;
            this.Prod_warehouse_id = prod_warehouse_id;
            this.Prod_warehouse_name = prod_warehouse_name;
            this.Status = status;
        }

        public SalesOrderLine(int id, int order_id, int product_id, int unit_measure_id, int quantity, double price, int prod_warehouse_id)
        {
            this.Id = id;
            this.Order_id = order_id;
            this.Product_id = product_id;            
            this.Unit_measure_id = unit_measure_id;
            this.Quantity = quantity;
            this.Unit_price = price;
            this.Delivery_quantity = 0;
            this.Prod_warehouse_id = prod_warehouse_id;
            this.Status = "Registrado";
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
            this.Prod_warehouse_id = prod_WS.Id;
            this.Prod_warehouse_name = prod_WS.Name;
            this.Amount = prod_WS.quantity * prod_WS.unit_price;
            this.Status = "Registrado";
        }

        public SalesOrderLine(SalesEstimateLine se)
        {            
            this.Product_id = se.Product_id;
            this.Product_name = se.Product_name;
            this.Unit_measure_id = se.Unit_measure_id;
            this.Unit_measure_name = se.Unit_measure_name;
            this.Quantity = se.Quantity;
            this.Unit_price = se.Unit_price;
            this.Prod_warehouse_id = se.Prod_warehouse_id;
            this.Prod_warehouse_name= se.Prod_warehouse_name;
            this.Amount = se.Amount;
        }
    }
}
