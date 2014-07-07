using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturacion : Form
    {
        Decimal codigoUsuario;
        public Facturacion(Decimal codigoUser)
        {
            InitializeComponent();
            codigoUsuario = codigoUser;
        }

        private void facturarCompraBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si iniciará la facturación de Compras", "Atención", MessageBoxButtons.OK);

            new Facturar(codigoUsuario, TipoFactura.FacturarCompra).ShowDialog(this);

            SeguirFacturandoPregunta();
        }

        private void SeguirFacturandoPregunta()
        {
            DialogResult resultado = MessageBox.Show("¿Desea seguir facturando?", "Atención",
                MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
                this.Close();
        }

        private void facturarOfertasBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se iniciará la facturación de Ofertas", "Atención", MessageBoxButtons.OK);

            new Facturar(codigoUsuario, TipoFactura.FacturarOferta).ShowDialog(this);

            SeguirFacturandoPregunta();
        }
    }
}
