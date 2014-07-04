using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Subasta : TipoPublicacion
    {

        public Subasta(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }

        public override bool VisibilidadStockParaEditar()
        {
            return false;
        }

        public override string mensajeParaPausada()
        {
            return "";
        }

        public override List<Estado> estadosParaEditarPublicada()
        {
            var estados = new List<Estado>();
            estados.Add(new Finalizada(4, "Finalizada"));
           
            return estados;
        }
    }
}
