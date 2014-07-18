using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class ItemFactura
    {
        public Decimal codigo { get; set; }
        public Decimal cantidad { get; set; }
        public Decimal monto { get; set; }
        public Decimal facturaId { get; set; }
        public Decimal publicacionId { get; set; }

        public ItemFactura(Decimal cant, Decimal mont, Decimal idPubli)
        {
            cantidad = cant;
            monto = mont;
            publicacionId = idPubli;
        }

        public ItemFactura(Decimal cant, Decimal mont, Decimal idFact, Decimal idPubli) : 
            this(cant, mont, idPubli)
        {
            facturaId = idFact;
        }

        public ItemFactura(Decimal Id, Decimal cant, Decimal mont, Decimal idFact, Decimal idPubli)
            : this(cant, mont, idFact, idPubli)
        {
            codigo = Id;
        }
    }
}
