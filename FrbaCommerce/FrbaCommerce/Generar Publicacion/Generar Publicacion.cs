using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Genepub : Form
    {
        bool modificacion;
        String cantStock;
 
        public Genepub()
        {
            InitializeComponent();
            
        }

        public Genepub(bool modificando)
        {
            this.modificacion = modificando;
            InitializeComponent();
            this.precio.Visible = false;
           
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Genepub_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxStock_TextChanged(object sender, EventArgs e)
        {
            cantStock = this.txtBoxStock.Text;
        }



    }
}
