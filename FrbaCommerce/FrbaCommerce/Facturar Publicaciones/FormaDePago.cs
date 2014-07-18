using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FormaDePago : Form
    {
        MediosPago mediosPago = new MediosPago();
        public FormaDePago(MediosPago medioPago)
        {
            InitializeComponent();
            mediosPago = medioPago;
            this.cuotasComboBox.DataSource = new List<String> { "1", "3", "6", "9", "12" };
        }

        private void aceptarBoton_Click(object sender, EventArgs e)
        {
            mediosPago.infoPersonal = "Número de Tarjeta: " +
                this.numeroTarjetaTextBox.Text + " cantidad de Cuotas: " +
                this.cuotasComboBox.SelectedItem.ToString();

            this.Close();
        }

        private void numeroTarjetaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo puede ingresar números.", "Atención", MessageBoxButtons.OK);
        }


    }
}
