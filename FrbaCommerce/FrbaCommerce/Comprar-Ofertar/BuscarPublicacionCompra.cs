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

        public BuscarPublicacionCompra()
        {
            InitializeComponent();
            rubros = RepositorioRubros.Instance.Rubros();
            publicaciones = RepositorioPublicacion.Instance.BuscarPublicadasComprar();
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


        }

        private void popularCheckList()
        {
            rubros.ForEach(rubro => this.rubrosCheckList.Items.Add(rubro));
            this.rubrosCheckList.Refresh();
            rubrosCheckList.DisplayMember = "rub_descripcion";
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
            var result = publicaciones.FindAll(publicacion => this.FiltrarPublicacion(publicacion));

            this.publicacionesGrid.DataSource = result;
            this.publicacionesGrid.Refresh();
        }

        private bool FiltrarPublicacion(Publicacion publicacion)
        {
            var resultDescripcion = publicacion.descripcion.Contains(this.descripcionTextBox.Text.ToString());



            return resultDescripcion;
        }


       
    }
}
