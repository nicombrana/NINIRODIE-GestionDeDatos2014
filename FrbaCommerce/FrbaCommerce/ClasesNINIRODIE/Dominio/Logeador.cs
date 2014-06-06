using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Logeador
    {
        public String id { get; set; }
        public String password { get; set; }

        public bool EsCorrecto(String id, String pass){
           //Aca se debería golpear a la base
            
            if(id == "diego" && pass == "123"){
                return true;
            }

            else { return false; }
        }
    }
}
