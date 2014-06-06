using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    abstract class Persona
    {
        public Decimal codigo { get; set; }
        public String mail { get; set; }
        public Decimal telefono { get; set; }
        public String ciud { get; set; }
        public String loc { get; set; }
        public String call { get; set; }
        public Decimal altu { get; set; }
        public Decimal pis { get; set; }
        public Decimal codpos { get; set; }
        public Char puert { get; set; }


    }
}
