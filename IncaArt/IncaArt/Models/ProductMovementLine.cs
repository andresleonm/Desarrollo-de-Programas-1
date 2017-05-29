using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ProductMovementLine
    {
        int movementId;
        int id { get; set; }       
        String Almacen { get; set; }
        String CantidadDocumento { get; set; }
        String Cantidad { get; set; }        
        String State { get; set; }
        int idDocumentLine { get; set; }

        
    }
}
