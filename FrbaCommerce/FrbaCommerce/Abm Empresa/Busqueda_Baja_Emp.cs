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
    public partial class Busqueda_Baja_Emp : Form
    {
        public String razon;
        public String mail;
        public Decimal cuit;

        public Busqueda_Baja_Emp()
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
            cuit = Decimal.Parse(TextCuit.Text);

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
                new BajaEmp(empresa.codigo).ShowDialog(this);
            }
        }


        private void TextCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

    }
}
