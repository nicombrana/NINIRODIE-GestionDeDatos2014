using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Generar_Publicacion;
using System.Windows.Forms;
using FrbaCommerce.Editar_Publicacion;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Publicada : Estado
    {
        public Publicada(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }

        public override void editar(Publicacion publicacion, BuscarPublicacion ventanaBusqueda)
        {
            DialogResult resultadoDialogo = MessageBox.Show("Esta publicación se encuentra en estado Activo \n" +
                                            "Solo podrá cambiar el Estado de la publicación a \n" +
                                            "Pausada o Finalizada \n" +
                                            "¿Esta seguro que deseada modificarla?", "Atención", MessageBoxButtons.YesNo);

            if (resultadoDialogo == DialogResult.Yes)
                new EditarPublicacionPublicada(publicacion).ShowDialog(ventanaBusqueda);
        }
    }
}
