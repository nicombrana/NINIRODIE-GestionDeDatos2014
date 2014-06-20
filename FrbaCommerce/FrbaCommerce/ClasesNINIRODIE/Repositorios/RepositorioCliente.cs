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

        public Cliente BuscarClientePorClave(Decimal idcliente)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.CLIENTE " +
                "WHERE CLI_CODIGO = '{0}')", idcliente);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.CLIENTE");

            var clientes = dataRow.ToList<Cliente>(this.DataRowToCliente);

            return clientes.First();
        }

        public void ModificarCliente(Cliente cliente)
        {
            var query = String.Format(@"UPDATE NINIRODIE.CLIENTE SET " + 
                " CLI_APELLIDO = '{0}', CLI_NOMBRE = '{1}', CLI_NRO_DOC = '{2}', " +
                "CLI_TIPO_DOC = '{3}', CLI_TELEFONO = '{4}', CLI_MAIL = '{5}', " +
                "CLI_FECHA_NAC = '{6}', CLI_CIUDAD = '{7}', CLI_LOCALDAD = '{8}', " +
                "CLI_CALLE = '{9}', CLI_ALTURA = '{10}', CLI_PISO = '{11}', " +
                "CLI_DEPARTAMENTO = '{12}', CLI_CODIGO_POSTAL = '{13}', " +
                "WHERE CLI_CODIGO = '{14}'", cliente.apellido, cliente.nombre, 
                cliente.nro_doc, cliente.tipo_doc, cliente.telefono, cliente.mail,
                cliente.fecha_nac, cliente.ciud, cliente.loc, cliente.call, 
                cliente.altu, cliente.pis, cliente.puert, cliente.codpos, cliente.codigo);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
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

        public Cliente DataRowToCliente(DataRow row)
        {
        var nombre = row["CLI_NOMBRE"].ToString();
        var apellido = row["CLI_APELLIDO"].ToString();
        var tipo_docu = row["CLI_TIPO_DOC"].ToString();
        var nro_doc = Decimal.Parse(row["CLI_NRO_DOC"].ToString());
        var telef = Decimal.Parse(row["CLI_TELEFONO"].ToString());
        var meil = row["CLI_MAIL"].ToString();
        var f_nac = DateTime.Parse(row["CLI_FECHA_NAC"].ToString());
        var  sex = Char.Parse(row["CLI_SEXO"].ToString());
        var ciudad = row["CLI_CIUDAD"].ToString();
        var loc = row["CLI_LOCALIDAD"].ToString();
        var call = row["CLI_CALLE"].ToString();
        var altu = Decimal.Parse(row["CLI_ALTURA"].ToString());
        var pis = Decimal.Parse(row["CLI_PISO"].ToString());
        var codpos = Decimal.Parse(row["CLI_CODIGO_POSTAL"].ToString());
        var puert = Char.Parse(row["CLI_DEPARTAMENTO"].ToString());

        var cliente = new Cliente(tipo_docu, nro_doc, nombre, apellido,
            f_nac, sex, meil, telef, ciudad, loc, call, altu, pis, codpos, puert);

            return cliente;
        
        }
    }
}
