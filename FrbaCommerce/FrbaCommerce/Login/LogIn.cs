using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.NINIRODIE;


namespace FrbaCommerce
{
    public partial class LogIn : Form
    {
        public String id = null, pass = null, usuario = null;
        public bool logeo = false, cerrar = false;
        public Usuario user;

        public LogIn()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            GenerarCliente form_cliente = new GenerarCliente();

            form_cliente.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            cerrar = true;
            this.Close();
        }

        private void empresa_Click(object sender, EventArgs e)
        {
            empresa form_emp = new empresa();

            form_emp.Show();
        }

        private void ID_Usuario_TextChanged(object sender, EventArgs e)
        {
         id = this.ID_Usuario.Text;   
        }

        private void Pass_usuario_TextChanged(object sender, EventArgs e)
        {
            pass = this.Pass_usuario.Text;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_onClick(object sender, EventArgs e)
        {
            Logeador log = new Logeador();
            log.id = id;
            log.password = pass;
            
            user = log.EsCorrecto(id,pass);
            
            if ( user.id == id && user.pass == pass && user.habilitado == true)
            {
                logeo = true;

                this.Close();
               
            }
            else
            {
                new Alerid().Show();
            }
                   
        }

        private void gencli_Click(object sender, EventArgs e)
        {
            new GenerarCliente().ShowDialog();
        }

        private void genemp_Click(object sender, EventArgs e)
        {
            new empresa().ShowDialog();
        }
    }
}
