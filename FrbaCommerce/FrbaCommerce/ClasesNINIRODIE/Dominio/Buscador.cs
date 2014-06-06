using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Buscador
    {
        public bool BuscarBajaCli(string nombre)
        {
            //golpear base con nombre
            if (nombre == "die")
            {
                return true;
            }
            else { return false; }
        }
    
        public bool BuscarBajaEmp(string razonsoc){
            //golpear base con razonsoc
            if (razonsoc == "niidea")
            {
                return true;
            }
            else { return false; }
        }

        public bool BuscarModCli(string nombre){
            //golpear base con nombre
            if (nombre == "die")
            {
                return true;
            }
            else { return false; }
        }

        public bool BuscarModEmp(string razonsoc){
            //golpear base con razonsoc
            if (razonsoc == "niidea")
            {
                return true;
            }
            else { return false; }
        }

    }
}
