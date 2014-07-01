using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Factura
    {
        Decimal id_fatcura { get; set; }
        Decimal publicacion_id { get; set; }
        Decimal cantidad_vendida { get; set; }
        String medios_de_pago { get; set; }
        bool pagada { get; set; }
        DateTime fecha { get; set; }
        Decimal comprador { get; set; }

        public Factura() { }

        public Factura(Decimal id, Decimal publicacionID, Decimal cantVendida,
            String medioPago, bool pagada, DateTime fecha, Decimal comprador) : this()
        {
            this.id_fatcura = id;
            this.publicacion_id = publicacionID;
            this.cantidad_vendida = cantVendida;
            this.medios_de_pago = medioPago;
            this.pagada = pagada;
            this.fecha = fecha;
            this.comprador = comprador;
        }
    }
}
