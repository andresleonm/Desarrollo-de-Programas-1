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
    class MaterialMovementController : DatabaseService
    {
        MaterialMovementDetailController pd;
        public MaterialMovementController(string user,string password) : base(user, password)
        {
            pd = new MaterialMovementDetailController(user, password);
        }

        public Result getMovementTypes()
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo", "M"));
            GenericResult result = execute_function("get_movements_types", parameters);
            List<MaterialMovementType> movementTypes = new List<MaterialMovementType>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    movementTypes.Add(new MaterialMovementType(Int32.Parse(r.getColumn(0)),r.getColumn(1), 
                        r.getColumn(2)[0], Int32.Parse(r.getColumn(3)), r.getColumn(4)));
                }
                return new Result(movementTypes, true, "");
            }
            return new Result(null, result.success, result.message);
       }

        public MaterialMovementType getMovementType(int id,List<MaterialMovementType> mov_types)
        {
            if (mov_types == null) return new MaterialMovementType();
            foreach (MaterialMovementType mt in mov_types)
            {
                if (mt.id == id)
                    return mt;
            }
            return new MaterialMovementType();
        }
        public string getLabel(int clase)
        {
            if (clase == 0)
            {
                return "Orden de Produccion Nro ";
            }else if (clase == 1)
            {
                return "Orden de Compra Nro";
            }
            return "";
        }

        public string getTipo(int clase)
        {
            if (clase == 0)
            {
                return "ORDEN_DE_PRODUCCION";
            }
            else if (clase == 1)
            {
                return "ORDEN_DE_COMPRA";
            }
            return "";
            
        }
        public Result getDocuments(int clase)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo", clase.ToString()));
            GenericResult result = execute_function("get_documentsm", parameters);
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

        public Result insertMovement(Models.MaterialMovement movement)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("tipo",movement.Tipo.id.ToString()));
            parameters.Add(new Parameter("observacion", movement.Observacion));
            parameters.Add(new Parameter("fecha", movement.Fecha));
            parameters.Add(new Parameter("tipodo", movement.TipoDocumentoOrigen));
            parameters.Add(new Parameter("nrodo", movement.NroDocumentoOrigen));
            parameters.Add(new Parameter("tipodf", movement.TipoDocumentoFin));
            parameters.Add(new Parameter("nrodf", movement.NroDocumentoFin));

            GenericResult result = execute_transaction("insert_movementm", parameters);

            if (result.success)
            {
                try
                {
                    int id = Int32.Parse(result.singleValue);
                    int n = 1;
                    foreach (Models.MaterialMovementLine line in movement.detail)
                    {
                        line.id = n;
                        line.movementId = id;
                        Result resultD=pd.insertLine(line);
                        if (!resultD.success)
                            return new Result(null, resultD.success, resultD.message);
                        n++;
                    }
                    return new Result(id, true, "");
                }catch(Exception e)
                {
                    return new Result(null, false, e.Message);
                }
                
            }
            return new Result(null, result.success, result.message);
        }


        public Result getMovements()
        {
            List<Parameter> parameters = new List<Parameter>();            
            GenericResult result = execute_function("get_movementsm", parameters);
            List<Models.MaterialMovement> movements = new List<MaterialMovement>();
            if (result.success)
            {
                List<MaterialMovementType> mov_types = (List<MaterialMovementType>) getMovementTypes().data;
                foreach (Row r in result.data)
                {
                    var movementType = getMovementType(Int32.Parse(r.getColumn(1)),mov_types);
                    var detail =new List<Models.MaterialMovementLine>();
                    movements.Add(new MaterialMovement(Int32.Parse(r.getColumn(0)),movementType, r.getColumn(2), r.getColumn(3),
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
            GenericResult result = execute_function("get_movementm", parameters);
           
            if (result.success)
            {
                Models.MaterialMovement movement= new MaterialMovement();
                List<MaterialMovementType> mov_types = (List<MaterialMovementType>)getMovementTypes().data;
                foreach (Row r in result.data)
                {
                    var movementType = getMovementType(Int32.Parse(r.getColumn(1)), mov_types);
                    var detail = (List<Models.MaterialMovementLine>)pd.getLines(id).data;
                    movement=new MaterialMovement(Int32.Parse(r.getColumn(0)), movementType, r.getColumn(2), r.getColumn(3),
                         r.getColumn(4), r.getColumn(5), r.getColumn(6), r.getColumn(7), r.getColumn(8), detail);
                }
                return new Result(movement, true, "");
            }
            return new Result(null, result.success, result.message);
        }


    }
}
