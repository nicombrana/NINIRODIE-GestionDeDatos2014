﻿namespace FrbaCommerce.Abm_Rubro
{
    partial class ABMRubro
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
            this.botonModificacion = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.botonAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonModificacion
            // 
            this.botonModificacion.Location = new System.Drawing.Point(59, 119);
            this.botonModificacion.Name = "botonModificacion";
            this.botonModificacion.Size = new System.Drawing.Size(75, 23);
            this.botonModificacion.TabIndex = 5;
            this.botonModificacion.Text = "Modificacion";
            this.botonModificacion.UseVisualStyleBackColor = true;
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(59, 74);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(75, 23);
            this.botonBaja.TabIndex = 4;
            this.botonBaja.Text = "Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(59, 26);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(75, 23);
            this.botonAlta.TabIndex = 3;
            this.botonAlta.Text = "Alta";
            this.botonAlta.UseVisualStyleBackColor = true;
            // 
            // ABMRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 178);
            this.Controls.Add(this.botonModificacion);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonAlta);
            this.Name = "ABMRubro";
            this.Text = "ABM Rubro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonModificacion;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Button botonAlta;
    }
}