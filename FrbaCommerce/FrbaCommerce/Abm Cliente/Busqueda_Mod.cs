﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.Alertas;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Busqueda_Mod : Form
    {
        string nombre;

        public Busqueda_Mod()
        {
            InitializeComponent();
        }

        private void Busqueda_Mod_Load(object sender, EventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BM_TextChanged(object sender, EventArgs e)
        {
            nombre = BM.Text;
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Buscador buscar = new Buscador();

            if (buscar.BuscarModCli(nombre))
            {
                new ModificarCli().ShowDialog();
            }
            else { new NoExisteUsuario().ShowDialog(); }
        }
    }
}