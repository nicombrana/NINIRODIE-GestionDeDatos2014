namespace FrbaCommerce.Comprar_Ofertar
{
    partial class BuscarPublicacionCompra
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
            this.publicacionesGrid = new System.Windows.Forms.DataGridView();
            this.comprarBoton = new System.Windows.Forms.Button();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borrarBoton = new System.Windows.Forms.Button();
            this.buscarBoton = new System.Windows.Forms.Button();
            this.descripcionTextBox = new System.Windows.Forms.RichTextBox();
            this.rubrosCheckList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // publicacionesGrid
            // 
            this.publicacionesGrid.AllowUserToOrderColumns = true;
            this.publicacionesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicacionesGrid.Location = new System.Drawing.Point(6, 19);
            this.publicacionesGrid.Name = "publicacionesGrid";
            this.publicacionesGrid.Size = new System.Drawing.Size(503, 171);
            this.publicacionesGrid.TabIndex = 1;
            this.publicacionesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.publicacionesGrid_CellClick);
            // 
            // comprarBoton
            // 
            this.comprarBoton.Location = new System.Drawing.Point(155, 415);
            this.comprarBoton.Name = "comprarBoton";
            this.comprarBoton.Size = new System.Drawing.Size(88, 33);
            this.comprarBoton.TabIndex = 3;
            this.comprarBoton.Text = "Comprar";
            this.comprarBoton.UseVisualStyleBackColor = true;
            this.comprarBoton.Click += new System.EventHandler(this.comprarBoton_Click);
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.Location = new System.Drawing.Point(299, 415);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(88, 33);
            this.cancelarBoton.TabIndex = 4;
            this.cancelarBoton.Text = "Salir";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.cancelarBoton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrarBoton);
            this.groupBox1.Controls.Add(this.buscarBoton);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(this.rubrosCheckList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // borrarBoton
            // 
            this.borrarBoton.Location = new System.Drawing.Point(146, 148);
            this.borrarBoton.Name = "borrarBoton";
            this.borrarBoton.Size = new System.Drawing.Size(88, 33);
            this.borrarBoton.TabIndex = 6;
            this.borrarBoton.Text = "Borrar";
            this.borrarBoton.UseVisualStyleBackColor = true;
            this.borrarBoton.Click += new System.EventHandler(this.borrarBoton_Click);
            // 
            // buscarBoton
            // 
            this.buscarBoton.Location = new System.Drawing.Point(290, 148);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(88, 33);
            this.buscarBoton.TabIndex = 5;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(246, 48);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(266, 94);
            this.descripcionTextBox.TabIndex = 4;
            this.descripcionTextBox.Text = "";
            // 
            // rubrosCheckList
            // 
            this.rubrosCheckList.FormattingEnabled = true;
            this.rubrosCheckList.Location = new System.Drawing.Point(9, 48);
            this.rubrosCheckList.Name = "rubrosCheckList";
            this.rubrosCheckList.Size = new System.Drawing.Size(215, 94);
            this.rubrosCheckList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rubros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.publicacionesGrid);
            this.groupBox2.Location = new System.Drawing.Point(9, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publicaciones";
            // 
            // BuscarPublicacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelarBoton);
            this.Controls.Add(this.comprarBoton);
            this.Name = "BuscarPublicacionCompra";
            this.Text = "BuscarPublicacionCompra";
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView publicacionesGrid;
        private System.Windows.Forms.Button comprarBoton;
        private System.Windows.Forms.Button cancelarBoton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox rubrosCheckList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox descripcionTextBox;
        private System.Windows.Forms.Button buscarBoton;
        private System.Windows.Forms.Button borrarBoton;

    }
}