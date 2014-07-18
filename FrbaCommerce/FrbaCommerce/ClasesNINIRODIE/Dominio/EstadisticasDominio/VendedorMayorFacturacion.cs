using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio
{
    class VendedorMayorFacturacion
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public Decimal total { get; set; }

        public VendedorMayorFacturacion(String name, String type, Decimal totall)
        {
            nombre = name;
            tipo = type;
            total = totall;
        }
    }
}
