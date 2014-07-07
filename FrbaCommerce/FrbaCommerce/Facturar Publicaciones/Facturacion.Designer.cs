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
            this.facturarCompraBoton = new System.Windows.Forms.Button();
            this.facturarOfertasBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facturarCompraBoton
            // 
            this.facturarCompraBoton.Location = new System.Drawing.Point(75, 42);
            this.facturarCompraBoton.Name = "facturarCompraBoton";
            this.facturarCompraBoton.Size = new System.Drawing.Size(84, 33);
            this.facturarCompraBoton.TabIndex = 0;
            this.facturarCompraBoton.Text = "Compras";
            this.facturarCompraBoton.UseVisualStyleBackColor = true;
            this.facturarCompraBoton.Click += new System.EventHandler(this.facturarCompraBoton_Click);
            // 
            // facturarOfertasBoton
            // 
            this.facturarOfertasBoton.Location = new System.Drawing.Point(75, 106);
            this.facturarOfertasBoton.Name = "facturarOfertasBoton";
            this.facturarOfertasBoton.Size = new System.Drawing.Size(84, 33);
            this.facturarOfertasBoton.TabIndex = 1;
            this.facturarOfertasBoton.Text = "Ofertas";
            this.facturarOfertasBoton.UseVisualStyleBackColor = true;
            this.facturarOfertasBoton.Click += new System.EventHandler(this.facturarOfertasBoton_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 181);
            this.Controls.Add(this.facturarOfertasBoton);
            this.Controls.Add(this.facturarCompraBoton);
            this.Name = "Facturacion";
            this.Text = "Elija que Facturar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button facturarCompraBoton;
        private System.Windows.Forms.Button facturarOfertasBoton;

    }
}