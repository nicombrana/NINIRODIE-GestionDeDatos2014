using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio
{
    class VendedorMayorCalificacion
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public Decimal cantidadEstrellas { get; set; }

        public VendedorMayorCalificacion(String name, String type, Decimal cantEstrellas)
        {
            nombre = name;
            tipo = type;
            cantidadEstrellas = cantEstrellas;
        }
    }
}
