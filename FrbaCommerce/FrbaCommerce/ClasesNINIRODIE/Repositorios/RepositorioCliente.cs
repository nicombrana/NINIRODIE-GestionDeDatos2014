using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using System.Data;
using FrbaCommerce.Alertas;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioCliente
    {
        private static RepositorioCliente _instance;

        public static RepositorioCliente Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioCliente();
                }
                return _instance;
            }
        }

        public Decimal BuscarCliente(String apellido, String nombre,
                                            Decimal nroDoc, String mail, String tipoDoc)
        {

            var query = String.Format(@"Select CLI_CODIGO FROM NINIRODIE.CLIENTE" +
                "(CLI_APELLIDO = '%busq1%' OR busq1 = '') AND (CLI_NOMBRE = '%busq2%' " +
                "OR busq2 = '') AND ( CLI_TIPO_DOC = '%busq3%' OR busq3 = '') AND " +
                "(CLI_NRO_DOC = '%busq4%' OR busq4 = '') AND (CLI_MAIL = '%busq5%' OR busq5 = '')",
                apellido, nombre, tipoDoc, nroDoc, mail);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.CLIENTE");

            if (dataRow.Count > 1)
            {
                return -1;
            }
            else if(dataRow.Count == 0)
            {
                return -2;
            }
            else
            {
                return (dataRow.ToList<Decimal>(row => Decimal.Parse(row["CLI_CODIGO"].ToString()))).First();
            }
        }

        public void InsertarCliente(Cliente cliente) 
        {

            var query = String.Format(@"INSERT INTO NINIRODIE.CLIENTE " +
                "(CLI_TIPO_DOC, CLI_NRO_DOC, CLI_NOMBRE, CLI_APELLIDO, " +
                "CLI_TELEFONO, CLI_MAIL, CLI_FECHA_NAC, CLI_SEXO, CLI_CIUDAD, " +
                 "CLI_LOCALIDAD, CLI_CALLE, CLI_ALTURA, CLI_PISO, " +
                 "CLI_DEPARTAMENTO, CLI_CODIGO_POSTAL)" +
                "VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', " +
                 "'{9}','{10}','{11}','{12}','{13}','{14}')", cliente.tipo_doc,
                 cliente.nro_doc, cliente.nombre, cliente.apellido, cliente.telefono,
                 cliente.mail, DBTypeConverter.ToSQLDateTime(cliente.fecha_nac), cliente.sexo, cliente.ciud,
                 cliente.loc, cliente.call, cliente.altu, cliente.pis, cliente.puert,
                 cliente.codpos);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);

        }

        public Decimal BuscarClaveCliente(Cliente cliente)
        {
            var query = String.Format(@"Select CLI_CODIGO FROM NINIRODIE.CLIENTE " +
                "WHERE CLI_TELEFONO = '{0}'", cliente.telefono);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.CLIENTE");

            return (dataRow.ToList<Decimal>(row => Decimal.Parse(row["CLI_CODIGO"].ToString()))).First();

            
        }
    }
}
