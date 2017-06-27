using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Views.Warehouse_Module;
namespace WindowsFormsApp1.Models
{
    public class MaterialMovementLine
    {
        public int movementId;
        public int id { get; set; }
        public int warehouse_id { get; set; }
        public int material_id { get; set; }

        public int  unit_id { get; set; }

        public String warehouse_name { get; set; }

        public String material_name { get; set; }
        public String unit_name { get; set; }

        public int warehouseQuantity { get; set; }
        public int documentQuantity { get; set; }
        public int quantity { get; set; }
        public String State { get; set; }
        public int idDocumentLine { get; set; }


        public MaterialMovementLine(int movementId,int id,int warehouse_id,int material_id,
            int unit_id,String warehouse_name,
                                String material_name,String unit_name,int warehouseQuantity,
                                int documentQuantity,int quantity,
                                String state,int idDocumentLine)
        {
            this.movementId = movementId;
            this.id = id;
            this.warehouse_id = warehouse_id;
            this.material_id = material_id;
            this.unit_id = unit_id;
            this.warehouse_name = warehouse_name;
            this.material_name = material_name;
            this.unit_name = unit_name;
            this.warehouseQuantity = warehouseQuantity;
            this.documentQuantity = documentQuantity;
            this.quantity = quantity;
            this.State = state;
            this.idDocumentLine = idDocumentLine;
        }
        public MaterialMovementLine(PurchaseOrderLine line,int id, string user, string password)
        {
            this.warehouse_id = line.Prod_warehouse_id;
            this.material_id = line.Material_id;
            this.unit_id = line.Unit_measure_id;
            MaterialWarehouseController mwc = new MaterialWarehouseController(user, password);
            Models.MaterialWarehouse warehouse = (Models.MaterialWarehouse)mwc.getMaterialWarehouse(line.Prod_warehouse_id).data;
            warehouse_name = warehouse.Name;
            MaterialsController mc = new MaterialsController(user, password);
            Models.Material material = (Models.Material)mc.getMaterial(line.Material_id).data;
            material_name = material.Name;
            UnitController uc = new UnitController(user, password);
            Models.UnitOfMeasure unit = (Models.UnitOfMeasure)uc.getUnit(line.Unit_measure_id).data;
            unit_name = unit.Name;
            this.warehouseQuantity = warehouse.Current_physical_stock;
            this.documentQuantity = line.Quantity - line.Delivery_quantity;
            this.State = "Active";
            this.idDocumentLine = line.Id;
        }

        public MaterialMovementLine(ProductionOrderMaterialLine line, int id, string user, string password)
        {
            this.warehouse_id = line.Warehouse_id;
            this.material_id = line.Material_id;
            this.unit_id = line.Unit_id;
            MaterialWarehouseController mwc = new MaterialWarehouseController(user, password);
            Models.MaterialWarehouse warehouse = (Models.MaterialWarehouse)mwc.getMaterialWarehouse(line.Warehouse_id).data;
            warehouse_name = warehouse.Name;            
            material_name = line.Material_name;            
            unit_name = line.Unit_name;
            this.warehouseQuantity = warehouse.Current_physical_stock;
            this.documentQuantity = line.Quantity_required - line.Quantity_taken_real;
            this.State = "Active";
            this.idDocumentLine = line.Id;
        }


        public MaterialMovementLine(string user,string password,MaterialWarehouseM line, int id)
        {
            this.warehouse_id = line.Id;
            this.material_id = line.Material_id;
            this.unit_id =line.unitId;
            this.warehouse_name = line.Name;
            this.material_name = line.materialName;
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
