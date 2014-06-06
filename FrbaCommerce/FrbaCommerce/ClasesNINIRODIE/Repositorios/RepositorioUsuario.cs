using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using System.Data;
using FrbaCommerce.NINIRODIE;
using FrbaCommerce.ClasesNINIRODIE.Dominio;


namespace FrbaCommerce.ClasesNINIRODIE.Repositorios
{
    class RepositorioUsuario
    {
        private static RepositorioUsuario _instance;

        public static RepositorioUsuario Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepositorioUsuario();  
                }
                return _instance;
            }
        }
        public Usuario BuscarUsuario(string id, string pass)
        {
            //Aca se debería golpear a la base
            var query = String.Format(@"select * from gd1c2014.NINIRODIE.USUARIO "+
                                       "where USU_NOMBRE_USUARIO = '{0}' and "+
                                       "USU_CLAVE = '{1}'",id,pass);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.USUARIO");
            
            if (dataRow.Count == 0)
            {
                return new Usuario();   
            }
            var usuarios = dataRow.ToList<Usuario>(this.DataRowToUsuario);

            return usuarios.First();
        }

        public void InsertarUsuario(Cliente cliente)
        {
            var query = String.Format(@"INSERT INTO NINIRODIE.USUARIO " +
     "(USU_NOMBRE_USUARIO, USU_CLAVE, USU_HABILITADO, USU_INTENTOS_FALLIDOS, " +
     "USU_EMPRESA_ID, USU_CLIENTE_ID, USU_TIPO)" +
     "VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')",cliente.nombre_usuario, 
     cliente.clave, 1, 0, null, cliente.codigo, "CLIENTE".ToString());
            
            SQLUtils.EjecutarConsultaConEfectoDeLado(query);
        }

        public Usuario DataRowToUsuario(DataRow row)
        {
            var codigo = Decimal.Parse(row["USU_CODIGO"].ToString());
            var id = row["USU_NOMBRE_USUARIO"].ToString();
            var pass = row["USU_CLAVE"].ToString();
            var habilitado = bool.Parse(row["USU_HABILITADO"].ToString());
            var intentos = Decimal.Parse(row["USU_INTENTOS_FALLIDOS"].ToString());
            var tipo = row["USU_TIPO"].ToString();/*
            var id_cliente = Decimal.Parse(row["USU_CLIENTE_ID"].ToString());
            var id_empresa = Decimal.Parse(row["USU_EMPRESA_ID"].ToString());
            */
            var usuario = new Usuario(codigo, id, pass, habilitado, intentos, tipo/*, id_cliente, id_empresa*/);

            return usuario;

        }
    }

}
