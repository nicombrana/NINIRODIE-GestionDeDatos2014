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
            this.comboBoxPreg = new System.Windows.Forms.ComboBox();
            this.DGWRes = new System.Windows.Forms.DataGridView();
            this.Pregaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGWRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Location = new System.Drawing.Point(35, 31);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(50, 13);
            this.pregunta.TabIndex = 0;
            this.pregunta.Text = "Pregunta";
            // 
            // comboBoxPreg
            // 
            this.comboBoxPreg.FormattingEnabled = true;
            this.comboBoxPreg.Location = new System.Drawing.Point(134, 23);
            this.comboBoxPreg.Name = "comboBoxPreg";
            this.comboBoxPreg.Size = new System.Drawing.Size(138, 21);
            this.comboBoxPreg.TabIndex = 1;
            // 
            // DGWRes
            // 
            this.DGWRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWRes.Location = new System.Drawing.Point(32, 65);
            this.DGWRes.Name = "DGWRes";
            this.DGWRes.Size = new System.Drawing.Size(240, 90);
            this.DGWRes.TabIndex = 2;
            // 
            // Pregaceptar
            // 
            this.Pregaceptar.Location = new System.Drawing.Point(104, 205);
            this.Pregaceptar.Name = "Pregaceptar";
            this.Pregaceptar.Size = new System.Drawing.Size(75, 23);
            this.Pregaceptar.TabIndex = 3;
            this.Pregaceptar.Text = "Aceptar";
            this.Pregaceptar.UseVisualStyleBackColor = true;
            this.Pregaceptar.Click += new System.EventHandler(this.Pregaceptar_Click);
            // 
            // preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Pregaceptar);
            this.Controls.Add(this.DGWRes);
            this.Controls.Add(this.comboBoxPreg);
            this.Controls.Add(this.pregunta);
            this.Name = "preguntas";
            this.Text = "Ver Respuestas";
            ((System.ComponentModel.ISupportInitialize)(this.DGWRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.ComboBox comboBoxPreg;
        private System.Windows.Forms.DataGridView DGWRes;
        private System.Windows.Forms.Button Pregaceptar;
    }
}