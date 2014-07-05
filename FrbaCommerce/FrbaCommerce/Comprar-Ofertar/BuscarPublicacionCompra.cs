using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class BuscarPublicacionCompra : Form
    {
        List<Rubro> rubros = new List<Rubro>();
        List<Publicacion> publicaciones = new List<Publicacion>();
        Publicacion publicacionSeleccionada = new Publicacion();

        public BuscarPublicacionCompra()
        {
            InitializeComponent();
            MessageBox.Show("Esta operación puede tardar algunos segundos", "Atención", MessageBoxButtons.OK);
            rubros = RepositorioRubros.Instance.Rubros();
            publicaciones = RepositorioPublicacion.Instance.BuscarPublicadasComprar(1, 1);
            this.popular();
        }

        private void popular()
        {
            this.popularCheckList();

            this.publicacionesGrid.DataSource = new List<Publicacion>();
            this.publicacionesGrid.Refresh();
            this.publicacionesGrid.DataSource = publicaciones;
            this.publicacionesGrid.Refresh();
            this.publicacionesGrid.Columns["publicacion_id"].Visible= false;
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

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se iniciará la búsqueda con los parámetros indicados",
                "Atención", MessageBoxButtons.OK);

            var publi = RepositorioPublicacion.Instance.FiltrarPublicacionesPorDescripcionYRubro(this.rubrosCheckList.CheckedItems,
                    this.descripcionTextBox.Text, 1); // EL 1 es porque es una Compra, hardcodeado... :(

            this.publicacionesGrid.DataSource = publi;

            this.publicacionesGrid.Refresh();

            //var result = publicaciones.FindAll(publicacion => this.FiltrarPublicacion(publicacion));

            //this.publicacionesGrid.DataSource = result;
            //this.publicacionesGrid.Refresh();
        }

        private void publicacionesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            publicacionSeleccionada = (Publicacion)this.publicacionesGrid.SelectedRows[0].DataBoundItem;
        }

        private void borrarBoton_Click(object sender, EventArgs e)
        {
            this.publicacionesGrid.DataSource = publicaciones;
            this.publicacionesGrid.Refresh();

            foreach(int index in this.rubrosCheckList.CheckedIndices)
            {
                this.rubrosCheckList.SetItemCheckState(index, CheckState.Unchecked);
            }

            this.descripcionTextBox.Text = "";
            this.publicacionSeleccionada = new Publicacion();
        }

        private void comprarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se iniciará la compra", "Atención", MessageBoxButtons.OK);

            new Comprar(publicacionSeleccionada).ShowDialog(this);
        }

        //private bool FiltrarPublicacion(Publicacion publicacion)
        //{
        //    var contieneDescripcion = publicacion.descripcion.Contains(this.descripcionTextBox.Text.ToString());
        //    bool tieneRubros = true;
           
        //    if (this.rubrosCheckList.CheckedItems.Count != 0)
        //    {
        //        var rubrosABuscar = RepositorioRubros.Instance.ObtenerRubrosPorPublicacion(publicacion);

        //        tieneRubros = this.tieneRubros(publicacion, rubrosABuscar);
        //    }

        //    return contieneDescripcion && tieneRubros;
        //}

        //private bool tieneRubros(Publicacion publicacion, List<Rubro> rubrosABuscar)
        //{
        //    foreach (Rubro rubro in this.rubrosCheckList.CheckedItems)
        //    {
        //        if (rubrosABuscar.Any(rub => rub.rubro_id == rubro.rubro_id))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


       
    }
}
