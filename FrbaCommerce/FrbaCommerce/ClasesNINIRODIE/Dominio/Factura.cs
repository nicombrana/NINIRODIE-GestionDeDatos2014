using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Factura
    {
        public Decimal id_fatcura { get; set; }
        public Decimal comprador { get; set; }
        public Decimal medios_de_pago { get; set; }
        public bool pagada { get; set; }
        public DateTime fecha { get; set; }
        public Decimal total { get; set; }

        public Factura() { }

        public Factura(Decimal id, Decimal compradorId, Decimal medios_Pago, 
            bool estaPaga, DateTime date, Decimal totall) : this()
        {
            this.id_fatcura = id;
            this.comprador = compradorId;
            this.medios_de_pago = medios_Pago;
            this.pagada = estaPaga;
            this.fecha = date;
            this.total = totall;
        }
    }
}
