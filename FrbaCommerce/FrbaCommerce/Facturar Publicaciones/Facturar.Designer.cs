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
            ((System.ComponentModel.ISupportInitialize)(this.compraOfertaGrilla)).BeginInit();
            this.compraOfertaGruopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // compraOfertaGrilla
            // 
            this.compraOfertaGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraOfertaGrilla.Location = new System.Drawing.Point(14, 19);
            this.compraOfertaGrilla.Name = "compraOfertaGrilla";
            this.compraOfertaGrilla.Size = new System.Drawing.Size(546, 217);
            this.compraOfertaGrilla.TabIndex = 0;
            // 
            // facturarBoton
            // 
            this.facturarBoton.Location = new System.Drawing.Point(191, 341);
            this.facturarBoton.Name = "facturarBoton";
            this.facturarBoton.Size = new System.Drawing.Size(77, 31);
            this.facturarBoton.TabIndex = 1;
            this.facturarBoton.Text = "Facturar";
            this.facturarBoton.UseVisualStyleBackColor = true;
            // 
            // salirBoton
            // 
            this.salirBoton.Location = new System.Drawing.Point(327, 341);
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
            this.compraOfertaGruopBox.Location = new System.Drawing.Point(10, 12);
            this.compraOfertaGruopBox.Name = "compraOfertaGruopBox";
            this.compraOfertaGruopBox.Size = new System.Drawing.Size(575, 250);
            this.compraOfertaGruopBox.TabIndex = 3;
            this.compraOfertaGruopBox.TabStop = false;
            this.compraOfertaGruopBox.Text = "Compras";
            // 
            // formaPagoComboBox
            // 
            this.formaPagoComboBox.FormattingEnabled = true;
            this.formaPagoComboBox.Location = new System.Drawing.Point(263, 280);
            this.formaPagoComboBox.Name = "formaPagoComboBox";
            this.formaPagoComboBox.Size = new System.Drawing.Size(192, 21);
            this.formaPagoComboBox.TabIndex = 4;
            // 
            // formaPago
            // 
            this.formaPago.AutoSize = true;
            this.formaPago.Location = new System.Drawing.Point(140, 283);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(101, 13);
            this.formaPago.TabIndex = 5;
            this.formaPago.Text = "Elija Forma de Pago";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 399);
            this.Controls.Add(this.formaPago);
            this.Controls.Add(this.formaPagoComboBox);
            this.Controls.Add(this.compraOfertaGruopBox);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.facturarBoton);
            this.Name = "Facturar";
            this.Text = "Facturar";
            ((System.ComponentModel.ISupportInitialize)(this.compraOfertaGrilla)).EndInit();
            this.compraOfertaGruopBox.ResumeLayout(false);
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
    }
}