using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Responder : Form
    {
        Decimal conectado = 0;

        public Responder(Decimal codigo)
        {
            conectado = codigo;
            InitializeComponent();
        }

        private void rescancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resaceptar_Click(object sender, EventArgs e)
        {

        }

    }
}
