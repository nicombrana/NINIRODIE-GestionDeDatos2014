namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class FormaDePago
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
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.numeroTarjetaTextBox = new System.Windows.Forms.TextBox();
            this.cuotasComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el número de Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione una cantidad de cuotas";
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.Location = new System.Drawing.Point(88, 162);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(95, 32);
            this.aceptarBoton.TabIndex = 2;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.aceptarBoton_Click);
            // 
            // numeroTarjetaTextBox
            // 
            this.numeroTarjetaTextBox.Location = new System.Drawing.Point(24, 59);
            this.numeroTarjetaTextBox.Name = "numeroTarjetaTextBox";
            this.numeroTarjetaTextBox.Size = new System.Drawing.Size(215, 20);
            this.numeroTarjetaTextBox.TabIndex = 3;
            this.numeroTarjetaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTarjetaTextBox_KeyPress);
            // 
            // cuotasComboBox
            // 
            this.cuotasComboBox.FormattingEnabled = true;
            this.cuotasComboBox.Location = new System.Drawing.Point(24, 119);
            this.cuotasComboBox.Name = "cuotasComboBox";
            this.cuotasComboBox.Size = new System.Drawing.Size(96, 21);
            this.cuotasComboBox.TabIndex = 4;
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 224);
            this.Controls.Add(this.cuotasComboBox);
            this.Controls.Add(this.numeroTarjetaTextBox);
            this.Controls.Add(this.aceptarBoton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaDePago";
            this.Text = "FormaDePago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.TextBox numeroTarjetaTextBox;
        private System.Windows.Forms.ComboBox cuotasComboBox;
    }
}