using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using System.Data;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioCompra
    {
        private static RepositorioCompra _instance;

        public static RepositorioCompra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioCompra();
                }
                return _instance;
            }
        }



        public void Comprar(Compra compra)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.COMPRA " +
                "(COMP_CANTIDAD, COMP_FECHA, COMP_PUBLICACION_ID, COMP_COMPRADOR) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", compra.cantidad, DBTypeConverter.ToSQLDateTime(compra.fecha),
                compra.id_publicacion, compra.id_comprador);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public Decimal ObtenerCodigoCompra(Compra compra)
        {
            var query = String.Format(@"SELECT COMP_ID_COMPRA FROM NINIRODIE.COMPRA WHERE " +
                "COMP_CANTIDAD = '{0}' AND COMP_FECHA = '{1}' AND COMP_PUBLICACION_ID = '{2}' " +
                "AND COMP_COMPRADOR = '{3}'", compra.cantidad,
                DBTypeConverter.ToSQLDateTime(compra.fecha), compra.id_publicacion, compra.id_comprador);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.COMPRA");

            return dataRow.ToList<Decimal>(row => Decimal.Parse(row["COMP_ID_COMPRA"].ToString())).First();
        }
    }
}
