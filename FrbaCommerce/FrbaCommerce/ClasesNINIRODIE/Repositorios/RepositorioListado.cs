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



        public DataGridView BuscarEstadísticas(int anio, int semestre, TipoReporte tipoReporte)
        {
            switch (tipoReporte)
            {
                case TipoReporte.Vendedores_Con_Mayor_Cantidad_Productos_No_Vendidos:
                    return this.VendedoresConMayorCantidadProductosNoVendidos(anio, semestre);
                case TipoReporte.Vendedores_Con_Mayor_Facturacion:
                    return this.VendedoresMayorFaturuacion(anio, semestre);
                case TipoReporte.Vendedores_Con_Mayores_Calificaciones:
                    return this.VendedoresConMayoresCalificaciones(anio, semestre);
                case TipoReporte.Clientes_Con_Mayor_Cantidad_Publicaciones_Sin_Calificar:
                    return this.ClientesConMayorCantidadPublicacionesSinCalificar(anio, semestre);
            }
            return new DataGridView();

        }

        private DataGridView VendedoresConMayorCantidadProductosNoVendidos(int anio, int semestre)
        {
            return new DataGridView();
        }

        private DataGridView ClientesConMayorCantidadPublicacionesSinCalificar(int anio, int semestre)
        {
            var query = String.Format(@"", anio.ToString());

            DataRowCollection dataRow = EjecutarConsulta(query);

            DataGridView grid = new DataGridView();

            grid.DataSource = dataRow.ToList<ClienteMayorCantidadPublicacionesSinCalificar>
                (this.DataRowToClienteMayorCantidadPublicacionesSinCalificar);

            return grid;
        }

        private ClienteMayorCantidadPublicacionesSinCalificar DataRowToClienteMayorCantidadPublicacionesSinCalificar(DataRow row)
        {
            var nombre = row[""].ToString();
            var cant = Decimal.Parse(row[""].ToString());

            return new ClienteMayorCantidadPublicacionesSinCalificar(nombre, cant);
        }

        private DataGridView VendedoresConMayoresCalificaciones(int anio, int semestre)
        {
            var query = String.Format(@"SELECT TOP 5(USU_NOMBRE_USUARIO), SUM(CALI_ESTRELLAS) AS CANTIDAD_DE_ESTRELLAS " +
                "FROM NINIRODIE.CALIFICACIONES, NINIRODIE.USUARIO, NINIRODIE.COMPRA " +
                "WHERE CALIFICACIONES.CALI_VENDEDOR = USUARIO.USU_CODIGO " + 
                "AND CALIFICACIONES.CALI_COMPRA = COMPRA.COMP_ID_COMPRA AND YEAR(COMPRA.COMP_FECHA) = '{0}' " +
                "AND MONTH(COMPRA.COMP_FECHA) " + this.CalcularSemetre(semestre) + "GROUP BY USU_NOMBRE_USUARIO " +
                "ORDER BY CANTIDAD_DE_ESTRELLAS DESC", anio.ToString());

            DataRowCollection dataRow = EjecutarConsulta(query);
            
            DataGridView grid = new DataGridView();

            grid.DataSource = dataRow.ToList<VendedorMayorCalificacion>(this.DataRowToVendedorMayorCalificacion);

            return grid;
        }

        private VendedorMayorCalificacion DataRowToVendedorMayorCalificacion(DataRow row)
        {
            var nombre = row["USU_NOMBRE_USUARIO"].ToString();
            var cantEstrellas = Decimal.Parse(row["CANTIDAD_DE_ESTRELLAS"].ToString());

            return new VendedorMayorCalificacion(nombre, cantEstrellas);
        }

        private DataGridView VendedoresMayorFaturuacion(int anio, int semestre)
        {
            var query = String.Format(@"SELECT TOP 5 (USU_NOMBRE_USUARIO), SUM(fac_total) as TOTAL_POR_VENDEDOR " +
                    "FROM NINIRODIE.FACTURA, NINIRODIE.USUARIO WHERE FAC_COMPRADOR = USU_CODIGO " +
                    "AND YEAR(FAC_FECHA) = '{0}' AND MONTH(FAC_FECHA) " + 
                    this.CalcularSemetre(semestre) +
                    "GROUP BY USU_NOMBRE_USUARIO, FAC_TOTAL ORDER BY TOTAL_POR_VENDEDOR DESC", anio.ToString());

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
            var suma = Decimal.Parse(row["TOTAL_POR_VENDEDOR"].ToString());

            return new VendedorMayorFacturacion(nombre, suma);
        }

        private String CalcularSemetre(int semestre)
        {
            if (semestre == 1)
                return "BETWEEN 1 AND 6 ";
            else
                return "BETWEEN 7 AND 12 ";
        }
    }
}
