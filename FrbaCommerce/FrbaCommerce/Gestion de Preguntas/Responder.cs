using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.DBUtils;
using FrbaCommerce.ClasesNINIRODIE.Dominio;
using FrbaCommerce.Alertas;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Responder : Form
    {
        Decimal conectado = 0;

        public Responder(Decimal codigo)
        {
            conectado = codigo;
            InitializeComponent();
        }

        private void rescancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resaceptar_Click(object sender, EventArgs e)
        {
            String pregunt = this.comboBoxPreg.SelectedValue.ToString();
            String resp = respuesta.Text;

            if (resp == "" || pregunt == "")
            {
                new TodosLosCampos().ShowDialog(this);
                this.Close();
            }
            RepositorioPreguntas.Instance.Responder(conectado, pregunt, resp);

            new RespuestaExitosa().ShowDialog(this);
            this.Close();
        }

        private void Responder_Load(object sender, EventArgs e)
        {
            var query = String.Format(@"select PREG_DESCRIPCION FROM NINIRODIE.PREGUNTA, NINIRODIE.PUBLICACION " +
                                     "where PUB_VENDEDOR = '{0}' AND PREG_PUBLICACION_ID = PUB_PUBLICACION_ID", conectado);

            DataRowCollection dataRow = SQLUtils.EjecutarConsultaSimple(query, "NINIRODIE.PREGUNTA");

            var preguntas = dataRow.ToList<String>(this.DataRowToString);

            if (preguntas.Count == 0)
            {
                new SinPreguntas().ShowDialog(this);
                this.Close();
            }
            else
            {
                this.comboBoxPreg.DataSource = new List<String>();
                this.comboBoxPreg.Refresh();
                this.comboBoxPreg.DataSource = preguntas;
                this.comboBoxPreg.Refresh();
                this.comboBoxPreg.DisplayMember = "Preguntas";
            }

        }

        public String DataRowToString(DataRow row)
        {
            var descripcion = row["PREG_DESCRIPCION"].ToString();

            return descripcion;
        }

    }
}
