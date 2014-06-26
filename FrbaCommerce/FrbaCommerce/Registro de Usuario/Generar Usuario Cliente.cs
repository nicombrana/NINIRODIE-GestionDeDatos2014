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
    public partial class GenerarCliente : Form
    {
        String nomb;
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



        public GenerarCliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void cod_pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void documento_KeyPress(object sender, KeyPressEventArgs e)
        {
                Validador.soloEscribeNumeros(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
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
                telef = Decimal.Parse(telefono.Text);
                nomb = nombre.Text;
                ape = apellido.Text;
                nro_doc = Decimal.Parse(documento.Text);
                codpos = Decimal.Parse(cod_pos.Text);
                pis = Decimal.Parse(piso.Text);
                altu = Decimal.Parse(altura.Text);
                loc = localidad.Text;
                ciud = ciudad.Text;
                
                meil = mail.Text;
                sex = Char.Parse(Sexo.Text);
                puert = Char.Parse(departamento.Text);
                f_nac = dateTimePicker1.Value;
                tipo_docu = tipo_doc.SelectedText;



                Cliente clie = new Cliente(tipo_docu, nro_doc, nomb,
                                            ape,f_nac, sex, meil, telef,ciud, loc, call,
                                            altu, pis, codpos, puert);
                           
                //encriptar password
                RepositorioCliente.Instance.InsertarCliente(clie);
                
            new UsuarioYPass(clie.nro_doc).ShowDialog(this);
            
            this.Close();
        }




    }
}
