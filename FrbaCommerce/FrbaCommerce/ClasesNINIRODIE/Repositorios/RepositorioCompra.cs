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


        public Decimal TraerCompraId(Decimal comprador, Decimal publicacion)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.COMPRA" +
                "WHERE COMP_PUBLICACION_ID = '{0}' AND COMP_COMPRADOR = '{1}'",
                publicacion, comprador);


            return SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.COMPRA").ToList<Decimal>(row => Decimal.Parse(row["COMP_ID_COMPRA"].ToString())).First();
        
            //return dataRow.ToList<Decimal>(row => Decimal.Parse(row["COMP_ID_COMPRA"].ToString())).First();
        
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

        public List<Compra> BuscarComprasHechasAlUsuario(Decimal codigoUsuario, int cantidad)
        {
            var query = String.Format(@"SELECT TOP {1} * FROM NINIRODIE.COMPRA WHERE COMP_PUBLICACION_ID " +
                "IN (SELECT PUB_PUBLICACION_ID FROM NINIRODIE.PUBLICACION WHERE PUB_VENDEDOR = '{0}') " +
                "ORDER BY COMP_FECHA ASC", codigoUsuario, cantidad);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.COMPRA");

            return dataRow.ToList<Compra>(this.DataRowToCompra);
        }

        public List<Compra> BuscarCompraCliente(Decimal codigoUsuario)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.COMPRA WHERE COMP_COMPRADOR = '{0}'", codigoUsuario);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.COMPRA");

            return dataRow.ToList<Compra>(this.DataRowToCompra);
        }

        public Compra DataRowToCompra(DataRow row)
        {
            var codigo = Decimal.Parse(row["COMP_ID_COMPRA"].ToString());
            var cantidad = Decimal.Parse(row["COMP_CANTIDAD"].ToString());
            var fechaCompra = DateTime.Parse(row["COMP_FECHA"].ToString());
            var publicacionID = Decimal.Parse(row["COMP_PUBLICACION_ID"].ToString());
            var comprador = Decimal.Parse(row["COMP_COMPRADOR"].ToString());

            return new Compra(codigo, cantidad, fechaCompra, publicacionID, comprador);
        }
    }
}
