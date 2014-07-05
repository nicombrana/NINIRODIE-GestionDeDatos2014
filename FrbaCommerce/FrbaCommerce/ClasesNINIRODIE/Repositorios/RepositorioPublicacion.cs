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
            this.AgregarPublicacionBorrador(publicacion);
            
            if (publicacion.estado.id != 2)
            {
                var query = String.Format(@"UPDATE NINIRODIE.PUBLICACION SET PUB_ESTADO = '{0}'" +
                                            "WHERE PUB_PUBLICACION_ID = '{1}'", publicacion.estado.id, publicacion.publicacion_id);

                SQLUtils.EjecutarConsultaConEfectoDeLado(query);
            }
        }

        public void AgregarPublicacionBorrador(Publicacion publicacion)
        {
            publicacion.publicacion_id = this.ProximoCodigo();

            var query = String.Format(@"INSERT INTO NINIRODIE.PUBLICACION " + 
                            "(PUB_PUBLICACION_ID, PUB_DESCRIPCION, PUB_TIPO, PUB_VISIBILIDAD_CODIGO, " +
                            "PUB_VENDEDOR, PUB_ESTADO, PUB_PERMITE_PREGUNTA, PUB_STOCK, " +
                            "PUB_FECHA_INICIO, PUB_PRECIO)" +
                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                            publicacion.publicacion_id, publicacion.descripcion.ToString(), publicacion.tipo.id, publicacion.visibilidad_codigo,
                            publicacion.vendedor, "2", publicacion.permitePregunta,
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

        public List<Publicacion> BuscarPublicaciones(String query)
        {
            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PUBLICACION");

            return dataRow.ToList<Publicacion>(this.DataRowToPublicacion);
 
        }

        public List<Publicacion> BuscarPublicacionesDeVendedor(Decimal usuario)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION WHERE PUB_VENDEDOR = '{0}'", usuario);

            return this.BuscarPublicaciones(query);
        }

        public List<Publicacion> Buscar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION");

            return this.BuscarPublicaciones(query);
        }

        private Publicacion DataRowToPublicacion(DataRow row)
        {
            var publicacionID = Decimal.Parse(row["PUB_PUBLICACION_ID"].ToString());
            var descripcion = row["PUB_DESCRIPCION"].ToString();
            var tipo = this.ObtenerTipoPublicacion(Decimal.Parse(row["PUB_TIPO"].ToString()));
            var visibilidad = Decimal.Parse(row["PUB_VISIBILIDAD_CODIGO"].ToString());
            var vendedorCodigo = Decimal.Parse(row["PUB_VENDEDOR"].ToString());
            var estado = this.ObtenerEstadoPublicacion(Decimal.Parse(row["PUB_ESTADO"].ToString()));
            var permitePregunta = bool.Parse(row["PUB_PERMITE_PREGUNTA"].ToString());
            var stock = Decimal.Parse(row["PUB_STOCK"].ToString());
            var fechaVto = DateTime.Parse(row["PUB_FECHA_VENCIMIENTO"].ToString());
            var fechaInit = DateTime.Parse(row["PUB_FECHA_INICIO"].ToString());
            var precio = Decimal.Parse(row["PUB_PRECIO"].ToString());
            if (!row["PUB_FACTURA"].Equals(DBNull.Value))
            {
                var factura = Decimal.Parse(row["PUB_FACTURA"].ToString());
                return new Publicacion(publicacionID, descripcion, tipo, visibilidad, vendedorCodigo, estado, permitePregunta, stock,
                fechaVto, fechaInit, precio, factura);
            }
            else
            {
                return new Publicacion(publicacionID, descripcion, tipo, visibilidad, vendedorCodigo, estado, permitePregunta, stock,
                fechaVto, fechaInit, precio);
            }
            
        }

        //private Factura ObtenerFactura(Decimal idFact)
        //{
        //    return RepositorioFactura.Instance.Buscar(idFact);
        //}

        private Estado ObtenerEstadoPublicacion(Decimal publiID)
        {
            return RepositorioEstado.Instance.Buscar(publiID);
        }

        private TipoPublicacion ObtenerTipoPublicacion(Decimal tipo)
        {
            return RepositorioTipoPublicacion.Instance.Buscar(tipo);
        }

        public void UpdateEstado(Publicacion publiAEditar)
        {
            var query = String.Format(@"UPDATE NINIRODIE.PUBLICACION SET PUB_ESTADO = '{0}', " +
                "PUB_STOCK = '{1}' WHERE PUB_PUBLICACION_ID = '{2}'", 
                publiAEditar.estado.id, publiAEditar.stock, publiAEditar.publicacion_id);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public void Update(Publicacion publicacion)
        {
            var query = String.Format(@"UPDATE NINIRODIE.PUBLICACION SET " +
                "PUB_DESCRIPCION = '{0}', PUB_TIPO = '{1}', PUB_VISIBILIDAD_CODIGO = '{2}', " +
                "PUB_VENDEDOR = '{3}', PUB_ESTADO = '{4}', PUB_PERMITE_PREGUNTA = '{5}', PUB_STOCK = '{6}', " +
                "PUB_FECHA_INICIO = '{7}', PUB_PRECIO = '{8}' WHERE PUB_PUBLICACION_ID = '{9}'", publicacion.descripcion.ToString(),
                publicacion.tipo.id, publicacion.visibilidad_codigo, publicacion.vendedor, publicacion.estado.id,
                publicacion.permitePregunta, publicacion.stock, DBTypeConverter.ToSQLDateTime(publicacion.fecha_inicio), Decimal.Truncate(publicacion.precio), publicacion.publicacion_id);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public List<Publicacion> BuscarPublicadasComprar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION " +
                "WHERE PUB_ESTADO = '1'  AND PUB_TIPO = '1'");

            return this.BuscarPublicaciones(query);
        }
    }
}

                            