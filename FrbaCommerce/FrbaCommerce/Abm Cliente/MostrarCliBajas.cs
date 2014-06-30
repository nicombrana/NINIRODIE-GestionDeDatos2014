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

namespace FrbaCommerce.Abm_Cliente
{
    public partial class MostrarCliBajas : Form
    {
        public String nombre;
        public String ape;
        public String tipo_docu = "nada";
        public int nro_doc = 0;
        public String meil;
        

        public MostrarCliBajas(String apellido, String nomb, int doc, String mail, String tipo)
        {
            InitializeComponent();

            nombre = nomb;
            ape = apellido;
            tipo_docu = tipo;
            nro_doc = doc;
            meil = mail;

            var clientes = RepositorioCliente.Instance.TomarClientes(ape, nombre, nro_doc,
                                                            meil, tipo_docu);
            
            
            this.ClientesGrid.Refresh();
            this.ClientesGrid.DataSource = clientes;
            this.ClientesGrid.Refresh();
            this.ClientesGrid.Columns["codigo"].Visible = false;
            this.ClientesGrid.Columns["tipo_doc"].Visible = true;
            this.ClientesGrid.Columns["nro_doc"].Visible = true;
            this.ClientesGrid.Columns["nombre"].Visible = true;
            this.ClientesGrid.Columns["apellido"].Visible = true;
            this.ClientesGrid.Columns["telefono"].Visible = false;
            this.ClientesGrid.Columns["mail"].Visible = false;
            this.ClientesGrid.Columns["fecha_nac"].Visible = false;
            this.ClientesGrid.Columns["sexo"].Visible = false;

            this.ClientesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ClientesGrid.Columns["tipo_doc"].ReadOnly = true;
            this.ClientesGrid.Columns["nro_doc"].ReadOnly = true;
            this.ClientesGrid.Columns["nombre"].ReadOnly = true;
            this.ClientesGrid.Columns["apellido"].ReadOnly = true;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = ((Cliente)this.ClientesGrid.Rows[0].DataBoundItem);

            new BajaCli(cliente.codigo).ShowDialog(this);
        }
    }
}
