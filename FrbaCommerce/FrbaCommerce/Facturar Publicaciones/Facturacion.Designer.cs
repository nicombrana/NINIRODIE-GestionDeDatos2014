namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class Facturacion
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
            this.facturarComprasSubastasBoton = new System.Windows.Forms.Button();
            this.facturarPublicacionesBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facturarComprasSubastasBoton
            // 
            this.facturarComprasSubastasBoton.Location = new System.Drawing.Point(61, 42);
            this.facturarComprasSubastasBoton.Name = "facturarComprasSubastasBoton";
            this.facturarComprasSubastasBoton.Size = new System.Drawing.Size(112, 33);
            this.facturarComprasSubastasBoton.TabIndex = 0;
            this.facturarComprasSubastasBoton.Text = "Compras/Subastas";
            this.facturarComprasSubastasBoton.UseVisualStyleBackColor = true;
            this.facturarComprasSubastasBoton.Click += new System.EventHandler(this.facturarCompraBoton_Click);
            // 
            // facturarPublicacionesBoton
            // 
            this.facturarPublicacionesBoton.Location = new System.Drawing.Point(61, 106);
            this.facturarPublicacionesBoton.Name = "facturarPublicacionesBoton";
            this.facturarPublicacionesBoton.Size = new System.Drawing.Size(112, 33);
            this.facturarPublicacionesBoton.TabIndex = 1;
            this.facturarPublicacionesBoton.Text = "Publicaciones";
            this.facturarPublicacionesBoton.UseVisualStyleBackColor = true;
            this.facturarPublicacionesBoton.Click += new System.EventHandler(this.facturarOfertasBoton_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 181);
            this.Controls.Add(this.facturarPublicacionesBoton);
            this.Controls.Add(this.facturarComprasSubastasBoton);
            this.Name = "Facturacion";
            this.Text = "Elija que Facturar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button facturarComprasSubastasBoton;
        private System.Windows.Forms.Button facturarPublicacionesBoton;

    }
}