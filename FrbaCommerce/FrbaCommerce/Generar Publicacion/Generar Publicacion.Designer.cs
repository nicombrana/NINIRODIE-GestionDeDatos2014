namespace FrbaCommerce.Generar_Publicacion
{
    partial class Genepub
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
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fechaini = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboTipoPubli = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rubro = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.preguntas = new System.Windows.Forms.CheckBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visi = new System.Windows.Forms.Label();
            this.visibilidades = new System.Windows.Forms.ComboBox();
            this.activado = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(698, 42);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(134, 20);
            this.txtBoxDescripcion.TabIndex = 0;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(22, 16);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(63, 13);
            this.desc.TabIndex = 1;
            this.desc.Text = "Descripcion";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(22, 42);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(35, 13);
            this.stock.TabIndex = 3;
            this.stock.Text = "Stock";
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Location = new System.Drawing.Point(124, 39);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(134, 20);
            this.txtBoxStock.TabIndex = 2;
            this.txtBoxStock.TextChanged += new System.EventHandler(this.txtBoxStock_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // fechaini
            // 
            this.fechaini.AutoSize = true;
            this.fechaini.Location = new System.Drawing.Point(22, 71);
            this.fechaini.Name = "fechaini";
            this.fechaini.Size = new System.Drawing.Size(65, 13);
            this.fechaini.TabIndex = 5;
            this.fechaini.Text = "Fecha Inicio";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(22, 94);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(37, 13);
            this.precio.TabIndex = 7;
            this.precio.Text = "Precio";
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(124, 91);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(134, 20);
            this.txtBoxPrecio.TabIndex = 6;
            // 
            // comboTipoPubli
            // 
            this.comboTipoPubli.FormattingEnabled = true;
            this.comboTipoPubli.Items.AddRange(new object[] {
            "Inmediata",
            "Subasta"});
            this.comboTipoPubli.Location = new System.Drawing.Point(124, 118);
            this.comboTipoPubli.Name = "comboTipoPubli";
            this.comboTipoPubli.Size = new System.Drawing.Size(134, 21);
            this.comboTipoPubli.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(124, 238);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(134, 64);
            this.checkedListBox1.TabIndex = 9;
            // 
            // rubro
            // 
            this.rubro.AutoSize = true;
            this.rubro.Location = new System.Drawing.Point(22, 238);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(41, 13);
            this.rubro.TabIndex = 11;
            this.rubro.Text = "Rubros";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(22, 121);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(86, 13);
            this.tipo.TabIndex = 10;
            this.tipo.Text = "Tipo Publicacion";
            // 
            // preguntas
            // 
            this.preguntas.AutoSize = true;
            this.preguntas.Location = new System.Drawing.Point(124, 156);
            this.preguntas.Name = "preguntas";
            this.preguntas.Size = new System.Drawing.Size(15, 14);
            this.preguntas.TabIndex = 12;
            this.preguntas.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(33, 344);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 13;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(168, 344);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 14;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Habilitar Preguntas";
            // 
            // visi
            // 
            this.visi.AutoSize = true;
            this.visi.Location = new System.Drawing.Point(22, 311);
            this.visi.Name = "visi";
            this.visi.Size = new System.Drawing.Size(53, 13);
            this.visi.TabIndex = 16;
            this.visi.Text = "Visibilidad";
            // 
            // visibilidades
            // 
            this.visibilidades.FormattingEnabled = true;
            this.visibilidades.Location = new System.Drawing.Point(124, 308);
            this.visibilidades.Name = "visibilidades";
            this.visibilidades.Size = new System.Drawing.Size(134, 21);
            this.visibilidades.TabIndex = 17;
            // 
            // activado
            // 
            this.activado.AutoSize = true;
            this.activado.Location = new System.Drawing.Point(22, 189);
            this.activado.Name = "activado";
            this.activado.Size = new System.Drawing.Size(40, 13);
            this.activado.TabIndex = 18;
            this.activado.Text = "Estado";
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Borrador",
            "Activada",
            "Pausada",
            "Finalizada"});
            this.estado.Location = new System.Drawing.Point(124, 189);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(134, 21);
            this.estado.TabIndex = 19;
            // 
            // Genepub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.activado);
            this.Controls.Add(this.visibilidades);
            this.Controls.Add(this.visi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.preguntas);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboTipoPubli);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.fechaini);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.txtBoxStock);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Name = "Genepub";
            this.Text = "Generar Publicacion";
            this.Load += new System.EventHandler(this.Genepub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label fechaini;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.ComboBox comboTipoPubli;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label rubro;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.CheckBox preguntas;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label visi;
        private System.Windows.Forms.ComboBox visibilidades;
        private System.Windows.Forms.Label activado;
        private System.Windows.Forms.ComboBox estado;
    }
}