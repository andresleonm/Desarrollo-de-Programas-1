using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductTypeWarehouseController : DataService.DatabaseService
    {
        public ProductTypeWarehouseController(string user, string password) : base(user, password)
        {
        }


        public Result getProductTypeWarehouses()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_producttype_warehouses", parameters);
            List<Models.ProductTypeWarehouse> productTypeWarehouse = new List<Models.ProductTypeWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {

                    productTypeWarehouse.Add(new Models.ProductTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3)));
                }
                //"WAREHOUSE_TYPE","WAREHOUSE_TYPE_NAME","WAREHOUSE_CLASS","STATE"
                return new Result(productTypeWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result getProductTypeWarehouse(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_productyype_warehouse", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.ProductTypeWarehouse productTypeWarehouse = new Models.ProductTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3));
                return new Result(productTypeWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductTypeWarehouses(Models.ProductTypeWarehouse typewarehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            if (typewarehouse.Name != "") parameters.Add(new Parameter("name", typewarehouse.Name));
            if (typewarehouse.Wclass != "") parameters.Add(new Parameter("class", typewarehouse.Wclass));
            // if (product.Unit_id != 0) parameters.Add(new Parameter("unit_id", product.Unit_id.ToString()));
            GenericResult result = execute_function("get_producttype_warehouses2", parameters);
            List<Models.ProductTypeWarehouse> ps = new List<Models.ProductTypeWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    ps.Add(new Models.ProductTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), (r.getColumn(3))));
                }
                return new Result(ps, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertTypeWarehouse(Models.ProductTypeWarehouse warehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name", warehouse.Name));
            parameters.Add(new Parameter("class", warehouse.Wclass.ToString()));
            parameters.Add(new Parameter("state", warehouse.State.ToString()));
            GenericResult result = execute_transaction("insert_producttype_warehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateTypeWarehouse(Models.ProductTypeWarehouse warehouse)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", warehouse.Id.ToString()));
            parameters.Add(new Parameter("name", warehouse.Name));
            parameters.Add(new Parameter("class", warehouse.Wclass));
            parameters.Add(new Parameter("state", warehouse.State));
            GenericResult result = execute_transaction("update_producttype_warehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteTypeWarehouse(Models.ProductTypeWarehouse warehouse)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", warehouse.Id.ToString()));
            GenericResult result = execute_transaction("delete_producttype_warehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
