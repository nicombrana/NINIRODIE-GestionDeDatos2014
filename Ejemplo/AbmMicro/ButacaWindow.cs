using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Model;

namespace FrbaBus.View.Abm_Micro
{
    public partial class ButacaWindow : Form
    {
        public Micro Micro { get; set; }
        public Butaca Butaca { get; set; }
        public ButacaWindow()
        {
            InitializeComponent();
            this.comboUbicacion.DataSource = new List<string> { Butaca.PASILLO, Butaca.VENTANA };
        }

        public ButacaWindow(Micro Micro)
            : this()
        { this.Micro = Micro;  }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarYSalir();
        }

        private void GuardarYSalir()
        {
            this.CrearButaca();
            this.Micro.AgregarButaca(this.Butaca);
            this.Close();
        }

        private void CrearButaca()
        {
            this.Butaca = new Butaca();
            this.Butaca.Numero = Int32.Parse(this.textNumero.Text);
            this.Butaca.Piso = Int32.Parse(this.textNumero.Text);
            this.Butaca.Ubicacion = (string)this.comboUbicacion.SelectedItem;
        }

        private void botonOtra_Click(object sender, EventArgs e)
        {
            this.GuardarYSalir();
            new ButacaWindow(this.Micro).ShowDialog();
        }

        private void textNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }

        private void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarSoloNumeros(e);
        }
    }
}
