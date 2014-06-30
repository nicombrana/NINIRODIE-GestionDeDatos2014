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

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class BuscarVisibilidadMod : Form
    {
        public BuscarVisibilidadMod()
        {
            InitializeComponent();
            this.Popular();
        }

        private void Popular()
        {
            this.nombreVisibilidadComoBox.DataSource = new List<Visibilidad>();
            this.nombreVisibilidadComoBox.Refresh();
            this.nombreVisibilidadComoBox.DataSource = RepositorioVisibilidad.Instance.Buscar();
            this.nombreVisibilidadComoBox.Refresh();
            this.nombreVisibilidadComoBox.DisplayMember = "visibiDescripcion";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Visibilidad)this.nombreVisibilidadComoBox.SelectedItem).visibilidadCodigo != -1)
            {
                new ModificarVisi(((Visibilidad)this.nombreVisibilidadComoBox.SelectedItem).visibilidadCodigo).ShowDialog(this);

            }
            else
            {
                new Noexistevisibilidad().ShowDialog(this);
            }
            
            this.Close();

        }
    }
}
