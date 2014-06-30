using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Calificar
{
    public partial class MostrarCompras : Form
    {
        Decimal id_conectado;

        public MostrarCompras(Decimal id)
        {
            id_conectado = id;
            InitializeComponent();
        }

        private void MostrarCompras_Load(object sender, EventArgs e)
        {
            var compras = new List<Compra>();
            this.ComprasGrid.DataSource = compras;
            this.ComprasGrid.Refresh();
            this.ComprasGrid.Columns["compra_id"].Visible = true;
            this.ComprasGrid.Columns["cantidad"].Visible = true;
            this.ComprasGrid.Columns["fecha"].Visible = false;
            this.ComprasGrid.Columns["publicacion_id"].Visible = true;
            this.ComprasGrid.Columns["comprador_id"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
