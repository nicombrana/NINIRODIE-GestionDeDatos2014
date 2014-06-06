namespace FrbaCommerce.Abm_Cliente
{
    partial class Busqueda_Baja
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
            this.TDoc = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nrodoc = new System.Windows.Forms.Label();
            this.NDoc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(160, 162);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(54, 162);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 6;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(121, 17);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(100, 20);
            this.BM.TabIndex = 4;
            this.BM.TextChanged += new System.EventHandler(this.BM_TextChanged);
            this.BM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BM_KeyPress);
            // 
            // TDoc
            // 
            this.TDoc.AutoSize = true;
            this.TDoc.Location = new System.Drawing.Point(51, 72);
            this.TDoc.Name = "TDoc";
            this.TDoc.Size = new System.Drawing.Size(51, 13);
            this.TDoc.TabIndex = 13;
            this.TDoc.Text = "Tipo Doc";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(51, 46);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 11;
            this.Apellido.Text = "Apellido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(51, 124);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(32, 13);
            this.Mail.TabIndex = 17;
            this.Mail.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(121, 121);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 16;
            // 
            // Nrodoc
            // 
            this.Nrodoc.AutoSize = true;
            this.Nrodoc.Location = new System.Drawing.Point(51, 98);
            this.Nrodoc.Name = "Nrodoc";
            this.Nrodoc.Size = new System.Drawing.Size(47, 13);
            this.Nrodoc.TabIndex = 15;
            this.Nrodoc.Text = "Nro Doc";
            // 
            // NDoc
            // 
            this.NDoc.Location = new System.Drawing.Point(121, 95);
            this.NDoc.Name = "NDoc";
            this.NDoc.Size = new System.Drawing.Size(100, 20);
            this.NDoc.TabIndex = 14;
            this.NDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NDoc_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "Libreta Civica",
            "Libreta Enrolamiento",
            "Cedula"});
            this.comboBox1.Location = new System.Drawing.Point(121, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // Busqueda_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nrodoc);
            this.Controls.Add(this.NDoc);
            this.Controls.Add(this.TDoc);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BM);
            this.Name = "Busqueda_Baja";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BM;
        private System.Windows.Forms.Label TDoc;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label Nrodoc;
        private System.Windows.Forms.TextBox NDoc;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}