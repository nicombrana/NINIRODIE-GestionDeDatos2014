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

namespace FrbaBus.View.Abm_Micro
{
    public partial class MicroWindow : Form
    {
        private Micro Micro { get; set; }
        private ModoApertura Modo;

        public MicroWindow(Micro Micro, ModoApertura Modo)
        {
            this.InitializeComponent();
            this.Micro = Micro;
            this.Modo = Modo;
            this.datePickerBaja.Value = DateTime.Now;
            this.datePickerReincorporacion.Value = DateTime.Now;
            this.ConfigurarVistaSegunModo();
        }

        private void ConfigurarVistaSegunModo()
        {
            var Header = "";
            var Caption = "";
            switch (this.Modo)
            {
                case ModoApertura.ALTA:
                    Header = "Nuevo Micro";
                    Caption = "Agregar";
                    this.checkHabilitado.Checked = true;
                    this.tabControlMicro.TabPages.Remove(this.tabButacas);
                    break;
                case ModoApertura.BAJA:
                    Header = "Eliminar Micro";
                    Caption = "Eliminar";
                    this.BindearGridButacas();
                    this.textKgsDisponibles.Enabled = false;
                    this.textMarca.Enabled = false;
                    this.textModelo.Enabled = false;
                    this.textNumero.Enabled = false;
                    this.textPatente.Enabled = false;
                    this.comboTipoServicio.Enabled = false;
                    break;
                case ModoApertura.MODIFICACION:
                    Header = "Editar Micro";
                    Caption = "Guardar";
                    this.BindearGridButacas();
                    break;
            }
            this.labelHeader.Text = Header;
            this.botonOk.Text = Caption;
        }

        private void BindearGridButacas()
        {
            this.gridButacas.DataSource = this.Micro.Butacas;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MicroWindow_Load(object sender, EventArgs e)
        {
            this.comboTipoServicio.DataSource = TipoServicioRepository.Instance.All();
            this.BindearTabInicio();
            this.BindearTabHabilitaciones();
        }

        private void BindearTabHabilitaciones()
        {
            this.checkHabilitado.Checked = this.Micro.Habilitado;
            if (this.Micro.BajaDefinitiva)
            {
                this.radioBajaDefinitiva.Checked = true;
                this.datePickerBaja.Value = this.Micro.FechaBajaDefinitiva;
            }
            if (this.Micro.FueraDeServicio)
            {
                this.radioFueraDeServicio.Checked = true;
                this.datePickerBaja.Value = this.Micro.FechaFueraDeServicio;
                this.datePickerReincorporacion.Value = this.Micro.FechaReinicioDeServicio;
            }

            this.ConfigurarHabilitaciones();
        }

        public void ConfigurarHabilitaciones()
        {
            this.datePickerReincorporacion.Enabled = this.radioFueraDeServicio.Checked;
            this.RefreshPanelHabilitaciones();
        }

        private void BindearTabInicio()
        {
            this.textKgsDisponibles.Text = this.Micro.KGSDisponibles.ToString();
            this.textMarca.Text = this.Micro.Marca;
            this.textModelo.Text = this.Micro.Modelo;
            this.textNumero.Text = this.Micro.Numero.ToString();
            this.textPatente.Text = this.Micro.Patente;
            this.comboTipoServicio.SelectedItem = this.Micro.TipoDeServicio;
            var bol = Modo == ModoApertura.ALTA;
            this.datePickerFechaAlta.Value = bol ? DateTime.Today : this.Micro.FechaAlta;
        }

        private void botonOk_Click(object sender, EventArgs e)
        {
            this.UpdateMicro();
            this.CrearButacas();
            MicrosRepository.Instance.InsertarOActualizar(this.Micro); 
            MessageBox.Show("Micro Guardado Correctamente", "Ok", MessageBoxButtons.OK);
            this.Close();
        }

        private void CrearButacas()
        {
            if (!this.Modo.Equals(ModoApertura.ALTA))
                return;
            new ButacaWindow(this.Micro).ShowDialog();
        }

        private void UpdateMicro()
        {
            UpdateInfoBasicaMicro();
            this.UpdateHabilitacionesDeMicro();
        }

        private void UpdateInfoBasicaMicro()
        {
            Micro.FechaAlta = this.datePickerFechaAlta.Value;
            Micro.Marca = this.textMarca.Text;
            Micro.Modelo = this.textModelo.Text;
            Micro.Patente = this.textPatente.Text;
            Micro.TipoDeServicio = (TipoServicio) this.comboTipoServicio.SelectedItem;
            Micro.Numero = Convert.ToInt32(this.textNumero.Text);
            Micro.KGSDisponibles = Convert.ToDouble(this.textKgsDisponibles.Text);
        }

        private void UpdateHabilitacionesDeMicro()
        {
            //TODO esta cantidad de ifs se soluciona con un state.
            if (!this.checkHabilitado.Checked)
            {
                Micro.BajaDefinitiva = this.radioBajaDefinitiva.Checked;
                Micro.FueraDeServicio = this.radioFueraDeServicio.Checked;
                if (Micro.FueraDeServicio)
                {
                    Micro.FechaFueraDeServicio = this.datePickerBaja.Value;
                    Micro.FechaReinicioDeServicio = this.datePickerReincorporacion.Value;
                }
                if (Micro.BajaDefinitiva)
                    Micro.FechaBajaDefinitiva = this.datePickerBaja.Value;
            }
        }

        private void checkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            this.RefreshPanelHabilitaciones();
        }

        private void RefreshPanelHabilitaciones()
        {
            this.panelHabilitaciones.Enabled = !this.checkHabilitado.Checked;
        }

        private void radioFueraDeServicio_CheckedChanged(object sender, EventArgs e)
        {
            this.MicroFueraDeServicio();
        }

        private void MicroFueraDeServicio()
        {
            this.datePickerReincorporacion.Enabled = true;
            this.datePickerBaja.Value = DateTime.Today;
            this.datePickerReincorporacion.Value = DateTime.Today.AddDays(1);
        }

        private void MicroBajaDefinitiva()
        {
            this.datePickerReincorporacion.Enabled = false;
            this.datePickerBaja.Value = DateTime.Today;
        }

        private void radioBajaDefinitiva_CheckedChanged(object sender, EventArgs e)
        {
            this.MicroBajaDefinitiva();
        }
    }
}
