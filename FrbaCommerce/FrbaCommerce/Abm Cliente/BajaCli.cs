using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class BajaCli : Form
    {
        Decimal clienteId;

        public BajaCli(Decimal id)
        {
            clienteId = id;
            InitializeComponent();
        }


        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BajaCli_Load(object sender, EventArgs e)
        {

        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            bool deshabili = deshabilitar.Checked;

            RepositorioUsuario.Instance.BajarUsuario(clienteId, deshabili);

            this.Close();
        }
    }
}
