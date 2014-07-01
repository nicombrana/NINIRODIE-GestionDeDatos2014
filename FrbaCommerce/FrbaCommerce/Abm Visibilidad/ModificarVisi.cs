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
        String porcenViejo, precioViejo;
        String cod, nomb;

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
            if (desc.Text != nomb)
            {
                estado_nombre = RepositorioVisibilidad.Instance.BuscarVisibilidadPorNombre(desc.Text);

                if (estado_nombre == -1)
                {
                    cerrar = 1;
                new VisibilidadExistente().ShowDialog(this);
                }
            }
            visibiDescripcion = desc.Text;
            if (cerrar == 0 && codigo.Text != cod)
            {
                estado_codigo = RepositorioVisibilidad.Instance.BuscarVisibilidadPorCodigo(Decimal.Parse(codigo.Text));

                if (estado_codigo == -1)
                {
                    cerrar = 1;
                    new VisibilidadExisteCodigo().ShowDialog(this);
                }
            }
            else
            {
                visibilidadCodigo = codViejo;
            }
            visibilidadCodigo = Decimal.Parse(cod);
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
            //    Visibilidad visi = new Visibilidad(visibilidadCodigo, visibiDescripcion,
            //            precio, porcentajeVenta, cantDias, true);

                RepositorioVisibilidad.Instance.ModificarDesc(visibiDescripcion, codViejo);
                RepositorioVisibilidad.Instance.ModificarDias(cantDias, codViejo);
                if (porcentaje.Text != porcenViejo)
                {
                    RepositorioVisibilidad.Instance.ModificarPorcen(porcentajeVenta, codViejo);    
                }
                if (valor.Text != precioViejo)
                {
                    RepositorioVisibilidad.Instance.ModificarPrecio(precio, codViejo);
                }

                RepositorioVisibilidad.Instance.ModificarCodigo(visibilidadCodigo, codViejo);
               // RepositorioVisibilidad.Instance.ModificarVisi(visi, codViejo);

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
            nomb = visibi.visibiDescripcion;

            porcentaje.Text = visibi.porcentajeVenta.ToString();
            porcenViejo = visibi.porcentajeVenta.ToString();

            valor.Text = visibi.precio.ToString();
            precioViejo = visibi.precio.ToString();

            codigo.Text = visibi.visibilidadCodigo.ToString();
            cod = visibi.visibilidadCodigo.ToString();

        }
        }
    }

