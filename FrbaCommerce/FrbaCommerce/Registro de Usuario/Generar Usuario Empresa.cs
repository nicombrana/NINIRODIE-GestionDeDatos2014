using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.Alertas;

namespace FrbaCommerce
{
    public partial class GenerarEmpresa : Form
    {
        String razon_social;
        Decimal nro_cuit;
        Decimal telef;
        String meil;
        String contact;
        DateTime f_creacion;
        String ciud;
        String loc;
        String call;
        Decimal altu;
        Decimal pis;
        Decimal codpos;
        Char puert;

        public GenerarEmpresa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empresa_Load(object sender, EventArgs e)
        {

        }

        private void ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void cod_pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            call = calle.Text;
            razon_social = nombre.Text;
            telef = Decimal.Parse(telefono.Text);
            contact = contacto.Text;
            nro_cuit = Decimal.Parse(cuit.Text);
            codpos = Decimal.Parse(cod_pos.Text);
            pis = Decimal.Parse(piso.Text);
            altu = Decimal.Parse(altura.Text);
            loc = localidad.Text;
            ciud = ciudad.Text;
            meil = mail.Text;
            puert = Char.Parse(departamento.Text);
            f_creacion = dateTimePicker1.Value;

            Empresa empresa = new Empresa(nro_cuit, razon_social, contact, f_creacion,
                meil, telef, ciud, loc, call, altu, pis, codpos, puert);

            RepositorioEmpresa.Instance.InsertarEmpresa(empresa);

            new PassYUsuario(empresa.razon_social).ShowDialog(this);

            this.Close();
        }

    }
}
