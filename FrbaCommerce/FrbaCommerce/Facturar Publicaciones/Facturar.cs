using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturar : Form
    {
        Decimal codigoUsuario;
        TipoFactura tipoFacturacion;

        public Facturar(Decimal codigoUser, TipoFactura tipoFacturacion)
        {
            InitializeComponent();
            codigoUsuario = codigoUser;
            this.tipoFacturacion = tipoFacturacion;

            this.PopularFormaPago();
            this.RenombrarComprarOfertar();
            this.compraOfertaGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MessageBox.Show("Debe ingresar una cantidad a Facturar", "Atención", MessageBoxButtons.OK);
        }

        private void RenombrarComprarOfertar()
        {
            if (tipoFacturacion == TipoFactura.FacturarOferta)
            {
                this.compraOfertaGruopBox.Text = "Ofertas";
                this.busquedaGroupBox.Text = "Búsqueda Ofertas";
            }
        }

        private void PopularGrilla()
        {
            if (tipoFacturacion == TipoFactura.FacturarCompra)
                this.PopularGrillaCompras();
            else
                this.PopularGrillaOfertas();
        }

        private void PopularFormaPago()
        {
            this.formaPagoComboBox.DataSource = new List<String> 
                {"Efectivo", "Tarjeta de Débito", "Tarjeta de Crédito" };
            this.formaPagoComboBox.Refresh();
        }

        private void PopularGrillaOfertas()
        {
            var cantidad = int.Parse(this.cantidadTextBox.Text);
            var ofertas = RepositorioOferta.Instance.BuscarOfertasCliente(codigoUsuario, cantidad);

            this.compraOfertaGrilla.DataSource = ofertas;
            this.compraOfertaGrilla.Refresh();
        }

        private void PopularGrillaCompras()
        {
            var cantidad = int.Parse(this.cantidadTextBox.Text);
            var compras = RepositorioCompra.Instance.BuscarComprasCliente(codigoUsuario, cantidad);

            this.compraOfertaGrilla.DataSource = compras;
            this.compraOfertaGrilla.Refresh();
        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturarBoton_Click(object sender, EventArgs e)
        {

        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            if (this.cantidadTextBox.Text != "")
                PopularGrilla();
            else
                MessageBox.Show("Debe ingresar una cantidad a Facturar", "Atención", MessageBoxButtons.OK);
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo puede ingresar números.", "Atención", MessageBoxButtons.OK);
        }
    }
}
