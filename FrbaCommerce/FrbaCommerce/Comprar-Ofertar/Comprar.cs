using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar : Form
    {
        Publicacion publicacionAComprar;
        Decimal codigoUser;
        Persona vendedor;
        Usuario usuario;

        public Comprar(Publicacion publicacion, Decimal codigoUsuario)
        {
            InitializeComponent();
            publicacionAComprar = publicacion;
            codigoUser = codigoUsuario;
            obtenerVendedor();
            popular();
        }

        private void obtenerVendedor()
        {
            usuario = RepositorioUsuario.Instance.BuscarUsuarioPorCodigo(publicacionAComprar.vendedor);

            if (usuario.idClienteOEmpresa % 2 != 0)
                vendedor = RepositorioEmpresa.Instance.BuscarEmpresaPorClave(usuario.idClienteOEmpresa);
            else
                vendedor = RepositorioCliente.Instance.BuscarClientePorClave(usuario.idClienteOEmpresa);
        }

        private void popular()
        {
            if (usuario.idClienteOEmpresa % 2 == 0)
            {
                var cliente = (Cliente)vendedor;
                identificador.Text = "Nombre";
                DNICUIL.Text = "DNI";
                FechaCreacion.Text = "Fecha Nacimiento";
                idTextBox.Text = cliente.apellido + ", " + cliente.nombre;
                dniTextBox.Text = cliente.nro_doc.ToString();
                mailTextBox.Text = cliente.mail;
                fechaCreacionTextBox.Text = cliente.fecha_nac.ToString();
                calleTextBox.Text = cliente.call;
                alturaTextBox.Text = cliente.altu.ToString();
                pisoTextBox.Text = cliente.pis.ToString();
                deptoTextBox.Text = cliente.puert.ToString();
                codPostalTextBox.Text = cliente.codpos.ToString();
            }
            else
            {
                var empresa = (Empresa)vendedor;
                idTextBox.Text = empresa.razon_social;
                dniTextBox.Text = empresa.cuit.ToString();
                mailTextBox.Text = empresa.mail;
                fechaCreacionTextBox.Text = empresa.fecha_creacion.ToString();
                calleTextBox.Text = empresa.call;
                alturaTextBox.Text = empresa.altu.ToString();
                pisoTextBox.Text = empresa.pis.ToString();
                deptoTextBox.Text = empresa.puert.ToString();
                codPostalTextBox.Text = empresa.codpos.ToString();
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preguntaraBoton_Click(object sender, EventArgs e)
        {
            new Preguntas(codigoUser ,this.publicacionAComprar.publicacion_id).ShowDialog(this);
        }
    }
}
