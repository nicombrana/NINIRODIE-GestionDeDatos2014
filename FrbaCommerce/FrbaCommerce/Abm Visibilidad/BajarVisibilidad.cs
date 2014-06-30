using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.Alertas;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class BajarVisibilidad : Form
    {
        bool est;
        Decimal cod;

        public BajarVisibilidad(bool estado, Decimal codigo)
        {
            est = estado;
            cod = codigo;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BajarVisibilidad_Load(object sender, EventArgs e)
        {
            if (est)
            {
                Habilitar.Enabled = true;
                Deshabilitar.Enabled = false;
            }
            if (est)
            {
                Habilitar.Enabled = false;
                Deshabilitar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool deshabili = false;

            if (Deshabilitar.Checked)
            {
                deshabili = false;
            }
            if (Habilitar.Checked)
            {
                deshabili = true;
            }

            RepositorioVisibilidad.Instance.BajarVisi(deshabili, cod);

            new BajaCorrecta().ShowDialog(this);
        }
    }
}
