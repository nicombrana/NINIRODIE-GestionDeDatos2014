using System;
using System.Collections.Generic;
using System.Text;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Editar_Publicacion;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Publicacion
    {
        public Decimal publicacion_id { get; set; }
        public String descripcion { get; set; }
        public TipoPublicacion tipo { get; set; }
        public Decimal visibilidad_codigo { get; set; }
        public Decimal vendedor { get; set; }
        public Estado estado { get; set; }
        public bool permitePregunta { get; set; }
        public Decimal stock { get; set; }
        public Decimal precio { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_vencimiento{ get; set; }

        public Publicacion()
        {}

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



        public void editar(BuscarPublicacion buscarPublicacion)
        {
            this.estado.editar(this, buscarPublicacion);
        }

        public bool visibilidadStockParaEditar()
        {
            return this.tipo.VisibilidadStockParaEditar();
        }

        public void ModificarValoresSiNecesario(String descripcion, TipoPublicacion type, Decimal codigoVisibilidad,
            Estado state, bool permitePregun, Decimal stoc, DateTime fechaInit, Decimal price)
        {
            if (this.fecha_inicio != fechaInit)
                this.fecha_inicio = fechaInit;

            if (this.descripcion != descripcion)
                this.descripcion = descripcion;

            if (this.tipo.id != type.id)
                this.tipo = type;

            if (this.visibilidad_codigo != codigoVisibilidad)
                this.visibilidad_codigo = codigoVisibilidad;

            if (this.estado.id != state.id)
                this.estado = state;

            if (this.permitePregunta != permitePregun)
                this.permitePregunta = permitePregunta;

            if (this.stock != stoc)
                this.stock = stoc;

            if (this.precio != price)
                this.precio = price;
        }

        public bool visibilidadStockParaEdicion()
        {
            return this.estado.visibilidadStockParaEdicion();
        }

        public string mensajeParaPausada()
        {
            return this.tipo.mensajeParaPausada();
        }
    }
}
