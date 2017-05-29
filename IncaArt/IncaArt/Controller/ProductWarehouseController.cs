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
            GenericResult result = execute_function("get_productWarehouses", parameters);
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
            GenericResult result = execute_function("get_productWarehouse", parameters);
            if (result.success)
            {
                var r = result.data[0];
                Models.ProductWarehouse productWarehouse = new Models.ProductWarehouse(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)));
                return new Result(productWarehouse, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
