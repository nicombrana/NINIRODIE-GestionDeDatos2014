using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioPublicacion
    {
        private static RepositorioPublicacion _instance;

        public static RepositorioPublicacion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioPublicacion();
                }
                return _instance;
            }
        }




        public void AgregarPublicacion(Publicacion publicacion)
        {
            publicacion.publicacion_id = this.ProximoCodigo();

            var query = String.Format(@"INSERT INTO NINIRODIE.PUBLICACION " + 
                            "(PUB_PUBLICACION_ID, PUB_DESCRIPCION, PUB_TIPO, PUB_VISIBILIDAD_CODIGO, " +
                            "PUB_VENDEDOR, PUB_ESTADO, PUB_PERMITE_PREGUNTA, PUB_STOCK, " +
                            "PUB_FECHA_INICIO, PUB_PRECIO)" +
                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                            publicacion.publicacion_id, publicacion.descripcion, publicacion.tipo, publicacion.visibilidad_codigo,
                            publicacion.vendedor, publicacion.estado, publicacion.permitePregunta,
                            publicacion.stock, DBTypeConverter.ToSQLDateTime(publicacion.fecha_inicio), publicacion.precio);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        private Decimal ProximoCodigo()
        {
            var query = String.Format(@"SELECT PUB_PUBLICACION_ID FROM NINIRODIE.PUBLICACION " +
                                        "ORDER BY PUB_PUBLICACION_ID DESC");

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PUBLICACION");

            return (dataRow.ToList<Decimal>(row => Decimal.Parse(row["PUB_PUBLICACION_ID"].ToString()))).First() + 1;
 
 
        }
    }
}
