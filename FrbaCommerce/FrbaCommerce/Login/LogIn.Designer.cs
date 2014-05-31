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
            this.cliente = new System.Windows.Forms.Button();
            this.empresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(48, 123);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
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
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(26, 170);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(97, 23);
            this.cliente.TabIndex = 4;
            this.cliente.Text = "Generar Cliente";
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.generar_Click);
            // 
            // empresa
            // 
            this.empresa.Location = new System.Drawing.Point(165, 170);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(97, 23);
            this.empresa.TabIndex = 5;
            this.empresa.Text = "Generar Empresa";
            this.empresa.UseVisualStyleBackColor = true;
            this.empresa.Click += new System.EventHandler(this.empresa_Click);
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empresa);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.Pass_usuario);
            this.Controls.Add(this.ID_Usuario);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Usuario;
        private System.Windows.Forms.TextBox Pass_usuario;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.Button empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}