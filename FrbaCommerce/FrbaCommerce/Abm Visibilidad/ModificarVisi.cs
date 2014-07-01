using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ModificarVisi : Form
    {
        Decimal codViejo;

        Decimal visibilidadCodigo;
        String visibiDescripcion;
        Decimal precio;
        Decimal porcentajeVenta;
        Decimal cantDias;

        public ModificarVisi(Decimal codigo)
        {
            codViejo = codigo;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal estado_nombre, estado_codigo, cerrar = 0;
            if (desc.Text != "")
            {
                estado_nombre = RepositorioVisibilidad.Instance.BuscarVisibilidadPorNombre(desc.Text);

                if (estado_nombre == -1)
                {
                    cerrar = 1;
                new VisibilidadExistente().ShowDialog(this);
                }

                visibiDescripcion = desc.Text;
            }
            if (codigo.Text != "")
            {
                estado_codigo = RepositorioVisibilidad.Instance.BuscarVisibilidadPorCodigo(Decimal.Parse(codigo.Text));

                if (estado_codigo == -1)
                {
                    cerrar = 1;
                    new VisibilidadExisteCodigo().ShowDialog(this);
                }

                visibilidadCodigo = Decimal.Parse(codigo.Text);
            }
            else
            {
                visibilidadCodigo = codViejo;
            }

            if (valor.Text != "")
            {
                precio = Decimal.Parse(valor.Text);
            }
            if (porcentaje.Text != "")
            {
                porcentajeVenta = Decimal.Parse(porcentaje.Text);
            }
            if (dias.Text != "")
            {
                cantDias = Decimal.Parse(dias.Text);
            }

            if (cerrar == 0)
            {
                Visibilidad visi = new Visibilidad(visibilidadCodigo, visibiDescripcion,
                        precio, porcentajeVenta, cantDias, true);

                RepositorioVisibilidad.Instance.ModificarVisi(visi, codViejo);

                new ModificacionCorrecta().ShowDialog(this);
                this.Close();
            }
            else
            {
                this.Close();
            }
                
            }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
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

        private void desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void ModificarVisi_Load(object sender, EventArgs e)
        {
            Visibilidad visibi = RepositorioVisibilidad.Instance.TraerVisi(codViejo);

            dias.Text = visibi.cantDias.ToString();
            desc.Text = visibi.visibiDescripcion;
            porcentaje.Text = visibi.porcentajeVenta.ToString();
            valor.Text = visibi.precio.ToString();
            codigo.Text = visibi.visibilidadCodigo.ToString();

        }
        }
    }

