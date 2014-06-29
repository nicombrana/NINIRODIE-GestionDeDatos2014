using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ABMVisibilidad : Form
    {
        public ABMVisibilidad()
        {
            InitializeComponent();
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new GenerarVisibilidad().ShowDialog(this);
            this.Close();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            new BuscarVisibilidad().ShowDialog(this);
            this.Close();
        }
    }
}
