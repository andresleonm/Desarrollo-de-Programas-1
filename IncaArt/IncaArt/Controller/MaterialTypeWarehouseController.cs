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
            GenericResult result = execute_function("get_materialTypeWarehouses", parameters);
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


        public Result getMaterialWarehouse(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_materialTypeWarehouse", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.MaterialTypeWarehouse materialTypeWarehouse = new Models.MaterialTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3));
                return new Result(materialTypeWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
