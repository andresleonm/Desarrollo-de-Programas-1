using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductWarehouseController : DataService.DatabaseService
    {
        public ProductWarehouseController(string user, string password) : base(user, password)
        {
        }

        public Result getProductWarehouses()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_productwarehouses", parameters);
            List<Models.ProductWarehouse> productWarehouses = new List<Models.ProductWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {

                    productWarehouses.Add(new Models.ProductWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7))));
                }
                return new Result(productWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result getProductWarehouse(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));                                                     
            GenericResult result = execute_function("get_productwarehouse", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.ProductWarehouse productWarehouse = new Models.ProductWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)));
                return new Result(productWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductWarehouses_by_idProduct(int idProduct, char idClass)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id_product", idProduct.ToString()));
            parameters.Add(new Parameter("class_id", idClass.ToString()));
            GenericResult result = execute_function("get_productwarehouse_by_idproduct", parameters);
            List<Models.ProductWarehouse> productWarehouses = new List<Models.ProductWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    productWarehouses.Add(new Models.ProductWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), int.Parse(r.getColumn(3)), int.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), int.Parse(r.getColumn(7))));
                }
                return new Result(productWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertProductWarehouse(Models.ProductWarehouse warehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("name",warehouse.Name.ToString()));
            parameters.Add(new Parameter("product_id", warehouse.Product_id.ToString()));
            parameters.Add(new Parameter("physical_stock", warehouse.Current_physical_stock.ToString()));
            parameters.Add(new Parameter("max_capacity", warehouse.Max_capacity.ToString()));
            parameters.Add(new Parameter("type_warehouse", warehouse.Type_id.ToString()));
            parameters.Add(new Parameter("logical_stock", warehouse.Current_logical_stock.ToString()));
            parameters.Add(new Parameter("state", warehouse.State.ToString()));
            GenericResult result = execute_transaction("insert_productwarehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateProductWarehouse(Models.ProductWarehouse warehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", warehouse.Id.ToString()));
            parameters.Add(new Parameter("name", warehouse.Name.ToString()));
            parameters.Add(new Parameter("product_id", warehouse.Product_id.ToString()));
            parameters.Add(new Parameter("physical_stock", warehouse.Current_physical_stock.ToString()));
            parameters.Add(new Parameter("max_capacity", warehouse.Max_capacity.ToString()));
            parameters.Add(new Parameter("type_warehouse", warehouse.Type_id.ToString()));
            parameters.Add(new Parameter("logical_stock", warehouse.Current_logical_stock.ToString()));
            parameters.Add(new Parameter("state", warehouse.State.ToString()));
            GenericResult result = execute_transaction("update_productwarehouse", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result deleteProductWarehouse(Models.ProductWarehouse warehouse)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", warehouse.Id.ToString()));
            GenericResult result = execute_transaction("delete_productwarehouse", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


        public Result getProductWarehouses(Models.ProductWarehouse warehouse)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            //if (warehouse.Max_capacity != "") parameters.Add(new Parameter("max_capacity", warehouse.Max_capacity));
            if (warehouse.Product_id != 0) parameters.Add(new Parameter("product_id", warehouse.Product_id.ToString()));
            if (warehouse.Type_id != 0) parameters.Add(new Parameter("type_id", warehouse.Type_id.ToString()));
            GenericResult result = execute_function("get_productwarehouses2", parameters);
            List<Models.ProductWarehouse> warehouses = new List<Models.ProductWarehouse>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    warehouses.Add(new Models.ProductWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), int.Parse(r.getColumn(3)), int.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), int.Parse(r.getColumn(7))));
                }
                return new Result(warehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
