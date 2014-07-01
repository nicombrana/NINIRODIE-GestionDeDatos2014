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

namespace FrbaCommerce.Calificar
{
    public partial class MostrarCompras : Form
    {
        Decimal id_conectado;
        Compra compraSeleccionada;

        public MostrarCompras(Decimal id)
        {
            id_conectado = id;
            InitializeComponent();
        }

        private void MostrarCompras_Load(object sender, EventArgs e)
        {
            var compras = new List<Compra>();
            compras = RepositorioCompra.Instance.BuscarCompraCliente(id_conectado);
            this.ComprasGrid.DataSource = compras;
            this.ComprasGrid.Refresh();
            this.ComprasGrid.Columns["fecha"].Visible = false;
            this.ComprasGrid.Columns["id_comprador"].Visible = false;

            this.ComprasGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.ComprasGrid.Columns["cod_compra"].ReadOnly = true;
            this.ComprasGrid.Columns["cantidad"].ReadOnly = true;
            this.ComprasGrid.Columns["id_publicacion"].ReadOnly = true;

        }

        private void seleccionarCompra()
        {
            if (this.ComprasGrid.SelectedRows.Count > 0)
                compraSeleccionada = (Compra)this.ComprasGrid.SelectedRows[0].DataBoundItem;
            else
                MessageBox.Show("No se encontró ninguna compra\n" +
                    "con los parámetros indicados.", "Atención", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal compraid = RepositorioCompra.Instance.ObtenerCodigoCompra(compraSeleccionada);
            int cerrar = RepositorioCalificacion.Instance.BuscarCalif(compraSeleccionada.id_comprador, compraid);
            if (cerrar == -1)
            {
                MessageBox.Show("La Compra Seleccionada Ya Ha Sido Calificada", "Atención", MessageBoxButtons.OK);
            }
            if (cerrar == 0)
            {
                new Calificar(compraSeleccionada.id_comprador, compraid).ShowDialog(this);
            }
            
        }

        private void ComprasGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.seleccionarCompra();
        }
    }
}
