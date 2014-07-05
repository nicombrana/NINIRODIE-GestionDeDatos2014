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
    public partial class EditarPublicacionBorrador : Form
    {
        Publicacion publicacion;
        List<Rubro> rubrosCheckeados;
        List<Rubro> rubrosTotales;
        CheckedListBox.CheckedItemCollection rub;
        TipoPublicacion tipoPublicacion;

        public EditarPublicacionBorrador(Publicacion publicacionAEditar)
        {

            InitializeComponent();
            publicacion = publicacionAEditar;
            rubrosCheckeados = RepositorioRubros.Instance.ObtenerRubrosPorPublicacion(publicacionAEditar);
            this.popular();
            this.InicializarValores();


        }

        private void InicializarValores()
        {
            tipoPublicacion = (TipoPublicacion)this.comboTipoPubli.SelectedValue;
            this.visibilidades.SelectedItem = this.ObtenerVisibilidad(publicacion.visibilidad_codigo);
            this.descripcionTextBox.Text = publicacion.descripcion;
            this.txtBoxPrecio.Text = publicacion.precio.ToString();
            this.txtBoxStock.Text = publicacion.stock.ToString();
            this.preguntas.Checked = publicacion.permitePregunta;
            this.fechaPicker.Value = publicacion.fecha_inicio;

            foreach (Visibilidad visibilidad in this.visibilidades.Items)
            {
                this.SeEncontroElValorAInicializar(visibilidad.visibilidadCodigo,
                    this.publicacion.visibilidad_codigo, visibilidad, this.visibilidades);
            }


            foreach (Estado state in this.estado.Items)
            {
                this.SeEncontroElValorAInicializar(state.id, this.publicacion.estado.id, state, this.estado);
            }

            foreach (TipoPublicacion tipoPubli in this.comboTipoPubli.Items)
            {
                this.SeEncontroElValorAInicializar(tipoPubli.id, this.publicacion.tipo.id, 
                        tipoPubli, this.comboTipoPubli);
            }


            this.CheckearRubros();
            this.rub = this.RubrosCheckList.CheckedItems;

        }

        private void popularCheckList()
        {
            RubrosCheckList.Refresh();
            rubrosTotales.ForEach(rubro => this.RubrosCheckList.Items.Add(rubro));
            this.RubrosCheckList.Refresh();
            RubrosCheckList.DisplayMember = "rub_descripcion";
            RubrosCheckList.CheckOnClick = true;
        }

        private void SeEncontroElValorAInicializar(Decimal idBuscado, Decimal idCorrespondienteALaPublicacion,
            Object buscado, ComboBox box)
        {
            if (idBuscado == idCorrespondienteALaPublicacion)
            {
                var index = box.Items.IndexOf(buscado);
                box.SelectedItem = box.Items[index];
            }
        }

        private Visibilidad ObtenerVisibilidad(decimal codigoVisibilidad)
        {
            var visibilidad = RepositorioVisibilidad.Instance.BuscarVisibilidad(codigoVisibilidad);

            return visibilidad;
        }

        private void CheckearRubros()
        {
            rubrosCheckeados.ForEach(rubro => this.CheckRubro(rubro));
        }

        private void CheckRubro(Rubro rubro)
        {
            foreach (Rubro rub in this.RubrosCheckList.Items)
            {
                if (rub.rubro_id == rubro.rubro_id)
                {
                    var indice = this.RubrosCheckList.Items.IndexOf(rub);
                    this.RubrosCheckList.SetItemChecked(indice, true);
                    break;
                }
            }
        }

        private void popular()
        {
            this.rubrosTotales = RepositorioRubros.Instance.Rubros();
            this.popularCheckList();
            this.popularListas();
        }

        private void popularListas()
        {
            this.visibilidades.DataSource = RepositorioVisibilidad.Instance.Buscar();
            this.visibilidades.Refresh();
            this.visibilidades.DisplayMember = "visibiDescripcion";

            this.estado.DataSource = RepositorioEstado.Instance.Buscar();
            this.estado.Refresh();
            this.estado.DisplayMember = "descripcion";

            this.comboTipoPubli.DataSource = RepositorioTipoPublicacion.Instance.Buscar();
            this.comboTipoPubli.Refresh();
            this.comboTipoPubli.DisplayMember = "descripcion";

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

        private void txtBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void txtBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void comboTipoPubli_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPublicacion = (TipoPublicacion)this.comboTipoPubli.SelectedValue;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!this.tieneCamposSinCompletar())
            {
                if ((this.tipoPublicacion.descripcion == "Subasta" && Decimal.Parse(this.txtBoxStock.Text) == 1 ||
                    this.tipoPublicacion.descripcion == "Compra Inmediata"))
                {
                    this.editarPublicacion();
                    MessageBox.Show("Se ha editado la Publicación exitosamente",
                        "Informe", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las Subastas solo pueden tener 1 sola unidad en Stock", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.NoPuedeContinuar();
            }
        }

        private void editarPublicacion()
        {
            publicacion.ModificarValoresSiNecesario(this.descripcionTextBox.Text.ToString(), this.tipoPublicacion,
                ((Visibilidad)this.visibilidades.SelectedValue).visibilidadCodigo, 
                (Estado)this.estado.SelectedValue, this.preguntas.Checked, Decimal.Parse(this.txtBoxStock.Text),
                this.fechaPicker.Value, Decimal.Parse(this.txtBoxPrecio.Text));

            RepositorioPublicacion.Instance.Update(publicacion);

            this.AgregarQuitarRubrosPorPublicacion();
        }

        private void AgregarQuitarRubrosPorPublicacion()
        {
            AgregarRubro();
            QuitarRubro();
        }

        private void QuitarRubro()
        {
            foreach (Rubro rubro in RubrosCheckList.Items)
            {
                if (rubrosCheckeados.Exists(rubroL => rubroL.rubro_id == rubro.rubro_id) &&
                    !RubrosCheckList.CheckedItems.Contains(rubro))
                    RepositorioPublicacionPorRubro.Instance.Quitar(publicacion, rubro);
            }
        }

        private void AgregarRubro()
        {
            foreach (Rubro rubroSeleccionado in this.RubrosCheckList.CheckedItems)
            {
                if (this.ElRubroEsNuevo(rubroSeleccionado))
                {
                    RepositorioPublicacionPorRubro.Instance.AgregarRubrosAPublicacion(publicacion, rubroSeleccionado);
                }
            }
        }

        private bool ElRubroEsNuevo(Rubro rubroSeleccionado)
        {
            return !rubrosCheckeados.Exists(rubro => rubro.rubro_id == rubroSeleccionado.rubro_id);
        }
    }
}
