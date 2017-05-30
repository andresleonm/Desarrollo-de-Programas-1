using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ProductMovement
    {
        public int id { get; set; }
        public ProductMovementType Tipo { get; set; }
        public String Observacion { get; set; }
        public String Fecha { get; set; }

        public String TipoDocumentoOrigen { get; set; }

        public String NroDocumentoOrigen { get; set; }

        public String TipoDocumentoFin { get; set; }

        public String NroDocumentoFin { get; set; }

        public String State { get; set; }

        public List<ProductMovementLine> detail { get; set; }

        
    }
}
