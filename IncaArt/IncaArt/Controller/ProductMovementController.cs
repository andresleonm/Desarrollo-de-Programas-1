using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataService;
using WindowsFormsApp1.Views.Warehouse_Module;

namespace WindowsFormsApp1.Controller
{
    class ProductMovementController : DatabaseService
    {
        ProductMovementDetailController pd;
        public ProductMovementController(string user,string password) : base(user, password)
        {
            pd = new ProductMovementDetailController(user, password);
        }

        public Result getMovementTypes()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo", "P"));
            GenericResult result = execute_function("get_movements_types", parameters);
            List<ProductMovementType> movementTypes = new List<ProductMovementType>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    movementTypes.Add(new ProductMovementType(Int32.Parse(r.getColumn(0)),r.getColumn(1), 
                        r.getColumn(2)[0], Int32.Parse(r.getColumn(3)), r.getColumn(4)));
                }
                return new Result(movementTypes, true, "");
            }
            return new Result(null, result.success, result.message);
       }
        public string getLabel(int clase)
        {
            if (clase == 0)
            {
                return "Pedido Nro ";
            }else if (clase == 1)
            {
                return "Devolucion Nro ";
            }
            return "Orden de Produccion Nro";
        }

        public string getTipo(int clase)
        {
            if (clase == 0)
            {
                return "PEDIDO";
            }
            else if (clase == 1)
            {
                return "DEVOLUCION";
            }
            return "ORDEN_DE_PRODUCCION";
        }
        public Result getDocuments(int clase)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo", clase.ToString()));
            GenericResult result = execute_function("get_documents", parameters);
            List<Document> documents = new List<Document>();
            if (result.success)
            {
                string label = getLabel(clase);
                string type = getTipo(clase);
                foreach (Row r in result.data)
                {
                    documents.Add(new Document(label+r.getColumn(0),r.getColumn(0),type));
                }
                return new Result(documents, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertMovement(Models.ProductMovement movement)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo",movement.Tipo.id));
            parameters.Add(new Parameter("observacion", movement.Observacion));
            parameters.Add(new Parameter("fecha", movement.Fecha));
            parameters.Add(new Parameter("tipodo", movement.TipoDocumentoOrigen));
            parameters.Add(new Parameter("nrodo", movement.NroDocumentoOrigen));
            parameters.Add(new Parameter("tipodf", movement.TipoDocumentoFin));
            parameters.Add(new Parameter("nrodf", movement.NroDocumentoFin));

            GenericResult result = execute_transaction("insert_movement", parameters);

            if (result.success)
            {
                try
                {
                    int id = Int32.Parse(result.singleValue);
                    int n = 1;
                    foreach (Models.ProductMovementLine line in movement.detail)
                    {
                        line.id = n;
                        line.movementId = id;
                        Result resultD=pd.insertLine(line);
                        if (!resultD.success)
                            return new Result(null, resultD.success, resultD.message);
                        n++;
                    }
                    return new Result(null, true, "");
                }catch(Exception e)
                {
                    return new Result(null, false, e.Message);
                }
                
            }
            return new Result(null, result.success, result.message);
        }

       
    }
}
