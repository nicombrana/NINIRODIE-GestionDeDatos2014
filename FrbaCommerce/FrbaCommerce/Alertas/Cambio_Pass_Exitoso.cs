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
    public partial class Cambio_Pass_Exitoso : Form
    {
        public Cambio_Pass_Exitoso()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
