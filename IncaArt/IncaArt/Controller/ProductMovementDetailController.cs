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
    class ProductMovementDetailController : DatabaseService
    {
        public ProductMovementDetailController(string user, string password):base(user,password){

        }

        public Result getWarehouses(int id)
        {
           
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_productwarehouse_byproduct", parameters);
            List<ProductWarehouseM> productWarehouses = new List<ProductWarehouseM>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {

                    productWarehouses.Add(new ProductWarehouseM(Int32.Parse(r.getColumn(0)), r.getColumn(1), Int32.Parse(r.getColumn(2)), Int32.Parse(r.getColumn(3)), Int32.Parse(r.getColumn(4)),
                        Int32.Parse(r.getColumn(5)), r.getColumn(6), Int32.Parse(r.getColumn(7)), r.getColumn(8), r.getColumn(9), Int32.Parse(r.getColumn(10))));
                }
                return new Result(productWarehouses, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertLine(Models.ProductMovementLine line)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("movementid", line.movementId.ToString()));
            parameters.Add(new Parameter("id", line.id.ToString()));
            parameters.Add(new Parameter("product", line.product.Id.ToString()));
            parameters.Add(new Parameter("warehouse", line.warehouse.Id.ToString()));
            parameters.Add(new Parameter("quantity", line.quantity.ToString()));
            parameters.Add(new Parameter("unit", line.unit.Id.ToString()));
            parameters.Add(new Parameter("documentquantity", line.documentQuantity.ToString()));
            parameters.Add(new Parameter("id_document_line", line.idDocumentLine.ToString()));

            GenericResult result = execute_transaction("insert_movement_line", parameters);

            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }


    }
}
