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

namespace FrbaCommerce.Abm_Empresa
{
    public partial class ModificarEmp : Form
    {
        public Decimal empresa_id;

        public ModificarEmp(Decimal idempresa)
        {
            empresa_id = idempresa;
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Empresa empresa = RepositorioEmpresa.Instance.BuscarEmpresaPorClave(empresa_id);

            empresa.razon_social = nombre.Text;
            empresa.telefono = Decimal.Parse(telefono.Text);
            empresa.mail = mail.Text;
            empresa.fecha_creacion = dateTimePicker1.Value;
            empresa.cuit = Decimal.Parse(cuit.Text);
            empresa.contacto = contacto.Text;
            empresa.ciud = ciudad.Text;
            empresa.loc = localidad.Text;
            empresa.call = calle.Text;
            empresa.puert = Char.Parse(departamento.Text);
            empresa.pis = Decimal.Parse(piso.Text);
            empresa.codpos = Decimal.Parse(cod_pos.Text);
            empresa.altu = Decimal.Parse(altura.Text);
            empresa.codigo = empresa_id;

            RepositorioEmpresa.Instance.ModificarEmpresa(empresa);
        }
    }
}
