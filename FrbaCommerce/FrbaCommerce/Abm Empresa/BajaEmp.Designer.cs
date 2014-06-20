namespace FrbaCommerce.Abm_Empresa
{
    partial class BajaEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.Ldeshabilitar = new System.Windows.Forms.Label();
            this.deshabilitar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(146, 53);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(51, 53);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 6;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // Ldeshabilitar
            // 
            this.Ldeshabilitar.AutoSize = true;
            this.Ldeshabilitar.Location = new System.Drawing.Point(77, 18);
            this.Ldeshabilitar.Name = "Ldeshabilitar";
            this.Ldeshabilitar.Size = new System.Drawing.Size(62, 13);
            this.Ldeshabilitar.TabIndex = 5;
            this.Ldeshabilitar.Text = "Deshabilitar";
            // 
            // deshabilitar
            // 
            this.deshabilitar.AutoSize = true;
            this.deshabilitar.Location = new System.Drawing.Point(171, 18);
            this.deshabilitar.Name = "deshabilitar";
            this.deshabilitar.Size = new System.Drawing.Size(15, 14);
            this.deshabilitar.TabIndex = 4;
            this.deshabilitar.UseVisualStyleBackColor = true;
            // 
            // BajaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.Ldeshabilitar);
            this.Controls.Add(this.deshabilitar);
            this.Name = "BajaEmp";
            this.Text = "Baja Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Label Ldeshabilitar;
        private System.Windows.Forms.CheckBox deshabilitar;
    }
}