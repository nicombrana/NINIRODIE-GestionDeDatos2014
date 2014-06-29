using System;
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

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModificarCli : Form
    {
        int clienteId;

        Cliente cliente;

        public ModificarCli(int id)
        {
            clienteId = id;
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (CBcedula.Checked)
            {
                cliente.tipo_doc = "cedula";
            }
            if (CBdni.Checked)
            {
                cliente.tipo_doc = "dni";
            }
            cliente.codigo = clienteId;
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

            RepositorioCliente.Instance.ModificarCliente(cliente);

            new ModificacionCorrecta().ShowDialog(this);
        }

        private void ModificarCli_Load(object sender, EventArgs e)
        {
            cliente = RepositorioCliente.Instance.BuscarClientePorClave(clienteId);

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
        }
    }
}
