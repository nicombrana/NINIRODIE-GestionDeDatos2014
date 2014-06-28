namespace FrbaCommerce
{
    partial class GenerarCliente
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.documento = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.calle = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.piso = new System.Windows.Forms.TextBox();
            this.cod_pos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CBdni = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CBcedula = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(50, 433);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(179, 433);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(138, 92);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(135, 20);
            this.documento.TabIndex = 5;
            this.documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documento_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(138, 118);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(135, 20);
            this.nombre.TabIndex = 6;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(138, 144);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(135, 20);
            this.apellido.TabIndex = 7;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(138, 170);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(135, 20);
            this.telefono.TabIndex = 8;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(138, 197);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(135, 20);
            this.mail.TabIndex = 10;
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(138, 276);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(135, 20);
            this.ciudad.TabIndex = 12;
            this.ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciudad_KeyPress);
            // 
            // Sexo
            // 
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Sexo.Location = new System.Drawing.Point(138, 249);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(135, 21);
            this.Sexo.TabIndex = 13;
            this.Sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sexo_KeyPress);
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(138, 302);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(135, 20);
            this.localidad.TabIndex = 15;
            this.localidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.localidad_KeyPress);
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(86, 328);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(68, 20);
            this.calle.TabIndex = 16;
            this.calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calle_KeyPress);
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(212, 328);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(61, 20);
            this.altura.TabIndex = 17;
            this.altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.altura_KeyPress);
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(212, 354);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(61, 20);
            this.departamento.TabIndex = 19;
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(86, 354);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(68, 20);
            this.piso.TabIndex = 18;
            this.piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piso_KeyPress);
            // 
            // cod_pos
            // 
            this.cod_pos.Location = new System.Drawing.Point(138, 380);
            this.cod_pos.Name = "cod_pos";
            this.cod_pos.Size = new System.Drawing.Size(117, 20);
            this.cod_pos.TabIndex = 20;
            this.cod_pos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_pos_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nro Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Fecha Nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ciudad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Localidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Calle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Altura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Puerta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Piso";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Codigo Postal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Doc";
            // 
            // CBdni
            // 
            this.CBdni.AutoSize = true;
            this.CBdni.Location = new System.Drawing.Point(212, 34);
            this.CBdni.Name = "CBdni";
            this.CBdni.Size = new System.Drawing.Size(15, 14);
            this.CBdni.TabIndex = 41;
            this.CBdni.UseVisualStyleBackColor = true;
            this.CBdni.CheckedChanged += new System.EventHandler(this.CBdni_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "DNI";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(85, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Cedula";
            // 
            // CBcedula
            // 
            this.CBcedula.AutoSize = true;
            this.CBcedula.Location = new System.Drawing.Point(212, 61);
            this.CBcedula.Name = "CBcedula";
            this.CBcedula.Size = new System.Drawing.Size(15, 14);
            this.CBcedula.TabIndex = 48;
            this.CBcedula.UseVisualStyleBackColor = true;
            this.CBcedula.CheckedChanged += new System.EventHandler(this.CBcedula_CheckedChanged);
            // 
            // GenerarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 468);
            this.Controls.Add(this.CBcedula);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBdni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cod_pos);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.piso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Name = "GenerarCliente";
            this.Text = "Generar Usuario Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.TextBox cod_pos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBdni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox CBcedula;
    }
}