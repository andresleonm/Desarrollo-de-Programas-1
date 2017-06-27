﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views.Purchase_Module
{
    public class MaterialWarehouseS : WindowsFormsApp1.Models.MaterialWarehouse
    {
        public String materialName { get; set; }
        public String unitName { get; set; }
        public int unitId { get; set; }
        public int quantity { get; set; }
        public bool selected { get; set; }
        public double unit_price { get; set; }

        public MaterialWarehouseS(int id, string name, int product_id, int current_physical_stock, int max_capacity, 
            int type_id, string state,int current_logical_stock, string productName, string unitName, int unitId, double unit_price):base( id,  name,  product_id,  current_physical_stock, 
                max_capacity,  type_id,  state,  current_logical_stock)
        {
            this.materialName = productName;
            this.unitName = unitName;
            this.unitId = unitId;
            this.quantity = 0;
            this.unit_price = unit_price;
            selected = false;       
        }
              
        public override string ToString()
        {
            return Name;
        }

    }
}
