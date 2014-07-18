using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio
{
    class ClienteMayorCantidadPublicacionesSinCalificar
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public Decimal cantidadPublicacionesSinCalificar { get; set; }

        public ClienteMayorCantidadPublicacionesSinCalificar(String name, String type, Decimal cant)
        {
            nombre = name;
            tipo = type;
            cantidadPublicacionesSinCalificar = cant;
        }
    }
}
