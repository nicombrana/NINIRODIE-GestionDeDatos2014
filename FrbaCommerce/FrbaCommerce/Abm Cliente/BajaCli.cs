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
            var user = RepositorioUsuario.Instance.BuscarCliente(clienteId);

            if (user.habilitado == false)
            {
                habilitar.Enabled = true;
                deshabilitar.Enabled = false;
            }
            else
            {
                habilitar.Enabled = false;
                deshabilitar.Enabled = true;
            }
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            int deshabili = 0;

            if (deshabilitar.Checked)
            {
               deshabili = 0;
            }
            if (habilitar.Checked)
            {
                deshabili = 1;
            }

            RepositorioUsuario.Instance.BajarCliente(clienteId, deshabili);

            new BajaCorrecta().ShowDialog(this);

            this.Close();
        }
    }
}
