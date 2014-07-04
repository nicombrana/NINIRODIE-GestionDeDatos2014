namespace FrbaCommerce.Editar_Publicacion
{
    partial class EditarPublicacionBorrador
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
            this.descripcionTextBox = new System.Windows.Forms.RichTextBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.activado = new System.Windows.Forms.Label();
            this.visibilidades = new System.Windows.Forms.ComboBox();
            this.visi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.preguntas = new System.Windows.Forms.CheckBox();
            this.rubro = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.RubrosCheckList = new System.Windows.Forms.CheckedListBox();
            this.comboTipoPubli = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.fechaini = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.stock = new System.Windows.Forms.Label();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(407, 64);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(213, 93);
            this.descripcionTextBox.TabIndex = 40;
            this.descripcionTextBox.Text = "";
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Borrador",
            "Activada",
            "Pausada",
            "Finalizada"});
            this.estado.Location = new System.Drawing.Point(123, 184);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(171, 21);
            this.estado.TabIndex = 39;
            // 
            // activado
            // 
            this.activado.AutoSize = true;
            this.activado.Location = new System.Drawing.Point(18, 184);
            this.activado.Name = "activado";
            this.activado.Size = new System.Drawing.Size(40, 13);
            this.activado.TabIndex = 38;
            this.activado.Text = "Estado";
            // 
            // visibilidades
            // 
            this.visibilidades.FormattingEnabled = true;
            this.visibilidades.Location = new System.Drawing.Point(122, 242);
            this.visibilidades.Name = "visibilidades";
            this.visibilidades.Size = new System.Drawing.Size(172, 21);
            this.visibilidades.TabIndex = 37;
            // 
            // visi
            // 
            this.visi.AutoSize = true;
            this.visi.Location = new System.Drawing.Point(18, 245);
            this.visi.Name = "visi";
            this.visi.Size = new System.Drawing.Size(53, 13);
            this.visi.TabIndex = 36;
            this.visi.Text = "Visibilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Habilitar Preguntas";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(367, 315);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 34;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(187, 315);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 33;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // preguntas
            // 
            this.preguntas.AutoSize = true;
            this.preguntas.Location = new System.Drawing.Point(123, 144);
            this.preguntas.Name = "preguntas";
            this.preguntas.Size = new System.Drawing.Size(15, 14);
            this.preguntas.TabIndex = 32;
            this.preguntas.UseVisualStyleBackColor = true;
            // 
            // rubro
            // 
            this.rubro.AutoSize = true;
            this.rubro.Location = new System.Drawing.Point(318, 184);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(41, 13);
            this.rubro.TabIndex = 31;
            this.rubro.Text = "Rubros";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(18, 24);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(86, 13);
            this.tipo.TabIndex = 30;
            this.tipo.Text = "Tipo Publicacion";
            // 
            // RubrosCheckList
            // 
            this.RubrosCheckList.FormattingEnabled = true;
            this.RubrosCheckList.Location = new System.Drawing.Point(407, 184);
            this.RubrosCheckList.Name = "RubrosCheckList";
            this.RubrosCheckList.Size = new System.Drawing.Size(213, 94);
            this.RubrosCheckList.TabIndex = 29;
            // 
            // comboTipoPubli
            // 
            this.comboTipoPubli.FormattingEnabled = true;
            this.comboTipoPubli.Items.AddRange(new object[] {
            "Inmediata",
            "Subasta"});
            this.comboTipoPubli.Location = new System.Drawing.Point(123, 21);
            this.comboTipoPubli.Name = "comboTipoPubli";
            this.comboTipoPubli.Size = new System.Drawing.Size(171, 21);
            this.comboTipoPubli.TabIndex = 28;
            this.comboTipoPubli.SelectedIndexChanged += new System.EventHandler(this.comboTipoPubli_SelectedIndexChanged);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(18, 102);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(37, 13);
            this.precio.TabIndex = 27;
            this.precio.Text = "Precio";
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(122, 102);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(172, 20);
            this.txtBoxPrecio.TabIndex = 26;
            this.txtBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrecio_KeyPress);
            // 
            // fechaini
            // 
            this.fechaini.AutoSize = true;
            this.fechaini.Location = new System.Drawing.Point(316, 24);
            this.fechaini.Name = "fechaini";
            this.fechaini.Size = new System.Drawing.Size(65, 13);
            this.fechaini.TabIndex = 25;
            this.fechaini.Text = "Fecha Inicio";
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(407, 21);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(213, 20);
            this.fechaPicker.TabIndex = 24;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(18, 64);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(35, 13);
            this.stock.TabIndex = 23;
            this.stock.Text = "Stock";
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Location = new System.Drawing.Point(122, 61);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(172, 20);
            this.txtBoxStock.TabIndex = 22;
            this.txtBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStock_KeyPress);
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(318, 64);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(63, 13);
            this.desc.TabIndex = 21;
            this.desc.Text = "Descripcion";
            // 
            // EditarPublicacionBorrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 366);
            this.Controls.Add(this.descripcionTextBox);
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
            this.Controls.Add(this.RubrosCheckList);
            this.Controls.Add(this.comboTipoPubli);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.fechaini);
            this.Controls.Add(this.fechaPicker);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.txtBoxStock);
            this.Controls.Add(this.desc);
            this.Name = "EditarPublicacionBorrador";
            this.Text = "EditarPublicacionBorrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label activado;
        private System.Windows.Forms.ComboBox visibilidades;
        private System.Windows.Forms.Label visi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.CheckBox preguntas;
        private System.Windows.Forms.Label rubro;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.CheckedListBox RubrosCheckList;
        private System.Windows.Forms.ComboBox comboTipoPubli;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Label fechaini;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.Label desc;

    }
}