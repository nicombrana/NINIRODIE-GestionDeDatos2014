using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Abm_Cliente;

namespace FrbaCommerce
{
    public partial class Commerce : Form
    {
        public Commerce()
        {
            InitializeComponent();
            LogIn login = new LogIn();
            login.ShowDialog(this);


            
            
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente().Show();
        }

        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new empresa().Show();
        }

        private void Campass_Click(object sender, EventArgs e)
        {
            new CambiarContrasenia().Show();
        }

        private void funciones_Load(object sender, EventArgs e)
        {

        }
    }          
}
