using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Estado
    {
        public Decimal id { get; set; }
        public String descripcion { get; set; }

        public Estado(Decimal id, String descrip)
        {
            this.id = id;
            this.descripcion = descrip;
        }


    }
}
