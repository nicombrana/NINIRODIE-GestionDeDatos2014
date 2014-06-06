using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FrbaCommerce.NINIRODIE
{
    class Usuario
    {
        private bool logueado;
        public bool EstaLogueado
        {
            get { return logueado; }
            set { logueado = value; }
        }

        private string username;
        public string Username
        {
            get { return username; }
        }

        private string password;
        public string Password
        {
            get { return password; }
        }

        public List<string> Roles;

        private int idUsuario;
        public int IdUsuario
        {
            get { return idUsuario; }
        }

        private int dniEmpleado;
        public int DniEmpleado
        {
            get { return dniEmpleado; }
        }

        private string tipoEmpleado;
        public string TipoEmpleado
        {
            get { return tipoEmpleado; }
        }

        private string provincia;
        public string Provincia
        {
            get { return provincia; }
        }
        private int idProvincia;
        public int IdProvincia
        {
            get { return idProvincia; }
        }

        private string sucursal;
        public string Sucursal
        {
            get { return sucursal; }
        }
        private int idSucursal;
        public int IdSucursal
        {
            get { return idSucursal; }
        }

        private int habilitado;
        public bool Habilitado
        {
            get { return (habilitado == 1) ? true : false; }
        }

        public List<string> Funcionalidades;

        public Usuario(string username, string password) 
        {
            //Contructor donde cargamos las propiedades con datos útiles para la aplicacion
            if (chequearLogueado(username, password))
            {
                setearRolFunc();
               // setearTipoEmpleado();
            }
        }
        public Usuario(string username)
        {
            this.username = username;
            setearRolFunc();
           // setearTipoEmpleado();
        }

        /// <summary>
        /// Chequea si el usuario corresponde con el password pasados, ademas setea la propiedad EstaLogueado y Habilitado
        /// </summary>
        /// <returns>booleano, true/false</returns>
        public bool chequearLogueado(string username, string password)
        {
            /*
             * Consulta a la base por el nombre de usuario, para que le devuelva el password.
             * Luego chequea ese pass contra el entregado por el usario.
             */
            string ConsultaHab = "select Habilitado from NINIRODIE.Usuarios where UserName = '" + username + "'",
                   ConsultaPass = "select password from NINIRODIE.Usuarios where UserName = '" + username + "'",
                   recoveredPass = "";
            
            habilitado = 0;

            if (ConsultorABase.obtenerValorCampo(ConsultaHab, ref habilitado))
            {
                //Si existe y consigo un password
                if (Habilitado && ConsultorABase.obtenerValorCampo(ConsultaPass,ref recoveredPass))
                {
                    //Chequea que el password sin hashear concuerde con el hasheado de la base
                    if (SHA256.VerifyHash(password, recoveredPass))
                    {
                        this.username = username;
                        this.password = password;
                        return (this.logueado = true);
                    }
                    else
                    {
                        return (this.logueado = false);
                    }
                }
            }

            //si no devolvio nada ó fallo la consulta
            return (this.logueado = false);
        }

        /// <summary>
        /// Setea el rol y las funcionalidades del usuario, ademas carga el IdUsuario.
        /// </summary>
        public void setearRolFunc()
        {
            Funcionalidades = new List<string>();
            Roles = new List<string>();

            DataSet dataset;
            
            //Obtengo el id de los roles del usuario
            string Consulta = " select r.IdRol from NINIRODIE.Usuarios u " +
                              " join NINIROE.Rol_Usuario r on r.IdUsuario = u.IdUsuario " +
                              " where u.Username = '" + this.username + "'";

            ConsultorABase.query(Consulta, "ListaRoles");
            dataset = ConsultorABase.getDataset();

            //si devolvio algo
            if (dataset.Tables["ListaRoles"].Rows.Count > 0)
            {
                Consulta = "Select Nombre from NINIRODIE.Roles Where IdRol = ";
                string rolUsuario = "";

                //Recorrer el resultado 
                foreach (DataRow fila in dataset.Tables["ListaRoles"].Rows)
                {
                    if (ConsultorABase.obtenerValorCampo(Consulta + fila.ItemArray.GetValue(0).ToString(), ref rolUsuario))
                    {
                        Roles.Add(rolUsuario);
                    }
                }
            }

            int IdRol = 0;
            foreach (string rol in Roles)
            {
                IdRol = ConsultorABase.getRolId(rol);

                //Por cada rol, obtenemos los Ids de las funcionalidades
                ConsultorABase.query("select IdFuncio from NINIRODIE.Rol_Funcio where IdRol=" + IdRol, "ListaFunc");
                dataset = ConsultorABase.getDataset();
                //Si devolvio algo
                if (dataset.Tables["ListaFunc"].Rows.Count > 0)
                {
                    string nombreFuncionalidad = "";
                    //Recorrer el resultado 
                    foreach (DataRow fila in dataset.Tables["ListaFunc"].Rows)
                    {
                        //Con cada Id, buscar el nombre de la funcionalidad y guardarlo en la lista
                        Consulta = "select Nombre from NINIRODIE.Funcionalidades where IdFuncio=" + fila.ItemArray.GetValue(0).ToString();
                        if (ConsultorABase.obtenerValorCampo(Consulta, ref nombreFuncionalidad))
                        {
                            Funcionalidades.Add(nombreFuncionalidad);
                        }
                    }
                }
            }
        }
        /*
        public void setearTipoEmpleado()
        { 
            dniEmpleado = 0;
            idUsuario = 0;
            ConsultorABase.obtenerValorCampo("Select IdUsuario from NINIRODIE.Usuarios Where UserName = '" + this.username + "'", ref idUsuario);

            if (ConsultorABase.obtenerValorCampo("Select DniEmpleado from NINIRODIE.Usuarios where IdUsuario=" + idUsuario.ToString(), ref dniEmpleado))
            {
                tipoEmpleado = "";
                string Consulta = "Select te.Tipo from NINIRODIE.Empleados emp join NINIRODIE.TipoEmpleado te on te.IdTipoEmpleado = emp.Tipo where emp.Dni=";
                if (ConsultorABase.obtenerValorCampo(Consulta + dniEmpleado.ToString(), ref tipoEmpleado))
                {
                    setearProvinciaSucursal();
                }
            }
        }

        public void setearProvinciaSucursal()
        {
            idSucursal = idProvincia = 0;
            string consulta1 = "Select IdSucursal from NINIRODIE.Empleados where Dni=" + dniEmpleado.ToString(),
                consulta2 = "Select IdProvincia from NINIRODIE.Empleados where Dni=" + dniEmpleado.ToString();
            if (ConsultorABase.obtenerValorCampo(consulta1, ref idSucursal) && ConsultorABase.obtenerValorCampo(consulta2, ref idProvincia)) 
            {
                if (ConsultorABase.obtenerValorCampo("Select Direccion from NINIRODIE.Sucursales where IdSucursal =" + idSucursal, ref sucursal) &&
                    ConsultorABase.obtenerValorCampo("Select Nombre from NINIRODIE.Provincias where IdProvincia ="+idProvincia, ref provincia)) 
                {
                
                }
            }
        }*/

    }

}