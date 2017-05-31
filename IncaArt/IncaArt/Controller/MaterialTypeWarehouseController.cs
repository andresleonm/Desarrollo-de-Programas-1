using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class MaterialTypeWarehouseController: DataService.DatabaseService
    {
        public MaterialTypeWarehouseController(string user, string password) : base(user, password)
        {
        }


        public Result getMaterialTypeWarehouses()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_material_typewarehouses", parameters);
            List<Models.MaterialTypeWarehouse> materialTypeWarehouse = new List<Models.MaterialTypeWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    materialTypeWarehouse.Add(new Models.MaterialTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)));
                }
                //"WAREHOUSE_TYPE","WAREHOUSE_TYPE_NAME","WAREHOUSE_CLASS","STATE"
                return new Result(materialTypeWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result getMaterialTypeWarehouse(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_material_typewarehouse", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.MaterialTypeWarehouse materialTypeWarehouse = new Models.MaterialTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3));
                return new Result(materialTypeWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertMaterialTypeWarehouse(Models.MaterialTypeWarehouse warehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();

            parameters.Add(new Parameter("name", warehouse.Name.ToString()));
            parameters.Add(new Parameter("class", warehouse.Wclass.ToString()));
            parameters.Add(new Parameter("state", warehouse.State.ToString()));
            GenericResult result = execute_transaction("insert_materialtype_warehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateMaterialTypeWarehouse(Models.MaterialTypeWarehouse warehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", warehouse.Id.ToString()));
            parameters.Add(new Parameter("name", warehouse.Name.ToString()));
            parameters.Add(new Parameter("class", warehouse.Wclass.ToString()));
            parameters.Add(new Parameter("state", warehouse.State.ToString()));
            GenericResult result = execute_transaction("update_materialwarehouse", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteMaterialTypeWarehouse(Models.MaterialTypeWarehouse warehouse)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", warehouse.Id.ToString()));
            GenericResult result = execute_transaction("delete_materialtype_warehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
