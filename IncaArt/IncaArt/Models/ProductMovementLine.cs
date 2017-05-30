using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Views.Warehouse_Module;
namespace WindowsFormsApp1.Models
{
    public class ProductMovementLine
    {
        public int movementId;
        public int id { get; set; }
        public int warehouse_id { get; set; }
        public int product_id { get; set; }

        public int  unit_id { get; set; }

        public String warehouse_name { get; set; }

        public String product_name { get; set; }
        public String unit_name { get; set; }

        public int warehouseQuantity { get; set; }
        public int documentQuantity { get; set; }
        public int quantity { get; set; }
        public String State { get; set; }
        public int idDocumentLine { get; set; }

        public ProductMovementLine(SalesOrderLine line,int id, string user, string password)
        {
            this.warehouse_id = line.Prod_warehouse_id;
            this.product_id = line.Product_id;
            this.unit_id = line.Unit_measure_id;
            warehouse_name = line.Prod_warehouse_name;
            product_name = line.Product_name;
            unit_name = line.Unit_measure_name;
            ProductWarehouseController pwc = new ProductWarehouseController(user, password);
            Models.ProductWarehouse warehouse = (Models.ProductWarehouse)pwc.getProductWarehouse(warehouse_id).data;
            this.warehouseQuantity = warehouse.Current_physical_stock;
            this.documentQuantity = line.Quantity - line.Delivery_quantity;
            this.State = "Active";
            this.idDocumentLine = line.Id;
        }

        public ProductMovementLine(string user,string password,ProductWarehouseM line, int id)
        {
            this.warehouse_id = line.Id;
            this.product_id = line.Product_id;
            this.unit_id =line.unitId;
            this.warehouse_name = line.Name;
            this.product_name = line.productName;
            this.unit_name = line.unitName;
            this.id = id;
            this.warehouseQuantity = line.Current_physical_stock;
            this.documentQuantity = 0;
            this.quantity = line.quantity;
            this.State = "Active";
            this.idDocumentLine = 0;
        }


    }
}
