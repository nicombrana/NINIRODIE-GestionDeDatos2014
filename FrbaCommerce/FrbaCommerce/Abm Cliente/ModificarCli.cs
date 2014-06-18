using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModificarCli : Form
    {
        Decimal clienteId;

        public ModificarCli(Decimal id)
        {
            clienteId = id;
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //Se debe chekear que campos son los que se pueden modificar

            //1)se debe buscar (SELECT)al cliente propietario de clienteId
            //2)se deben tomar todos los datos del cliente y generar uno
            //3)se deben tomar todos los datos ingresados por el administrador
            //4)se deben remplazar en el cliente generado los campos que ingreso 
            //el administrados por los nuevos ingresados
            //5)se debe hacer un update pasandole el cliente resultante del paso 
            //anterior y que haga un update de todos sus campos
        }
    }
}
