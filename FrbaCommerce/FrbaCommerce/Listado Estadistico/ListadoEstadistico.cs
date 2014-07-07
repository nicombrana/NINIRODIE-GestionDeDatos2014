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
using FrbaCommerce.ClasesNINIRODIE.Dominio.EstadisticasDominio;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public TipoReporte tipoReporte;

        public ListadoEstadistico()
        {
            InitializeComponent();
            Popular();
        }

        private void Popular()
        {
            this.anioComboBox.DataSource = new List<int> { 2014, 2013, 2012, 2011, 2010 };
            this.anioComboBox.Refresh();
            this.semestreComboBox.DataSource = new List<int> { 1, 2 };
            this.semestreComboBox.Refresh();
            this.tipoListadoComboBox.DataSource = Enum.GetValues(typeof(TipoReporte));
            this.tipoListadoComboBox.Refresh();
        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            int anio = int.Parse(this.anioComboBox.Text);
            int semestre = int.Parse(this.semestreComboBox.Text);
            TipoReporte tipoListado = (TipoReporte)this.tipoListadoComboBox.SelectedItem;

            var resultados = RepositorioListado.Instance.BuscarEstadísticas(anio, semestre, tipoListado);

            this.listadoDataGrid.DataSource = resultados.DataSource;
            this.listadoDataGrid.Refresh();
        }
    }
}
