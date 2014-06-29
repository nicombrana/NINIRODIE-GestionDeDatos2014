using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class ModificarVisi : Form
    {
        Decimal cod;

        public ModificarVisi(Decimal codigo)
        {
            cod = codigo;

            InitializeComponent();
        }
    }
}
