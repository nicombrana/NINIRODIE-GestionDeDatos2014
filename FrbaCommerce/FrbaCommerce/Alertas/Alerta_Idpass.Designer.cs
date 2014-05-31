namespace FrbaCommerce.Alertas
{
    partial class Alerid
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
            this.aleip_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "El Usuario o la Password No Coinciden";
            // 
            // aleip_aceptar
            // 
            this.aleip_aceptar.Location = new System.Drawing.Point(96, 57);
            this.aleip_aceptar.Name = "aleip_aceptar";
            this.aleip_aceptar.Size = new System.Drawing.Size(75, 23);
            this.aleip_aceptar.TabIndex = 1;
            this.aleip_aceptar.Text = "Aceptar";
            this.aleip_aceptar.UseVisualStyleBackColor = true;
            this.aleip_aceptar.Click += new System.EventHandler(this.aleip_aceptar_Click);
            // 
            // Alerid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 92);
            this.Controls.Add(this.aleip_aceptar);
            this.Controls.Add(this.label1);
            this.Name = "Alerid";
            this.Text = "Alerta";
            this.Load += new System.EventHandler(this.Alerid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aleip_aceptar;
    }
}