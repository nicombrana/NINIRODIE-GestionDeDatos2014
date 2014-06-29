using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class BuscarPublicacion : Form
    {
        Decimal usuarioCodigo;

        public BuscarPublicacion()
        {
            InitializeComponent();
        }

        public BuscarPublicacion(Decimal codigoUser)
            : this()
        {
            usuarioCodigo = codigoUser;
            popular();
        }

        private void popular()
        {
            this.publicacionesComboBox.DataSource = new List<Publicacion>();
            this.publicacionesComboBox.Refresh();
            this.publicacionesComboBox.DataSource = RepositorioPublicacion.Instance.BuscarPublicacionesDeVendedor(usuarioCodigo);
            this.publicacionesComboBox.Refresh();
            this.publicacionesComboBox.DisplayMember = "descripcion";
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            new GenerarPublicacionParaBusqueda().ShowDialog(this);
        }
    }
}
