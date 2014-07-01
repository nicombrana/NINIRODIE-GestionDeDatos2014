using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class MostrarEmpMod : Form
    {
        String razon, mail, cuit;

        public MostrarEmpMod(String social, String email, String nrocuit)
        {
            InitializeComponent();

            razon = social;
            mail = email;
            cuit = nrocuit;

            var empresas = RepositorioEmpresa.Instance.TomarEmpresa(razon, mail, cuit);

            this.EmpresasGrid.Refresh();
            this.EmpresasGrid.DataSource = empresas;
            this.EmpresasGrid.Refresh();
            this.EmpresasGrid.Columns["EMP_CODIGO"].Visible = false;
            this.EmpresasGrid.Columns["EMP_RAZON_SOCIAL"].Visible = true;
            this.EmpresasGrid.Columns["EMP_MAIL"].Visible = false;
            this.EmpresasGrid.Columns["EMP_TELEFONO"].Visible = false;
            this.EmpresasGrid.Columns["EMP_CUIT"].Visible = true;
            this.EmpresasGrid.Columns["EMP_CONTACTO"].Visible = false;
            this.EmpresasGrid.Columns["EMP_FECHA_CREACION"].Visible = false;

            this.EmpresasGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.EmpresasGrid.Columns["EMP_RAZON_SOCIAL"].ReadOnly = true;
            this.EmpresasGrid.Columns["EMP_CUIT"].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empresa = ((Empresa)this.EmpresasGrid.Rows[0].DataBoundItem);
            new ModificarEmp(empresa.codigo);
        }
    }
}
