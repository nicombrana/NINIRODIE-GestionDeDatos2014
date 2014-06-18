using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Alertas
{
    public partial class UsuarioYPass : Form
    {
        public UsuarioYPass(Decimal userpass)
        {
            label3.Text = userpass.ToString();
            label4.Text = userpass.ToString();

            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
