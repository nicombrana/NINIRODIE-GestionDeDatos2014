using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class FechaSistema
    {
        private static FechaSistema _instance;
        public DateTime fecha;

        public static FechaSistema Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FechaSistema();
                }
                return _instance;
            }
        }

        public FechaSistema()
        {
            fecha = DateTime.Parse(ConfigurationManager.ConnectionStrings["FECHA"].ConnectionString);
        }
    }
}
