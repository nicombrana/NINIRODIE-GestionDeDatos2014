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

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Genepub : Form
    {
        bool modificacion;
        String cantStock;
        Decimal precioPublicacion;
        private List<Rubro> rubros = new List<Rubro>();
        DateTime fechaInicio;
        DateTime fechaFin;
        String descripcion;
        bool preguntasHabilitadas;
        Visibilidad visibilidad;
 
        public Genepub()
        {
            InitializeComponent();
            this.rubros = RepositorioRubros.Instance.Rubros();
            this.popular();
            
        }

        private void popular()
        {
            this.popularCheckList();
            this.popularListas();
        }

        private void popularListas()
        {
            this.visibilidades.DataSource = new List<Visibilidad>();
            this.visibilidades.Refresh();
            this.visibilidades.DataSource = RepositorioVisibilidad.Instance.Buscar();
            this.visibilidades.Refresh();
            this.visibilidades.DisplayMember = "visibiDescripcion";

            this.estado.DataSource = new List<String> { "Borrador", "Activa", "Pausada", "Finalizada" };
            this.estado.Refresh();

            this.comboTipoPubli.DataSource = new List<String> {"Compra Inmediata", "Subasta"};
            this.comboTipoPubli.Refresh();
        }

        private void popularCheckList()
        {
            RubrosCheckList.Refresh();
            rubros.ForEach(rubro => this.RubrosCheckList.Items.Add(rubro));
            this.RubrosCheckList.Refresh();
            RubrosCheckList.DisplayMember = "rub_descripcion";
        }

        public Genepub(bool modificando) :this()
        {
            this.modificacion = modificando;
            this.precio.Visible = false;
            //InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Genepub_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxStock_TextChanged(object sender, EventArgs e)
        {
            cantStock = this.txtBoxStock.Text;
        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            precioPublicacion = Decimal.Parse(this.txtBoxPrecio.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaInicio = this.dateTimePicker1.Value;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            descripcion = this.descripcionTextBox.Text;
        }

        private void preguntas_CheckedChanged(object sender, EventArgs e)
        {
            preguntasHabilitadas = this.preguntas.Checked;
        }

        private void visibilidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibilidad = (Visibilidad)this.visibilidades.SelectedValue;
        }



    }
}
