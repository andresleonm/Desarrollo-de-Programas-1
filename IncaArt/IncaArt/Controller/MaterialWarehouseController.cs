using System;
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

        public Result getMaterialWarehouse()
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
                Models.Material material = new Models.Material(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(4)), Int32.Parse(r.getColumn(5)));
                return new Result(material, true, "");
            }
            return new Result(null, result.success, result.message);
        }



    }
}
