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
            var cantVendida = Decimal.Parse(row["FAC_CANTIDAD_VENDIDA"].ToString());
            var mediosPago = Decimal.Parse(row["FAC_MEDIOS_DE_PAGO"].ToString());
            var pagada = bool.Parse(row["FAC_PAGADA"].ToString());
            var fechaFactura = DBTypeConverter.ToDateTime(row["FAC_FECHA"].ToString());
            var factTotal = Decimal.Parse(row["FAC_TOTAL"].ToString());

            return new Factura();
        }

    }
}
