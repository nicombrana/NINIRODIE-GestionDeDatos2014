using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.Alertas;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class BuscarVisibilidad : Form
    {
        String nomb;

        public BuscarVisibilidad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomb = nombre.Text;

            Visibilidad visi = RepositorioVisibilidad.Instance.BuscarVisibilidad(nomb);

            if (visi.visibilidadCodigo != -1)
            {
                new BajarVisibilidad(visi.habilitado).ShowDialog(this);
                
                this.Close();
            }
            new Noexistevisibilidad().ShowDialog(this);
            this.Close();

        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }
    }
}
