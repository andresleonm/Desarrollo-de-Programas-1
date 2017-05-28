﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controller
{
    class MaterialWarehouseController : DataService.DatabaseService
    {
        public MaterialWarehouseController(string user, string password) : base(user, password)
        {
        }

        public Result getMaterialWarehouses()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_materialWarehouses", parameters);
            List<MaterialWarehouse> materialWarehouses = new List<MaterialWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    
                    materialWarehouses.Add(new MaterialWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)),r.getColumn(6), Int32.Parse(r.getColumn(7))));
                }
                return new Result(materialWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getMaterialWarehouse(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_material", parameters);
            if (result.success)
            {
                var r = result.data[0];
                MaterialWarehouse materialWarehouse = new MaterialWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)));
                return new Result(materialWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result insertMaterialWarehouse(MaterialWarehouse materialWarehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", materialWarehouse.Name.ToString()));
            parameters.Add(new Parameter("product_id", materialWarehouse.Material_id.ToString()));
            parameters.Add(new Parameter("physical_stock", materialWarehouse.Current_physical_stock.ToString()));
            parameters.Add(new Parameter("max_capacity", materialWarehouse.Max_capacity.ToString()));
            parameters.Add(new Parameter("type_warehouse", materialWarehouse.Type_id.ToString()));
            parameters.Add(new Parameter("state", materialWarehouse.State.ToString()));
            parameters.Add(new Parameter("logical_stock", materialWarehouse.Current_logical_stock.ToString()));
            GenericResult result = execute_transaction("insert_materialWarehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
       /*
                "WAREHOUSE_ID"                      0
                ,"WAREHOUSE_NAME",                  1
              "MATERIAL_ID",                        2
              "WAREHOUSE_CURRENT_PHYSICAL_STOCK",   3
              "WAREHOUSE_MAX_CAPACITY",             4
              "WAREHOUSE_TYPE_ID",                  5
              "STATE",                              6
              "WAREHOUSE_CURRENT_LOGICAL_STOCK"     7

        */
    }
}