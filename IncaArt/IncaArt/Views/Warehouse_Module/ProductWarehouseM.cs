using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public class ProductWarehouseM : WindowsFormsApp1.Models.ProductWarehouse
    {
        public String productName { get; set; }
        public String unitName { get; set; }
        public int unitId { get; set; }
        public int quantity { get; set; }
        public bool selected { get; set; }

        public ProductWarehouseM(int id, string name, int product_id, int current_physical_stock, int max_capacity, 
            int type_id, string state,int current_logical_stock,string productName,string unitName,int unitId):base( id,  name,  product_id,  current_physical_stock, 
                max_capacity,  type_id,  state,  current_logical_stock)
        {
            this.productName = productName;
            this.unitName = unitName;
            this.unitId = unitId;
            this.quantity = 0;
            selected = false;       
        }
        
      
        public override string ToString()
        {
            return Name;
        }

    }
}
