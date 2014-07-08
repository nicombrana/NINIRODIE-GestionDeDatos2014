namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class Facturar
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
            this.compraOfertaGrilla = new System.Windows.Forms.DataGridView();
            this.facturarBoton = new System.Windows.Forms.Button();
            this.salirBoton = new System.Windows.Forms.Button();
            this.compraOfertaGruopBox = new System.Windows.Forms.GroupBox();
            this.formaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.formaPago = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.busquedaGroupBox = new System.Windows.Forms.GroupBox();
            this.buscarBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.compraOfertaGrilla)).BeginInit();
            this.compraOfertaGruopBox.SuspendLayout();
            this.busquedaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // compraOfertaGrilla
            // 
            this.compraOfertaGrilla.AllowUserToAddRows = false;
            this.compraOfertaGrilla.AllowUserToDeleteRows = false;
            this.compraOfertaGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraOfertaGrilla.Enabled = false;
            this.compraOfertaGrilla.Location = new System.Drawing.Point(14, 19);
            this.compraOfertaGrilla.MultiSelect = false;
            this.compraOfertaGrilla.Name = "compraOfertaGrilla";
            this.compraOfertaGrilla.ReadOnly = true;
            this.compraOfertaGrilla.Size = new System.Drawing.Size(546, 217);
            this.compraOfertaGrilla.TabIndex = 0;
            this.compraOfertaGrilla.TabStop = false;
            // 
            // facturarBoton
            // 
            this.facturarBoton.Location = new System.Drawing.Point(191, 437);
            this.facturarBoton.Name = "facturarBoton";
            this.facturarBoton.Size = new System.Drawing.Size(77, 31);
            this.facturarBoton.TabIndex = 1;
            this.facturarBoton.Text = "Facturar";
            this.facturarBoton.UseVisualStyleBackColor = true;
            this.facturarBoton.Click += new System.EventHandler(this.facturarBoton_Click);
            // 
            // salirBoton
            // 
            this.salirBoton.Location = new System.Drawing.Point(327, 437);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(77, 31);
            this.salirBoton.TabIndex = 2;
            this.salirBoton.Text = "Salir";
            this.salirBoton.UseVisualStyleBackColor = true;
            this.salirBoton.Click += new System.EventHandler(this.salirBoton_Click);
            // 
            // compraOfertaGruopBox
            // 
            this.compraOfertaGruopBox.Controls.Add(this.compraOfertaGrilla);
            this.compraOfertaGruopBox.Location = new System.Drawing.Point(10, 128);
            this.compraOfertaGruopBox.Name = "compraOfertaGruopBox";
            this.compraOfertaGruopBox.Size = new System.Drawing.Size(575, 250);
            this.compraOfertaGruopBox.TabIndex = 3;
            this.compraOfertaGruopBox.TabStop = false;
            this.compraOfertaGruopBox.Text = "Compras";
            // 
            // formaPagoComboBox
            // 
            this.formaPagoComboBox.FormattingEnabled = true;
            this.formaPagoComboBox.Location = new System.Drawing.Point(263, 393);
            this.formaPagoComboBox.Name = "formaPagoComboBox";
            this.formaPagoComboBox.Size = new System.Drawing.Size(192, 21);
            this.formaPagoComboBox.TabIndex = 4;
            // 
            // formaPago
            // 
            this.formaPago.AutoSize = true;
            this.formaPago.Location = new System.Drawing.Point(140, 396);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(101, 13);
            this.formaPago.TabIndex = 5;
            this.formaPago.Text = "Elija Forma de Pago";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(334, 29);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(91, 20);
            this.cantidadTextBox.TabIndex = 6;
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese una Cantidad a Facturar";
            // 
            // busquedaGroupBox
            // 
            this.busquedaGroupBox.Controls.Add(this.buscarBoton);
            this.busquedaGroupBox.Controls.Add(this.cantidadTextBox);
            this.busquedaGroupBox.Controls.Add(this.label1);
            this.busquedaGroupBox.Location = new System.Drawing.Point(10, 12);
            this.busquedaGroupBox.Name = "busquedaGroupBox";
            this.busquedaGroupBox.Size = new System.Drawing.Size(573, 110);
            this.busquedaGroupBox.TabIndex = 8;
            this.busquedaGroupBox.TabStop = false;
            this.busquedaGroupBox.Text = "Búsqueda Compras";
            // 
            // buscarBoton
            // 
            this.buscarBoton.Location = new System.Drawing.Point(230, 64);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(77, 31);
            this.buscarBoton.TabIndex = 8;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 490);
            this.Controls.Add(this.busquedaGroupBox);
            this.Controls.Add(this.formaPago);
            this.Controls.Add(this.formaPagoComboBox);
            this.Controls.Add(this.compraOfertaGruopBox);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.facturarBoton);
            this.Name = "Facturar";
            this.Text = "Facturar";
            ((System.ComponentModel.ISupportInitialize)(this.compraOfertaGrilla)).EndInit();
            this.compraOfertaGruopBox.ResumeLayout(false);
            this.busquedaGroupBox.ResumeLayout(false);
            this.busquedaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView compraOfertaGrilla;
        private System.Windows.Forms.Button facturarBoton;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.GroupBox compraOfertaGruopBox;
        private System.Windows.Forms.ComboBox formaPagoComboBox;
        private System.Windows.Forms.Label formaPago;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox busquedaGroupBox;
        private System.Windows.Forms.Button buscarBoton;
    }
}