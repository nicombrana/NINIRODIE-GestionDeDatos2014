using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using FrbaCommerce.Alertas;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioPreguntas
    {
        private static RepositorioPreguntas _instance;

        public static RepositorioPreguntas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioPreguntas();
                }
                return _instance;
            }
        }

        public List<Pregunta> BuscarPregunta(Decimal Idusuario)
        {
            var query = String.Format(@"select * from gd1c2014.NINIRODIE.PREGUNTA " +
                                       "where PREG_CLIENTE = '{0}'", Idusuario);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PREGUNTA");

            var preguntas = dataRow.ToList<Pregunta>(this.DataRowToPregunta);

            return preguntas;
        }

        public Pregunta BuscarPreguntaPorDescripcion(String desc)
        {
            var query = String.Format(@"select * from gd1c2014.NINIRODIE.PREGUNTA " +
                           "where PREG_DESCRIPCION = '{0}'", desc);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PREGUNTA");

            var preguntas = dataRow.ToList<Pregunta>(this.DataRowToPregunta);

            return preguntas.First();
        }

        public Pregunta DataRowToPregunta(DataRow row)
        {
            var pregunta_id = Decimal.Parse(row["PREG_PREGUNTA_ID"].ToString());
            var publicacion_id = Decimal.Parse(row["PREG_PUBLICACION_ID"].ToString());
            var cliente = Decimal.Parse(row["PREG_CLIENTE"].ToString());
            var descripcion = row["PREG_DESCRIPCION"].ToString();
            var respuesta = row["PREG_RESPUESTA"].ToString();
            var fecha_respuesta = DateTime.Parse(row["PREG_FECHA_RESPUESTA"].ToString());

            var pregunta = new Pregunta(pregunta_id, publicacion_id, cliente, descripcion,
                                        respuesta, fecha_respuesta);
            return pregunta;
        }
    }
}
