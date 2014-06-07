using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Model.Repositorios.DBUtils;
using System.Data;

namespace FrbaBus.Model.Repositorios
{
    public class FuncionalidadesRepository
    {
        private static FuncionalidadesRepository _instance;

        public static FuncionalidadesRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FuncionalidadesRepository();
                return _instance;
            }
        }

        public List<Funcionalidad> All()
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                String.Format(@"
                    SELECT *
                    FROM LCDTMAB.Funciones"),
                "LCDTMAB.LCDTMAB.Funciones");

            return ConvertirAFuncionalidades(dataRows);

        }

        public List<Funcionalidad> FuncionalidadesDisponiblesPara(Rol rol)
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                String.Format(@"
                    SELECT *
                    FROM LCDTMAB.Funciones
                    WHERE Funcion_Codigo NOT IN
                            (SELECT FPR_Funcion_Codigo
                             FROM LCDTMAB.Funciones_Por_Rol
                             WHERE FPR_Rol_Codigo='{0}'
                             GROUP BY FPR_Funcion_Codigo)", rol.Id),
                "LCDTMAB.Funciones");

            return ConvertirAFuncionalidades(dataRows);
        }

        public List<Funcionalidad> FuncionalidadesDeRol(Rol rol)
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                String.Format(@"
                    SELECT Funcion_Codigo, Funcion_Nombre
                    FROM LCDTMAB.Funciones_Por_Rol, LCDTMAB.Funciones
                    WHERE FPR_Rol_Codigo = '{0}'
                        AND FPR_Funcion_Codigo = Funcion_Codigo", rol.Id),
                "LCDTMAB.Funciones");

            return ConvertirAFuncionalidades(dataRows);
        }

        public virtual void ModificarFuncionalidades(Rol rol, List<Funcionalidad> funcionalidadesAEliminar)
        {
            this.AgregarFuncionalidades(rol);
            this.RemoverFuncionalidades(rol, funcionalidadesAEliminar);
        }

        public virtual void AgregarFuncionalidades(Rol rol)
        {
            foreach(Funcionalidad funcion in rol.Funcionalidades){
                SQLUtils.EjecutarConsultaConEfectoDeLado(
                    String.Format(@"IF NOT EXISTS
                                        (SELECT FPR_Rol_Codigo, FPR_Funcion_Codigo
				                         FROM LCDTMAB.Funciones_Por_Rol
				                         WHERE FPR_Rol_Codigo = '{0}' AND FPR_Funcion_Codigo = '{1}')
                                    INSERT INTO LCDTMAB.Funciones_Por_Rol 
                                           (FPR_Rol_Codigo, FPR_Funcion_Codigo)
                                    VALUES ('{0}', '{1}')", rol.Id, funcion.ToString("D")));
            }
        }

        public virtual void RemoverFuncionalidades(Rol rol, List<Funcionalidad> funcionesAEliminar)
        {
            foreach (Funcionalidad funcion in funcionesAEliminar)
            {
                SQLUtils.EjecutarConsultaConEfectoDeLado(
                    String.Format(@"DELETE FROM LCDTMAB.Funciones_Por_Rol 
                                    WHERE FPR_Rol_Codigo='{0}' 
                                          AND FPR_Funcion_Codigo='{1}'", rol.Id, funcion.ToString("D")));
            }
        }

        public List<Funcionalidad> FuncionalidadesDe(string rol)
        {
            var query = String.Format(@"select Funcion_Codigo, Funcion_Nombre
                from LCDTMAB.Funciones 
	                right join LCDTMAB.Funciones_Por_Rol on Funcion_Codigo = FPR_Funcion_Codigo
	                left join LCDTMAB.Roles on FPR_Rol_Codigo = Rol_Codigo
                where Rol_Nombre = '{0}'",
                rol);
            var dataRows = SQLUtils.EjecutarConsultaSimple(query, "LCDTMAB.Funciones");
            var funcionalidades = ConvertirAFuncionalidades(dataRows);
            return funcionalidades;
        }

        #region Private Methods

            private List<Funcionalidad> ConvertirAFuncionalidades(DataRowCollection dataRows)
            {
                return dataRows.ToList<Funcionalidad>(this.DataRowToFuncionalidad);
            }

            private Funcionalidad DataRowToFuncionalidad(DataRow row)
            {
                return (Funcionalidad)int.Parse(row["Funcion_Codigo"].ToString());
            }
        
        #endregion Private Methods
    }
}
