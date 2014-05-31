namespace FrbaCommerce
{
    partial class LogIn
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
            this.ID_Usuario = new System.Windows.Forms.TextBox();
            this.Pass_usuario = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gencli = new System.Windows.Forms.Button();
            this.genemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.Location = new System.Drawing.Point(112, 32);
            this.ID_Usuario.Name = "ID_Usuario";
            this.ID_Usuario.Size = new System.Drawing.Size(98, 20);
            this.ID_Usuario.TabIndex = 0;
            this.ID_Usuario.TextChanged += new System.EventHandler(this.ID_Usuario_TextChanged);
            // 
            // Pass_usuario
            // 
            this.Pass_usuario.Location = new System.Drawing.Point(112, 74);
            this.Pass_usuario.Name = "Pass_usuario";
            this.Pass_usuario.Size = new System.Drawing.Size(98, 20);
            this.Pass_usuario.TabIndex = 1;
            this.Pass_usuario.UseSystemPasswordChar = true;
            this.Pass_usuario.TextChanged += new System.EventHandler(this.Pass_usuario_TextChanged);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(48, 123);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_onClick);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(165, 123);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // gencli
            // 
            this.gencli.Location = new System.Drawing.Point(25, 171);
            this.gencli.Name = "gencli";
            this.gencli.Size = new System.Drawing.Size(98, 23);
            this.gencli.TabIndex = 8;
            this.gencli.Text = "Generar Cliente";
            this.gencli.UseVisualStyleBackColor = true;
            this.gencli.Click += new System.EventHandler(this.gencli_Click);
            // 
            // genemp
            // 
            this.genemp.Location = new System.Drawing.Point(165, 171);
            this.genemp.Name = "genemp";
            this.genemp.Size = new System.Drawing.Size(98, 23);
            this.genemp.TabIndex = 9;
            this.genemp.Text = "Generar Empresa";
            this.genemp.UseVisualStyleBackColor = true;
            this.genemp.Click += new System.EventHandler(this.genemp_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.genemp);
            this.Controls.Add(this.gencli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.Pass_usuario);
            this.Controls.Add(this.ID_Usuario);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Usuario;
        private System.Windows.Forms.TextBox Pass_usuario;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gencli;
        private System.Windows.Forms.Button genemp;
    }
}