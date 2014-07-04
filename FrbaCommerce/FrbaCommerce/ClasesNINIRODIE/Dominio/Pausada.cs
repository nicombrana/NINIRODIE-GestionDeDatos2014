using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Editar_Publicacion;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Pausada : Estado
    {
        public Pausada(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }

        public override void editar(Publicacion publicacion, BuscarPublicacion ventanaBusqueda)
        {
            MessageBox.Show(this.ArmarMensaje(publicacion), "Atención", MessageBoxButtons.OK);

            var estados = new List<Estado>();
            estados.Add(this);
            estados.Add(new Publicada(1, "Publicada"));

            new EditarPublicacion(publicacion, estados).ShowDialog(ventanaBusqueda);
        }

        private String ArmarMensaje(Publicacion publi)
        {
            String mensaje = "Esta Publicación se encuentra en Estado Pausado\n" +
                "Podrá cambiar el Estado a Publicada " + publi.mensajeParaPausada();

            return mensaje;
        }

        //public override bool visibilidadStockParaEdicion()
        //{
        //    return true;
        //}


    }
}
