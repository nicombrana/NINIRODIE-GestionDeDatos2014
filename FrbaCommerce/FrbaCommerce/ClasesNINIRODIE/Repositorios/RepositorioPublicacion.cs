using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioPublicacion
    {
        private static RepositorioPublicacion _instance;

        public static RepositorioPublicacion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioPublicacion();
                }
                return _instance;
            }
        }



    }
}
