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

    }
}
