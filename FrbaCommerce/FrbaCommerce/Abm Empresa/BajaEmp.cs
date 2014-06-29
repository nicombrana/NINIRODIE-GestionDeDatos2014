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

namespace FrbaCommerce.Abm_Empresa
{
    public partial class BajaEmp : Form
    {
 
        public Decimal id_empresa;

        public BajaEmp(Decimal empresaid)
        {
            id_empresa = empresaid;
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            bool deshabili = deshabilitar.Checked;

            RepositorioUsuario.Instance.BajarEmpresa(id_empresa, deshabili);

            new BajaCorrecta().ShowDialog(this);

            this.Close();
        }

        private void BajaEmp_Load(object sender, EventArgs e)
        {
            var user = RepositorioUsuario.Instance.BuscarEmpresa(id_empresa);

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
    }
}
