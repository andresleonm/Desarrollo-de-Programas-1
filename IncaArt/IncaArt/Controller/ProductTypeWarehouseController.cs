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
            GenericResult result = execute_function("get_productTypeWarehouses", parameters);
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


        public Result getProductWarehouse(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_productTypeWarehouse", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.ProductTypeWarehouse productTypeWarehouse = new Models.ProductTypeWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), r.getColumn(2), r.getColumn(3));
                return new Result(productTypeWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }



    }
}
