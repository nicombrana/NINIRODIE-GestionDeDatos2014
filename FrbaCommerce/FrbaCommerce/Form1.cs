using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente().Show();
        }

        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new empresa().Show();
        }
    }          
}
