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
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.Comprar_Ofertar;

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
            new CambiarContrasenia().Show();
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
            }
            else{
                if (login.user.tipo == "CLIENTE" || login.user.tipo == "EMPRESA")
                {
                    Campass.Visible = true;
                    publicacion.Visible = true;
                    preguntas.Visible = true;
                }
                else
                {
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
            new BuscarComprarOfertar(1).ShowDialog(this);//Código de Inmediata
        }

        private void ofertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuscarComprarOfertar(2).ShowDialog(this);//Código de Subasta
        }
    }          
}
