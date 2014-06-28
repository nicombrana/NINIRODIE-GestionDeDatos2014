using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Publicacion
    {
        public Decimal publicacion_id { get; set; }
        public String descripcion { get; set; }
        public String tipo { get; set; }
        public Decimal visibilidad_codigo { get; set; }
        public Decimal vendedor { get; set; }
        public String estado { get; set; }
        public int permite_pregunta { get; set; }
        public Decimal stock { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public DateTime fecha_inicio { get; set; }
        public Decimal precio { get; set; }

        public Publicacion(String desc, String tip, Decimal visibilidad, 
            Decimal vended, String state, int permitePreg, Decimal stoc, 
            DateTime fechaVto, DateTime fechaInit, Decimal price)
        {
            this.descripcion = desc;
            this.tipo = tip;
            this.visibilidad_codigo = visibilidad;
            this.vendedor = vended;
            this.estado = state;
            this.permite_pregunta = permitePreg;
            this.stock = stoc;
            this.fecha_vencimiento = fechaVto;
            this.fecha_inicio = fechaInit;
            this.precio = price;
        }





    }
}
