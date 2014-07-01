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
        public Decimal empresa_id;
        String telefo, cu;

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
            int cerrar = 0;

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
                empresa.cuit = cuit.Text;
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

            if (cerrar == 0 && telefono.Text != telefo)
            {
                cerrar = this.buscarTel(telefono.Text);
            }
            if (cerrar == 0 && cuit.Text != cu)
            {
                cerrar = this.buscarCuit(cuit.Text);
            }

            if (cerrar == 0)
            {
                RepositorioEmpresa.Instance.ModificarEmpresa(empresa);

                new ModificacionCorrecta().ShowDialog(this);

                this.Close();
            }
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

        private void ModificarEmp_Load(object sender, EventArgs e)
        {
            Empresa empre = RepositorioEmpresa.Instance.BuscarEmpresaPorClave(empresa_id);
            cod_pos.Text = empre.codpos.ToString();
            piso.Text = empre.pis.ToString();
            altura.Text = empre.altu.ToString();
            telefono.Text = empre.telefono.ToString();
            telefo = empre.telefono.ToString();
            calle.Text = empre.call;
            nombre.Text = empre.razon_social;
            contacto.Text = empre.contacto;
            ciudad.Text = empre.ciud;
            localidad.Text = empre.loc;
            mail.Text = empre.mail;
            cuit.Text = empre.cuit;
            cu = empre.cuit;
            departamento.Text = empre.puert;
        }

        private int buscarCuit(String cuit)
        {

            int valor = RepositorioEmpresa.Instance.buscarEmpresaPorCuit(cuit);

            if (valor == 1)
            {
                MessageBox.Show("Cuit Ya Existente", "Atención", MessageBoxButtons.OK);
            }
            return valor;
        }

        private int buscarTel(String telefono)
        {
            int tel = int.Parse(telefono);

            int valor = RepositorioEmpresa.Instance.buscarEmpresaPorTelefono(tel);

            if (valor == 1)
            {
                MessageBox.Show("Telefono Ya Existente", "Atención", MessageBoxButtons.OK);
            }
            return valor;
        }
    }
}
