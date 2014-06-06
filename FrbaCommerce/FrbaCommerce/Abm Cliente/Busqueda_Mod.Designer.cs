namespace FrbaCommerce.Abm_Cliente
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
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Mail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nrodoc = new System.Windows.Forms.Label();
            this.NDoc = new System.Windows.Forms.TextBox();
            this.TDoc = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(46, 167);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 2;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(152, 167);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "Libreta Civica",
            "Libreta Enrolamiento",
            "Cedula"});
            this.comboBox1.Location = new System.Drawing.Point(127, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(57, 119);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(32, 13);
            this.Mail.TabIndex = 27;
            this.Mail.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(127, 116);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 26;
            // 
            // Nrodoc
            // 
            this.Nrodoc.AutoSize = true;
            this.Nrodoc.Location = new System.Drawing.Point(57, 93);
            this.Nrodoc.Name = "Nrodoc";
            this.Nrodoc.Size = new System.Drawing.Size(47, 13);
            this.Nrodoc.TabIndex = 25;
            this.Nrodoc.Text = "Nro Doc";
            // 
            // NDoc
            // 
            this.NDoc.Location = new System.Drawing.Point(127, 90);
            this.NDoc.Name = "NDoc";
            this.NDoc.Size = new System.Drawing.Size(100, 20);
            this.NDoc.TabIndex = 24;
            this.NDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NDoc_KeyPress);
            // 
            // TDoc
            // 
            this.TDoc.AutoSize = true;
            this.TDoc.Location = new System.Drawing.Point(57, 67);
            this.TDoc.Name = "TDoc";
            this.TDoc.Size = new System.Drawing.Size(51, 13);
            this.TDoc.TabIndex = 23;
            this.TDoc.Text = "Tipo Doc";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(57, 41);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 22;
            this.Apellido.Text = "Apellido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(127, 12);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(100, 20);
            this.BM.TabIndex = 19;
            this.BM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.BM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BM_KeyPress);
            // 
            // Busqueda_Mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nrodoc);
            this.Controls.Add(this.NDoc);
            this.Controls.Add(this.TDoc);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Name = "Busqueda_Mod";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Mod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label Nrodoc;
        private System.Windows.Forms.TextBox NDoc;
        private System.Windows.Forms.Label TDoc;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BM;
    }
}