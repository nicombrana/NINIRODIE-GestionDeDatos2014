using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Comprar : Form
    {
        Publicacion publicacionAComprar;

        public Comprar(Publicacion publicacion)
        {
            InitializeComponent();
            publicacionAComprar = publicacion;
        }
    }
}
