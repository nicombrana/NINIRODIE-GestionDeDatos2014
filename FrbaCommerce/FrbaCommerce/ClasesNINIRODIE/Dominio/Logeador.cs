using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using FrbaCommerce.NINIRODIE;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Logeador
    {
        public string id = null, password = null;

        public bool EsCorrecto(String id, String pass){
           //Aca se debería golpear a la base

            if(id == "diego" && pass == "123"){
                return true;
            }

            else { return false; }
        }
    }
}
