using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioOferta
    {
        private static RepositorioOferta _instance;

        public static RepositorioOferta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioOferta();
                }
                return _instance;
            }
        }


        private Oferta DataRowToOferta(DataRow row)
        {
            var id = Decimal.Parse(row["OF_OFERTA_ID"].ToString());
            var subastaId = Decimal.Parse(row["OF_SUBASTA_ID"].ToString());
            var monto = Decimal.Parse(row["OF_MONTO"].ToString());
            var fecha = DateTime.Parse(row["OF_FECHA"].ToString());
            var comprador = Decimal.Parse(row["OF_COMPRADOR"].ToString());

            return new Oferta(id, subastaId, monto, fecha, comprador);
        }


        public Oferta BuscarOferta(Decimal codigoPublicacion)
        {
            var query = String.Format(@"SELECT* FROM NINIRODIE.OFERTAS WHERE " +
                "OF_SUBASTA_ID = '{0}' ORDER BY OF_MONTO DESC", codigoPublicacion);

            var ofertas = this.Buscar(query);

            if (ofertas.Count > 0)
                return ofertas.First();
            else
                return new Oferta();
        }

        private List<Oferta> Buscar(String query)
        {
            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.OFERTAS");

            return dataRow.ToList<Oferta>(this.DataRowToOferta);
        }

        public void GenerarOferta(Oferta ofertaGenerada)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.OFERTAS (OF_SUBASTA_ID, " +
                "OF_MONTO, OF_FECHA, OF_COMPRADOR) VALUES ('{0}', '{1}', '{2}', '{3}')",
                ofertaGenerada.subasta_id, ofertaGenerada.monto, DBTypeConverter.ToSQLDateTime(ofertaGenerada.fecha),
                ofertaGenerada.compradorId);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public List<Oferta> BuscarOfertasHechasAlUsuario(Decimal codigoUsuario, int cantidad)
        {
            var query = String.Format(@"SELECT TOP {0} * FROM "+
                "(SELECT OF_SUBASTA_ID, OF_MONTO, OF_FECHA, OF_COMPRADOR, OF_OFERTA_ID " +
                "FROM NINIRODIE.OFERTAS WHERE OF_SUBASTA_ID IN " +
                "(SELECT PUB_PUBLICACION_ID FROM NINIRODIE.PUBLICACION WHERE PUB_VENDEDOR = '{1}') " +
                "GROUP BY OF_SUBASTA_ID, OF_MONTO, OF_FECHA, OF_COMPRADOR, " +
                "OF_OFERTA_ID) OFERTA1 WHERE OFERTA1.OF_MONTO = (SELECT MAX(OF_MONTO) FROM NINIRODIE.OFERTAS " +
                "WHERE OF_SUBASTA_ID = OFERTA1.OF_SUBASTA_ID) ORDER BY OF_FECHA ASC", cantidad, codigoUsuario);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.OFERTAS");

            return dataRow.ToList<Oferta>(this.DataRowToOferta);
        }
    }
}
