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

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Busqueda_Baja_Emp : Form
    {
        string razonsoc;

        public Busqueda_Baja_Emp()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BM_TextChanged(object sender, EventArgs e)
        {
            razonsoc = BM.Text;
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Buscador buscar = new Buscador();
           
            if (buscar.BuscarBajaEmp(razonsoc))
            {
                new BajaEmp().ShowDialog();
            }
            else { new NoExisteUsuario().ShowDialog(); }
        }
    }
}
