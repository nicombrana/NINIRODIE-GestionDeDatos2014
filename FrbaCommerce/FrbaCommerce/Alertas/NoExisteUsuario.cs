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
    public partial class NoExisteUsuario : Form
    {
        public NoExisteUsuario()
        {
            InitializeComponent();
        }

        private void NEUAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
