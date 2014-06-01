using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    abstract class Persona
    {
        Decimal codigo { get; set; }
        String mail { get; set; }
        Decimal telefono { get; set; }
        String direccion { get; set; }


    }
}
