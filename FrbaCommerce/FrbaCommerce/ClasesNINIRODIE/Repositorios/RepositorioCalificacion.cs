using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

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

        public void InsertarCalificacion(Decimal comprador, String comentario, 
            Decimal calificacion, Decimal compra)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.CALIFICACIONES " +
                "(CALI_COMPRADOR, CALI_DESCRIPCION, CALI_ESTRELLAS, CALI_COMPRA)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", comprador, comentario,
                calificacion, compra);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }
    }
}
