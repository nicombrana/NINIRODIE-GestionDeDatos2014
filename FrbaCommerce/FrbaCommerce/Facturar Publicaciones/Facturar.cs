using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturar : Form
    {
        Decimal codigoUsuario;

        public Facturar(Decimal codigoUser, TipoFactura tipoFacturacion)
        {
            InitializeComponent();
            codigoUsuario = codigoUser;

            this.PopularFormaPago();

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
            this.compraOfertaGruopBox.Text = "Ofertas";

            var ofertas = RepositorioOferta.Instance.BuscarOfertasCliente(codigoUsuario);

            this.compraOfertaGrilla.DataSource = ofertas;
            this.compraOfertaGrilla.Refresh();
        }

        private void PopularGrillaCompras()
        {
            var compras = RepositorioCompra.Instance.BuscarComprasCliente(codigoUsuario);

            this.compraOfertaGrilla.DataSource = compras;
            this.compraOfertaGrilla.Refresh();
        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
