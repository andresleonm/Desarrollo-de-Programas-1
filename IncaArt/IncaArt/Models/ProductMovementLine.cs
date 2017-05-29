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
        public ProductWarehouse warehouse { get; set; }
        public Product product { get; set; }

        public  UnitOfMeasure unit { get; set; }
    
        public int warehouseQuantity { get; set; }
        public int documentQuantity { get; set; }
        public int quantity { get; set; }
        public String State { get; set; }
        public int idDocumentLine { get; set; }

        public ProductMovementLine(SalesOrderLine line,int id)
        {
            this.warehouse = line.Prod_warehouse;
            this.product = line.Product;
            this.unit = line.Unit_measure;
            this.id = id;
            this.warehouseQuantity = line.Prod_warehouse.Current_physical_stock;
            this.documentQuantity = line.Quantity - line.Delivery_quantity;
            this.State = "Active";
            this.idDocumentLine = line.Id;
        }

        public ProductMovementLine(string user,string password,ProductWarehouseM line, int id)
        {
            this.warehouse = line;
            this.product = (Product) new ProductsController(user,password).getProduct(line.Product_id).data;
            this.unit = (UnitOfMeasure)new UnitController(user, password).getUnit(product.Unit_id).data;
            this.id = id;
            this.warehouseQuantity = line.Current_physical_stock;
            this.documentQuantity = 0;
            this.quantity = line.quantity;
            this.State = "Active";
            this.idDocumentLine = 0;
        }


    }
}
