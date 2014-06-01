using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Empresa : Persona
    {
        String razon_social { get; set; }
        Decimal cuit { get; set; }
        String contacto { get; set; }
        DateTime fecha_creacion { get; set; }
        Char habilitado { get; set; }


    }
}
