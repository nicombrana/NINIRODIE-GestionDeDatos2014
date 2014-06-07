using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaBus.Model.Repositorios.DBUtils;
using System.Globalization;
using System.Data.SqlTypes;
using FrbaBus.Model.Filtros;

namespace FrbaBus.Model.Repositorios
{
    public class MicrosRepository
    {
        private static MicrosRepository _instance;

        public static MicrosRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MicrosRepository();
                return _instance;
            }
        }

        public virtual List<Micro> All()
        {
            return AllDataRowCollection().ToList<Micro>(this.DataRowToMicro);
        }

        public virtual List<Micro> MicrosPara(FiltroMicro Filtro)
        {
            var marca = Filtro.Marca;
            var modelo = Filtro.Modelo;
            var tipoServicio = Filtro.TipoServicio.Tipo;
            
            var query = String.Format(@"select * from LCDTMAB.Micros
                            where Micro_Marca like '%{0}%'
                            and Micro_Modelo like '%{1}%'
                            and Micro_Tipo_Servicio like '%{2}%' ",
                    marca, modelo, tipoServicio);

            switch (Filtro.Estado)
            {
                case EstadoMicro.Habilitado:
                    query += String.Format(@" 
                        and Micro_Baja_Por_Fin_Vida_Util = '0'
                        and Micro_Baja_Por_Fuera_Servicio = '0'"); 
                    break;
                case EstadoMicro.Fuera_de_servicio:
                    query += " and Micro_Baja_Por_Fuera_Servicio = '1'"; 
                    break;
                case EstadoMicro.Baja:
                    query += " and Micro_Baja_Por_Fin_Vida_Util = '1'";
                    break;
                case EstadoMicro.Todos:
                    break;
            }

            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                    query,
                    "LCDTMAB.Micros");

            var micros = dataRows.ToList<Micro>(this.DataRowToMicro);
            return micros;
        }

        public virtual void InsertarOActualizar(Micro micro)
        {
            if (this.ExistePatente(micro.Patente))
                this.Actualizar(micro);
            else
                this.Insertar(micro);
        }

        public virtual Micro BuscarPorPatente(string patente)
        {
            DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                    String.Format(@"
                        SELECT TOP 1 *
                        FROM LCDTMAB.Micros
                        WHERE Micro_Patente = '{0}'", patente),
                    "LCDTMAB.Micros");

            return dataRows.GetFirstAs<Micro>(this.DataRowToMicro);
        }

        /// <summary>
        /// Este método devuelve los micros disponibles para la fecha de salida desde y la fecha de llegada estimada hasta.
        /// Valida que no tenga viajes asignados en ese período ni antes de 24 hs después de la llegada o antes de la partida.
        /// No tiene en cuenta el lugar en el que está.
        /// </summary>
        /// <param name="desde">la fecha de salida del micro.</param>
        /// <param name="hasta">la fecha de llegada (estimada) del micro a destino.</param>
        /// <returns>La lista de micros que pueden realizar un viaje en ese período</returns>
        public virtual List<Micro> MicrosDisponibleEnFechas(DateTime desde, DateTime hasta, TipoServicio tipoServicio)
        {
            var buscadoDesde = DBTypeConverter.ToSQLDateTime(desde.Subtract(TimeSpan.FromDays(1)));
            var buscadoHasta = DBTypeConverter.ToSQLDateTime(hasta.AddDays(1));

            var query = String.Format(
@"SELECT * FROM LCDTMAB.Micros
WHERE Micro_Tipo_Servicio = '{0}'
AND Micro_Patente NOT IN ( 
       SELECT DISTINCT Viaje_Micro_Patente
       FROM LCDTMAB.Viajes
       WHERE Viaje_Fecha_Salida < '{1}'
         AND Viaje_Fecha_Llegada_Estimada > '{2}') " , tipoServicio, buscadoDesde, buscadoHasta);
 
            var dataRows = SQLUtils.EjecutarConsultaSimple(query, "LCDTMAB.Micros");
            var micros = dataRows.ToList<Micro>(this.DataRowToMicro);
            return micros;
        }

        public virtual List<String> Patentes()
        {
            return AllDataRowCollection().ToList<String>(row => row["Micro_Patente"].ToString());
        }

        public void Actualizar(Micro micro)
        {

            if (micro.Habilitado)
            {

                String fechaAlta = DBTypeConverter.ToSQLDateTime(micro.FechaAlta);
                String fechaBajaDefinitiva = DBTypeConverter.ToSQLDateTime(micro.FechaBajaDefinitiva);
                String fechaFueraServicio = DBTypeConverter.ToSQLDateTime(micro.FechaFueraDeServicio);
                String fechaReinicioServicio = DBTypeConverter.ToSQLDateTime(micro.FechaReinicioDeServicio);

                SQLUtils.EjecutarConsultaConEfectoDeLado(
                        String.Format(@"
	                        UPDATE LCDTMAB.Micros
	                        SET Micro_Baja_Por_Fin_Vida_Util = '{0}', Micro_Baja_Por_Fuera_Servicio = '{1}', 
		                        Micro_Fecha_Alta = '{2}', 
		                        Micro_Fecha_Baja_Definitiva = '{3}', Micro_Fecha_Baja_Por_Fuera_Servicio = '{4}', 
		                        Micro_Fecha_Reinicio_Servicio = '{5}', Micro_KG_Disponibles = '{6}',
		                        Micro_Marca = '{7}', Micro_Modelo = '{8}',
		                        Micro_Patente = '{9}', Micro_Tipo_Servicio = '{10}'
	                        WHERE Micro_Patente = '{9}'",
                            micro.BajaDefinitiva, micro.FueraDeServicio,
                            fechaAlta,
                            fechaBajaDefinitiva, fechaFueraServicio,
                            fechaReinicioServicio, micro.KGSDisponibles,
                            micro.Marca, micro.Modelo,
                            micro.Patente, micro.TipoDeServicio.Tipo)
                        );
            }
            else
                this.CambioDeMicrosCon(micro);
        }

        private void CambioDeMicrosCon(Micro micro)
        {
            ViajesRepository.Instance.ViajesPendientesDe(micro);
            //aca ejecuto el stored procedure que hace la magia correspondiente
        }

        public void Insertar(Micro micro) 
        {
            String fechaAlta = DBTypeConverter.ToSQLDateTime(micro.FechaAlta);
            String fechaBajaDefinitiva = DBTypeConverter.ToSQLDateTime(micro.FechaBajaDefinitiva);
            String fechaFueraServicio = DBTypeConverter.ToSQLDateTime(micro.FechaFueraDeServicio);
            String fechaReinicioServicio = DBTypeConverter.ToSQLDateTime(micro.FechaReinicioDeServicio);

            var query = String.Format(@"
                        INSERT INTO LCDTMAB.Micros
	                        (Micro_Baja_Por_Fin_Vida_Util, Micro_Baja_Por_Fuera_Servicio, 
                            Micro_Fecha_Alta, Micro_Fecha_Baja_Definitiva, 
	                        Micro_Fecha_Baja_Por_Fuera_Servicio, Micro_Fecha_Reinicio_Servicio, 
	                        Micro_KG_Disponibles, Micro_Marca, Micro_Modelo, 
	                        Micro_Patente, Micro_Tipo_Servicio)
                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', 
                                '{6}', '{7}', '{8}', '{9}', '{10}')",
                        micro.BajaDefinitiva, micro.FueraDeServicio, fechaAlta,
                        fechaBajaDefinitiva, fechaFueraServicio, fechaReinicioServicio, micro.KGSDisponibles,
                        micro.Marca, micro.Modelo, micro.Patente, micro.TipoDeServicio.Tipo);
            SQLUtils.EjecutarConsultaConEfectoDeLado(query);

            foreach (Butaca butaca in micro.Butacas) {
                SQLUtils.EjecutarConsultaConEfectoDeLado(String.Format(@"
                        INSERT INTO LCDTMAB.Butacas(Butaca_Piso, 
                                                    Butaca_Numero, 
                                                    Butaca_Tipo, 
                                                    Butaca_Micro_Patente)
                        VALUES ('{0}', '{1}', '{2}', '{3}')",
                        butaca.Piso, butaca.Numero, butaca.Ubicacion[0], micro.Patente));
            }
        }

        #region Private Methods

            private static DataRowCollection AllDataRowCollection()
            {
                return SQLUtils.EjecutarConsultaSimple(
                        String.Format(@"
                            SELECT *
                            FROM LCDTMAB.Micros"),
                        "LCDTMAB.Micros");
            }

            private Micro DataRowToMicro(DataRow row)
            {
                var patente = row["Micro_Patente"].ToString();
                var modelo = row["Micro_Modelo"].ToString();
                var fechaAlta = DBTypeConverter.ToDateTime(row["Micro_Fecha_Alta"]);
                var fechaReinicio = DBTypeConverter.ToDateTime(row["Micro_Fecha_Reinicio_Servicio"]);
                var fueraDeServicio = row["Micro_Fecha_Baja_Por_Fuera_Servicio"];
                var fechaFueraServicio = DBTypeConverter.ToDateTime(fueraDeServicio);
                var baja4gud = row["Micro_Fecha_Baja_Definitiva"];
                DateTime bajaDefinitiva = DBTypeConverter.ToDateTime(baja4gud);
                var tipoServicio = new TipoServicio(row["Micro_Tipo_Servicio"].ToString());
                var marca = row["Micro_Marca"].ToString();

                var estaBajoFueraDeServicio = Boolean.Parse(row["Micro_Baja_Por_Fuera_Servicio"].ToString());
                var estaBajoForGud = Boolean.Parse(row["Micro_Baja_Por_Fin_Vida_Util"].ToString());
                var kgsDisponibles = Double.Parse(row["Micro_KG_Disponibles"].ToString());
                var numero = int.Parse(row["Micro_Numero"].ToString());
                var butacas = ButacasRepository.Instance.BuscarPorPatenteMicro(patente);

                var micro = new Micro(patente, modelo, marca, tipoServicio, fechaAlta, fechaReinicio, 
                    fechaFueraServicio, bajaDefinitiva, estaBajoFueraDeServicio, estaBajoForGud, 
                    kgsDisponibles, numero, butacas);
                return micro;
            }

            private Boolean ExistePatente(string patente)
            {
                DataRowCollection dataRows = SQLUtils.EjecutarConsultaSimple(
                        String.Format(@"
                                SELECT 1
                                WHERE EXISTS (
                                    SELECT Micro_Patente 
                                    FROM LCDTMAB.Micros 
                                    WHERE Micro_Patente = '{0}'
                                )", patente),
                        "LCDTMAB.Micros");

                return dataRows.Count != 0;
            }

        #endregion Private Methods
    }
}
