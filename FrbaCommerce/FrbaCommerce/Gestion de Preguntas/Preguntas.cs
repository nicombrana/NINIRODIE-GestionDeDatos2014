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
        List<Pregunta> preguntasAVisualizar;

        public preguntas(Decimal id)
        {
            InitializeComponent();
            cod_usuario = id;
            preguntasAVisualizar = RepositorioPreguntas.Instance.BuscarPregunta(cod_usuario);
            
            if (preguntasAVisualizar.Count == 0)
            {
                new SinPreguntas().ShowDialog(this);
            }
            else
            {
                Popular();

            }
            
            
            
            
        }

        private void Popular()
        {
            this.PreguntasGrid.DataSource = preguntasAVisualizar;
            this.PreguntasGrid.Refresh();
            this.PreguntasGrid.Columns["pregunta_id"].Visible = false;
            this.PreguntasGrid.Columns["publicacion_id"].Visible = false;
            this.PreguntasGrid.Columns["cliente"].Visible = false;
            this.PreguntasGrid.Columns["descripcion"].Visible = true;
            this.PreguntasGrid.Columns["descripcion"].ReadOnly = true;
            this.PreguntasGrid.Columns["respuesta"].Visible = true;
            this.PreguntasGrid.Columns["respuesta"].ReadOnly = true;
            this.PreguntasGrid.Columns["fecha_respuesta"].Visible = true;
            this.PreguntasGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
