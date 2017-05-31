using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductionOrderProductLineController : DataService.DatabaseService
    {
        public ProductionOrderProductLineController(string user, string password) : base( user, password)
        {
        }
        public Result insertProductLine(ProductionOrderProductLine product_line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("production_order_id", product_line.Order_Id.ToString()));
            parameters.Add(new Parameter("product_id", product_line.Product.Id.ToString()));
            parameters.Add(new Parameter("quantity", product_line.Quantity.ToString()));
            parameters.Add(new Parameter("produced_quantity", product_line.Produced_quantity.ToString()));
            parameters.Add(new Parameter("unit_of_measure", product_line.Product.Unit.Id.ToString()));
            parameters.Add(new Parameter("state", product_line.State));
            parameters.Add(new Parameter("recipe_id", product_line.Recipe.Id.ToString()));
            parameters.Add(new Parameter("quantity_warehouse", product_line.Quantity_warehouse.ToString()));
            parameters.Add(new Parameter("warehouse_id", product_line.Warehouse.Id.ToString()));
            GenericResult result = execute_transaction("insert_production_detail_products", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
