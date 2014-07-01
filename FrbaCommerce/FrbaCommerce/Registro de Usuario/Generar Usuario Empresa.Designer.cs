namespace FrbaCommerce
{
    partial class GenerarEmpresa
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
            this.mail = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.cuit = new System.Windows.Forms.TextBox();
            this.contacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cod_pos = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.piso = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.calle = new System.Windows.Forms.TextBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(163, 64);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(146, 20);
            this.mail.TabIndex = 30;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(163, 38);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(146, 20);
            this.telefono.TabIndex = 29;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(163, 12);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(146, 20);
            this.nombre.TabIndex = 27;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(234, 317);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 22;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(39, 317);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 21;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(163, 116);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(146, 20);
            this.cuit.TabIndex = 41;
            // 
            // contacto
            // 
            this.contacto.Location = new System.Drawing.Point(163, 142);
            this.contacto.Name = "contacto";
            this.contacto.Size = new System.Drawing.Size(146, 20);
            this.contacto.TabIndex = 42;
            this.contacto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contacto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Razon Social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "CUIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fecha de Creacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Contacto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 65;
            this.label18.Text = "Codigo Postal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Piso";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Puerta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Altura";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Calle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Localidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Ciudad";
            // 
            // cod_pos
            // 
            this.cod_pos.Location = new System.Drawing.Point(163, 272);
            this.cod_pos.Name = "cod_pos";
            this.cod_pos.Size = new System.Drawing.Size(146, 20);
            this.cod_pos.TabIndex = 58;
            this.cod_pos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_pos_KeyPress);
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(237, 246);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(72, 20);
            this.departamento.TabIndex = 57;
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(111, 246);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(73, 20);
            this.piso.TabIndex = 56;
            this.piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piso_KeyPress);
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(237, 220);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(72, 20);
            this.altura.TabIndex = 55;
            this.altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.altura_KeyPress);
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(111, 220);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(73, 20);
            this.calle.TabIndex = 54;
            this.calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calle_KeyPress);
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(163, 194);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(146, 20);
            this.localidad.TabIndex = 53;
            this.localidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.localidad_KeyPress);
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(163, 168);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(146, 20);
            this.ciudad.TabIndex = 52;
            this.ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciudad_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 354);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cod_pos);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contacto);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Name = "empresa";
            this.Text = "Generar Usuario Empresa";
            this.Load += new System.EventHandler(this.empresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.TextBox contacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cod_pos;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}