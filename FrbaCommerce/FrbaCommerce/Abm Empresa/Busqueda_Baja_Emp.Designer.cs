namespace FrbaCommerce.Abm_Empresa
{
    partial class Busqueda_Baja_Emp
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
            this.label1 = new System.Windows.Forms.Label();
            this.BM = new System.Windows.Forms.TextBox();
            this.Cuit = new System.Windows.Forms.Label();
            this.TextCuit = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Textmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(159, 125);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 11;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(53, 125);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 10;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Razon Social";
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(120, 12);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(100, 20);
            this.BM.TabIndex = 8;
            this.BM.TextChanged += new System.EventHandler(this.BM_TextChanged);
            this.BM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BM_KeyPress);
            // 
            // Cuit
            // 
            this.Cuit.AutoSize = true;
            this.Cuit.Location = new System.Drawing.Point(50, 41);
            this.Cuit.Name = "Cuit";
            this.Cuit.Size = new System.Drawing.Size(32, 13);
            this.Cuit.TabIndex = 13;
            this.Cuit.Text = "CUIT";
            // 
            // TextCuit
            // 
            this.TextCuit.Location = new System.Drawing.Point(120, 38);
            this.TextCuit.Name = "TextCuit";
            this.TextCuit.Size = new System.Drawing.Size(100, 20);
            this.TextCuit.TabIndex = 12;
            this.TextCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCuit_KeyPress);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(50, 67);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email";
            // 
            // Textmail
            // 
            this.Textmail.Location = new System.Drawing.Point(120, 64);
            this.Textmail.Name = "Textmail";
            this.Textmail.Size = new System.Drawing.Size(100, 20);
            this.Textmail.TabIndex = 14;
            // 
            // Busqueda_Baja_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Textmail);
            this.Controls.Add(this.Cuit);
            this.Controls.Add(this.TextCuit);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BM);
            this.Name = "Busqueda_Baja_Emp";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Baja_Emp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BM;
        private System.Windows.Forms.Label Cuit;
        private System.Windows.Forms.TextBox TextCuit;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Textmail;
    }
}