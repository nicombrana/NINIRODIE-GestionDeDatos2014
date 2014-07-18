using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using System.Data;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioFactura
    {
        private static RepositorioFactura _instance;

        public static RepositorioFactura Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioFactura();
                }
                return _instance;
            }
        }

        public List<Factura> Buscar(String query)
        {
            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.FACTURA");

            return dataRow.ToList<Factura>(this.DataRowToFactura);
        }

        public List<Factura> Buscar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.FACTURA");

            return this.Buscar(query);
        }

        public Factura Buscar(Decimal idFact)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.FACTURA WHERE FAC_ID_FACTURA = '{0}'", idFact);

            return this.Buscar(query).First();
        }

        //TODO: Arreglar esto con respecto a la Base.

        public Factura DataRowToFactura(DataRow row)
        {
            var id = Decimal.Parse(row["FAC_ID_FACTURA"].ToString());
            var comprador = Decimal.Parse(row["FAC_COMPRADOR"].ToString());
            Decimal mediosPago = Decimal.Parse(row["FAC_MEDIOS_DE_PAGO"].ToString());
            var pagada = bool.Parse(row["FAC_PAGADA"].ToString());
            var fechaFactura = DBTypeConverter.ToDateTime(row["FAC_FECHA"].ToString());
            var factTotal = Decimal.Parse(row["FAC_TOTAL"].ToString());
            /*
            var query = String.Format(@"SELECT PAGO_DESCRIPCION FROM NINIRODIE.MEDIO_PAGO " +
                "WHERE PAGO_ID = '{0}'", mediosPago);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.MEDIO_PAGO");

            var pagoDescripcion = (dataRow.ToList<String>(lambdaRow => lambdaRow["PAGO_DESCRIPCION"].ToString())).First();
            */
            return new Factura(id, comprador, mediosPago, pagada, fechaFactura, factTotal);
        }


        public Decimal ProximoCodigo()
        {
            var query = String.Format(@"SELECT TOP 1 FAC_ID_FACTURA " +
                "FROM NINIRODIE.FACTURA ORDER BY FAC_ID_FACTURA DESC");

            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.FACTURA");

            Decimal codigo = (dataRows.ToList<Decimal>(row => Decimal.Parse(row["FAC_ID_FACTURA"].ToString()))).First();

            return (codigo + 1);
        }

        public void GuardarItem(ItemFactura item)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.ITEM (ITEM_CANTIDAD, ITEM_MONTO, " +
                "ITEM_FACTURA_ID, ITEM_PUBLICACION_ID) VALUES ('{0}','{1}','{2}','{3}')",
                item.cantidad, Decimal.Truncate(item.monto), item.facturaId, item.publicacionId);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public void AlmacenarMedioPago(MediosPago medioPago)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.MEDIO_PAGO " +
                "(PAGO_DESCRIPCION, PAGO_INFO_PERSONAL) VALUES ('{0}', '{1}')",
                medioPago.descripcion, medioPago.infoPersonal);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);

            medioPago.pagoId = this.ObtenerCodigoMedioPago();
        }

        private Decimal ObtenerCodigoMedioPago()
        {
            var query = String.Format(@"SELECT TOP 1 PAGO_ID FROM NINIRODIE.MEDIO_PAGO ORDER BY PAGO_ID DESC");
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.MEDIO_PAGO");

            return (dataRows.ToList<Decimal>(row => Decimal.Parse(row["PAGO_ID"].ToString()))).First();
        }

        public void AlmacenarFactura(Factura factura)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.FACTURA " +
                "(FAC_ID_FACTURA, FAC_COMPRADOR, FAC_MEDIOS_DE_PAGO, FAC_PAGADA, FAC_FECHA, FAC_TOTAL) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", factura.id_fatcura, factura.comprador,
                factura.medios_de_pago, factura.pagada, DBTypeConverter.ToSQLDateTime(FechaSistema.Instance.fecha),
                factura.total);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public void ActualizarMontoFactura(Factura factura)
        {
            var query = String.Format(@"UPDATE NINIRODIE.FACTURA SET FAC_TOTAL = '{0}' " +
                "WHERE FAC_ID_FACTURA = '{1}'", Decimal.Truncate(factura.total), factura.id_fatcura);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }
    }
}
