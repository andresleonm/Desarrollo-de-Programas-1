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
            parameters.Add(new Parameter("product_id", product_line.Product_id.ToString()));
            parameters.Add(new Parameter("quantity", product_line.Quantity.ToString()));
            parameters.Add(new Parameter("produced_quantity", product_line.Produced_quantity.ToString()));
            parameters.Add(new Parameter("unit_of_measure", product_line.Unit_id.ToString()));
            parameters.Add(new Parameter("state", product_line.State));
            parameters.Add(new Parameter("recipe_id", product_line.Recipe_id.ToString()));
            parameters.Add(new Parameter("quantity_warehouse", product_line.Quantity_warehouse.ToString()));
            parameters.Add(new Parameter("warehouse_id", product_line.Warehouse_id.ToString()));
            GenericResult result = execute_transaction("insert_production_detail_products", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getProductLines(int order_id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id",order_id.ToString()));
            GenericResult result = execute_function("get_production_detail_products", parameters);
            List<ProductionOrderProductLine> product_lines = new List<ProductionOrderProductLine>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    // "O"."PRODUCTION_DETAIL_PRODUCTS_ID", "O"."PRODUCTION_ORDER_ID", "O"."PRODUCT_ID", "P"."PRODUCT_NAME", 
                    //"O"."UNIT_OF_MEASURE", "U"."UNIT_OF_MEASURE_NAME", "O"."QUANTITY","O"."PRODUCED_QUANTITY", 
                    //"O"."WAREHOUSE_ID", "W"."WAREHOUSE_NAME", "O"."STATE","O".RECIPE_ID,"R"."RECIPE_NAME"
                    product_lines.Add(new ProductionOrderProductLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)), r.getColumn(3), 
                        Int32.Parse(r.getColumn(4)), r.getColumn(5), Int32.Parse(r.getColumn(6)), Int32.Parse(r.getColumn(7)), 
                        Int32.Parse(r.getColumn(8)), r.getColumn(9), r.getColumn(10), Int32.Parse(r.getColumn(11)), r.getColumn(12)));
                }
                return new Result(product_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

    }
}
