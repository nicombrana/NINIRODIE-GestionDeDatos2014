namespace FrbaCommerce.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.buscarBoton = new System.Windows.Forms.Button();
            this.salirBoton = new System.Windows.Forms.Button();
            this.listadoDataGrid = new System.Windows.Forms.DataGridView();
            this.anioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anioComboBox = new System.Windows.Forms.ComboBox();
            this.semestreComboBox = new System.Windows.Forms.ComboBox();
            this.tipoListado = new System.Windows.Forms.Label();
            this.tipoListadoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.visibilidadComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarBoton
            // 
            this.buscarBoton.Location = new System.Drawing.Point(230, 141);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(90, 34);
            this.buscarBoton.TabIndex = 0;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // salirBoton
            // 
            this.salirBoton.Location = new System.Drawing.Point(230, 381);
            this.salirBoton.Name = "salirBoton";
            this.salirBoton.Size = new System.Drawing.Size(90, 34);
            this.salirBoton.TabIndex = 1;
            this.salirBoton.Text = "Salir";
            this.salirBoton.UseVisualStyleBackColor = true;
            this.salirBoton.Click += new System.EventHandler(this.salirBoton_Click);
            // 
            // listadoDataGrid
            // 
            this.listadoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGrid.Location = new System.Drawing.Point(3, 18);
            this.listadoDataGrid.Name = "listadoDataGrid";
            this.listadoDataGrid.ReadOnly = true;
            this.listadoDataGrid.Size = new System.Drawing.Size(524, 159);
            this.listadoDataGrid.TabIndex = 2;
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(13, 25);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(26, 13);
            this.anioLabel.TabIndex = 3;
            this.anioLabel.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semestre";
            // 
            // anioComboBox
            // 
            this.anioComboBox.FormattingEnabled = true;
            this.anioComboBox.Location = new System.Drawing.Point(48, 22);
            this.anioComboBox.Name = "anioComboBox";
            this.anioComboBox.Size = new System.Drawing.Size(81, 21);
            this.anioComboBox.TabIndex = 5;
            // 
            // semestreComboBox
            // 
            this.semestreComboBox.FormattingEnabled = true;
            this.semestreComboBox.Location = new System.Drawing.Point(202, 22);
            this.semestreComboBox.Name = "semestreComboBox";
            this.semestreComboBox.Size = new System.Drawing.Size(69, 21);
            this.semestreComboBox.TabIndex = 6;
            // 
            // tipoListado
            // 
            this.tipoListado.AutoSize = true;
            this.tipoListado.Location = new System.Drawing.Point(6, 63);
            this.tipoListado.Name = "tipoListado";
            this.tipoListado.Size = new System.Drawing.Size(65, 13);
            this.tipoListado.TabIndex = 7;
            this.tipoListado.Text = "Tipo Listado";
            // 
            // tipoListadoComboBox
            // 
            this.tipoListadoComboBox.FormattingEnabled = true;
            this.tipoListadoComboBox.Location = new System.Drawing.Point(82, 60);
            this.tipoListadoComboBox.Name = "tipoListadoComboBox";
            this.tipoListadoComboBox.Size = new System.Drawing.Size(444, 21);
            this.tipoListadoComboBox.TabIndex = 8;
            this.tipoListadoComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoListadoComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visibilidadComboBox);
            this.groupBox1.Controls.Add(this.codigoLabel);
            this.groupBox1.Controls.Add(this.tipoListadoComboBox);
            this.groupBox1.Controls.Add(this.anioLabel);
            this.groupBox1.Controls.Add(this.tipoListado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.semestreComboBox);
            this.groupBox1.Controls.Add(this.anioComboBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listadoDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(9, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 184);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(283, 25);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(89, 13);
            this.codigoLabel.TabIndex = 9;
            this.codigoLabel.Text = "Codigo Visibilidad";
            this.codigoLabel.Visible = false;
            // 
            // visibilidadComboBox
            // 
            this.visibilidadComboBox.FormattingEnabled = true;
            this.visibilidadComboBox.Location = new System.Drawing.Point(387, 22);
            this.visibilidadComboBox.Name = "visibilidadComboBox";
            this.visibilidadComboBox.Size = new System.Drawing.Size(132, 21);
            this.visibilidadComboBox.TabIndex = 10;
            this.visibilidadComboBox.Visible = false;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salirBoton);
            this.Controls.Add(this.buscarBoton);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarBoton;
        private System.Windows.Forms.Button salirBoton;
        private System.Windows.Forms.DataGridView listadoDataGrid;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anioComboBox;
        private System.Windows.Forms.ComboBox semestreComboBox;
        private System.Windows.Forms.Label tipoListado;
        private System.Windows.Forms.ComboBox tipoListadoComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox visibilidadComboBox;
        private System.Windows.Forms.Label codigoLabel;
    }
}