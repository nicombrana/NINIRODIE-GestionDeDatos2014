﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ABMCli : Form
    {
        public ABMCli()
        {
            InitializeComponent();
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new GenerarCliente().ShowDialog(this);
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            new Busqueda_Baja().ShowDialog();
        }

        private void botonModificacion_Click(object sender, EventArgs e)
        {
            new Busqueda_Mod().ShowDialog();
        }

        private void ABMCli_Load(object sender, EventArgs e)
        {

        }
    }
}
