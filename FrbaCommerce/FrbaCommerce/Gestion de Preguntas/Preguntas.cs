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

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class preguntas : Form
    {
        Decimal cod_usuario;

        public preguntas(Decimal id)
        {
            cod_usuario = id;
            Decimal elementos = 0;
            

            List<Pregunta> preguntas = RepositorioPreguntas.Instance.BuscarPregunta(cod_usuario);
            elementos = preguntas.Count;
            if (elementos == 0)
            {
                new SinPreguntas().ShowDialog(this);
            }
            else
            {
                this.PreguntasGrid.DataSource = preguntas;
                this.PreguntasGrid.Refresh();
                this.PreguntasGrid.Columns["pregunta_id"].Visible = false;
                this.PreguntasGrid.Columns["publicacion_id"].Visible = false;
                this.PreguntasGrid.Columns["cliente"].Visible = false;
                this.PreguntasGrid.Columns["pregunta"].Visible = true;
                this.PreguntasGrid.Columns["pregunta"].ReadOnly = true;
                this.PreguntasGrid.Columns["respuesta"].Visible = true;
                this.PreguntasGrid.Columns["respuesta"].ReadOnly = true;
                this.PreguntasGrid.Columns["fecha"].Visible = false;
                this.PreguntasGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            
            
            InitializeComponent();
            
        }

        private void Pregaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void preguntas_Load(object sender, EventArgs e)
        {

        }
    }
}
