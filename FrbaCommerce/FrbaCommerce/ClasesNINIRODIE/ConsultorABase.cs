using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.NINIRODIE
{
    class ConsultorABase
    {
		//SqlHelper("NICOLAS-PC\\SQLEXPRESS", "GD1C2011", "LOOPPA\\nicolas", "");
		private static SqlHelper sqlHelper = new SqlHelper("localhost\\SQLSERVER2005", "GD1C2014", "gd", "gd2014");
        private static SqlConnection sqlConn = new SqlConnection(sqlHelper.GetConnString());
        private static SqlCommand comando;
        private static SqlDataAdapter adapter;
        private static DataSet dataset = new DataSet();
        public static DataSet getDataset()
        {
            return dataset;
        }
        private static string nombreTablaResultado;
        public static string NombreTablaResultado()
        {
            return nombreTablaResultado;
        }
        private static string ultimaQuery;
        public static string UltimaQuery()
        {
            return ultimaQuery;
        }

        #region ABM
        public static bool query(string Consulta)
        {
            //Descripcion en la sobrecarga, deja Resultado como default para el nombre del dataset
            sqlConn.Open();
            dataset = new DataSet();
            comando = new SqlCommand(Consulta, sqlConn);
            adapter = new SqlDataAdapter(comando);
            try { adapter.Fill(dataset, "Resultado"); } catch (Exception) { sqlConn.Close(); return false; }
            nombreTablaResultado = "Resultado";
            ultimaQuery = Consulta;
            sqlConn.Close();
            return true;
        }
        public static bool query(string Consulta, string nombreTablaResult)
        {
            /*
             * Hacemos una consula que nos llega en el string Consulta, y la guardamos en el dataset
             * para acceder mas tarde a los datos usamos el nombre pasado en nombreTablaResult
             * retorna false si hubo un error
             */
            sqlConn.Open();

            dataset = new DataSet();

            comando = new SqlCommand(Consulta, sqlConn);

            adapter = new SqlDataAdapter(comando);
            try
            {
                adapter.Fill(dataset, nombreTablaResult);
            }
            catch (Exception)
            {
                sqlConn.Close();
                return false;
            }
            nombreTablaResultado = nombreTablaResult;
            ultimaQuery = Consulta;

            sqlConn.Close();
            return true;
        }

        /// <summary>
        /// Realiza un insert en la tabla, con los campos pasados.
        /// Ajusta los valores si es un numero o un string, si es string agrega los '
        /// </summary>
        /// <param name="tabla">Tabla donde insertar</param>
        /// <param name="campos">Campos separados por coma</param>
        /// <param name="valores">valores a insertar</param>
        public static bool insert(string tabla, string[] campos, object[] valores)
        {
            if (campos.Length != valores.Length)
            {
                return false;
            }
            else
            {
                string camposQuery = campos[0], valoresQuery = detectarSetearTipo(valores[0]);
                for (int i = 1, len = campos.Length; i < len; i++)
                {
                    camposQuery += ", " + campos[i];
                    valoresQuery += ", " + detectarSetearTipo(valores[i]);
                }
                return query("INSERT INTO NINIRODIE." + tabla + " (" + camposQuery + ") VALUES (" + valoresQuery + ")", "Resultado");
            }

        }
        
        /// <summary>
        /// Realiza una "búsqueda en la base con un simple where.
        /// Detecta el tipo de los valores en valoresComparacion
        /// </summary>
        /// <param name="tabla">nombre de la tabla</param>
        /// <param name="campos">campos a buscar, separados por coma</param>
        /// <param name="camposComparacion"> Campos del lado izq de la comparacion where</param>
        /// <param name="valoresComparacion"> Valores a comprar con los campos anteriores</param>
        public static bool search(string tabla, string campos, string[] camposComparacion, object[] valoresComparacion, string[] tipoSeleccion)
        {
            //Si tienen distinto tamaño, no puedo hacer la consulta
            if (camposComparacion.Length != valoresComparacion.Length)
            {
                return false;
            }
            //Armo la condicion, antes de concatenar me fijo si es numero u string
            string condicionActual = "";
            for (int i = 0; i < camposComparacion.Length; i++)
            {
                if (valoresComparacion[i].ToString() != "")
                {
                    if (tipoSeleccion[i].Contains("textbox"))
                    {
                        if (tipoSeleccion[i].EndsWith("E"))
                        {
                            //Comparacion exacta
                            condicionActual += camposComparacion[i] + " = " + detectarSetearTipo(valoresComparacion[i]) + " and ";
                        }
                        else if (tipoSeleccion[i].EndsWith("NE"))
                        {
                            //Comparacion por distinto
                            condicionActual += camposComparacion[i] + " != " + detectarSetearTipo(valoresComparacion[i]) + " and ";
                        }
                        else if (tipoSeleccion[i].EndsWith("L"))
                        {
                            //Comparacion por Like
                            condicionActual += camposComparacion[i] + " LIKE " + detectarSetearTipo("%" + valoresComparacion[i] + "%") + " and ";
                        }
                        else if (tipoSeleccion[i].EndsWith("RD"))
                        {
                            //Comparacion desde
                            condicionActual += camposComparacion[i].Replace(" desde","") + " >= " + detectarSetearTipo(valoresComparacion[i]) + " and ";
                        }
                        else if (tipoSeleccion[i].EndsWith("RH"))
                        {
                            //Comparacion hasta
                            condicionActual += camposComparacion[i].Replace(" hasta", "") + " <= " + detectarSetearTipo(valoresComparacion[i]) + " and ";
                        }
                        else if (tipoSeleccion[i].EndsWith("IN"))
                        {
                            //Comparacion IN, espera valores separados por ,
                            condicionActual += camposComparacion[i] + " IN (" + valoresComparacion[i] + ") and ";
                        }
                    }
                    else 
                    {
                        condicionActual += camposComparacion[i] + " = " + detectarSetearTipo(valoresComparacion[i]) + " and ";
                    }
                }
            }

            //Saco el and de sobra
            condicionActual = condicionActual.Substring(0, condicionActual.Length - 4);

            //Consulta
            if (query("select " + campos + " from NINIRODIE." + tabla + " where " + condicionActual, "Resultado"))
            {
                return dataset.Tables["Resultado"].Rows.Count > 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Realiza un upd en la base, chequea tipos de los valores
        /// </summary>
        /// <param name="tabla">tabla a updatear</param>
        /// <param name="campos">campos a modificar</param>
        /// <param name="valores">valores a setear en los campos</param>
        /// <param name="condiciones">condiciones enteras para el upd, con las clausulas que correspondan</param>
        public static bool update(string tabla, string[] campos, object[] valores, string condiciones)
        {

            if (campos.Length != valores.Length)
            { 
                return false;
            }
            string set = "";
            for (int i = 0; i < campos.Length; i++)
            {
                if (!Validador.estaVacio(valores[i].ToString()))
                {
                    set += campos[i] + "=" + detectarSetearTipo(valores[i]) + ", ";
                }
            }
            if (set != "" && set.Length >2)
            {
                set = set.Substring(0, set.Length - 2);
                return query("UPDATE NINIRODIE." + tabla + " SET " + set + " " + condiciones);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Realiza una baja, lógica o física.
        /// </summary>
        /// <param name="tabla">tabla a utilizar</param>
        /// <param name="condiciones"> condiciones para el delete, con las clausulas que correspondan</param>
        /// <param name="bajaLogica">true para baja lógica, false para física</param>
        public static bool delete(string tabla, string condiciones, bool bajaLogica)
        {
            if (bajaLogica)
            {
                //Si es una baja lógica realizo un update
                return update(tabla, new string[] { "Habilitado" }, new object[] { 0 }, condiciones);
            }
            else 
            {
                //Sino hago un delete
                return query("DELETE FROM NINIRODIE." + tabla + " " + condiciones);
            }
        }

        /// <summary>
        /// Search mas "performante"
        /// </summary>
        /// <param name="tabla">Tabla a buscar</param>
        /// <param name="condiciones">condiciones, van a estar precedidas por un where</param>
        public static bool existe(string tabla, string condiciones)
        {
            query("select 1 from NINIRODIE." + tabla + " where " + condiciones, "Resultado");
            return dataset.Tables["Resultado"].Rows.Count > 0;
        }
        #endregion 

        #region Listados y Ids

        public static List<string> getNombreSucursales() 
        {
            return getNombres("Direccion", "Sucursales");
        }
        public static List<string> getNombreProvincias() 
        {
            return getNombres("Nombre", "Provincias");
        }
        public static List<string> getTipoEmpleado() 
        {
            return getNombres("Tipo", "TipoEmpleado");
        }
        public static List<string> getNombreFuncionalidades()
        {
            return getNombres("Nombre", "Funcionalidades");
        }
        public static List<string> getNombreRoles()
        {
            return getNombres("Nombre", "Roles");
        }

        /// <summary>
        /// Metodo privado para obtener una lista de campos de una consulta.
        /// </summary>
        /// <param name="campo">campo a buscar</param>
        /// <param name="tabla">tabla</param>
        /// <returns>Lista de strings con los resultados</returns>
        private static List<string> getNombres(string campo, string tabla)
        {
            List<string> listaRetorno = new List<string>();

            if (query("select " + campo + " from NINIRODIE." + tabla, "Resultado"))
            {
                if (dataset.Tables["Resultado"].Rows.Count > 0)
                {
                    foreach (DataRow fila in dataset.Tables["Resultado"].Rows)
                    {
                        listaRetorno.Add(fila.ItemArray.GetValue(0).ToString());
                    }
                }
            }
            return listaRetorno;
        }

      
        public static int getSucursalId(string direccion)
        {
            return getId("IdSucursal", "Direccion", direccion, "Sucursales");
        }
        public static int getProvinciaId(string nombre)
        {
            return getId("IdProvincia", "Nombre", nombre, "Provincias");
        }
        public static int getTipoEmpleadoId(string tipo)
        {
            return getId("IdTipoEmpleado", "Tipo", tipo, "TipoEmpleado");
        }
        public static int getFuncionalidadId(string func)
        {
            return getId("IdFuncio", "Nombre", func, "Funcionalidades");
        }
        public static int getRolId(string rol)
        {
            return getId("IdRol", "Nombre", rol, "Roles");
        }

        /// <summary>
        /// Metodo privado para obtener un Id de una tabla, pensado para buscar por PK
        /// </summary>
        /// <param name="campo">Campo con el Id</param>
        /// <param name="comparacion">Campo a comparar</param>
        /// <param name="valor">valor a comprar</param>
        /// <param name="tabla">tabla</param>
        /// <returns>Entero con el Id buscado</returns>
        private static int getId(string campo, string comparacion, string valor, string tabla)
        {
            int retornar = 0;
            obtenerValorCampo("select " + campo + " from NINIRODIE." + tabla + " where " + comparacion + "='" + valor + "'", ref retornar);
            return retornar;
        }

        #endregion

        #region helpers

        /// <summary>
        ///  Realiza la consulta y retorna true devuelve algo.
        /// </summary>
        /// <param name="Consulta">Consulta a realizar</param>
        public static bool queryNoVacia(string Consulta)
        { 
            //Realizo la consulta
            if (ConsultorABase.query(Consulta))
            {
                //Si devolvio algo
                if (dataset.Tables["Resultado"].Rows.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Retorna el valor del primer campo pasado en la consulta en la variable llenar realizando chequeos
        /// </summary>
        /// <param name="Consulta">Consulta a ejecutar</param>
        /// <param name="llenar">variable a llenar</param>
        /// <returns>true si la var se pudo llenar, sinó false.</returns>
        public static bool obtenerValorCampo(string Consulta, ref int llenar)
        {
            if (queryNoVacia(Consulta))
            {
                //llenamos la variable chequeando si el resultado es entero
                int aux;
                if (int.TryParse(dataset.Tables["Resultado"].Rows[0][0].ToString(), out aux))
                {
                    llenar = aux;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retorna el valor del primer campo pasado en la consulta en la variable llenar realizando chequeos
        /// </summary>
        /// <param name="Consulta">Consulta a ejecutar</param>
        /// <param name="llenar">variable a llenar</param>
        /// <returns>true si la var se pudo llenar, sinó false.</returns>
        public static bool obtenerValorCampo(string Consulta, ref float llenar)
        {
            if (queryNoVacia(Consulta))
            {
                //llenamos la variable chequeando si el resultado es entero
                float aux;
                if (float.TryParse(dataset.Tables["Resultado"].Rows[0][0].ToString(), out aux))
                {
                    llenar = aux;
                    return true;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna el valor del primer campo pasado en la consulta en la variable llenar realizando chequeos
        /// </summary>
        /// <param name="Consulta">Consulta a ejecutar</param>
        /// <param name="llenar">variable a llenar</param>
        /// <returns>true si la var se pudo llenar, sinó false.</returns>
        public static bool obtenerValorCampo(string Consulta, ref string llenar)
        {
            if (queryNoVacia(Consulta))
            {
                //llenamos la variable
                llenar = dataset.Tables["Resultado"].Rows[0][0].ToString();
                return true;
            }
            return false;
        }

        /// <summary>
        /// LLena un datagrid con la consulta pasada
        /// </summary>
        public static void llenarDatagrid(string Consulta, string nombreTablaResult, System.Windows.Forms.DataGridView datagrid)
        {
            /*
             * Implementa el método query y luego llena el datagrid que llega de parámetro
             */
            if (query(Consulta, nombreTablaResult))
            {
                datagrid.DataSource = dataset;
                datagrid.DataMember = nombreTablaResult;
            }
        }
        /// <summary>
        /// LLena el datagrid con la ultima consulta realizada
        /// </summary>
        public static void llenarDatagrid(System.Windows.Forms.DataGridView datagrid)
        {
            if (nombreTablaResultado != "" && dataset.Tables.Count > 0)
            {
                datagrid.DataSource = dataset;
                datagrid.DataMember = nombreTablaResultado;
            }
        }

        /// <summary>
        /// Detecta el tipo del objecto y retorna un string, agregando apos si era string.
        /// Ademas si el valor contiene () asume que es una funcion y lo deja como esta.
        /// </summary>
        public static string detectarSetearTipo(object obj)
        {
            int o;
            float f;
            if (obj.ToString().Contains("()") || obj is int || int.TryParse(obj.ToString(), out o))
            {
                //Es int
                return obj.ToString();
            }
            else
            {
                if (obj is float || float.TryParse(obj.ToString(), out f))
                {
                    //Es float
                    return obj.ToString().Replace(",",".");
                }
                else
                {
                    //Es string, agregar apostrofes
                    return toStr(obj.ToString());
                }
            }
        }

        /// <summary>
        /// Obtiene los campos de una consulta simple.
        /// </summary>
        /// <returns>string con los campos, separados por ,</returns>
        public static string obtenerCamposDeConsulta(string consulta) 
        {
            return consulta.Substring(0,consulta.IndexOf("from")).Replace("select","");
        }

        /// <summary>
        /// Obtiene la tabla de una consulta simple.
        /// </summary>
        /// <returns>string con la primera tabla usada</returns>
        public static string obtenerTablaDeConsulta(string consulta, string schema)
        {
            string aux = consulta.Substring(consulta.IndexOf(schema));
            return aux.Replace(aux.Substring(aux.IndexOf(' ')),"");
        }

        private static string toStr(string s)
        {
            return "\'" + s + "\'";
        }
        #endregion
    }
    }

