namespace FrbaCommerce.Editar_Publicacion
{
    partial class EditarPublicacion
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
            this.estadoPublicacionLabel = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.estadosComboBox = new System.Windows.Forms.ComboBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // estadoPublicacionLabel
            // 
            this.estadoPublicacionLabel.AutoSize = true;
            this.estadoPublicacionLabel.Location = new System.Drawing.Point(12, 31);
            this.estadoPublicacionLabel.Name = "estadoPublicacionLabel";
            this.estadoPublicacionLabel.Size = new System.Drawing.Size(98, 13);
            this.estadoPublicacionLabel.TabIndex = 0;
            this.estadoPublicacionLabel.Text = "Estado Publicación";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(54, 110);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(68, 28);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(152, 110);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(68, 28);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // estadosComboBox
            // 
            this.estadosComboBox.FormattingEnabled = true;
            this.estadosComboBox.Location = new System.Drawing.Point(130, 28);
            this.estadosComboBox.Name = "estadosComboBox";
            this.estadosComboBox.Size = new System.Drawing.Size(142, 21);
            this.estadosComboBox.TabIndex = 3;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(12, 69);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(35, 13);
            this.stockLabel.TabIndex = 4;
            this.stockLabel.Text = "Stock";
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(130, 66);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(142, 20);
            this.stockTextBox.TabIndex = 5;
            this.stockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockTextBox_KeyPress);
            // 
            // EditarPublicacionPublicada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.estadosComboBox);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.estadoPublicacionLabel);
            this.Name = "EditarPublicacion";
            this.Text = "EditarPublicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label estadoPublicacionLabel;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ComboBox estadosComboBox;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockTextBox;
    }
}