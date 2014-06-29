using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Visibilidad
    {
        public Decimal visibilidadCodigo { get; set; }
        public String visibiDescripcion { get; set; }
        public Decimal precio { get; set; }
        public Decimal porcentajeVenta { get; set; }
        public Decimal cantDias { get; set; }
        public Decimal habilitado { get; set; }

        public Visibilidad()
        {
            visibilidadCodigo = -1;
        }

        public Visibilidad(Decimal cod, String descrip, Decimal price, Decimal porcentaje, Decimal diasCant, Decimal hab)
        {
            visibilidadCodigo = cod;
            visibiDescripcion = descrip;
            precio = price;
            porcentajeVenta = porcentaje;
            cantDias = diasCant;
            habilitado = hab;
        }



    }
}
