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
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class GenerarVisibilidad : Form
    {
        Decimal visibilidadCodigo;
        String visibiDescripcion;
        Decimal precio;
        Decimal porcentajeVenta;
        Decimal cantDias;

        public GenerarVisibilidad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal estado_nombre, estado_codigo;

            visibiDescripcion = desc.Text;
            visibilidadCodigo = Decimal.Parse(codigo.Text);
            precio = Decimal.Parse(valor.Text);
            porcentajeVenta = Decimal.Parse(porcentaje.Text);
            cantDias = Decimal.Parse(dias.Text);

            Visibilidad visi = new Visibilidad(visibilidadCodigo, visibiDescripcion,
                    precio, porcentajeVenta, cantDias, true);

            estado_nombre = RepositorioVisibilidad.Instance.BuscarVisibilidadPorNombre(visi.visibiDescripcion);

            if (estado_nombre == -1)
            {
                new VisibilidadExistente().ShowDialog(this);
            }
            else
            {
                estado_codigo = RepositorioVisibilidad.Instance.BuscarVisibilidadPorCodigo(visi.visibilidadCodigo);
                if (estado_codigo == -1)
                {
                    new VisibilidadExisteCodigo().ShowDialog(this);
                }
                else
                {
                    RepositorioVisibilidad.Instance.InsertarVisibilidad(visi);

                    new VisiGeneradaCorrectamente().ShowDialog(this);
                }
            }

        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }
    }
}
