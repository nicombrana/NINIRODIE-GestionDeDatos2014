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
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Genepub : Form
    {
        bool modificacion;
        private List<Rubro> rubros = new List<Rubro>();
        String tipoPubli;
        Decimal codigoUsuario;
 
        public Genepub()
        {
            InitializeComponent();
            this.rubros = RepositorioRubros.Instance.Rubros();
            this.popular();
            
        }

        public Genepub(Decimal codigoUser)
            : this()
        {
            codigoUsuario = codigoUser;
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

        private void comboTipoPubli_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPubli = this.comboTipoPubli.SelectedValue.ToString();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (tipoPubli == "Subasta" && Decimal.Parse(this.txtBoxStock.Text) == 1 || tipoPubli == "Compra Inmediata")
            {
                this.generarPublicacion();
                new GeneracionPublicacionCorrecta().ShowDialog(this);
                this.Close();
            }
            else
            {
                new AlertaSubastaStock().ShowDialog(this);
            }

        }

        private void generarPublicacion()
        {
            var publicacion = new Publicacion(this.descripcionTextBox.Text, this.tipoPubli, 
                ((Visibilidad)this.visibilidades.SelectedValue).visibilidadCodigo, codigoUsuario, 
                this.estado.SelectedValue.ToString(), this.preguntas.Checked, Decimal.Parse(this.txtBoxStock.Text),
                this.dateTimePicker1.Value, this.dateTimePicker1.Value, Decimal.Parse(this.txtBoxPrecio.Text));

            RepositorioPublicacion.Instance.AgregarPublicacion(publicacion);

            foreach (Rubro rubroSeleccionado in this.RubrosCheckList.CheckedItems)
            {
                RepositorioPublicacionPorRubro.Instance.AgregarRubrosAPublicacion(publicacion, rubroSeleccionado);
            }
              
        }

        private void txtBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void txtBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }



    }
}
