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
            Decimal elementos = 0, indice = 0;
            

            List<Pregunta> preguntas = RepositorioPreguntas.Instance.BuscarPregunta(cod_usuario);

            elementos = preguntas.Count;
            if (elementos == 0)
            {
                new SinPreguntas().ShowDialog(this);
               
            }else{
                while (indice != elementos)
                {
                    comboBoxPreg.Items.Add(preguntas.First().descripcion);
                    preguntas.RemoveAt(1);
                    indice = indice + 1;
                }
            }
            
            InitializeComponent();
            
        }

        private void Pregaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxPreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            String preg = comboBoxPreg.SelectedText;

            Pregunta pregunta = RepositorioPreguntas.Instance.BuscarPreguntaPorDescripcion(preg);

            richTextBox1.Text = pregunta.respuesta;
        }

        private void preguntas_Load(object sender, EventArgs e)
        {

        }
    }
}
