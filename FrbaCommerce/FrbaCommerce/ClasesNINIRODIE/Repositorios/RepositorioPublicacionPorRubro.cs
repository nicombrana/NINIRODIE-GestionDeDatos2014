using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioPublicacionPorRubro
    {
        private static RepositorioPublicacionPorRubro _instance;

        public static RepositorioPublicacionPorRubro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioPublicacionPorRubro();
                }
                return _instance;
            }
        }


        public void AgregarRubrosAPublicacion(Publicacion publicacion, Rubro rubroSeleccionado)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.PUBLICACION_RUBRO " +
                                        "(PR_PUBLICACION_ID, PR_RUBRO_ID)" +
                                        "VALUES ('{0}', '{1}')", publicacion.publicacion_id, rubroSeleccionado.rubro_id);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }



        public void Quitar(Publicacion publicacion, Rubro rubroCheckeadoAnterior)
        {
            var query = String.Format(@"DELETE FROM NINIRODIE.PUBLICACION_RUBRO " +
                "WHERE PR_PUBLICACION_ID = '{0}' AND PR_RUBRO_ID = '{1}'", publicacion.publicacion_id,
                rubroCheckeadoAnterior.rubro_id);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }
    }
}
