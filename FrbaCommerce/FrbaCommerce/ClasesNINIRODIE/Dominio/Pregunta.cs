using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Pregunta
    {
        Decimal pregunta_id { get; set; }
        Decimal publicacion_id { get; set; }
        Decimal cliente { get; set; }
        String descripcion { get; set; }
        String respuesta { get; set; }
        DateTime fecha_respuesta { get; set; }

    }
}
