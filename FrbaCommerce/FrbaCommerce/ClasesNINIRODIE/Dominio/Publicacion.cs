using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Publicacion
    {
        public Decimal publicacion_id { get; set; }
        public String descripcion { get; set; }
        public Decimal rubro_id { get; set; }
        public String tipo { get; set; }
        public Decimal visibilidad_codigo { get; set; }
        public Decimal vendedor { get; set; }
        public String estado { get; set; }
        public int permite_pregunta { get; set; }
        public Decimal stock { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public DateTime fecha_inicio { get; set; }
        public Decimal precio { get; set; }

        public Publicacion()
        {
        }



    }
}
