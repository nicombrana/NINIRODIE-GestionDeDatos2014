using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Model;
using FrbaBus.Model.Repositorios;

namespace FrbaBus.View.Abm_Roles
{
    public partial class RolWindow : Form
    {
        private List<Funcionalidad> FuncionalidadesUtilizadas { get; set; }
        private List<Funcionalidad> FuncionalidadesDisponibles { get; set; }
        private FuncionalidadesRepository RepositoryFuncionalidad { get; set; }
        private RolRepository RepositoryRol { get; set; }
        private UsuariosRepository RepositoryUsuario { get; set; }
        private ModoApertura ModoApertura { get; set; }
        private Boolean Estado { get; set; }
       
        private Rol Rol { get; set; }

        public RolWindow()
        {
            InitializeComponent();
            this.RepositoryFuncionalidad = FuncionalidadesRepository.Instance;
            this.RepositoryRol = RolRepository.Instance;
            this.RepositoryUsuario = UsuariosRepository.Instance;
        }


        public RolWindow(Rol rol, ModoApertura modo)
            : this()
        {
            this.Rol = rol;
            this.ObtenerFuncionalidadesDelRol();
            this.PopularListas();
            this.textNombre.Text = this.Rol.NombreRol;
            this.checkHabilitar.Checked = this.Rol.Habilitado;
            this.ModoApertura = modo;
            if (this.Rol.NombreRol == Rol.ADMIN || this.Rol.NombreRol == Rol.CLIENTE) 
            {
                this.checkHabilitar.Enabled = false;
            }
        }

        public void ObtenerFuncionalidadesDelRol()
        {
            this.Rol.Funcionalidades = this.RepositoryFuncionalidad.FuncionalidadesDeRol(this.Rol);
        }

        
        private void PopularListas()
        {
            this.FuncionalidadesDisponibles = this.RepositoryFuncionalidad.FuncionalidadesDisponiblesPara(this.Rol);
            this.FuncionalidadesUtilizadas = Rol.Funcionalidades;
            this.PopularListasDeSeleccion();
        }

        
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            var funcionalidadesAAgregar = this.listFuncionesDisponibles.SelectedItems;

            foreach (Funcionalidad funcionalidad in funcionalidadesAAgregar)
            {
                this.FuncionalidadesUtilizadas.Add(funcionalidad);
                this.FuncionalidadesDisponibles.Remove(funcionalidad);
            }

            PopularListasDeSeleccion();
            this.Estado = true;
        }

        private void PopularListasDeSeleccion()
        {
            this.listFuncionesUtilizadas.DataSource = new List<Funcionalidad>();
            this.listFuncionesDisponibles.DataSource = new List<Funcionalidad>();
            this.listFuncionesUtilizadas.Refresh();
            this.listFuncionesDisponibles.Refresh();

            this.listFuncionesUtilizadas.DataSource = this.FuncionalidadesUtilizadas;
            this.listFuncionesDisponibles.DataSource = this.FuncionalidadesDisponibles;
            this.listFuncionesUtilizadas.Refresh();
            this.listFuncionesDisponibles.Refresh();
        }

        private void botonQuitar_Click(object sender, EventArgs e) 
        {
            var funcionalidadesAQuitar = this.listFuncionesUtilizadas.SelectedItems;

            foreach (Funcionalidad funcionalidad in funcionalidadesAQuitar)
            {
                this.FuncionalidadesDisponibles.Add(funcionalidad);
                this.FuncionalidadesUtilizadas.Remove(funcionalidad);
            }

            this.PopularListasDeSeleccion();

            this.Estado = true;
                                   
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.Rol.cambiarNombre(this.textNombre.Text);
            this.Rol.Funcionalidades = this.FuncionalidadesUtilizadas;
            if(this.ModoApertura == ModoApertura.MODIFICACION){
                this.ModificarAlRolConSusFuncionalidades();
            }else{
                this.AgregarRolConFuncionalidades();
            }
            if (!(this.checkHabilitar.Checked))
            {
               Rol nuevoRol = this.RepositoryRol.BuscarRol(new Rol(2,Rol.CLIENTE, true));
               this.RepositoryUsuario.CambiarRol(this.Rol, nuevoRol);
            }
            this.Close();
        }

        private void AgregarRolConFuncionalidades()
        {
            this.RepositoryRol.AgregarRol(this.Rol);
            this.Rol.Id = (int) this.RepositoryRol.NuevoId();
            if (this.Estado){
                this.RepositoryFuncionalidad.AgregarFuncionalidades(this.Rol);
            }
        }

        private void ModificarAlRolConSusFuncionalidades()
        {
            this.RepositoryRol.ModificarRol(this.Rol);
            if(this.Estado){
                this.RepositoryFuncionalidad.ModificarFuncionalidades(this.Rol, this.FuncionalidadesDisponibles);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            this.Rol.Habilitado = this.checkHabilitar.Checked;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
