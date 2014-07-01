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
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Calificar
{
    public partial class Calificar : Form
    {
        Decimal comprador, compra;

        public Calificar(Decimal id, Decimal compraID)
        {
            comprador = id;
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

            if (comentario.Text == "")
            {
                MessageBox.Show("Ingrese Un Comentario", "Atención", MessageBoxButtons.OK);
            }
            String desc = comentario.Text;
            
            RepositorioCalificacion.Instance.InsertarCalificacion(comprador, desc, calificacion, compra);

            MessageBox.Show("Gracias Por Su Calificacion", "Atención", MessageBoxButtons.OK);

            this.Close();
        }
    }
}
