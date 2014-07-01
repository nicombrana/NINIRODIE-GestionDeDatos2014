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

namespace FrbaCommerce.Calificar
{
    public partial class Calificar : Form
    {
        Decimal vendedor;

        public Calificar(Decimal id)
        {
            vendedor = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int calificacion = int.Parse(nota.Text);
            if (calificacion > 10 || calificacion < 1)
            {
                MessageBox.Show("Ingrese Una Calificacion Entre 1 y 10", "Atención", MessageBoxButtons.OK);
            }
            //Golpear Tabla Calificacion
        }
    }
}
