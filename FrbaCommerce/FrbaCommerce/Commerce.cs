﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.Abm_Empresa;
using FrbaCommerce.ABM_Rol;
using FrbaCommerce.Abm_Rubro;
using FrbaCommerce.Abm_Visibilidad;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Gestion_de_Preguntas;
using FrbaCommerce.Alertas;

namespace FrbaCommerce
{
    public partial class Commerce : Form
    {
        public Commerce()
        {
            InitializeComponent();
            LogIn login = new LogIn();
            login.ShowDialog(this);
            if (login.id == null && login.pass == null)
            {
                new bypass().ShowDialog(this);
                this.Close();
            }

        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMCli().ShowDialog(this);
        }

        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMEmp().ShowDialog(this);
        }

        private void Campass_Click(object sender, EventArgs e)
        {
            new CambiarContrasenia().Show();
        }

        private void funciones_Load(object sender, EventArgs e)
        {

        }

        private void aBMRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMRol().ShowDialog(this);
        }

        private void aBMRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMRubro().ShowDialog(this);
        }

        private void aBMVisibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ABMVisibilidad().ShowDialog(this);
        }

        private void generarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Genepub().ShowDialog(this);
        }

        private void editarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Genepub().ShowDialog(this);
        }

        private void verRespuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new preguntas().ShowDialog(this);
        }

        private void responderPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Responder().ShowDialog(this);
        }
    }          
}
