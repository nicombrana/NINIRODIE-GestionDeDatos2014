namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Ofertar
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
            this.ofertaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.publicacionDataGrid = new System.Windows.Forms.DataGridView();
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.preguntarBoton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realice una Oferta";
            // 
            // ofertaTextBox
            // 
            this.ofertaTextBox.Location = new System.Drawing.Point(238, 127);
            this.ofertaTextBox.Name = "ofertaTextBox";
            this.ofertaTextBox.Size = new System.Drawing.Size(142, 20);
            this.ofertaTextBox.TabIndex = 1;
            this.ofertaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ofertaTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.publicacionDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicación";
            // 
            // publicacionDataGrid
            // 
            this.publicacionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicacionDataGrid.Location = new System.Drawing.Point(7, 19);
            this.publicacionDataGrid.Name = "publicacionDataGrid";
            this.publicacionDataGrid.Size = new System.Drawing.Size(463, 62);
            this.publicacionDataGrid.TabIndex = 0;
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.Location = new System.Drawing.Point(89, 164);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(93, 31);
            this.aceptarBoton.TabIndex = 3;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.aceptarBoton_Click);
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.Location = new System.Drawing.Point(204, 164);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(93, 31);
            this.cancelarBoton.TabIndex = 4;
            this.cancelarBoton.Text = "Cancelar";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.cancelarBoton_Click);
            // 
            // preguntarBoton
            // 
            this.preguntarBoton.Location = new System.Drawing.Point(319, 164);
            this.preguntarBoton.Name = "preguntarBoton";
            this.preguntarBoton.Size = new System.Drawing.Size(93, 31);
            this.preguntarBoton.TabIndex = 5;
            this.preguntarBoton.Text = "Preguntar";
            this.preguntarBoton.UseVisualStyleBackColor = true;
            this.preguntarBoton.Click += new System.EventHandler(this.preguntarBoton_Click);
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 211);
            this.Controls.Add(this.preguntarBoton);
            this.Controls.Add(this.cancelarBoton);
            this.Controls.Add(this.aceptarBoton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ofertaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ofertar";
            this.Text = "Ofertar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.publicacionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ofertaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.Button cancelarBoton;
        private System.Windows.Forms.DataGridView publicacionDataGrid;
        private System.Windows.Forms.Button preguntarBoton;
    }
}