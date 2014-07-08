using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ClasesNINIRODIE.Dominio
{
    public class Rol
    {
        public static String ADMIN = "ADMINISTRADOR";
        public static String USUARIO = "USUARIO";
        public static String EMPRESA = "EMPRESA";

        public string NombreRol { get; set; }
        public int Id { get; set; }
        public bool Habilitado { get; set; }
        public List<Funcionalidad> Funcionalidades { get; set; }

        public Rol()
        {
            this.Funcionalidades = new List<Funcionalidad>();
        }

        public Rol(string Rol)
            : this()
        {
            this.NombreRol = Rol;
        }

        public Rol(int id, string nombre, Boolean habilitado)
            : this(nombre)
        {
            this.Id = id;
            this.Habilitado = habilitado;
        }

        public void cambiarNombre(String nombre)
        {
            this.NombreRol = nombre;
        }

        public void AgregarFuncionalidades(List<Funcionalidad> funcionalidades)
        {
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                Funcionalidades.Add(funcionalidad);
            }
        }
    }
}
