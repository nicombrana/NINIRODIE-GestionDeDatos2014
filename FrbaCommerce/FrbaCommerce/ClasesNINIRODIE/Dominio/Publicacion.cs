using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Publicacion
    {
        public Decimal publicacion_id { get; set; }
        public String descripcion { get; set; }
        public TipoPublicacion tipo { get; set; }
        public Decimal visibilidad_codigo { get; set; }
        public Decimal vendedor { get; set; }
        public Estado estado { get; set; }
        public bool permitePregunta { get; set; }
        public Decimal stock { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public DateTime fecha_inicio { get; set; }
        public Decimal precio { get; set; }
        public Decimal factura { get; set; }


        public Publicacion(String desc, TipoPublicacion tip, Decimal visibilidad, 
            Decimal vended, Estado state, bool permitePreg, Decimal stoc, 
            DateTime fechaVto, DateTime fechaInit, Decimal price)
        {
            this.descripcion = desc;
            this.tipo = tip;
            this.visibilidad_codigo = visibilidad;
            this.vendedor = vended;
            this.estado = state;
            this.permitePregunta = permitePreg;
            this.stock = stoc;
            this.fecha_vencimiento = fechaVto;
            this.fecha_inicio = fechaInit;
            this.precio = price;
        }

        public Publicacion(Decimal codigo, String desc, TipoPublicacion tip, Decimal visibilidad,
            Decimal vended, Estado state, bool permitePreg, Decimal stoc,
            DateTime fechaVto, DateTime fechaInit, Decimal price) :
            this(desc, tip, visibilidad, vended, state, permitePreg, stoc, fechaVto, fechaInit, price)
        {
            this.publicacion_id = codigo;
        }

        public Publicacion(Decimal codigo, String desc, TipoPublicacion tip, Decimal visibilidad,
            Decimal vended, Estado state, bool permitePreg, Decimal stoc,
            DateTime fechaVto, DateTime fechaInit, Decimal price, Decimal fact)
            : this(desc, tip, visibilidad, vended, state, permitePreg, stoc, fechaVto, fechaInit, price)
        {
            this.publicacion_id = codigo;
            this.factura = fact;
        }







    }
}
