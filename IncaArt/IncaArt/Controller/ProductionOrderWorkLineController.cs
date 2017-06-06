using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class ProductionOrderWorkLineController : DataService.DatabaseService
    {
        public ProductionOrderWorkLineController(string user, string password) : base( user, password)
        {
        }
        public Result insertWorkLine(ProductionOrderWorkLine work_line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("production_order_id", work_line.Order_Id.ToString()));
            parameters.Add(new Parameter("worker_id", work_line.Worker_id.ToString()));
            parameters.Add(new Parameter("work_station_id", work_line.Workstation_id.ToString()));
            parameters.Add(new Parameter("quantity_required", work_line.Quantity_required.ToString()));
            parameters.Add(new Parameter("quantity_produced", work_line.Quantity_produced.ToString()));
            parameters.Add(new Parameter("quantity_broken", work_line.Quantity_broken.ToString()));
            parameters.Add(new Parameter("production_time", work_line.Quantity_broken.ToString()));
            parameters.Add(new Parameter("product_id", work_line.Product_id.ToString()));
            parameters.Add(new Parameter("unit_of_measure", work_line.Unit_id.ToString()));
            parameters.Add(new Parameter("observation", work_line.Observation));
            parameters.Add(new Parameter("state", work_line.State));
            GenericResult result = execute_transaction("insert_production_detail_work", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getWorkLines(int order_id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("order_id", order_id.ToString()));
            GenericResult result = execute_function("get_production_detail_works", parameters);
            List<ProductionOrderWorkLine> work_lines = new List<ProductionOrderWorkLine>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    // "O"."PRODUCTION_DETAIL_WORK_ID", "O"."PRODUCTION_ORDER_ID", "O"."WORKER_ID", "T"."NAME","T".PATERNAL_NAME,"T".MATERNAL_NAME,
                    //"O"."WORK_STATION_ID","W"."WORKSTATION_NAME","O"."QUANTITY_REQUIRED","O"."QUANTITY_PRODUCED","O"."QUANTITY_BROKEN","O"."PRODUCTION_TIME",
                    //"O"."PRODUCT_ID","P"."PRODUCT_NAME","O"."UNIT_OF_MEASURE", "U"."UNIT_OF_MEASURE_NAME","O"."OBSERVATION","O"."STATE"
                    work_lines.Add(new ProductionOrderWorkLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)), r.getColumn(3), r.getColumn(4), r.getColumn(5),
                        Int32.Parse(r.getColumn(6)), r.getColumn(7), Int32.Parse(r.getColumn(8)), Int32.Parse(r.getColumn(9)), Int32.Parse(r.getColumn(10)),Double.Parse(r.getColumn(11)),
                        Int32.Parse(r.getColumn(12)), r.getColumn(13), Int32.Parse(r.getColumn(14)), r.getColumn(15), r.getColumn(16), r.getColumn(17)));
                }
                return new Result(work_lines, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateWorkLine(ProductionOrderWorkLine work_line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("production_order_id", work_line.Order_Id.ToString()));
            parameters.Add(new Parameter("production_detail_work_id", work_line.Id.ToString()));
            parameters.Add(new Parameter("worker_id", work_line.Worker_id.ToString()));
            parameters.Add(new Parameter("work_station_id", work_line.Workstation_id.ToString()));
            parameters.Add(new Parameter("quantity_required", work_line.Quantity_required.ToString()));
            parameters.Add(new Parameter("quantity_produced", work_line.Quantity_produced.ToString()));
            parameters.Add(new Parameter("quantity_broken", work_line.Quantity_broken.ToString()));
            parameters.Add(new Parameter("production_time", work_line.Production_time.ToString()));
            parameters.Add(new Parameter("product_id", work_line.Product_id.ToString()));
            parameters.Add(new Parameter("unit_of_measure", work_line.Unit_id.ToString()));
            parameters.Add(new Parameter("observation", work_line.Observation));
            parameters.Add(new Parameter("state", work_line.State));


            GenericResult result = execute_transaction("update_production_detail_work", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
