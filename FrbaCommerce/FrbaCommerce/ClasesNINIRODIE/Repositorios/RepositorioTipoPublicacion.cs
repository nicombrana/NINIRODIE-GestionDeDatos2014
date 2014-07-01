using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioTipoPublicacion
    {
        private static RepositorioTipoPublicacion _instance;

        public static RepositorioTipoPublicacion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioTipoPublicacion();
                }
                return _instance;
            }
        }

        public List<TipoPublicacion> Buscar(String query)
        {
            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.TIPO_PUBLICACION");

            return dataRow.ToList<TipoPublicacion>(this.DataRowToTipoPublicacion);
        }

        public TipoPublicacion Buscar(Decimal TipoPubliID)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.TIPO_PUBLICACION WHERE TIPO_ID = '{0}'", TipoPubliID);

            return this.Buscar(query).First();
        }

        private TipoPublicacion DataRowToTipoPublicacion(DataRow row)
        {
            var id = Decimal.Parse(row["TIPO_ID"].ToString());
            var descripcion = row["TIPO_DESCRIPCION"].ToString();

            if (descripcion == "Subasta")
            {
               return new Subasta(id, descripcion);
            }
            else
            {
              return  new CompraInmediata(id, descripcion);
            }

        }


        public List<TipoPublicacion> Buscar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.TIPO_PUBLICACION");

            return this.Buscar(query);
        }
    }
}
