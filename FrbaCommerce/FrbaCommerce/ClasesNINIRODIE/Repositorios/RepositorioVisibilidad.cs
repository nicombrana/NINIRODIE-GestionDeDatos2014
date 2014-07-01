using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioVisibilidad
    {
        private static RepositorioVisibilidad _instance;

        public static RepositorioVisibilidad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioVisibilidad();
                }
                return _instance;
            }
        }

        public Visibilidad TraerVisi(Decimal codViejo)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD " +
                "WHERE VIS_VISIBILIDAD_CODIGO = '{0}'", codViejo);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            return (dataRow.ToList<Visibilidad>(this.DataRowToVisibilidad)).First();
        }

        public void ModificarVisi(Visibilidad visi, Decimal codViejo)
        {
            var query = String.Format(@"UPDATE NINIRODIE.VISIBILIDAD SET " +
       "VIS_VISIBILIDAD_CODIGO = '{0}', VIS_DESCRIPCION = '{1}', VIS_PRECIO = '{2}', " +
       "VIS_POCENTAJE_VENTA = '{3}', VIS_CANT_DIAS = '{4}' WHERE VIS_VISIBILIDAD_CODIGO = '{5}'",
       visi.visibilidadCodigo, visi.visibiDescripcion, visi.precio, visi.porcentajeVenta, visi.cantDias, codViejo);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);   
        }

        public void BajarVisi(bool habilitada, Decimal codigo)
        {
            var query = String.Format(@"UPDATE NINIRODIE.VISIBILIDAD SET VIS_HABILITADA = " +
                "'{0}' WHERE VIS_VISIBILIDAD_CODIGO = '{1}'", habilitada, codigo);


            SQLUtils.EjecutarConsultaConEfectoDeLado(query);

        }

        public void InsertarVisibilidad(Visibilidad visi)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.VISIBILIDAD " +
                "(VIS_VISIBILIDAD_CODIGO, VIS_DESCRIPCION, VIS_PRECIO, VIS_POCENTAJE_VENTA, " +
                "VIS_CANT_DIAS, VIS_HABILITADA)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", visi.visibilidadCodigo,
                visi.visibiDescripcion, visi.precio, visi.porcentajeVenta, visi.cantDias, 1);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);


        }

        public Decimal BuscarVisibilidadPorCodigo(Decimal codigo)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD " +
        "WHERE VIS_VISIBILIDAD_CODIGO = '{0}'", codigo);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            if (dataRow.Count > 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public Decimal BuscarVisibilidadPorNombre(String nombre)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD " +
            "WHERE VIS_DESCRIPCION = '{0}'", nombre);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            if (dataRow.Count > 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public Visibilidad BuscarVisibilidad(String nombre)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD "+
                "WHERE VIS_DESCRIPCION = '{0}'", nombre);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            if (dataRow.Count == 0)
            {
                return new Visibilidad();
            }

            return (dataRow.ToList<Visibilidad>(this.DataRowToVisibilidad)).First();
        }

        public List<Visibilidad> Buscar()
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD");

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            return dataRow.ToList<Visibilidad>(this.DataRowToVisibilidad);
        }

        private Visibilidad DataRowToVisibilidad(DataRow row)
        {
            var id = Decimal.Parse(row["VIS_VISIBILIDAD_CODIGO"].ToString());
            var descripcion = row["VIS_DESCRIPCION"].ToString();
            var precio = Decimal.Parse(row["VIS_PRECIO"].ToString());
            var porcentajeVenta = Decimal.Parse(row["VIS_POCENTAJE_VENTA"].ToString());
            var cantDias = Decimal.Parse(row["VIS_CANT_DIAS"].ToString());
            var habili = bool.Parse(row["VIS_HABILITADA"].ToString());

            return new Visibilidad(id, descripcion, precio, porcentajeVenta, cantDias, habili);
        }


        public Visibilidad BuscarVisibilidad(decimal codigoVisibilidad)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.VISIBILIDAD " +
                "WHERE VIS_VISIBILIDAD_CODIGO = '{0}'", codigoVisibilidad);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.VISIBILIDAD");

            return (dataRow.ToList<Visibilidad>(this.DataRowToVisibilidad)).First();
        }
    }
}
