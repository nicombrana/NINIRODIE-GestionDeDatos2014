using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    class Logeador
    {
        public string id = null, password = null, tipo = null;

        public Usuario EsCorrecto(String id){

            Usuario user = RepositorioUsuario.Instance.BuscarUsuario(id);

            return user;
        }
    }
}
