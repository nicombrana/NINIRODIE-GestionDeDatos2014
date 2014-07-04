using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioRubros
    {
        private static RepositorioRubros _instance;

        public static RepositorioRubros Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioRubros();
                }
                return _instance;
            }
        }

        public List<Rubro> Rubros()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.RUBRO");

            return this.Rubro(query);
        }

        public List<Rubro> Rubro(String query)
        {
            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.RUBRO");

            return dataRow.ToList<Rubro>(this.DataRowToRubro);
        }



        public Rubro DataRowToRubro(DataRow row)
        {
            var id = Decimal.Parse(row["RUB_RUBRO_ID"].ToString());
            var descripcion = row["RUB_DESCRIPCION"].ToString();

            return new Rubro(id, descripcion);
        }

        public List<Rubro> ObtenerRubrosPorPublicacion(Publicacion publicacionAEditar)
        {
            var query = String.Format(@"SELECT RUB_RUBRO_ID, RUB_DESCRIPCION " +
                                       "FROM NINIRODIE.RUBRO, NINIRODIE.PUBLICACION_RUBRO " +
                                       "WHERE PR_RUBRO_ID = RUB_RUBRO_ID AND PR_PUBLICACION_ID = '{0}'",
                                       publicacionAEditar.publicacion_id);

            return this.Rubro(query);
        }
    }
}
