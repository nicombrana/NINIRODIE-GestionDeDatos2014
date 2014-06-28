using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Rubro
    {
        public Decimal rubro_id { get; set; }
        public String rub_descripcion { get; set; }

        public Rubro(Decimal id, String descripcion)
        {
            this.rubro_id = id;
            this.rub_descripcion = descripcion;
        }


    }
}
