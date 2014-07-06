using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Preguntas : Form
    {
        Decimal CodigoCliente;
        Decimal CodigoPublicacion;

        public Preguntas(Decimal codigoCliente, Decimal codigoPublicacion)
        {
            InitializeComponent();
            CodigoCliente = codigoCliente;
            CodigoPublicacion = codigoPublicacion;
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarBoton_Click(object sender, EventArgs e)
        {
            RepositorioPreguntas.Instance.GenerarPregunta(this.preguntaRichTextBox.Text.ToString(),
                this.CodigoCliente, this.CodigoPublicacion);

            MessageBox.Show("Se ha generado la pregunta exitosamente",
                "Informe", MessageBoxButtons.OK);

            this.Close();
        }
    }
}
