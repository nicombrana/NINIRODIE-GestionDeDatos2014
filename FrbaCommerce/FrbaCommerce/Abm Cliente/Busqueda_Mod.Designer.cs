﻿namespace FrbaCommerce.Abm_Cliente
{
    partial class Busqueda_Mod
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
            this.BM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(113, 36);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(100, 20);
            this.BM.TabIndex = 0;
            this.BM.TextChanged += new System.EventHandler(this.BM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(46, 100);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 2;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(152, 100);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // Busqueda_Mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BM);
            this.Name = "Busqueda_Mod";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Mod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
    }
}