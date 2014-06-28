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

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.RUBRO");

            return dataRow.ToList<Rubro>(this.DataRowToRubro);
        }



        public Rubro DataRowToRubro(DataRow row)
        {
            var id = Decimal.Parse(row["RUB_RUBRO_ID"].ToString());
            var descripcion = row["RUB_DESCRIPCION"].ToString();

            return new Rubro(id, descripcion);
        }
    }
}
