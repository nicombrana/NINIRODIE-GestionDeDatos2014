using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioEstado
    {
        private static RepositorioEstado _instance;

        public static RepositorioEstado Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioEstado();
                }
                return _instance;
            }
        }

        public List<Estado> Buscar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.ESTADO_PUBLICACION");

            return this.Buscar(query);
        }

        public List<Estado> Buscar(String query)
        {
            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.ESTADO_PUBLICACION");

            return dataRow.ToList<Estado>(this.DataRowToEstado);
        }

        public Estado Buscar(Decimal idEstado)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.ESTADO_PUBLICACION WHERE EST_ID_ESTADO = '{0}'", idEstado);

            return this.Buscar(query).First();
        }

        public Estado DataRowToEstado(DataRow row)
        {
            var id = Decimal.Parse(row["EST_ID_ESTADO"].ToString());
            var descripcion = row["EST_DESCRIPCION"].ToString();
            
            if(descripcion == "Pausada")
                return new Pausada(id, descripcion);
            if(descripcion == "Publicada")
                return new Publicada(id, descripcion);
            if (descripcion == "Finalizada")
                return new Finalizada(id, descripcion);
            return new Borrador(id, descripcion);

        }
    }
}
