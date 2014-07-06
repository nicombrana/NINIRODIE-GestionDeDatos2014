using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    abstract class Persona
    {
        public Decimal codigo { get; set; }
        public String mail { get; set; }
        public int telefono { get; set; }
        public String ciud { get; set; }
        public String loc { get; set; }
        public String call { get; set; }
        public int altu { get; set; }
        public int pis { get; set; }
        public int codpos { get; set; }
        public String puert { get; set; }


    }
}
