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
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class ModificarEmp : Form
    {
        public int empresa_id;

        public ModificarEmp(int idempresa)
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
            
            if (nombre.Text != "")
            {
                empresa.razon_social = nombre.Text;
            }
            if (telefono.Text != "")
            {
                empresa.telefono = int.Parse(telefono.Text);
            }
            if (mail.Text != "")
            {
                empresa.mail = mail.Text;
            }
            empresa.fecha_creacion = dateTimePicker1.Value;
            if (cuit.Text != "")
            {
                empresa.cuit = int.Parse(cuit.Text);
            }
            if (contacto.Text != "")
            {
                empresa.contacto = contacto.Text;
            }
            if (ciudad.Text != "")
            {
                empresa.ciud = ciudad.Text;
            }
            if (localidad.Text != "")
            {
                empresa.loc = localidad.Text;
            }
            if (calle.Text != "")
            {
                empresa.call = calle.Text;
            }
            if (departamento.Text != "")
            {
                empresa.puert = departamento.Text;
            }
            if (piso.Text != "")
            {
                empresa.pis = int.Parse(piso.Text);
            }
            if (cod_pos.Text != "")
            {
                empresa.codpos = int.Parse(cod_pos.Text);
            }
            if (altura.Text != "")
            {
                empresa.altu = int.Parse(altura.Text);
            }
            empresa.codigo = empresa_id;

            RepositorioEmpresa.Instance.ModificarEmpresa(empresa);

            new ModificacionCorrecta().ShowDialog(this);

            this.Close();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeLetras(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }

        private void cod_pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
        }
    }
}
