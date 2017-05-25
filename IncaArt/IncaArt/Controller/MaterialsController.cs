using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class MaterialsController : DataService.DatabaseService
    {
        //todos los controladores deben de hereder de DatabaseService de esta manera
        public MaterialsController(string user, string password):base( user, password)
        {
        }

        public Result getMaterials()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_materials", parameters);
            List<Models.Material> materials = new List<Models.Material>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    materials.Add(new Models.Material(
                        Int32.Parse(r.getColumn(0)),r.getColumn(1),Int32.Parse(r.getColumn(2)),Int32.Parse(r.getColumn(3))));
                }
                return new Result(materials, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getMaterial(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_user", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Material material = new Models.Material(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(4)), Int32.Parse(r.getColumn(5)));
                return new Result(material, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertUser(Models.Material material)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", material.Name));
            parameters.Add(new Parameter("unit_id", material.Unit_id.ToString()));
            parameters.Add(new Parameter("min_stock", material.Min_stock.ToString()));
            parameters.Add(new Parameter("max_stock", material.Max_stock.ToString()));
            GenericResult result = execute_transaction("insert_user", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
