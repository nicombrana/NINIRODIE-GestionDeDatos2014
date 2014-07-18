using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio;
using System.Windows.Forms;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioListado
    {
        private static RepositorioListado _instance;

        public static RepositorioListado Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioListado();
                }
                return _instance;
            }
        }



        public DataGridView BuscarEstadísticas(Filtro filtro, TipoReporte tipoReporte)
        {
            switch (tipoReporte)
            {
                case TipoReporte.Vendedores_Con_Mayor_Cantidad_Productos_No_Vendidos:
                    return this.VendedoresConMayorCantidadProductosNoVendidos(filtro);
                case TipoReporte.Vendedores_Con_Mayor_Facturacion:
                    return this.VendedoresMayorFaturuacion(filtro.anio, filtro.trimestre);
                case TipoReporte.Vendedores_Con_Mayores_Calificaciones:
                    return this.VendedoresConMayoresCalificaciones(filtro.anio, filtro.trimestre);
                case TipoReporte.Clientes_Con_Mayor_Cantidad_Publicaciones_Sin_Calificar:
                    return this.ClientesConMayorCantidadPublicacionesSinCalificar(filtro.anio, filtro.trimestre);
            }
            return new DataGridView();

        }

        private DataGridView VendedoresConMayorCantidadProductosNoVendidos(Filtro filtro)
        {
            var query = String.Format(@"SELECT TOP 5 U.USU_NOMBRE_USUARIO AS USUARIO, " +
                "U.USU_TIPO AS TIPO_DE_USUARIO, SUM(P.PUB_STOCK) AS UNIDADES_SIN_VENDER FROM NINIRODIE.USUARIO U " +
                "JOIN NINIRODIE.PUBLICACION P ON P.PUB_VENDEDOR = U.USU_CODIGO JOIN NINIRODIE.VISIBILIDAD VP " +
                "ON VP.VIS_VISIBILIDAD_CODIGO = P.PUB_VISIBILIDAD_CODIGO WHERE P.PUB_VISIBILIDAD_CODIGO = '{1}' " +
                "AND YEAR(P.PUB_FECHA_INICIO) = '{0}' AND MONTH(P.PUB_FECHA_INICIO) " + this.CalcularTrimestre(filtro.trimestre) +
                "GROUP BY U.USU_NOMBRE_USUARIO, U.USU_TIPO, P.PUB_FECHA_INICIO, P.PUB_VISIBILIDAD_CODIGO " +
                "ORDER BY P.PUB_FECHA_INICIO, P.PUB_VISIBILIDAD_CODIGO, UNIDADES_SIN_VENDER DESC", 
                filtro.anio.ToString(), filtro.visibilidadCodgio);

            DataRowCollection dataRow = EjecutarConsulta(query);

            DataGridView grid = new DataGridView();

            grid.DataSource = dataRow.ToList<VendedoresMayorCantidadProductosNoVendidos>
                (this.DataRowToVendedorMayorCantidadProductosNoVendidos);

            return grid;
        }

        private VendedoresMayorCantidadProductosNoVendidos DataRowToVendedorMayorCantidadProductosNoVendidos(DataRow row)
        {
            var nombre = row["USUARIO"].ToString();
            var tipo = row["TIPO_DE_USUARIO"].ToString();
            var unidadesSinVender = Decimal.Parse(row["UNIDADES_SIN_VENDER"].ToString());

            return new VendedoresMayorCantidadProductosNoVendidos(nombre, tipo, unidadesSinVender);
        }

        private DataGridView ClientesConMayorCantidadPublicacionesSinCalificar(int anio, int trimestre)
        {
            var query = String.Format(@"SELECT TOP 5 USU_NOMBRE_USUARIO, USU_TIPO, " +
                    "COUNT(*) AS CANTIDAD_DE_COMPRAS_SIN_CALIFICAR FROM NINIRODIE.COMPRA, " + 
                    "NINIRODIE.USUARIO WHERE NOT EXISTS " + 
                    "(SELECT * FROM  NINIRODIE.CALIFICACIONES WHERE " + 
                    "CALIFICACIONES.CALI_COMPRA = COMPRA.COMP_ID_COMPRA) " + 
                    "AND COMP_COMPRADOR = USU_CODIGO AND YEAR(COMPRA.COMP_FECHA) = '{0}' " +
                    "AND MONTH(COMPRA.COMP_FECHA) " + this.CalcularTrimestre(trimestre) +
                    "GROUP BY USU_NOMBRE_USUARIO, USU_TIPO ORDER BY CANTIDAD_DE_COMPRAS_SIN_CALIFICAR DESC", anio.ToString());

            DataRowCollection dataRow = EjecutarConsulta(query);

            DataGridView grid = new DataGridView();

            grid.DataSource = dataRow.ToList<ClienteMayorCantidadPublicacionesSinCalificar>
                (this.DataRowToClienteMayorCantidadPublicacionesSinCalificar);

            return grid;
        }

        private ClienteMayorCantidadPublicacionesSinCalificar DataRowToClienteMayorCantidadPublicacionesSinCalificar(DataRow row)
        {
            var nombre = row["USU_NOMBRE_USUARIO"].ToString();
            var tipo = row["USU_TIPO"].ToString();
            var cant = Decimal.Parse(row["CANTIDAD_DE_COMPRAS_SIN_CALIFICAR"].ToString());

            return new ClienteMayorCantidadPublicacionesSinCalificar(nombre, tipo, cant);
        }

        private DataGridView VendedoresConMayoresCalificaciones(int anio, int trimestre)
        {
            var query = String.Format(@"SELECT TOP 5 USU_NOMBRE_USUARIO, USU_TIPO, " +
                "SUM(CALI_ESTRELLAS) AS CANTIDAD_DE_ESTRELLAS " +
                "FROM NINIRODIE.CALIFICACIONES, NINIRODIE.USUARIO, NINIRODIE.COMPRA " +
                "WHERE CALIFICACIONES.CALI_COMPRADOR = USUARIO.USU_CODIGO " + 
                "AND CALIFICACIONES.CALI_COMPRA = COMPRA.COMP_ID_COMPRA AND YEAR(COMPRA.COMP_FECHA) = '{0}' " +
                "AND MONTH(COMPRA.COMP_FECHA) " + this.CalcularTrimestre(trimestre) + "GROUP BY USU_NOMBRE_USUARIO, " +
                "USU_TIPO ORDER BY CANTIDAD_DE_ESTRELLAS DESC", anio.ToString());

            DataRowCollection dataRow = EjecutarConsulta(query);
            
            DataGridView grid = new DataGridView();

            grid.DataSource = dataRow.ToList<VendedorMayorCalificacion>(this.DataRowToVendedorMayorCalificacion);

            return grid;
        }

        private VendedorMayorCalificacion DataRowToVendedorMayorCalificacion(DataRow row)
        {
            var nombre = row["USU_NOMBRE_USUARIO"].ToString();
            var tipo = row["USU_TIPO"].ToString();
            var cantEstrellas = Decimal.Parse(row["CANTIDAD_DE_ESTRELLAS"].ToString());

            return new VendedorMayorCalificacion(nombre, tipo, cantEstrellas);
        }

        private DataGridView VendedoresMayorFaturuacion(int anio, int trimestre)
        {
            var query = String.Format(@"SELECT TOP 5 USU_NOMBRE_USUARIO, USU_TIPO, SUM(FAC_TOTAL) as TOTAL_POR_VENDEDOR " +
                    "FROM NINIRODIE.FACTURA, NINIRODIE.USUARIO WHERE FAC_COMPRADOR = USU_CODIGO " +
                    "AND YEAR(FAC_FECHA) = '{0}' AND MONTH(FAC_FECHA) " + 
                    this.CalcularTrimestre(trimestre) +
                    "GROUP BY USU_NOMBRE_USUARIO, USU_TIPO ORDER BY TOTAL_POR_VENDEDOR DESC", anio.ToString());

            DataRowCollection dataRow = EjecutarConsulta(query);

            DataGridView grid = new DataGridView();
            
            grid.DataSource = dataRow.ToList<VendedorMayorFacturacion>(this.DataRowToVendedorMayorFacturacion);

            return grid;
        }

        private static DataRowCollection EjecutarConsulta(string query)
        {
            DataTable dataTable = new DataTable();

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaListado(query, dataTable);
            return dataRow;
        }

        private VendedorMayorFacturacion DataRowToVendedorMayorFacturacion(DataRow row)
        {
            var nombre = row["USU_NOMBRE_USUARIO"].ToString();
            var tipo = row["USU_TIPO"].ToString();
            var suma = Decimal.Parse(row["TOTAL_POR_VENDEDOR"].ToString());

            return new VendedorMayorFacturacion(nombre, tipo, suma);
        }

        private String CalcularTrimestre(int trimestre)
        {
            switch (trimestre)
            {
                case 1:
                    return "BETWEEN 1 AND 3 ";
                case 2:
                    return "BETWEEN 4 AND 6 ";
                case 3:
                    return "BETWEEN 7 AND 8 ";
                default:
                    return "BETWEEN 9 AND 12 "; 
            }
        }
    }
}
