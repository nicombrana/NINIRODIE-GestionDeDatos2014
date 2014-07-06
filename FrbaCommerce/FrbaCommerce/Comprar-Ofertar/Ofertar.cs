using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using System.Configuration;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Ofertar : Form
    {
        Publicacion publicacionAOfertar;
        Oferta ofertaActual;
        Decimal codigoUsuario;
        DateTime fecha;

        public Ofertar(Publicacion publicacion, Decimal codigoComprador)
        {
            InitializeComponent();
            publicacionAOfertar = publicacion;
            codigoUsuario = codigoComprador;
            fecha = FechaSistema.Instance.fecha;
            this.ObtenerOfertaActual();
            this.popular();
        }

        private void ObtenerOfertaActual()
        {
            ofertaActual = RepositorioOferta.Instance.BuscarOferta(publicacionAOfertar.publicacion_id);
        }

        private void popular()
        {
            var publicaciones = new List<Publicacion>();
            publicaciones.Add(publicacionAOfertar);
            this.publicacionDataGrid.DataSource = publicaciones;
            this.publicacionDataGrid.Refresh();
            this.publicacionDataGrid.Columns["publicacion_id"].Visible = false;
            this.publicacionDataGrid.Columns["tipo"].Visible = false;
            this.publicacionDataGrid.Columns["visibilidad_codigo"].Visible = false;
            this.publicacionDataGrid.Columns["vendedor"].Visible = false;
            this.publicacionDataGrid.Columns["estado"].Visible = false;
            this.publicacionDataGrid.Columns["permitePregunta"].Visible = false;
            this.publicacionDataGrid.Columns["factura"].Visible = false;

            this.publicacionDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.publicacionDataGrid.Columns["descripcion"].ReadOnly = true;
            this.publicacionDataGrid.Columns["stock"].ReadOnly = true;
            this.publicacionDataGrid.Columns["precio"].ReadOnly = true;
            this.publicacionDataGrid.Columns["fecha_inicio"].ReadOnly = false;
            this.publicacionDataGrid.Columns["fecha_vencimiento"].ReadOnly = true;

            this.publicacionDataGrid.Columns["precio"].Name = "Precio a superarar";

            var publi = ((Publicacion)this.publicacionDataGrid.Rows[0].DataBoundItem);
            if (ofertaActual.monto != 0)
            {
                publi.precio = ofertaActual.monto;
            }
            else
                ofertaActual.monto = publi.precio;
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ofertaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
            VerificaValorEntero(e);
               
        }

        private void VerificaValorEntero(KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                MessageBox.Show("Solo puede introducir valores enteros para ofertar",
                    "Atención", MessageBoxButtons.OK);
        }

        private void aceptarBoton_Click(object sender, EventArgs e)
        {
            var monto = Decimal.Parse(ofertaTextBox.Text);
            if (monto > ofertaActual.monto)
                this.RealizarOferta(monto);
            else
                MessageBox.Show("Su oferta no es suficiente", "Atención", MessageBoxButtons.OK);
        }

        private void RealizarOferta(Decimal monto)
        {
            Oferta ofertaGenerada = this.GenerarOferta(monto);

            RepositorioOferta.Instance.GenerarOferta(ofertaGenerada);

            MessageBox.Show("Su oferta ha sido generada existosamente", 
                "Informe", MessageBoxButtons.OK);

            this.Close();
        }

        private Oferta GenerarOferta(Decimal monto)
        {
            return new Oferta(publicacionAOfertar.publicacion_id, monto, fecha, this.codigoUsuario);
        }

        private void preguntarBoton_Click(object sender, EventArgs e)
        {
            new Preguntas(codigoUsuario, publicacionAOfertar.publicacion_id).ShowDialog(this);
        }
    }
}
