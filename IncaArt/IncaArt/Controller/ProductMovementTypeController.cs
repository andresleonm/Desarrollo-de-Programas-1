using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductMovementTypeController : DataService.DatabaseService
    {
        public ProductMovementTypeController(string user, string password):base( user, password)
        {
        }

        public Result getProductMovementTypes(Models.ProductMovementType type)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (type != null)
            {
                if (type.name != "") parameters.Add(new Parameter("name", type.name));
                if (type.clase != -1) parameters.Add(new Parameter("class", type.clase.ToString()));
            }
            GenericResult result = execute_function("get_product_movement_types", parameters);
            List<Models.ProductMovementType> list = new List<Models.ProductMovementType>();
            Models.ProductMovementType item;
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    item = new Models.ProductMovementType();
                    item.id = r.getColumn(0);
                    item.name = r.getColumn(1);
                    item.clase = Int32.Parse(r.getColumn(2));
                    item.sign = (r.getColumn(3))[0];
                    list.Add(item);
                }
                return new Result(list, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductMovementType(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_product_movement_type", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.ProductMovementType item = new Models.ProductMovementType();
                item.id = r.getColumn(0);
                item.name = r.getColumn(1);
                item.clase = Int32.Parse(r.getColumn(2));
                item.sign = (r.getColumn(3))[0];
                return new Result(item, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertProductMovementType(Models.ProductMovementType type)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", type.name));
            parameters.Add(new Parameter("class", type.clase.ToString()));
            parameters.Add(new Parameter("sign", type.sign.ToString()));
            GenericResult result = execute_transaction("insert_product_movement_type", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateProductMovementType(Models.ProductMovementType type)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", type.id.ToString()));
            parameters.Add(new Parameter("name", type.name));
            parameters.Add(new Parameter("class", type.clase.ToString()));
            parameters.Add(new Parameter("sign", type.sign.ToString()));
            GenericResult result = execute_transaction("update_product_movement_type", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteProductMovementType(Models.ProductMovementType type)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", type.id.ToString()));
            GenericResult result = execute_transaction("delete_product_movement_type", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
