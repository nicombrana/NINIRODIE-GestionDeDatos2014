using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class EditarPublicacionPausada : Form
    {
        public Publicacion publiAEditar;

        public EditarPublicacionPausada(Publicacion publicacionAEditar)
        {
            InitializeComponent();
            publiAEditar = publicacionAEditar;
        }
    }
}
