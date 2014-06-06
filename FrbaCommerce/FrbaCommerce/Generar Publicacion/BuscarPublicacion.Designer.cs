namespace FrbaCommerce.Generar_Publicacion
{
    partial class BuscarPublicacion
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
            this.Rubro = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.LDesc = new System.Windows.Forms.Label();
            this.BM = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Rubro
            // 
            this.Rubro.AutoSize = true;
            this.Rubro.Location = new System.Drawing.Point(45, 41);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(36, 13);
            this.Rubro.TabIndex = 21;
            this.Rubro.Text = "Rubro";
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(154, 138);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 19;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(48, 138);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(75, 23);
            this.BAceptar.TabIndex = 18;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            // 
            // LDesc
            // 
            this.LDesc.AutoSize = true;
            this.LDesc.Location = new System.Drawing.Point(45, 15);
            this.LDesc.Name = "LDesc";
            this.LDesc.Size = new System.Drawing.Size(63, 13);
            this.LDesc.TabIndex = 17;
            this.LDesc.Text = "Descripcion";
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(115, 12);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(100, 20);
            this.BM.TabIndex = 16;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(115, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 22;
            // 
            // BuscarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Rubro);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.LDesc);
            this.Controls.Add(this.BM);
            this.Name = "BuscarPublicacion";
            this.Text = "BuscarPublicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rubro;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Label LDesc;
        private System.Windows.Forms.TextBox BM;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}