using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Cliente : Persona
    {
        String tipo_doc { get; set; }
        Decimal nro_doc { get; set; }
        String nombre { get; set; }
        String apellido { get; set; }
        DateTime fecha_nac { get; set; }
        Char sexo { get; set; }


    }
}
