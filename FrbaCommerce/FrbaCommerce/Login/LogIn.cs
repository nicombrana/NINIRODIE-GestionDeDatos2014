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
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;


namespace FrbaCommerce
{
    public partial class LogIn : Form
    {
        public String id = null, pass = null, usuario = null;
        public bool logeo = false, cerrar = false;
        public Usuario user;
        public int intentos_fallidos = 0;

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
            GenerarEmpresa form_emp = new GenerarEmpresa();

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
            
            user = log.EsCorrecto(id);

            if ( user.id == id){
                if (user.pass == pass){
                    if (user.habilitado == true)
                    {
                        if (user.bloque == false)
                        {
                            if (user.prim == false)
                            {
                                intentos_fallidos = 0;
                                logeo = true;
                                this.Close();
                            }
                            else
                            {
                                new CambiarContrasenia(user.codigo).ShowDialog(this);
                            }
                        }
                        else
                        {
                            new Bloqueado().ShowDialog(this);
                        }
                    }
                    else
                    {
                        new NoHabilitado().ShowDialog(this);
                    }
                }
                else
                {
                    intentos_fallidos = intentos_fallidos + 1;
              
                    if (intentos_fallidos == 3)
                    {
                        RepositorioUsuario.Instance.Bloquear(user.id);
                        new Bloqueado().ShowDialog(this);
                    }
                    else
                    {
                        new Alerid().ShowDialog(this);
                    }
                }
            }
            else
            {
                new Alerid().ShowDialog(this);
            }
                  
        }

        private void gencli_Click(object sender, EventArgs e)
        {
            new GenerarCliente().ShowDialog();
        }

        private void genemp_Click(object sender, EventArgs e)
        {
            new GenerarEmpresa().ShowDialog();
        }
    }
}
