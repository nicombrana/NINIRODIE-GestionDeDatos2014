using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio
{
    public class Filtro
    {
        public int anio { get; set; }
        public int trimestre { get; set; }
        public Decimal visibilidadCodgio { get; set; }

        public Filtro(int year, int trimester, Decimal visId)
        {
            anio = year;
            trimestre = trimester;
            visibilidadCodgio = visId;
        }
    }
}
