using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FrbaCommerce
{
    public partial class LogIn : Form
    {
        String id, pass;
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Cliente form_cliente = new Cliente();

            form_cliente.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void empresa_Click(object sender, EventArgs e)
        {
            empresa form_emp = new empresa();

            form_emp.Show();
        }

        private void ID_Usuario_TextChanged(object sender, EventArgs e)
        {
         id = this.ID_Usuario.Text;   
        }

        private void Pass_usuario_TextChanged(object sender, EventArgs e)
        {
            pass = this.Pass_usuario.Text;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_onClick(object sender, EventArgs e)
        {
            if ( id == "diego" && pass == "123")
            {
                new Form1().Show();
            }
            else
            {
            }
                    
        }
    }
}
