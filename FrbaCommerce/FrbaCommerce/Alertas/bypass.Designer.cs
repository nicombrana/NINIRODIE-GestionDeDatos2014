namespace FrbaCommerce.Alertas
{
    partial class bypass
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
            this.pasear = new System.Windows.Forms.Label();
            this.putos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pasear
            // 
            this.pasear.AutoSize = true;
            this.pasear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasear.Location = new System.Drawing.Point(48, 28);
            this.pasear.Name = "pasear";
            this.pasear.Size = new System.Drawing.Size(275, 31);
            this.pasear.TabIndex = 0;
            this.pasear.Text = "Adios. Vuelva Pronto.";
            // 
            // putos
            // 
            this.putos.Location = new System.Drawing.Point(103, 96);
            this.putos.Name = "putos";
            this.putos.Size = new System.Drawing.Size(142, 33);
            this.putos.TabIndex = 1;
            this.putos.Text = "Aceptar";
            this.putos.UseVisualStyleBackColor = true;
            this.putos.Click += new System.EventHandler(this.putos_Click);
            // 
            // bypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 141);
            this.Controls.Add(this.putos);
            this.Controls.Add(this.pasear);
            this.Name = "bypass";
            this.Text = "bypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pasear;
        private System.Windows.Forms.Button putos;
    }
}