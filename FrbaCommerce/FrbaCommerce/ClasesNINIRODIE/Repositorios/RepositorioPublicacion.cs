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
        private String fecha;

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

        public RepositorioPublicacion()
        {
            fecha = DBTypeConverter.ToSQLDateTime(FechaSistema.Instance.fecha);
        }

        public Decimal BuscarVendedor(Decimal id_publicacion)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION " +
                "WHERE PUB_PUBLICACION_ID = '{0}'", id_publicacion);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PUBLICACION");

            return ((dataRow.ToList<Publicacion>(this.DataRowToPublicacion)).First()).vendedor;
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
           
                return new Publicacion(publicacionID, descripcion, tipo, visibilidad, vendedorCodigo, estado, permitePregunta, stock,
                fechaVto, fechaInit, precio);
            
        }

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

        public List<Publicacion> BuscarPublicadasComprarOfertar(Decimal tipo, Decimal estado, Decimal codigoUsuario)
        {
            var query = this.QueryPublicacion(tipo, estado, codigoUsuario);

            return this.BuscarPublicaciones(query);
        }
        private String QueryPublicacion(Decimal tipo, Decimal estado, Decimal codigoUsuario)
        {
            return String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION " +
                "WHERE PUB_ESTADO = '{0}' AND PUB_TIPO = '{1}' AND PUB_STOCK > 0 " +
                "AND PUB_FECHA_VENCIMIENTO > '{2}' AND PUB_VENDEDOR <> '{3}'" +
                "ORDER BY PUB_VISIBILIDAD_CODIGO ASC", estado, tipo,
                fecha, codigoUsuario);
        }
        
        public List<Publicacion> FiltrarPublicacionesPorDescripcionYRubro(System.Windows.Forms.CheckedListBox.CheckedItemCollection rubrosCheck,
            string descripcionAContener, Decimal tipo, Decimal estado, Decimal codigoUsuario)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION WHERE " +
                "PUB_FECHA_VENCIMIENTO > '{3}' AND PUB_TIPO = '{1}' " +
                "AND PUB_ESTADO = '{2}' AND PUB_STOCK > 0 AND " + 
                "PUB_DESCRIPCION LIKE '%{0}%' AND PUB_VENDEDOR <> '{4}'" +
                this.ArmarSubquery(rubrosCheck) + 
                " ORDER BY PUB_VISIBILIDAD_CODIGO ASC", descripcionAContener, tipo, estado,
                fecha, codigoUsuario);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PUBLICACION");

            return dataRow.ToList<Publicacion>(this.DataRowToPublicacion);
        }

        private String ArmarSubquery(System.Windows.Forms.CheckedListBox.CheckedItemCollection rubrosCheck)
        {
            if(rubrosCheck.Count > 0)
                return String.Format(@"AND PUB_PUBLICACION_ID IN (SELECT PR_PUBLICACION_ID FROM NINIRODIE.PUBLICACION_RUBRO " +
                    " WHERE PR_RUBRO_ID IN (" + this.ArmarQueryParaRubros(rubrosCheck) + "))");
            return "";
        }

        private String ArmarQueryParaRubros(System.Windows.Forms.CheckedListBox.CheckedItemCollection rubrosCheck)
        {
            String restoQuery = "";
            String query = "";

            foreach (Rubro rubro in rubrosCheck)
            {
                query = String.Format(@" '{0}',", rubro.rubro_id);
                restoQuery = String.Concat(restoQuery, query);
            }
            if(restoQuery != "")
                return restoQuery.Substring(0, restoQuery.LastIndexOf(","));
            return restoQuery;
        }

        public int CantidadPublicacionesGratuitasDelUsuario(Decimal codigoUsuario)
        {
            var query = String.Format(@"SELECT COUNT(*) AS CANTIDAD_GRATUITAS FROM NINIRODIE.PUBLICACION " +
                "WHERE PUB_VENDEDOR = '{0}' AND PUB_ESTADO = 1 AND PUB_VISIBILIDAD_CODIGO IN " +
                "(SELECT VIS_VISIBILIDAD_CODIGO FROM NINIRODIE.VISIBILIDAD WHERE VIS_DESCRIPCION = 'Gratis')"
                , codigoUsuario);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaListado(query, new DataTable());

            return (dataRow.ToList<int>(row => int.Parse(row["CANTIDAD_GRATUITAS"].ToString()))).First();
        }

        public List<Facturable> BuscarPublicacionesParaFacturar(Decimal codigoUsuario, int cantidad)
        {
            var query = String.Format(@"SELECT TOP {1} * FROM NINIRODIE.PUBLICACION " +
                "WHERE PUB_VENDEDOR = '{0}' AND PUB_PUBLICACION_ID NOT IN " +
                "(SELECT ITEM_PUBLICACION_ID FROM NINIRODIE.ITEM WHERE ITEM_MONTO = " +
                "(SELECT VIS_PRECIO FROM NINIRODIE.VISIBILIDAD WHERE VIS_VISIBILIDAD_CODIGO " +
                "= PUB_VISIBILIDAD_CODIGO))", codigoUsuario, cantidad);

            var publicaciones = this.BuscarPublicaciones(query);

            var facturables = new List<Facturable>();

            foreach (Publicacion publicacion in publicaciones)
            {
                Visibilidad visibilidad = RepositorioVisibilidad.Instance.BuscarVisibilidad(publicacion.visibilidad_codigo);

                Facturable facturable = new Facturable(publicacion.publicacion_id, publicacion.vendedor,
                    visibilidad.precio, 1, FechaSistema.Instance.fecha);
                
                facturables.Add(facturable);
            }

            return facturables;
        }

        public Publicacion BuscarPublicaciones(Decimal codigo)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.PUBLICACION WHERE PUB_PUBLICACION_ID = '{0}'", codigo);

            return (this.BuscarPublicaciones(query)).First();
        }
    }
}

                            