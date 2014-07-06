using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Compra
    {
        public Decimal cod_compra { get; set; }
        public Decimal cantidad { get; set; }
        public DateTime fecha { get; set; }
        public Decimal id_publicacion { get; set; }
        public Decimal id_comprador { get; set; }

        public Compra(Decimal cant, DateTime fec, Decimal pub, Decimal comp)
        {
            cantidad = cant;
            fecha = fec;
            id_publicacion = pub;
            id_comprador = comp;
        }

        public Compra(Decimal cod, Decimal cant, DateTime fec, Decimal pub, Decimal comp)
            : this(cant, fec, pub, comp)
        {
            cod_compra = cod;
        }
    }
}
