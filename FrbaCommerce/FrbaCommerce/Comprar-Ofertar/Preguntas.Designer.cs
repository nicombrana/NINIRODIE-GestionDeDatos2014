namespace FrbaCommerce.Comprar_Ofertar
{
    partial class Preguntas
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
            this.aceptarBoton = new System.Windows.Forms.Button();
            this.preguntaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aceptarBoton
            // 
            this.aceptarBoton.Location = new System.Drawing.Point(52, 184);
            this.aceptarBoton.Name = "aceptarBoton";
            this.aceptarBoton.Size = new System.Drawing.Size(80, 33);
            this.aceptarBoton.TabIndex = 0;
            this.aceptarBoton.Text = "Aceptar";
            this.aceptarBoton.UseVisualStyleBackColor = true;
            this.aceptarBoton.Click += new System.EventHandler(this.aceptarBoton_Click);
            // 
            // preguntaRichTextBox
            // 
            this.preguntaRichTextBox.Location = new System.Drawing.Point(14, 35);
            this.preguntaRichTextBox.Name = "preguntaRichTextBox";
            this.preguntaRichTextBox.Size = new System.Drawing.Size(256, 127);
            this.preguntaRichTextBox.TabIndex = 1;
            this.preguntaRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba su pregunta";
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.Location = new System.Drawing.Point(152, 184);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(80, 33);
            this.cancelarBoton.TabIndex = 3;
            this.cancelarBoton.Text = "Cancelar";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.cancelarBoton_Click);
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.cancelarBoton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preguntaRichTextBox);
            this.Controls.Add(this.aceptarBoton);
            this.Name = "Preguntas";
            this.Text = "Preguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarBoton;
        private System.Windows.Forms.RichTextBox preguntaRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelarBoton;
    }
}