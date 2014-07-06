using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Usuario
    {
        public Decimal codigo {get;set;}
        public String id {get; set;}
        public String pass { get; set; }
        public bool habilitado { get; set; }
        public Decimal intentos { get; set; }
        public String tipo { get; set; }
        public bool bloque { get; set; }
        public bool prim { get; set; }
        public Decimal idClienteOEmpresa { get; set; }
        

        public Usuario()
        { 
        }

        public Usuario(Decimal cod, String iD, String password, bool habili, Decimal intent,
            String type, bool bloqueado, bool primer)
        {
            codigo = cod;
            id = iD;
            pass = password;
            habilitado = habili;
            intentos = intent;
            tipo = type;
            bloque = bloqueado;
            prim = primer;
        }

        public Usuario(Decimal cod, String iD, String password, bool habili, Decimal intent,
            String type, bool bloqueado, bool primer, Decimal idCliOEmp) : this(cod, iD, password, habili, intent,
            type, bloqueado, primer)
        {
            idClienteOEmpresa = idCliOEmp;
        }
    }
}
