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
        public String tipo_docu;
        public Decimal nro_doc;
        public Decimal telef;
        public String meil;
        public DateTime f_nac;
        public Char sex;
        public String ciud;
        public String loc;
        public String call;
        public Decimal altu;
        public Decimal pis;
        public Decimal codpos;
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
            nro_doc = Decimal.Parse(NDoc.Text);
            meil = Email.Text;
            tipo_docu = comboBox1.SelectedText;

            Cliente cliente = new Cliente();

            cliente.codigo = RepositorioCliente.Instance.BuscarCliente(ape, nombre, nro_doc,
                                                            meil, tipo_docu);
            if (cliente.codigo == -1)
            {
                new Muchos().ShowDialog(this);
            }
            else if (cliente.codigo == -2)
            {
                new NoExisteUsuario().ShowDialog(this);
            }
            else
            {
                new ModificarCli(cliente.codigo).ShowDialog(this);
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


    }
}
