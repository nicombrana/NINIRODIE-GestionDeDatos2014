namespace FrbaCommerce.Alertas
{
    partial class NoExisteUsuario
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
            this.NEU = new System.Windows.Forms.Label();
            this.NEUAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NEU
            // 
            this.NEU.AutoSize = true;
            this.NEU.Location = new System.Drawing.Point(55, 9);
            this.NEU.Name = "NEU";
            this.NEU.Size = new System.Drawing.Size(116, 13);
            this.NEU.TabIndex = 0;
            this.NEU.Text = "NO EXISTE USUARIO";
            // 
            // NEUAceptar
            // 
            this.NEUAceptar.Location = new System.Drawing.Point(74, 41);
            this.NEUAceptar.Name = "NEUAceptar";
            this.NEUAceptar.Size = new System.Drawing.Size(75, 23);
            this.NEUAceptar.TabIndex = 1;
            this.NEUAceptar.Text = "Aceptar";
            this.NEUAceptar.UseVisualStyleBackColor = true;
            this.NEUAceptar.Click += new System.EventHandler(this.NEUAceptar_Click);
            // 
            // NoExisteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 76);
            this.Controls.Add(this.NEUAceptar);
            this.Controls.Add(this.NEU);
            this.Name = "NoExisteUsuario";
            this.Text = "Alerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NEU;
        private System.Windows.Forms.Button NEUAceptar;
    }
}