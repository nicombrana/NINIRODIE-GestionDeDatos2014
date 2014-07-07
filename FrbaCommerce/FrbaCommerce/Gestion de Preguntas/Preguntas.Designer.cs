namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class preguntas
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
            this.pregunta = new System.Windows.Forms.Label();
            this.Pregaceptar = new System.Windows.Forms.Button();
            this.PreguntasGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PreguntasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Location = new System.Drawing.Point(12, 9);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(55, 13);
            this.pregunta.TabIndex = 0;
            this.pregunta.Text = "Preguntas";
            // 
            // Pregaceptar
            // 
            this.Pregaceptar.Location = new System.Drawing.Point(148, 205);
            this.Pregaceptar.Name = "Pregaceptar";
            this.Pregaceptar.Size = new System.Drawing.Size(75, 23);
            this.Pregaceptar.TabIndex = 3;
            this.Pregaceptar.Text = "Aceptar";
            this.Pregaceptar.UseVisualStyleBackColor = true;
            this.Pregaceptar.Click += new System.EventHandler(this.Pregaceptar_Click);
            // 
            // PreguntasGrid
            // 
            this.PreguntasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreguntasGrid.Location = new System.Drawing.Point(13, 34);
            this.PreguntasGrid.Name = "PreguntasGrid";
            this.PreguntasGrid.Size = new System.Drawing.Size(344, 150);
            this.PreguntasGrid.TabIndex = 4;
            // 
            // preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 253);
            this.Controls.Add(this.PreguntasGrid);
            this.Controls.Add(this.Pregaceptar);
            this.Controls.Add(this.pregunta);
            this.Name = "preguntas";
            this.Text = "Ver Respuestas";
            this.Load += new System.EventHandler(this.preguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreguntasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.Button Pregaceptar;
        private System.Windows.Forms.DataGridView PreguntasGrid;
    }
}