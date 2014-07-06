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
        Decimal codigoUser;

        public Comprar(Publicacion publicacion, Decimal codigoUsuario)
        {
            InitializeComponent();
            publicacionAComprar = publicacion;
            codigoUser = codigoUsuario;
        }
    }
}
