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

        public ProductMovementType getMovementType(int id,List<ProductMovementType> mov_types)
        {
            if (mov_types == null) return new ProductMovementType();
            foreach (ProductMovementType mt in mov_types)
            {
                if (mt.id == id.ToString())
                    return mt;
            }
            return new ProductMovementType();
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

        public Result deleteMovement(int id,string tipo)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo",tipo));
            parameters.Add(new Parameter("id", id.ToString()));

            GenericResult result = execute_transaction("delete_movement", parameters);
           
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
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
            int id;
            if (result.success)
            {
                try
                {
                    id= Int32.Parse(result.singleValue);
                }
                catch (Exception e)
                {
                    
                    return new Result(null, false, e.Message);
                }
                
                try
                {                    
                    int n = 1;
                    foreach (Models.ProductMovementLine line in movement.detail)
                    {
                        if (line.quantity != 0)
                        {
                            line.id = n;
                            line.movementId = id;
                            Result resultD = pd.insertLine(line);
                            if (!resultD.success)
                            {
                                deleteMovement(id, "P");
                                return new Result(null, resultD.success, resultD.message);
                            }

                            n++;
                        }                         
                    }
                    return new Result(id, true, "");
                }catch(Exception e)
                {
                    deleteMovement(id, "P");
                    return new Result(null, false, e.Message);
                }
                
            }
            return new Result(null, result.success, result.message);
        }


        public Result getMovements()
        {
            List<Parameter> parameters = new List<Parameter>();            
            GenericResult result = execute_function("get_movements", parameters);
            List<Models.ProductMovement> movements = new List<ProductMovement>();
            if (result.success)
            {
                List<ProductMovementType> mov_types = (List<ProductMovementType>) getMovementTypes().data;
                foreach (Row r in result.data)
                {
                    var movementType = getMovementType(Int32.Parse(r.getColumn(1)),mov_types);
                    var detail =new List<Models.ProductMovementLine>();
                    movements.Add(new ProductMovement(Int32.Parse(r.getColumn(0)),movementType, r.getColumn(2), r.getColumn(3),
                         r.getColumn(4), r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8), detail));
                }
                return new Result(movements, true, "");
            }
            return new Result(null, result.success, result.message);
        }
        
        public Result getMovements(char type)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("type", type.ToString()));
            GenericResult result = execute_function("get_movements", parameters);
            List<Models.ProductMovement> movements = new List<ProductMovement>();
            if (result.success)
            {
                List<ProductMovementType> mov_types = (List<ProductMovementType>)getMovementTypes().data;
                foreach (Row r in result.data)
                {
                    var movementType = getMovementType(Int32.Parse(r.getColumn(1)), mov_types);
                    var detail = new List<Models.ProductMovementLine>();
                    movements.Add(new ProductMovement(Int32.Parse(r.getColumn(0)), movementType, r.getColumn(2), r.getColumn(3),
                         r.getColumn(4), r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8), detail));
                }
                return new Result(movements, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getMovement(int id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_movement", parameters);
           
            if (result.success)
            {
                Models.ProductMovement movement= new ProductMovement();
                List<ProductMovementType> mov_types = (List<ProductMovementType>)getMovementTypes().data;
                foreach (Row r in result.data)
                {
                    var movementType = getMovementType(Int32.Parse(r.getColumn(1)), mov_types);
                    var detail = (List<Models.ProductMovementLine>)new ProductMovementDetailController(user, password).getLines(id).data;
                    movement=new ProductMovement(Int32.Parse(r.getColumn(0)), movementType, r.getColumn(2), r.getColumn(3),
                         r.getColumn(4), r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8), detail);
                }
                return new Result(movement, true, "");
            }
            return new Result(null, result.success, result.message);
        }


    }
}
