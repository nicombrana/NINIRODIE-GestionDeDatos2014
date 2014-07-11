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
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar : Form
    {
        Publicacion publicacionAComprar;
        Decimal codigoUser;
        Persona vendedor;
        Usuario usuario;
        Compra compra;


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

            stockTextBox.Text = publicacionAComprar.stock.ToString();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.cantidadTextBox.Text.ToString() != "")
            {
                Decimal cantidad = Decimal.Parse(this.cantidadTextBox.Text.ToString());

                if (cantidad <= publicacionAComprar.stock)
                {
                    this.GenerarCompra(cantidad);

                    compra.cod_compra = RepositorioCompra.Instance.ObtenerCodigoCompra(compra);

                    MessageBox.Show("Su compra ha sido llevada a cabo satisfactoriamente.\n" +
                        "Su código de compra es el " + compra.cod_compra.ToString() + "." +
                        "\nContactese con el vendedor para arreglar los\n" +
                        "terminos de envío.", "Informe", MessageBoxButtons.OK);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No puede ingresar una cantidad mayor al Stock del producto.",
                        "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una cantidad\n" + "para poder realizar una compra.",
                    "Atención", MessageBoxButtons.OK);
            }

        }

        private void GenerarCompra(Decimal cantidad)
        {
            compra = new Compra(cantidad, FechaSistema.Instance.fecha, 
                publicacionAComprar.publicacion_id, this.codigoUser);

            RepositorioCompra.Instance.Comprar(compra);
        }

        private void preguntaraBoton_Click(object sender, EventArgs e)
        {
            if (publicacionAComprar.permitePregunta)
                new Preguntas(codigoUser ,this.publicacionAComprar.publicacion_id).ShowDialog(this);
            else
                MessageBox.Show("El vendedor no permite preguntas.", "Atención", MessageBoxButtons.OK);
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);

            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo puede ingresar números.", "Atención", MessageBoxButtons.OK);
        }
    }
}
