using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ProductMovement
    {
        int id { get; set; }
        ProductMovementType Tipo { get; set; }
        String Observacion { get; set; }
        String Fecha { get; set; }

        String TipoDocumentoOrigen { get; set; }

        String NroDocumentoOrigen { get; set; }

        String TipoDocumentoFin { get; set; }

        String NroDocumentoFin { get; set; }

        String State { get; set; }

        List<ProductMovementLine> detail { get; set; }

        
    }
}
