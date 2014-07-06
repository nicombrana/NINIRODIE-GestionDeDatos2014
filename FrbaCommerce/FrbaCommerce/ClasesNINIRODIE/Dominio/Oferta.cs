using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Oferta
    {
        public Decimal oferta_id { get; set; }
        public Decimal subasta_id { get; set; }
        public Decimal monto { get; set; }
        public DateTime fecha { get; set; }
        public Decimal compradorId { get; set; }

        public Oferta() { }

        public Oferta(Decimal id, Decimal subastaId, Decimal monto, DateTime fecha, Decimal idComprador) : 
            this(subastaId, monto, fecha, idComprador)
        {
            oferta_id = id;
            subasta_id = subastaId;
            this.monto = monto;
            this.fecha = fecha;
            compradorId = idComprador;
        }

        public Oferta(Decimal subastaId, Decimal monto, DateTime fecha, Decimal idComprador)
        {
            subasta_id = subastaId;
            this.monto = monto;
            this.fecha = fecha;
            compradorId = idComprador;
        }
    }
}
