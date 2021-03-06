﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModificarCli : Form
    {
        Decimal userId;
        String docum, telefo;

        Cliente cliente;

        public ModificarCli(Decimal id)
        {
            userId = id;
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            int cerrar = 0;

            if (CBcedula.Checked)
            {
                cliente.tipo_doc = "cedula";
            }
            if (CBdni.Checked)
            {
                cliente.tipo_doc = "dni";
            }
            cliente.usuario_id = userId;
            if (apellido.Text != "")
            {
                cliente.apellido = apellido.Text;
            }
            if (nombre.Text != "")
            {
                cliente.nombre = nombre.Text;
            }
            if (documento.Text != "")
            {
                cliente.nro_doc = int.Parse(documento.Text);
            }
            if (telefono.Text != "")
            {
                cliente.telefono = int.Parse(telefono.Text);
            }
            if (mail.Text != "")
            {
                cliente.mail = mail.Text;
            }
            cliente.fecha_nac = dateTimePicker1.Value;
            if (ciudad.Text != "")
            {
                cliente.ciud = ciudad.Text;
            }
            if (localidad.Text != "")
            {
                cliente.loc = localidad.Text;
            }
            if (calle.Text != "")
            {
                cliente.call = calle.Text;
            }
            if (altura.Text != "")
            {
                cliente.altu = int.Parse(altura.Text);
            }
            if (piso.Text != "")
            {
                cliente.pis = int.Parse(piso.Text);
            }
            if (departamento.Text != "")
            {
                cliente.puert = departamento.Text;
            }
            if (cod_pos.Text != "")
            {
                cliente.codpos = int.Parse(cod_pos.Text);
            }
            if (cerrar == 0 && documento.Text != docum)
            {
                cerrar = this.buscarDoc(documento.Text);
            }
            if (cerrar == 0 && telefono.Text != telefo)
            {
                cerrar = this.buscarTel(telefono.Text);
            }

            if (cerrar == 0)
            {
                RepositorioCliente.Instance.ModificarCliente(cliente);

                new ModificacionCorrecta().ShowDialog(this);
                this.Close();
            }
        }

        private void ModificarCli_Load(object sender, EventArgs e)
        {
            cliente = RepositorioCliente.Instance.BuscarClientePorClave(userId);

            if (cliente.tipo_doc == "dni")
            {
                CBcedula.Enabled = true;
                CBdni.Enabled = false;
            }
            else
            {
                CBcedula.Enabled = false;
                CBdni.Enabled = true;
            }

            documento.Text = cliente.nro_doc.ToString();
            docum = cliente.nro_doc.ToString();
            cod_pos.Text = cliente.codpos.ToString();
            departamento.Text = cliente.puert;
            piso.Text = cliente.pis.ToString();
            altura.Text = cliente.altu.ToString();
            calle.Text = cliente.call;
            localidad.Text = cliente.loc;
            ciudad.Text = cliente.ciud;
            mail.Text = cliente.mail;
            telefono.Text = cliente.telefono.ToString();
            telefo = cliente.telefono.ToString();
            apellido.Text = cliente.apellido;
            nombre.Text = cliente.nombre;
            

        }

        private void documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
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

        private void calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
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
                MessageBox.Show("Documento Ya Existente", "Atención", MessageBoxButtons.OK);
            }
            return valor;
        }
    }
}
