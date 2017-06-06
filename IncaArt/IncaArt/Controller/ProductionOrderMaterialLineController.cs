using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductionOrderMaterialLineController : DataService.DatabaseService
    {
        public ProductionOrderMaterialLineController(string user, string password) : base( user, password)
        {
        }

        public Result insertMaterialLine(ProductionOrderMaterialLine material_line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("production_order_id", material_line.Order_Id.ToString()));
            parameters.Add(new Parameter("material_id", material_line.Material_id.ToString()));
            parameters.Add(new Parameter("quantity_required", material_line.Quantity_required.ToString()));
            parameters.Add(new Parameter("quantity_taken_real", material_line.Quantity_taken_real.ToString()));
            parameters.Add(new Parameter("unit_of_measure", material_line.Unit_id.ToString()));
            parameters.Add(new Parameter("state", material_line.State));
            parameters.Add(new Parameter("warehouse_id", material_line.Warehouse_id.ToString()));
            GenericResult result = execute_transaction("insert_production_detail_materials", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getMaterialLines(int order_id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", order_id.ToString()));
            GenericResult result = execute_function("get_production_detail_materials", parameters);
            List<ProductionOrderMaterialLine> material_lines = new List<ProductionOrderMaterialLine>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    // "O"."PRODUCTION_DETAIL_MATERIALS_ID", "O"."PRODUCTION_ORDER_ID", "O"."MATERIAL_ID","M"."MATERIAL_NAME", 
                    //"O"."UNIT_OF_MEASURE", "U"."UNIT_OF_MEASURE_NAME", "O"."QUANTITY_REQUIRED","O"."QUANTITY_TAKEN_REAL", 
                    //"O"."WAREHOUSE_ID",  "W"."WAREHOUSE_NAME", "O"."STATE"
                    material_lines.Add(new ProductionOrderMaterialLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)), r.getColumn(3),
                        Int32.Parse(r.getColumn(4)), r.getColumn(5), Int32.Parse(r.getColumn(6)), Int32.Parse(r.getColumn(7)),
                        Int32.Parse(r.getColumn(8)), r.getColumn(9), r.getColumn(10)));
                }
                return new Result(material_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
