using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Generar_Publicacion;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Finalizada : Estado
    {
        public Finalizada(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }

        public override void editar(Publicacion publicacion, BuscarPublicacion ventanaBusqueda)
        {
            MessageBox.Show("Este tipo de Publicación no puede ser modificada",
                "Atención", MessageBoxButtons.OK);
        }
    }
}
