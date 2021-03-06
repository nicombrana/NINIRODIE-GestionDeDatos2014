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
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.Comprar_Ofertar;
using FrbaCommerce.Calificar;
using FrbaCommerce.Listado_Estadistico;
using FrbaCommerce.Facturar_Publicaciones;

namespace FrbaCommerce
{
    public partial class Commerce : Form
    {
        Decimal cod_conectado = 0;
        LogIn login = new LogIn();

        public Commerce()
        {
            InitializeComponent();

           
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

            new CambiarContrasenia(cod_conectado).Show();
        }

        private void funciones_Load(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Visible = false; ;
            Campass.Visible = false;
            publicacion.Visible = false;
            preguntas.Visible = false;

            
            login.ShowDialog(this);

            cod_conectado = login.user.codigo;

            if (login.user.tipo == "ADMINISTRADOR")
            {
                toolStripDropDownButton1.Visible = true;
                Campass.Visible = true;
                publicacion.Visible = true;
                preguntas.Visible = true;
                listadoEstadistico.Visible = true;
            }
            else{
                if (login.user.tipo == "CLIENTE")
                {
                    toolStripSplitButton1.Visible = true;
                    Campass.Visible = true;
                    publicacion.Visible = true;
                    preguntas.Visible = true;
                    listadoEstadistico.Visible = false;
                }
                else if (login.user.tipo == "EMPRESA")
                {
                    toolStripSplitButton1.Visible = false;
                    Campass.Visible = true;
                    publicacion.Visible = true;
                    preguntas.Visible = true;
                    listadoEstadistico.Visible = false;
                }
                else {
                    this.Close();
                }
            }
            if(login.cerrar == true){
                this.Close();
            }

            if(login.logeo == false){
                new bypass().ShowDialog(this);
                this.Close();
            
            }
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
            new Genepub(this.login.user.codigo).ShowDialog(this);
        }

        private void editarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuscarPublicacion(this.login.user.codigo).ShowDialog(this);
        }

        private void verRespuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Pregunta> preguntas = RepositorioPreguntas.Instance.BuscarPregunta(cod_conectado);

            if (preguntas.Count == 0)
            {
                new SinPreguntas().ShowDialog(this);
            }
            else
            {
                new preguntas(cod_conectado).ShowDialog(this);
            }
        }

        private void responderPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Responder(cod_conectado).ShowDialog(this);
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.login.user.habilitado)
                new BuscarComprarOfertar(1, this.login.user.codigo).ShowDialog(this);//Código de Inmediata
            else
                MessageBox.Show("Usted se encuentra inhabilitado.\n" +
                    "Para continuar deberá regularizar su situación.", "Atención", MessageBoxButtons.OK);
        }

        private void ofertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.login.user.habilitado)
                new BuscarComprarOfertar(2, this.login.user.codigo).ShowDialog(this);//Código de Subasta
            else
                MessageBox.Show("Usted se encuentra inhabilitado.\n" +
                    "Para continuar deberá regularizar su situación.", "Atención", MessageBoxButtons.OK);
        }

        private void Calificar_Click(object sender, EventArgs e)
        {
            new MostrarCompras(cod_conectado).ShowDialog(this);
        }

        private void listadoEstadistico_Click(object sender, EventArgs e)
        {
            new ListadoEstadistico().ShowDialog(this);
        }

        private void facturarBoton_Click(object sender, EventArgs e)
        {
            new Facturacion(this.login.user.codigo).ShowDialog(this);
        }


    }          
}
