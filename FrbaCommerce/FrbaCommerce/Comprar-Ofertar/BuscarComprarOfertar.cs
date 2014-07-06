using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class BuscarComprarOfertar : Form
    {
        List<Publicacion> publicaciones;
        List<Rubro> rubros;
        Publicacion publicacionSeleccionada;
        Decimal tipo;
        Decimal codigoUser;

        public BuscarComprarOfertar(Decimal type, Decimal codigoUsuario)
        {
            InitializeComponent();
            MessageBox.Show("Esta operación puede tardar algunos segundos", "Atención", MessageBoxButtons.OK);
            tipo = type;
            codigoUser = codigoUsuario;
            rubros = RepositorioRubros.Instance.Rubros();
            publicaciones = this.ObtenerPublicaciones();
            this.popular();
            this.CrearBotonAceptarOfertar();
        }

        private void CrearBotonAceptarOfertar()
        {
            if (tipo == 1)
            {
                this.aceptarBoton.Text = "Comprar";
                this.aceptarBoton.Click += new EventHandler(comprarBoton_Click);
            }
            else
            {
                this.aceptarBoton.Text = "Ofertar";
                this.aceptarBoton.Click += new EventHandler(ofertarBoton_Click);
            }
        }

        private void AvisarUsuario(String mensaje)
        {
            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
        }

        void ofertarBoton_Click(object sender, EventArgs e)
        {
            this.AvisarUsuario("Se iniciará la Oferta");

            SeleccionarSiNull();

            new Ofertar(publicacionSeleccionada, codigoUser).ShowDialog(this);
        }

        private void SeleccionarSiNull()
        {
            if (publicacionSeleccionada == null)
                this.seleccionarPublicacion();
        }

        void comprarBoton_Click(object sender, EventArgs e)
        {
            this.AvisarUsuario("Se iniciará la compra");

            SeleccionarSiNull();

            new Comprar(publicacionSeleccionada, codigoUser).ShowDialog(this);
        }

        private void popular()
        {
            this.popularCheckList();

            this.publicacionesGrid.DataSource = new List<Publicacion>();
            this.publicacionesGrid.Refresh();
            this.publicacionesGrid.DataSource = publicaciones;
            this.publicacionesGrid.Refresh();
            this.publicacionesGrid.Columns["publicacion_id"].Visible = false;
            this.publicacionesGrid.Columns["tipo"].Visible = false;
            this.publicacionesGrid.Columns["visibilidad_codigo"].Visible = false;
            this.publicacionesGrid.Columns["vendedor"].Visible = false;
            this.publicacionesGrid.Columns["estado"].Visible = false;
            this.publicacionesGrid.Columns["permitePregunta"].Visible = false;
            this.publicacionesGrid.Columns["factura"].Visible = false;

            this.publicacionesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.publicacionesGrid.Columns["descripcion"].ReadOnly = true;
            this.publicacionesGrid.Columns["stock"].ReadOnly = true;
            this.publicacionesGrid.Columns["precio"].ReadOnly = true;
            this.publicacionesGrid.Columns["fecha_inicio"].ReadOnly = true;
            this.publicacionesGrid.Columns["fecha_vencimiento"].ReadOnly = true;

        }

        private void popularCheckList()
        {
            rubros.ForEach(rubro => this.rubrosCheckList.Items.Add(rubro));
            this.rubrosCheckList.Refresh();
            rubrosCheckList.DisplayMember = "rub_descripcion";
            rubrosCheckList.CheckOnClick = true;
        }

        private List<Publicacion> ObtenerPublicaciones()
        {
            return RepositorioPublicacion.Instance.BuscarPublicadasComprarOfertar(tipo, 1, codigoUser);
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se iniciará la búsqueda con los parámetros indicados",
                "Atención", MessageBoxButtons.OK);

            var publi = this.FiltrarPublicaciones();

            this.publicacionesGrid.DataSource = publi;

            this.publicacionesGrid.Refresh();
        }

        private List<Publicacion> FiltrarPublicaciones()
        {
            return RepositorioPublicacion.Instance.FiltrarPublicacionesPorDescripcionYRubro(this.rubrosCheckList.CheckedItems,
                    this.descripcionTextBox.Text, tipo, 1, codigoUser);
        }

        private void borrarBoton_Click(object sender, EventArgs e)
        {
            this.publicacionesGrid.DataSource = publicaciones;
            this.publicacionesGrid.Refresh();

            foreach (int index in this.rubrosCheckList.CheckedIndices)
            {
                this.rubrosCheckList.SetItemCheckState(index, CheckState.Unchecked);
            }

            this.descripcionTextBox.Text = "";
            this.publicacionSeleccionada = new Publicacion();
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void publicacionesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.seleccionarPublicacion();
        }

        private void seleccionarPublicacion()
        {
            publicacionSeleccionada = (Publicacion)this.publicacionesGrid.SelectedRows[0].DataBoundItem;
        }
    }
}
