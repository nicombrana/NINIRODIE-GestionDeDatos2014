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
        String nro_cuit;
        int telef;
        String meil;
        String contact;
        DateTime f_creacion;
        String ciud;
        String loc;
        String call;
        int altu;
        int pis;
        int codpos;
        String puert;

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

        private void calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Decimal cerrar = 0;
            
            if(calle.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if(nombre.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (telefono.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (contacto.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (cuit.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (cod_pos.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (piso.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (altura.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (localidad.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (ciudad.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (mail.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (departamento.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (cerrar == 0)
            {
                cerrar = this.buscarTel(telefono.Text);
            }
            if (cerrar == 0)
            {
                cerrar = this.buscarCuit(cuit.Text);
            }

            if (cerrar == 0)
            {
                call = calle.Text;
                razon_social = nombre.Text;
                telef = int.Parse(telefono.Text);
                contact = contacto.Text;
                nro_cuit = cuit.Text.ToString();
                codpos = int.Parse(cod_pos.Text);
                pis = int.Parse(piso.Text);
                altu = int.Parse(altura.Text);
                loc = localidad.Text;
                ciud = ciudad.Text;
                meil = mail.Text;
                puert = departamento.Text;
                f_creacion = dateTimePicker1.Value;

                Empresa empresa = new Empresa(nro_cuit, razon_social, contact, f_creacion,
                    meil, telef, ciud, loc, call, altu, pis, codpos, puert);

                RepositorioEmpresa.Instance.InsertarEmpresa(empresa);

                new UsuarioYPassEmpresa().ShowDialog(this);
                this.Close();
            }
        }

        private int buscarCuit(String cuit)
        {

            int valor = RepositorioEmpresa.Instance.buscarEmpresaPorCuit(cuit);

            if (valor == 1)
            {
                MessageBox.Show("Cuit Ya Existente", "Atención", MessageBoxButtons.OK);
            }
            return valor;
        }

        private int buscarTel(String telefono)
        {
            int tel = int.Parse(telefono);

            int valor = RepositorioEmpresa.Instance.buscarEmpresaPorTelefono(tel);

            if (valor == 1)
            {
                MessageBox.Show("Telefono Ya Existente", "Atención", MessageBoxButtons.OK);
            }
            return valor;
        }
    }
}
