using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio
{
    class VendedoresMayorCantidadProductosNoVendidos
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public Decimal cantidad { get; set; }

        public VendedoresMayorCantidadProductosNoVendidos(String name, String type, Decimal cant)
        {
            nombre = name;
            tipo = type;
            cantidad = cant;
        }
    }
}
