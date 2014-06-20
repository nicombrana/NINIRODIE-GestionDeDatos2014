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
    public partial class PassYUsuario : Form
    {
        public PassYUsuario(String userpass)
        {
            label3.Text = userpass;
            label4.Text = userpass;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
