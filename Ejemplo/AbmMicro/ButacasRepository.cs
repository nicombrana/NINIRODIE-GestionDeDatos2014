using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaBus.Model.Repositorios.DBUtils;

namespace FrbaBus.Model.Repositorios
{
    class ButacasRepository
    {
        private static ButacasRepository _instance;

        public static ButacasRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ButacasRepository();
                return _instance;
            }
        }

        public virtual List<Butaca> All()
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                    String.Format(@"
                        SELECT *
                        FROM LCDTMAB.Butacas"),
                    "LCDTMAB.Butacas");

            return dataRows.ToList<Butaca>(this.DataRowToButaca);
        }

        public virtual List<Butaca> BuscarPorPatenteMicro(string patente)
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                    String.Format(@"
                        SELECT *
                        FROM LCDTMAB.Butacas
                        WHERE Butaca_Micro_Patente = '{0}'", patente),
                    "LCDTMAB.Butacas");

            return dataRows.ToList<Butaca>(this.DataRowToButaca);
        }

        public virtual Butaca DataRowToButaca(DataRow row) 
        {
            return new Butaca(
                    row["Butaca_Tipo"].ToString(),
                    int.Parse(row["Butaca_Piso"].ToString()),
                    int.Parse(row["Butaca_Numero"].ToString())
                );
        }

        public Butaca BuscarPorCodigoButaca(int codigoButaca)
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                    String.Format(@"
                        SELECT TOP 1 *
                        FROM LCDTMAB.Butacas
                        WHERE Butaca_Codigo = '{0}'", codigoButaca),
                    "LCDTMAB.Butacas");

            return dataRows.GetFirstAs<Butaca>(this.DataRowToButaca);
        }

        internal List<Butaca> BuscarButacasLibresPorPatenteYViaje(string patente, int viajeCodigo)
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                String.Format(@"
                        SELECT *
                        FROM LCDTMAB.Butacas
                        WHERE Butaca_Micro_Patente = '{0}' AND
                              Butaca_Codigo NOT IN (SELECT Vendible_Butaca_Codigo
                                                    FROM LCDTMAB.Vendibles, LCDTMAB.Viajes
                                                    WHERE Vendible_Viaje_Codigo = Viaje_Codigo AND
                                                          Viaje_Codigo = '{1}' AND
                                                          Viaje_Micro_Patente = '{0}')", patente, viajeCodigo),
                "LCDTMAB.Butacas");

            return dataRows.ToList<Butaca>(this.DataRowToButaca);
        }
    }
}
