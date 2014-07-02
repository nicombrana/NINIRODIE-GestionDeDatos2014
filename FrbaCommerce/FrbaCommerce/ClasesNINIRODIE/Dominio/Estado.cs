using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Generar_Publicacion;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public abstract class Estado
    {
        public Decimal id { get; set; }
        public String descripcion { get; set; }


        public virtual void editar(Publicacion publicacion, BuscarPublicacion ventanaBusqueda)
        {
            throw new NotImplementedException();
        }
    }
}
