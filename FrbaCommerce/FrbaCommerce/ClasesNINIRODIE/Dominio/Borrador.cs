using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Editar_Publicacion;
using FrbaCommerce.Generar_Publicacion;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Borrador : Estado
    {
        public Borrador(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }

        public override void editar(Publicacion publicacion, BuscarPublicacion ventanaBusqueda)
        {
            new Genepub(publicacion).ShowDialog(ventanaBusqueda);
        }
    }
}
