using System;
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
        string usuario = "admin";

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
            new CambiarContrasenia().Show();
        }

        private void funciones_Load(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Visible = false; ;
            Campass.Visible = false;
            publicacion.Visible = false;
            preguntas.Visible = false;

            LogIn login = new LogIn();
            login.ShowDialog(this);

            if (login.usuario == "admin")
            {
                toolStripDropDownButton1.Visible = true;
                Campass.Visible = true;
                publicacion.Visible = true;
                preguntas.Visible = true;
            }
            else{
                Campass.Visible = true;
                publicacion.Visible = true;
                preguntas.Visible = true;
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

        private void buscarPublicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuscarPublicacion().ShowDialog(this);
        }
    }          
}
