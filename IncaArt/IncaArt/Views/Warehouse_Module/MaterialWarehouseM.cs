using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views.Warehouse_Module
{
    public class MaterialWarehouseM : WindowsFormsApp1.Models.MaterialWarehouse
    {
        public String materialName { get; set; }
        public String unitName { get; set; }
        public int unitId { get; set; }
        public int quantity { get; set; }
        public bool selected { get; set; }

        public MaterialWarehouseM(int id, string name, int material_id, int current_physical_stock, int max_capacity, 
            int type_id, string state,int current_logical_stock,string materialName,string unitName,int unitId):base( id,  name,  material_id,  current_physical_stock, 
                max_capacity,  type_id,  state,  current_logical_stock)
        {
            this.materialName = materialName;
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
