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
    public partial class BuscarPublicacionOferta : Form
    {
        List<Publicacion> publicaciones;
        List<Rubro> rubros;
        Publicacion publicacionSeleccionada;

        public BuscarPublicacionOferta()
        {
            InitializeComponent();
            MessageBox.Show("Esta operación puede tardar algunos segundos", "Atención", MessageBoxButtons.OK);
            rubros = RepositorioRubros.Instance.Rubros();
            publicaciones = RepositorioPublicacion.Instance.BuscarPublicadasComprar(2, 1);
            this.popular();
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
            this.publicacionesGrid.Columns["fecha_inicio"].ReadOnly = true;
            this.publicacionesGrid.Columns["precio"].ReadOnly = true;
            this.publicacionesGrid.Columns["fecha_vencimiento"].ReadOnly = true;

        }

        private void popularCheckList()
        {
            rubros.ForEach(rubro => this.rubrosCheckList.Items.Add(rubro));
            this.rubrosCheckList.Refresh();
            rubrosCheckList.DisplayMember = "rub_descripcion";
            rubrosCheckList.CheckOnClick = true;
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se iniciará la búsqueda con los parámetros indicados",
                "Atención", MessageBoxButtons.OK);

            var publi = RepositorioPublicacion.Instance.FiltrarPublicacionesPorDescripcionYRubro(this.rubrosCheckList.CheckedItems,
                    this.descripcionTextBox.Text, 2); // EL 2 es porque es una Compra, hardcodeado... :(

            this.publicacionesGrid.DataSource = publi;

            this.publicacionesGrid.Refresh();

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

        private void publicacionesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            publicacionSeleccionada = (Publicacion)this.publicacionesGrid.SelectedRows[0].DataBoundItem;
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ofertarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se iniciará la oferta", "Atención", MessageBoxButtons.OK);

            new Ofertar(publicacionSeleccionada).ShowDialog(this);
        }


    }
}
