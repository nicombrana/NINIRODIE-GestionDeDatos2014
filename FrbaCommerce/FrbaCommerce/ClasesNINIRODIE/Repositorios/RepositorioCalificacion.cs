using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using System.Data;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioCalificacion
    {
        private static RepositorioCalificacion _instance;

        public static RepositorioCalificacion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioCalificacion();
                }
                return _instance;
            }
        }

        public int BuscarCalif(Decimal comprador, Decimal compra)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.CALIFICACIONES " +
                "WHERE CALI_COMPRADOR = '{0}' AND CALI_COMPRA = '{1}'",
                comprador, compra);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.CALIFICACION");

            if (dataRow.Count > 0)
            {
                return -1;
            }
            return 0;
        }

        public void InsertarCalificacion(Decimal comprador, String comentario, 
            Decimal calificacion, Decimal compra)
        {
            Decimal n = 0;

            n = this.buscarId();

            var query = String.Format(@"INSERT INTO NINIRODIE.CALIFICACIONES " +
                "(CALI_ID_CALIFICACION, CALI_COMPRADOR, CALI_DESCRIPCION, CALI_ESTRELLAS, CALI_COMPRA)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", n, comprador, comentario,
                calificacion, compra);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public Decimal buscarId()
        {
            Decimal m = 0;
            Decimal cerrar = 1;
            while (cerrar == 1)
            {
                var query = String.Format(@"SELECT * FROM NINIRODIE.CALIFICACIONES WHERE CALI_ID_CALIFICACION = '{0}'", m);

                DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.CALIFICACIONES");

                if (dataRow.Count > 0)
                {
                    m = m + 1;
                }
                else
                {
                    cerrar = 0;
                }
            }

            return m;


        }
    }
}
