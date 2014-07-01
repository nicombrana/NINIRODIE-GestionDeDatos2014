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

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Busqueda_Mod : Form
    {

        public String nombre;
        public String ape;
        public String tipo_docu = "nada";
        public int nro_doc = 0;
        public int telef;
        public String meil;
        public DateTime f_nac;
        public Char sex;
        public String ciud;
        public String loc;
        public String call;
        public int altu;
        public int pis;
        public int codpos;
        public Char puert;

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
            ape = textBox2.Text;
            nombre = BM.Text;
            if (NDoc.Text != "")
            {
                nro_doc = int.Parse(NDoc.Text);
            } 
            meil = Email.Text;

            Cliente cliente = new Cliente();

            Decimal usuariocodigo = RepositorioCliente.Instance.BuscarCliente(ape, nombre, nro_doc,
                                                            meil, tipo_docu);
            if (usuariocodigo == -1)
            {
                //new MostrarCliMod(ape, nombre, nro_doc, meil, tipo_docu).ShowDialog(this);
                new Muchos().ShowDialog(this);
            }
            else if (usuariocodigo == -2)
            {
                new NoExisteUsuario().ShowDialog(this);
            }
            else
            {
                new ModificarCli(usuariocodigo).ShowDialog(this);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void NDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void CBdni_CheckedChanged(object sender, EventArgs e)
        {
            if (CBdni.Checked)
            {
                tipo_docu = "dni";
                CBcedula.Enabled = false;
            }
            else
            {
                tipo_docu = "nada";
                CBcedula.Enabled = true;

            }
        }

        private void CBcedula_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcedula.Checked)
            {
                tipo_docu = "cedula";
                CBdni.Enabled = false;
            }
            else
            {
                tipo_docu = "nada";
                CBdni.Enabled = true;
            }
        }


    }
}
