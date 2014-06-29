using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class BajarVisibilidad : Form
    {
        Decimal est;

        public BajarVisibilidad(Decimal estado)
        {
            est = estado;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BajarVisibilidad_Load(object sender, EventArgs e)
        {
            if (est == 0)
            {
                Habilitar.Enabled = true;
                Deshabilitar.Enabled = false;
            }
            if (est == 1)
            {
                Habilitar.Enabled = false;
                Deshabilitar.Enabled = true;
            }
        }
    }
}
