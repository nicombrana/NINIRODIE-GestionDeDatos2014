using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class ABMEmp : Form
    {
        public ABMEmp()
        {
            InitializeComponent();
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new GenerarEmpresa().ShowDialog(this);
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            new Busqueda_Baja_Emp().ShowDialog();
        }

        private void botonModificacion_Click(object sender, EventArgs e)
        {
            new Busqueda_Mod_Emp().ShowDialog();
        }
    }
}
