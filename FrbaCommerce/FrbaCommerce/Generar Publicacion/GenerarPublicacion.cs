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
        TipoPublicacion tipoPubli;
        Decimal codigoUsuario;
 
        public Genepub()
        {
            InitializeComponent();
            this.popular();
            
        }
        public Genepub(Decimal codigoUser)
            : this()
        {
            codigoUsuario = codigoUser;
        }


        private void popular()
        {
            this.rubros = RepositorioRubros.Instance.Rubros();
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

            this.estado.DataSource = new List<Estado>();
            this.estado.Refresh();
            this.estado.DataSource = RepositorioEstado.Instance.Buscar();
            this.estado.Refresh();
            this.estado.DisplayMember = "descripcion";

            this.comboTipoPubli.DataSource = new List<TipoPublicacion>();
            this.comboTipoPubli.Refresh();
            this.comboTipoPubli.DataSource = RepositorioTipoPublicacion.Instance.Buscar();
            this.comboTipoPubli.Refresh();
            this.comboTipoPubli.DisplayMember = "descripcion";
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
            tipoPubli = (TipoPublicacion)this.comboTipoPubli.SelectedValue;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!this.tieneCamposSinCompletar())
            {
                if ((tipoPubli.descripcion == "Subasta" && Decimal.Parse(this.txtBoxStock.Text) == 1 || 
                    tipoPubli.descripcion == "Compra Inmediata"))
                {
                    this.generarPublicacion();
                    new GeneracionPublicacionCorrecta().ShowDialog(this);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las Subastas solo pueden tener 1 sola unidad en Stock", "Atención", MessageBoxButtons.OK);
                    //new AlertaSubastaStock().ShowDialog(this);
                }
            }
            else
            {
                this.NoPuedeContinuar();
            }

        }

        private void NoPuedeContinuar()
        {
            if (Validador.estaVacio(this.txtBoxStock.Text))
                MessageBox.Show("Debe ingresar una cantidad de Stock", "Atención", MessageBoxButtons.OK);
           
            if (Validador.estaVacio(this.txtBoxPrecio.Text))
                MessageBox.Show("Debe ingresar un Precio", "Atención", MessageBoxButtons.OK);
           
            if (Validador.estaVacio(this.descripcionTextBox.Text))
                MessageBox.Show("Debe ingresar una Descripción", "Atención", MessageBoxButtons.OK);
           
            if (this.RubrosCheckList.CheckedItems.Count == 0)
                MessageBox.Show("Debe seleccionar al menos 1 rubro", "Atención", MessageBoxButtons.OK);
        } 
       
        private bool tieneCamposSinCompletar()
        {
            return (Validador.estaVacio(this.txtBoxStock.Text) || Validador.estaVacio(this.txtBoxPrecio.Text) ||
                Validador.estaVacio(this.descripcionTextBox.Text) || this.RubrosCheckList.CheckedItems.Count == 0);
                
        }

        private bool debeAgregarDescripcion()
        {
            return this.descripcionTextBox.Text == "";
        }

        private void generarPublicacion()
        {
            var publicacion = new Publicacion(this.descripcionTextBox.Text, this.tipoPubli, 
                ((Visibilidad)this.visibilidades.SelectedValue).visibilidadCodigo, codigoUsuario, 
                (Estado)(this.estado.SelectedValue), this.preguntas.Checked, Decimal.Parse(this.txtBoxStock.Text),
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
