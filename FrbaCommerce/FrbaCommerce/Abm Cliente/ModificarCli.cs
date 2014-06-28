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

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModificarCli : Form
    {
        int clienteId;

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
            Cliente cliente = RepositorioCliente.Instance.BuscarClientePorClave(clienteId);

            cliente.codigo = clienteId;
            cliente.apellido = apellido.Text;
            cliente.nombre = nombre.Text;
            cliente.nro_doc = int.Parse(documento.Text);
            cliente.tipo_doc = tipo_doc.SelectedText;
            cliente.telefono = int.Parse(telefono.Text);
            cliente.mail = mail.Text;
            cliente.fecha_nac = dateTimePicker1.Value;
            cliente.ciud = ciudad.Text;
            cliente.loc = localidad.Text;
            cliente.call = calle.Text;
            cliente.altu = int.Parse(altura.Text);
            cliente.pis = int.Parse(piso.Text);
            cliente.puert = departamento.Text;
            cliente.codpos = int.Parse(cod_pos.Text);

            RepositorioCliente.Instance.ModificarCliente(cliente);
        }
    }
}
