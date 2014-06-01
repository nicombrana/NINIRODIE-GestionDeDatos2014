using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Factura
    {
        Decimal id_fatcura { get; set; }
        Decimal publicacion_id { get; set; }
        Decimal cantidad_vendida { get; set; }
        String medios_de_pago { get; set; }
        Char pagada { get; set; }
        DateTime fecha { get; set; }
        Decimal comprador { get; set; }

    }
}
