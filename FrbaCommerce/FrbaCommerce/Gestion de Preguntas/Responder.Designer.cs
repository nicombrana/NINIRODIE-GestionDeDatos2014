namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class Responder
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
            this.preguntas = new System.Windows.Forms.Label();
            this.comboBoxPreg = new System.Windows.Forms.ComboBox();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.resaceptar = new System.Windows.Forms.Button();
            this.rescancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preguntas
            // 
            this.preguntas.AutoSize = true;
            this.preguntas.Location = new System.Drawing.Point(26, 26);
            this.preguntas.Name = "preguntas";
            this.preguntas.Size = new System.Drawing.Size(55, 13);
            this.preguntas.TabIndex = 0;
            this.preguntas.Text = "Preguntas";
            // 
            // comboBoxPreg
            // 
            this.comboBoxPreg.FormattingEnabled = true;
            this.comboBoxPreg.Location = new System.Drawing.Point(132, 23);
            this.comboBoxPreg.Name = "comboBoxPreg";
            this.comboBoxPreg.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPreg.TabIndex = 1;
            // 
            // respuesta
            // 
            this.respuesta.Location = new System.Drawing.Point(29, 70);
            this.respuesta.Multiline = true;
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(243, 100);
            this.respuesta.TabIndex = 2;
            // 
            // resaceptar
            // 
            this.resaceptar.Location = new System.Drawing.Point(29, 218);
            this.resaceptar.Name = "resaceptar";
            this.resaceptar.Size = new System.Drawing.Size(75, 23);
            this.resaceptar.TabIndex = 3;
            this.resaceptar.Text = "Aceptar";
            this.resaceptar.UseVisualStyleBackColor = true;
            this.resaceptar.Click += new System.EventHandler(this.resaceptar_Click);
            // 
            // rescancelar
            // 
            this.rescancelar.Location = new System.Drawing.Point(197, 218);
            this.rescancelar.Name = "rescancelar";
            this.rescancelar.Size = new System.Drawing.Size(75, 23);
            this.rescancelar.TabIndex = 4;
            this.rescancelar.Text = "Cancelar";
            this.rescancelar.UseVisualStyleBackColor = true;
            this.rescancelar.Click += new System.EventHandler(this.rescancelar_Click);
            // 
            // Responder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rescancelar);
            this.Controls.Add(this.resaceptar);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.comboBoxPreg);
            this.Controls.Add(this.preguntas);
            this.Name = "Responder";
            this.Text = "Responder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preguntas;
        private System.Windows.Forms.ComboBox comboBoxPreg;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.Button resaceptar;
        private System.Windows.Forms.Button rescancelar;
    }
}