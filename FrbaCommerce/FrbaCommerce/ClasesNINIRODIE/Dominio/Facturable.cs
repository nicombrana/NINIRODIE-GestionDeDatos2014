using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Facturable
    {
        public Decimal codigoFacturable { get; set; }
        public Decimal publicacionId { get; set; }
        public Decimal sujetoActivo { get; set; }
        public Decimal montoPorUnidad { get; set; }
        public Decimal cantidad { get; set; }
        public DateTime fecha { get; set; }

        public Facturable(Decimal publicacion, Decimal comprador, Decimal montoAPagar,
            Decimal cantidadAFacturar, DateTime fechaFacturacion)
        {
            publicacionId = publicacion;
            sujetoActivo = comprador;
            montoPorUnidad = montoAPagar;
            cantidad = cantidadAFacturar;
            fecha = fechaFacturacion;
        }

        public Facturable(Decimal id, Decimal publicacion, Decimal comprador, Decimal montoAPagar,
            Decimal cantidadAFacturar, DateTime fechaFacturacion)
            : this(publicacion, comprador, montoAPagar, cantidadAFacturar, fechaFacturacion)
        {
            codigoFacturable = id;
        }
    }
}
