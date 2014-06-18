using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Cliente : Persona
    {
        public String tipo_doc { get; set; }
        public Decimal nro_doc { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fecha_nac { get; set; }
        public Char sexo { get; set; }

        public Cliente(){
        }

        public Cliente(String tipo_docu, Decimal numero_doc, String nombr, String apellid,
            DateTime fechan, Char se, String mal, Decimal Telefon, 
            String ciu, String lodad, String cal, Decimal al, Decimal pi, Decimal cp, 
            Char purta)
        {
            tipo_doc = tipo_docu;
            nro_doc = numero_doc;
            nombre = nombr;
            apellido = apellid;
            fecha_nac = fechan;
            sexo = se;
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
