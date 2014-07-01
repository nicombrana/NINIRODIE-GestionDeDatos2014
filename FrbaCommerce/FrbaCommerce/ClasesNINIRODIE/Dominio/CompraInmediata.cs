using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class CompraInmediata : TipoPublicacion
    {

        public CompraInmediata(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }
    }
}
