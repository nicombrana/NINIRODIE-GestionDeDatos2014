using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;

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
            var subastaId = Decimal.Parse(row["OF_SUBASTA_ID"].ToString();
            var monto = Decimal.Parse(row["OF_MONTO"].ToString());
            var fecha = DateTime.Parse(row["OF_FECHA"].ToString());
            var comprador = Decimal.Parse(row["OF_COMPRADOR"].ToString());

            return new Oferta(id, subastaId, monto, fecha, comprador);
        }

    }
}
