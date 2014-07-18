using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class MediosPago
    {
        public Decimal pagoId { get; set; }
        public String descripcion { get; set; }
        public String infoPersonal { get; set; }

        public MediosPago() { }

        public MediosPago(String descrip, String info) : this()
        {
            descripcion = descrip;
            infoPersonal = info;
        }
    }
}
