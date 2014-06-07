using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Model;
using FrbaBus.Model.Repositorios;
using FrbaBus.Model.Filtros;
using FrbaBus.View.Abm_Micro;
using FrbaBus.View;

namespace FrbaBus.Abm_Micro
{
    public partial class AbmMicrosWindow : Form
    {
        private List<Ciudad> Ciudades;
        private List<TipoServicio> TiposServicio;
        private FiltroMicro Filtro;
        public List<Micro> Micros { get; set; }
        public Micro Selected { get; set; }

        public AbmMicrosWindow()
        {
            InitializeComponent();
            this.Filtro = new FiltroMicro();
            this.Ciudades = CiudadesRepository.Instance.All();
            this.TiposServicio = TipoServicioRepository.Instance.TiposServicio;
            this.Micros = new List<Micro>();
        }

        private void AbmMicros_Load(object sender, EventArgs e)
        {
            this.comboTipoServicio.DataSource = this.TiposServicio;
            this.grillaMicros.DataSource = this.Micros;
            this.comboEstado.DataSource = Enum.GetValues(typeof(EstadoMicro));
        }

        private void comboTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Filtro.TipoServicio = (TipoServicio)this.comboTipoServicio.SelectedValue;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.Filtro.Marca = this.textMarca.Text;
            this.Filtro.Modelo = this.textModelo.Text;
            this.RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            var repo = MicrosRepository.Instance;
            this.Micros = repo.MicrosPara(Filtro);
            this.RefrescarGrilla();
        }
        private void RefrescarGrilla()
        {
            this.grillaMicros.DataSource = this.Micros;
            this.grillaMicros.Refresh();
        }

        private void grillaMicros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new MicroWindow(this.Selected, ModoApertura.MODIFICACION).ShowDialog();
            this.RebindGrilla();
        }

        private void grillaMicros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selected = (Micro)this.grillaMicros.CurrentRow.DataBoundItem;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            new MicroWindow(new Micro(), ModoApertura.ALTA).ShowDialog();
            this.RebindGrilla();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.Selected = null;
            this.UnbindGrilla();
            this.RefrescarGrilla();
        }

        private void RebindGrilla()
        {
            this.UnbindGrilla();
            this.RefrescarGrilla();
            this.RealizarBusqueda();
        }

        private void UnbindGrilla()
        {
            this.comboTipoServicio.BindingContext = new BindingContext();
            this.Micros = new List<Micro>();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            new MicroWindow(new Micro(), ModoApertura.BAJA).ShowDialog();
            this.RebindGrilla();
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Filtro.Estado = (EstadoMicro) this.comboEstado.SelectedItem;
        }
    }
}
