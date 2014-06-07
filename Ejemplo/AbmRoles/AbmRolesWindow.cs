using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Model;

namespace FrbaBus.View.Abm_Roles
{
    public partial class AbmRolesWindow : Form
    {
        //TODO: Validar que Roles "Administrador" y "Cliente" siempre esten habilitados
        private List<Rol> Roles { get; set; }
        private Rol RolSeleccionado { get; set; }
        private RolRepository RepositoryRol { get; set; }


        public AbmRolesWindow()
        {
            InitializeComponent();
            this.RepositoryRol = RolRepository.Instance;
            this.CrearGrilla();
            if (this.Roles != null)
            {
                this.RolSeleccionado = this.Roles.First();
            }
        }

        private void CrearGrilla()
        {
            this.Roles = this.RepositoryRol.All();
            this.PopularGrilla();
            this.grillaRoles.Columns[1].Visible = false;
        }

        private void PopularGrilla()
        {
            this.grillaRoles.DataSource = this.Roles;
            this.grillaRoles.Refresh();
        }

        public virtual void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.textNombre.Text = "";
            this.CrearGrilla();
        }

        public virtual void botonNuevo_Click(object sender, EventArgs e)
        {
            new RolWindow(new Rol(), ModoApertura.ALTA).ShowDialog();
            this.CrearGrilla();
        }

        public virtual void textNombre_TextChanged(object sender, EventArgs e)
        {
            String nombre = textNombre.Text;
            List<Rol> resultado = this.Roles.FindAll(rol => rol.NombreRol.Contains(nombre));
            this.Roles = resultado;
            this.PopularGrilla();
        }

        public virtual void grillaRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RolSeleccionado = (Rol)this.grillaRoles.CurrentRow.DataBoundItem;
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            new RolWindow(this.RolSeleccionado, ModoApertura.MODIFICACION).ShowDialog();
            this.CrearGrilla();
        }
    }
}
