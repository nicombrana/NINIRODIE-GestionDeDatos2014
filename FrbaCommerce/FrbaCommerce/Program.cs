using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaCommerce.Alertas;

namespace FrbaCommerce
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Commerce());

            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha producido un error.\n La aplicación se cerrará",
                    "Atención", MessageBoxButtons.OK);
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
