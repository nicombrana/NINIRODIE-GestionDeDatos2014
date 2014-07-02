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
            new EditarPublicacionPausada(publicacion).ShowDialog(ventanaBusqueda);
        }
    }
}
