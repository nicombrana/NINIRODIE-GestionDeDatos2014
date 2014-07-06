using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioEmpresa
    {
        private static RepositorioEmpresa _instance;

        public static RepositorioEmpresa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioEmpresa();
                }
                return _instance;
            }
        }

        public int BuscarEmpresa(String razon_soc, String mail,int cuit)
        {
            var query = String.Format(@"Select EMP_CODIGO FROM NINIRODIE.EMPRESA WHERE 1 = 1 ");

            if (razon_soc != "")
            {
                query = query + "AND EMP_RAZON_SOCIAL = '" + razon_soc + "' ";
            }
            if (cuit != 0)
            {
                query = query + "AND EMP_CUIT = " + cuit;
            }
            if (mail != "")
            {
                query = query + "AND EMP_MAIL = '" + mail + "' ";
            }

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.EMPRESA");

            if (dataRow.Count > 1)
            {
                return -1;
            }
            else if (dataRow.Count == 0)
            {
                return -2;
            }
            else
            {
                return (dataRow.ToList<int>(row => int.Parse(row["EMP_CODIGO"].ToString()))).First();
            }
        }

        public void InsertarEmpresa(Empresa empresa)
        {

            var query = String.Format(@"INSERT INTO NINIRODIE.EMPRESA " +
                "(EMP_RAZON_SOCIAL, EMP_CUIT, EMP_CONTACTO, " +
                "EMP_TELEFONO, EMP_MAIL, EMP_FECHA_CREACION, EMP_CIUDAD, " +
                 "EMP_LOCALIDAD, EMP_CALLE, EMP_ALTURA, EMP_PISO, " +
                 "EMP_DEPARTAMENTO, EMP_CODIGO_POSTAL)" +
                "VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', " +
                 "'{9}','{10}','{11}','{12}')",
                 empresa.razon_social, empresa.cuit, empresa.contacto, empresa.telefono,
                 empresa.mail, DBTypeConverter.ToSQLDateTime(empresa.fecha_creacion),
                 empresa.ciud, empresa.loc, empresa.call, empresa.altu, empresa.pis,
                 empresa.puert,empresa.codpos);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);

        }

        public void ModificarEmpresa(Empresa empresa)
        {
            var query = String.Format(@"UPDATE NINIRODIE.EMPRESA SET " +
    " EMP_CONTACTO = '{0}', EMP_RAZON_SOCIAL = '{1}', EMP_CUIT = '{2}', " +
    "EMP_TELEFONO = '{3}', EMP_MAIL = '{4}', " +
    "EMP_FECHA_CREACION = '{5}', EMP_CIUDAD = '{6}', EMP_LOCALIDAD = '{7}', " +
    "EMP_CALLE = '{8}', EMP_ALTURA = '{9}', EMP_PISO = '{10}', " +
    "EMP_DEPARTAMENTO = '{11}', EMP_CODIGO_POSTAL = '{12}' " +
    "WHERE EMP_CODIGO = '{13}'", empresa.contacto, empresa.razon_social,
    empresa.cuit, empresa.telefono, empresa.mail,
    DBTypeConverter.ToSQLDateTime(empresa.fecha_creacion), empresa.ciud, empresa.loc, empresa.call,
    empresa.altu, empresa.pis, empresa.puert, empresa.codpos, empresa.codigo);

            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public Empresa BuscarEmpresaPorClave(Decimal codigo)
        {
            var query = String.Format(@"SELECT * FROM NINIRODIE.EMPRESA " +
                "WHERE EMP_CODIGO = '{0}'", codigo);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.EMPRESA");

            var empresas = dataRow.ToList<Empresa>(this.DataRowToEmpresa);

            return empresas.First();
        }

        public Empresa DataRowToEmpresa(DataRow row)
        {
            var codigo = Decimal.Parse(row["EMP_CODIGO"].ToString());

            var razon = row["EMP_RAZON_SOCIAL"].ToString();
            
            String contacto = "";
            if (!row["EMP_CONTACTO"].Equals(DBNull.Value))
                contacto = row["EMP_CONTACTO"].ToString();
            
            var cuit = (row["EMP_CUIT"].ToString());
            
            int telef = 0;
            if (!row["EMP_TELEFONO"].Equals(DBNull.Value))
                telef = int.Parse(row["EMP_TELEFONO"].ToString());

            var meil = row["EMP_MAIL"].ToString();
            DateTime f_crea = new DateTime();
            if (!row["EMP_FECHA_CREACION"].Equals(DBNull.Value))
                f_crea = DateTime.Parse(row["EMP_FECHA_CREACION"].ToString());
            
            String ciudad = "";
            if(!row["EMP_CIUDAD"].Equals(DBNull.Value))
                ciudad = row["EMP_CIUDAD"].ToString();

            String loc = "";
            if(!row["EMP_LOCALIDAD"].Equals(DBNull.Value))
                loc = row["EMP_LOCALIDAD"].ToString();
            
            var call = row["EMP_CALLE"].ToString();
            var altu = int.Parse(row["EMP_ALTURA"].ToString());
            var pis = int.Parse(row["EMP_PISO"].ToString());
            var codpos = int.Parse(row["EMP_CODIGO_POSTAL"].ToString());
            var puert = row["EMP_DEPARTAMENTO"].ToString();

            var empresa = new Empresa(codigo, cuit, razon, contacto, f_crea, meil, telef,
            ciudad, loc, call, altu, pis, codpos, puert);

            return empresa;
        }


    }
}
