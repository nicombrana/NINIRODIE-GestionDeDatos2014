using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Publicacion
    {
        Decimal publicacion_id { get; set; }
        String descripcion { get; set; }
        Decimal rubro_id { get; set; }
        String tipo { get; set; }
        Decimal visibilidad_codigo { get; set; }
        Decimal vendedor { get; set; }
        Char estado { get; set; }
        Char permite_pregunta { get; set; }
        Decimal stock { get; set; }
        DateTime fecha_vencimiento { get; set; }
        DateTime fecha_inicio { get; set; }
        Decimal precio { get; set; }


    }
}
