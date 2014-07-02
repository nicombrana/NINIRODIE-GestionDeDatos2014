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

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class EditarPublicacionPublicada : Form
    {
        Publicacion publiAEditar;
        List<Estado> estados = new List<Estado>();

        public EditarPublicacionPublicada(Publicacion publicacionAEditar)
        {
            InitializeComponent();
            publiAEditar = publicacionAEditar;
            estados.Add(new Pausada(3, "Pausada"));
            estados.Add(new Finalizada(4, "Finalizada"));
            this.popular();
        }

        private void popular()
        {
            this.estadosComboBox.DataSource = new List<Publicacion>();
            this.estadosComboBox.Refresh();
            this.estadosComboBox.DataSource = estados;
            this.estadosComboBox.Refresh();
            this.estadosComboBox.DisplayMember = "descripcion";
        }

        /*
        private List<Estado> ObtenerEstados()
        {
            var estadoBorrador = new Borrador(2, "Borrador");

            if (estados.Exists(estado => estado.id == publiAEditar.estado.id))
            {
                var estadoAQuitar = estados.Find(estado => estado.id == publiAEditar.estado.id);
                estados.Remove(estadoAQuitar);
            }
            if (estados.Exists(estado => estado.id == estadoBorrador.id))
                estados.Remove(new Borrador(2, "Borrador"));

            return estados;
        }
        */

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            publiAEditar.estado = (Estado)estadosComboBox.SelectedValue;
            
            RepositorioPublicacion.Instance.UpdateEstado(publiAEditar);

            MessageBox.Show("Se ha editado el estado de la publicación correctamente",
                "Informe", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
