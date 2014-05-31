using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    class CambiarContrasenia : Form1
    {
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passActual;
        private System.Windows.Forms.TextBox PassNueva;
        private System.Windows.Forms.TextBox PassNueva2;
        private System.Windows.Forms.Button CPaceptar;
        private System.Windows.Forms.Button CPcancelar;
        private System.Windows.Forms.Label label1;

        public CambiarContrasenia() 
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passActual = new System.Windows.Forms.TextBox();
            this.PassNueva = new System.Windows.Forms.TextBox();
            this.PassNueva2 = new System.Windows.Forms.TextBox();
            this.CPaceptar = new System.Windows.Forms.Button();
            this.CPcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña";
            // 
            // passActual
            // 
            this.passActual.Location = new System.Drawing.Point(134, 18);
            this.passActual.Name = "passActual";
            this.passActual.Size = new System.Drawing.Size(128, 20);
            this.passActual.TabIndex = 3;
            this.passActual.UseSystemPasswordChar = true;
            // 
            // PassNueva
            // 
            this.PassNueva.Location = new System.Drawing.Point(134, 51);
            this.PassNueva.Name = "PassNueva";
            this.PassNueva.Size = new System.Drawing.Size(128, 20);
            this.PassNueva.TabIndex = 4;
            this.PassNueva.UseSystemPasswordChar = true;
            // 
            // PassNueva2
            // 
            this.PassNueva2.Location = new System.Drawing.Point(134, 87);
            this.PassNueva2.Name = "PassNueva2";
            this.PassNueva2.Size = new System.Drawing.Size(128, 20);
            this.PassNueva2.TabIndex = 5;
            this.PassNueva2.UseSystemPasswordChar = true;
            // 
            // CPaceptar
            // 
            this.CPaceptar.Location = new System.Drawing.Point(53, 134);
            this.CPaceptar.Name = "CPaceptar";
            this.CPaceptar.Size = new System.Drawing.Size(75, 23);
            this.CPaceptar.TabIndex = 6;
            this.CPaceptar.Text = "aceptar";
            this.CPaceptar.UseVisualStyleBackColor = true;
            // 
            // CPcancelar
            // 
            this.CPcancelar.Location = new System.Drawing.Point(165, 134);
            this.CPcancelar.Name = "CPcancelar";
            this.CPcancelar.Size = new System.Drawing.Size(75, 23);
            this.CPcancelar.TabIndex = 7;
            this.CPcancelar.Text = "cancelar";
            this.CPcancelar.UseVisualStyleBackColor = true;
            this.CPcancelar.Click += new System.EventHandler(this.CPcancelar_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.CPcancelar);
            this.Controls.Add(this.CPaceptar);
            this.Controls.Add(this.PassNueva2);
            this.Controls.Add(this.PassNueva);
            this.Controls.Add(this.passActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CambiarPassword";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.CambiarPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CambiarPassword_Load(object sender, EventArgs e)
        {

        }

        private void CPcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
