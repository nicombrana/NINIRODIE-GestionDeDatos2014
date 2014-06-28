using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Empresa : Persona
    {
        public String razon_social { get; set; }
        public int cuit { get; set; }
        public String contacto { get; set; }
        public DateTime fecha_creacion { get; set; }
        public Char habilitado { get; set; }

        public Empresa(){
        }

        public Empresa(int nro_cuit, String razon, String contact,
            DateTime fechac, String mal, int Telefon, 
            String ciu, String lodad, String cal, int al, int pi, int cp, 
            String purta)
        {
            cuit = nro_cuit;
            razon_social = razon;
            contacto = contact;
            fecha_creacion = fechac;
            mail = mal;
            telefono = Telefon;
            ciud = ciu;
            loc = lodad;
            altu = al;
            call = cal;
            pis = pi;
            codpos = cp;
            puert = purta;
        }

    }
}
