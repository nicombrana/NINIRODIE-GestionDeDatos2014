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
    public partial class Busqueda_Baja : Form
    {
        String nombre_usuario;
        String clave;
        String clave_rep;
        String nombre;
        String ape;
        String tipo_docu;
        Decimal nro_doc;
        Decimal telef;
        String meil;
        DateTime f_nac;
        Char sex;
        String ciud;
        String loc;
        String call;
        Decimal altu;
        Decimal pis;
        Decimal codpos;
        Char puert;


        public Busqueda_Baja()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            ape = textBox2.Text;
            nombre = BM.Text;
            nro_doc = Decimal.Parse(NDoc.Text);
            meil = Email.Text;
            tipo_docu = comboBox1.SelectedText;

            Cliente cliente = new Cliente();

            cliente = RepositorioCliente.Instance.BuscarClienteBaja(ape, nombre, nro_doc,
                                                            meil, tipo_docu);

            cliente.codigo = RepositorioCliente.Instance.BuscarClaveCliente(cliente); 
            

            new BajaCli(cliente.codigo).ShowDialog(this);
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

        private void Busqueda_Baja_Load(object sender, EventArgs e)
        {

        }
    }
}
