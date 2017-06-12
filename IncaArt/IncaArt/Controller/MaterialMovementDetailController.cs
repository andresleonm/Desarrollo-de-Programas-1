using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views.Warehouse_Module;

namespace WindowsFormsApp1.Controller
{
    class MaterialMovementDetailController : DatabaseService
    {
        public MaterialMovementDetailController(string user, string password):base(user,password){

        }

        public Result getWarehouses(int id)
        {
           
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_materialwarehouse_bymaterial", parameters);
            List<MaterialWarehouseM> productWarehouses = new List<MaterialWarehouseM>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {

                    productWarehouses.Add(new MaterialWarehouseM(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)), r.getColumn(8), r.getColumn(9), Int32.Parse(r.getColumn(10))));
                }
                return new Result(productWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        

        public Result insertLine(Models.MaterialMovementLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("movementid", line.movementId.ToString()));
            parameters.Add(new Parameter("id", line.id.ToString()));
            parameters.Add(new Parameter("material", line.material_id.ToString()));
            parameters.Add(new Parameter("warehouse", line.warehouse_id.ToString()));
            parameters.Add(new Parameter("quantity", line.quantity.ToString()));
            parameters.Add(new Parameter("unit", line.unit_id.ToString()));
            parameters.Add(new Parameter("documentquantity", line.documentQuantity.ToString()));
            parameters.Add(new Parameter("id_document_line", line.idDocumentLine.ToString()));

            GenericResult result = execute_transaction("insert_movement_linem", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getLines(int idMovement)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", idMovement.ToString()));
            GenericResult result = execute_function("get_movement_material_detailm", parameters);
            
            if (result.success)
            {
                List<Models.MaterialMovementLine> lines = new List<Models.MaterialMovementLine>();
                foreach (Row r in result.data)
                {

                    lines.Add(new Models.MaterialMovementLine(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)),
                                                        Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)),
                        Int32.Parse(r.getColumn(4)), r.getColumn(5), r.getColumn(6),r.getColumn(7), Int32.Parse(r.getColumn(8)), 
                        Int32.Parse(r.getColumn(9)), Int32.Parse(r.getColumn(10)), r.getColumn(11), Int32.Parse(r.getColumn(12))));
                }
                return new Result(lines, true, "");
            }
            return new Result(null, result.success, result.message);

        }

    }
}
