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
            Models.Material item;
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    item = new Models.Material();
                    item.Id = Int32.Parse(r.getColumn(0));
                    item.Unit_id = Int32.Parse(r.getColumn(1));
                    item.Name = r.getColumn(2);
                    item.Stock_min = Int32.Parse(r.getColumn(3));
                    item.Stock_max = Int32.Parse(r.getColumn(4));
                    item.Average_cost = double.Parse(r.getColumn(5));
                    item.Currency_id = Int32.Parse(r.getColumn(6));
                    materials.Add(item);
                }
                return new Result(materials, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getMaterials(Models.Material material)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (material != null)
            {
                if (material.Name != "") parameters.Add(new Parameter("name", material.Name));
                if (material.Unit_id != 0) parameters.Add(new Parameter("unit_id", material.Unit_id.ToString()));
            }
            GenericResult result = execute_function("get_materials2", parameters);
            List<Models.Material> materials = new List<Models.Material>();
            Models.Material item;
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    item = new Models.Material();
                    item.Id = Int32.Parse(r.getColumn(0));
                    item.Unit_id = Int32.Parse(r.getColumn(1));
                    item.Name = r.getColumn(2);
                    item.Stock_min = Int32.Parse(r.getColumn(3));
                    item.Stock_max = Int32.Parse(r.getColumn(4));
                    item.Average_cost = double.Parse(r.getColumn(5));
                    item.Currency_id = Int32.Parse(r.getColumn(6));
                    materials.Add(item);
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
            GenericResult result = execute_function("get_material", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.Material material = new Models.Material(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)));
                material.Average_cost = double.Parse(r.getColumn(5));
                material.Currency_id = Int32.Parse(r.getColumn(6));
                return new Result(material, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        //Only get the materials which have minimum one warehouse
        public Result getMaterials_withWarehouses()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_materials3", parameters);
            List<Models.Material> materials = new List<Models.Material>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    materials.Add(new Models.Material(
                        Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4))
                        ));
                }
                return new Result(materials, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertMaterial(Models.Material material)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", material.Name));
            parameters.Add(new Parameter("unit_id", material.Unit_id.ToString()));
            parameters.Add(new Parameter("stock_min", material.Stock_min.ToString()));
            parameters.Add(new Parameter("stock_max", material.Stock_max.ToString()));
            parameters.Add(new Parameter("average_cost", material.Average_cost.ToString()));
            parameters.Add(new Parameter("currency_id", material.Currency_id.ToString()));
            GenericResult result = execute_transaction("insert_material", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateMaterial(Models.Material material)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", material.Id.ToString()));
            parameters.Add(new Parameter("name", material.Name));
            parameters.Add(new Parameter("unit_id", material.Unit_id.ToString()));
            parameters.Add(new Parameter("stock_min", material.Stock_min.ToString()));
            parameters.Add(new Parameter("stock_max", material.Stock_max.ToString()));
            parameters.Add(new Parameter("average_cost", material.Average_cost.ToString()));
            parameters.Add(new Parameter("currency_id", material.Currency_id.ToString()));
            GenericResult result = execute_transaction("update_material", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteMaterial(Models.Material material)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", material.Id.ToString()));
            GenericResult result = execute_transaction("delete_material", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
