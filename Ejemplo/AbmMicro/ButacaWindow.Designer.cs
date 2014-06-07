namespace FrbaBus.View.Abm_Micro
{
    partial class ButacaWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboUbicacion = new System.Windows.Forms.ComboBox();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonOtra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Piso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboUbicacion);
            this.groupBox1.Controls.Add(this.textPiso);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Butaca";
            // 
            // comboUbicacion
            // 
            this.comboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUbicacion.FormattingEnabled = true;
            this.comboUbicacion.Location = new System.Drawing.Point(95, 43);
            this.comboUbicacion.Name = "comboUbicacion";
            this.comboUbicacion.Size = new System.Drawing.Size(140, 21);
            this.comboUbicacion.TabIndex = 5;
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(95, 73);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(140, 20);
            this.textPiso.TabIndex = 4;
            this.textPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPiso_KeyPress);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(95, 14);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(140, 20);
            this.textNumero.TabIndex = 3;
            this.textNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumero_KeyPress);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(170, 121);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(101, 23);
            this.botonAceptar.TabIndex = 4;
            this.botonAceptar.Text = "Aceptar y Salir";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonOtra
            // 
            this.botonOtra.Location = new System.Drawing.Point(63, 120);
            this.botonOtra.Name = "botonOtra";
            this.botonOtra.Size = new System.Drawing.Size(101, 23);
            this.botonOtra.TabIndex = 5;
            this.botonOtra.Text = "Cargar Otra";
            this.botonOtra.UseVisualStyleBackColor = true;
            this.botonOtra.Click += new System.EventHandler(this.botonOtra_Click);
            // 
            // ButacaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.botonOtra);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ButacaWindow";
            this.Text = "ButacaWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboUbicacion;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonOtra;
    }
}