﻿using System;
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
        String tipo_docu = "nada";
        int nro_doc;
        int telef;
        String meil;
        DateTime f_nac;
        Char sex;
        String ciud;
        String loc;
        String call;
        int altu;
        int pis;
        int codpos;
        String puert;



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
            Decimal cerrar = 0;

            if (calle.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (telefono.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (nombre.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (apellido.Text == "" && cerrar == 0)
            {
                cerrar = 1;
                new TodosLosCampos().ShowDialog(this);
            }
            if (documento.Text == "" && cerrar == 0)
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
            if (Sexo.Text == "" && cerrar == 0)
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
                cerrar = this.buscarDoc(documento.Text);
            }
            if (cerrar == 0)
            {
                cerrar = this.buscarTel(telefono.Text);
            }

            if (cerrar == 0)
            {
                call = calle.Text;
                telef = int.Parse(telefono.Text);
                nomb = nombre.Text;
                ape = apellido.Text;
                nro_doc = int.Parse(documento.Text);
                codpos = int.Parse(cod_pos.Text);
                pis = int.Parse(piso.Text);
                altu = int.Parse(altura.Text);
                loc = localidad.Text;
                ciud = ciudad.Text;
                meil = mail.Text;
                sex = Char.Parse(Sexo.Text);
                puert = departamento.Text;
                f_nac = dateTimePicker1.Value;



                Cliente clie = new Cliente(tipo_docu, nro_doc, nomb,
                                            ape, f_nac, sex, meil, telef, ciud, loc, call,
                                            altu, pis, codpos, puert);

                //encriptar password
                RepositorioCliente.Instance.InsertarCliente(clie);


                new UsuarioYPassCliente().ShowDialog(this);
                this.Close();
            }
        }

        private int buscarTel(String telefono)
        {
            int tel = int.Parse(telefono);

            int valor = RepositorioCliente.Instance.buscarClientePorTelefono(tel);

            if (valor == 1)
            {
                MessageBox.Show("Telefono Ya Existente", "Atención", MessageBoxButtons.OK);
            }
            return valor;
        }

        private int buscarDoc(String documento)
        {
            int doc = int.Parse(documento);

            int valor = RepositorioCliente.Instance.InsertarClientePorDocumento(doc);
            if (valor == 1)
            {
                MessageBox.Show("Documento Ya Existente","Atención", MessageBoxButtons.OK);
            }
            return valor;
        }

        private void CBdni_CheckedChanged(object sender, EventArgs e)
        {
            if (CBdni.Checked)
            {
                CBcedula.Enabled = false;
                tipo_docu = "DNI";
            }
            else
            {
                CBcedula.Enabled = true;
                tipo_docu = "nada";
            }
        }

        private void CBcedula_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcedula.Checked)
            {
                CBdni.Enabled = false;
                tipo_docu = "Cedula";
            }
            else
            {
                CBdni.Enabled = true;
                tipo_docu = "nada";
            }
        }

        private void Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.noEscribeNada(e);
        }




    }
}
