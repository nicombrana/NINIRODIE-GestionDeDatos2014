namespace FrbaCommerce.Abm_Cliente
{
    partial class BajaCli
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
            this.deshabilitar = new System.Windows.Forms.CheckBox();
            this.Ldeshabilitar = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deshabilitar
            // 
            this.deshabilitar.AutoSize = true;
            this.deshabilitar.Location = new System.Drawing.Point(151, 12);
            this.deshabilitar.Name = "deshabilitar";
            this.deshabilitar.Size = new System.Drawing.Size(15, 14);
            this.deshabilitar.TabIndex = 0;
            this.deshabilitar.UseVisualStyleBackColor = true;
            // 
            // Ldeshabilitar
            // 
            this.Ldeshabilitar.AutoSize = true;
            this.Ldeshabilitar.Location = new System.Drawing.Point(57, 12);
            this.Ldeshabilitar.Name = "Ldeshabilitar";
            this.Ldeshabilitar.Size = new System.Drawing.Size(62, 13);
            this.Ldeshabilitar.TabIndex = 1;
            this.Ldeshabilitar.Text = "Deshabilitar";
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(31, 47);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 2;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(126, 47);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BajaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 85);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.Ldeshabilitar);
            this.Controls.Add(this.deshabilitar);
            this.Name = "BajaCli";
            this.Text = "Baja Cliente";
            this.Load += new System.EventHandler(this.BajaCli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox deshabilitar;
        private System.Windows.Forms.Label Ldeshabilitar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
    }
}