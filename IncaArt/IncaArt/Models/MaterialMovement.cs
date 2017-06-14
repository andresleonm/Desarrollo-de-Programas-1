using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class MaterialMovement
    {
        public string movementName;
        public int id { get; set; }
        public MaterialMovementType Tipo { get; set; }
        public String Observacion { get; set; }
        public String Fecha { get; set; }

        public String TipoDocumentoOrigen { get; set; }

        public String NroDocumentoOrigen { get; set; }

        public String TipoDocumentoFin { get; set; }

        public String NroDocumentoFin { get; set; }

        public String State { get; set; }

        public List<MaterialMovementLine> detail { get; set; }

        public MaterialMovement(int id,MaterialMovementType pm,String observacion,String Fecha
                            ,String TipoDocumentoOrigen, String NroDocumentoOrigen
            , String TipoDocumentoFin, String NroDocumentoFin,String State,List<MaterialMovementLine> detail    )
        {
            this.id = id;
            this.Observacion = observacion;
            this.Fecha = Fecha;
            this.TipoDocumentoOrigen = TipoDocumentoOrigen;
            this.NroDocumentoOrigen = NroDocumentoOrigen;
            this.TipoDocumentoFin = TipoDocumentoFin;
            this.NroDocumentoFin = NroDocumentoFin;
            this.State = State;
            this.detail = detail;
            this.Tipo = pm;
        }
        public MaterialMovement()
        {

        }

        public string MovementName
        {
            get
            {
                return "Movimiento Nro - "+ id.ToString();
            }

            set
            {
                movementName = value;
            }
        }


    }
}
