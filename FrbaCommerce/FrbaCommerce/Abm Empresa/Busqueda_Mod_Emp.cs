using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Busqueda_Mod_Emp : Form
    {
        public String razon;
        public String mail;
        public String cuit;

        public Busqueda_Mod_Emp()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            razon = BM.Text;
            mail = Textmail.Text;
            cuit = TextCuit.Text;

            Empresa empresa = new Empresa();

            empresa.codigo = RepositorioEmpresa.Instance.BuscarEmpresa(razon, mail, cuit);

            if (empresa.codigo == -1)
            {
                new Muchos().ShowDialog(this);
            }
            else if (empresa.codigo == -2)
            {
                new NoExisteUsuario().ShowDialog(this);
            }
            else
            {
                new ModificarEmp(empresa.codigo).ShowDialog(this);
                this.Close();
            }
        }

        private void Busqueda_Mod_Emp_Load(object sender, EventArgs e)
        {

        }

        private void Busqueda_Mod_Emp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
