using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Alertas
{
    public partial class GeneracionPublicacionCorrecta : Form
    {
        public GeneracionPublicacionCorrecta()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
