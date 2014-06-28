using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioVisibilidad
    {
        private static RepositorioVisibilidad _instance;

        public static RepositorioVisibilidad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioVisibilidad();
                }
                return _instance;
            }
        }

        public List<Visibilidad> Buscar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD");

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            return dataRow.ToList<Visibilidad>(this.DataRowToVisibilidad);
        }

        private Visibilidad DataRowToVisibilidad(DataRow row)
        {
            var id = Decimal.Parse(row["VIS_VISIBILIDAD_CODIGO"].ToString());
            var descripcion = row["VIS_DESCRIPCION"].ToString();
            var precio = Decimal.Parse(row["VIS_PRECIO"].ToString());
            var porcentajeVenta = Decimal.Parse(row["VIS_POCENTAJE_VENTA"].ToString());
            var cantDias = row["VIS_CANT_DIAS"].ToString();

            return new Visibilidad(id, descripcion, precio, porcentajeVenta, cantDias);
        }

    }
}
