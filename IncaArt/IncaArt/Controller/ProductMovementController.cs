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
        public ProductMovementController(string user,string password) : base(user, password)
        {
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
            if (clase == 1)
            {
                return "Pedido Nro ";
            }else if (clase == 2)
            {
                return "Devolucion Nro ";
            }
            return "Orden de Produccion Nro";
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
                foreach (Row r in result.data)
                {
                    documents.Add(new Document(label+r.getColumn(0),r.getColumn(0)));
                }
                return new Result(documents, true, "");
            }
            return new Result(null, result.success, result.message);
        }

       
    }
}
