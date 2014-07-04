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
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class EditarPublicacion : Form
    {
        Publicacion publiAEditar;
        List<Estado> estados = new List<Estado>();
        bool visibilidad;

        public EditarPublicacion(Publicacion publicacionAEditar)
        {
            InitializeComponent();
            publiAEditar = publicacionAEditar;
            //this.ObtenerEstadosAMostrar();
            this.popular();

            this.stockTextBox.Text = publicacionAEditar.stock.ToString();

            this.ObtenerVisibilidadStock();

        }

        public EditarPublicacion(Publicacion publicacionAEditar, List<Estado> states)
        {
            InitializeComponent();
            publiAEditar = publicacionAEditar;
            estados = states;
            this.popular();

            this.stockTextBox.Text = publicacionAEditar.stock.ToString();

            this.ObtenerVisibilidadStock();

        }

        //private void ObtenerEstadosAMostrar()
        //{
        //    estados = publiAEditar.tipo.PosiblesEstados(publiAEditar);
        //}

        private void ObtenerVisibilidadStock()
        {
            visibilidad = this.publiAEditar.visibilidadStockParaEditar() &&
                this.publiAEditar.estado.visibilidadStockParaEdicion();

            this.stockTextBox.Visible = visibilidad;
            this.stockLabel.Visible = visibilidad;
        }

        private void popular()
        {
            this.estadosComboBox.DataSource = new List<Publicacion>();
            this.estadosComboBox.Refresh();
            this.estadosComboBox.DataSource = estados;
            this.estadosComboBox.Refresh();
            this.estadosComboBox.DisplayMember = "descripcion";
        }

        /*
        private List<Estado> ObtenerEstados()
        {
            var estadoBorrador = new Borrador(2, "Borrador");

            if (estados.Exists(estado => estado.id == publiAEditar.estado.id))
            {
                var estadoAQuitar = estados.Find(estado => estado.id == publiAEditar.estado.id);
                estados.Remove(estadoAQuitar);
            }
            if (estados.Exists(estado => estado.id == estadoBorrador.id))
                estados.Remove(new Borrador(2, "Borrador"));

            return estados;
        }
        */

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (Decimal.Parse(stockTextBox.Text) >= publiAEditar.stock)
            {
                this.editarPublicacion();

                RepositorioPublicacion.Instance.UpdateEstado(publiAEditar);

                MessageBox.Show("Se ha editado el estado de la publicación correctamente",
                    "Informe", MessageBoxButtons.OK);
                this.Close();
            }
            else
                MessageBox.Show("El Stock solo puede incrementarse", "Atención", MessageBoxButtons.OK);

        }

        private void editarPublicacion()
        {
            publiAEditar.estado = (Estado)estadosComboBox.SelectedValue;

            var stock = Decimal.Parse(this.stockTextBox.Text);

            if (this.visibilidad)
                publiAEditar.stock = stock;
        }

        private void stockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }
    }
}
