namespace FrbaBus.Abm_Micro
{
    partial class AbmMicrosWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbmMicrosWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.comboTipoServicio = new System.Windows.Forms.ComboBox();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.grillaMicros = new System.Windows.Forms.DataGridView();
            this.columnaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHabilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnaKGSDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnasAsientosDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaBajaDefinitiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNumereo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFueraDeServicio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnaFechaFueraDeServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaReinicioDeServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBajaDefinitiva = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnaButacas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMicros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.textMarca);
            this.groupBox1.Controls.Add(this.textModelo);
            this.groupBox1.Controls.Add(this.botonLimpiar);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.comboTipoServicio);
            this.groupBox1.Controls.Add(this.labelTipoServicio);
            this.groupBox1.Controls.Add(this.labelMarca);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Micros";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(501, 48);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 7;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(582, 48);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 6;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // comboTipoServicio
            // 
            this.comboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoServicio.FormattingEnabled = true;
            this.comboTipoServicio.Location = new System.Drawing.Point(501, 18);
            this.comboTipoServicio.Name = "comboTipoServicio";
            this.comboTipoServicio.Size = new System.Drawing.Size(156, 21);
            this.comboTipoServicio.TabIndex = 4;
            this.comboTipoServicio.SelectedIndexChanged += new System.EventHandler(this.comboTipoServicio_SelectedIndexChanged);
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(411, 22);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.labelTipoServicio.TabIndex = 2;
            this.labelTipoServicio.Text = "Tipo de Servicio";
            // 
            // grillaMicros
            // 
            this.grillaMicros.AllowUserToAddRows = false;
            this.grillaMicros.AllowUserToDeleteRows = false;
            this.grillaMicros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaMicros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaMicros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMicros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaModelo,
            this.columnaMarca,
            this.columnaPatente,
            this.columnaTipoServicio,
            this.columnaHabilitado,
            this.columnaKGSDisponibles,
            this.columnasAsientosDisponibles,
            this.columnaFechaAlta,
            this.columnaFechaBajaDefinitiva,
            this.columnaNumereo,
            this.columnaFueraDeServicio,
            this.columnaFechaFueraDeServicio,
            this.columnaFechaReinicioDeServicio,
            this.columnaBajaDefinitiva,
            this.columnaButacas});
            this.grillaMicros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grillaMicros.Location = new System.Drawing.Point(13, 103);
            this.grillaMicros.MultiSelect = false;
            this.grillaMicros.Name = "grillaMicros";
            this.grillaMicros.ReadOnly = true;
            this.grillaMicros.RowHeadersVisible = false;
            this.grillaMicros.RowHeadersWidth = 20;
            this.grillaMicros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grillaMicros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaMicros.Size = new System.Drawing.Size(663, 158);
            this.grillaMicros.TabIndex = 1;
            this.grillaMicros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaMicros_CellDoubleClick);
            this.grillaMicros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaMicros_CellClick);
            // 
            // columnaModelo
            // 
            this.columnaModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaModelo.DataPropertyName = "Modelo";
            this.columnaModelo.Frozen = true;
            this.columnaModelo.HeaderText = "Modelo";
            this.columnaModelo.Name = "columnaModelo";
            this.columnaModelo.ReadOnly = true;
            this.columnaModelo.Width = 66;
            // 
            // columnaMarca
            // 
            this.columnaMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnaMarca.DataPropertyName = "Marca";
            this.columnaMarca.Frozen = true;
            this.columnaMarca.HeaderText = "Marca";
            this.columnaMarca.Name = "columnaMarca";
            this.columnaMarca.ReadOnly = true;
            this.columnaMarca.Width = 66;
            // 
            // columnaPatente
            // 
            this.columnaPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnaPatente.DataPropertyName = "Patente";
            this.columnaPatente.HeaderText = "Patente";
            this.columnaPatente.Name = "columnaPatente";
            this.columnaPatente.ReadOnly = true;
            this.columnaPatente.Width = 69;
            // 
            // columnaTipoServicio
            // 
            this.columnaTipoServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaTipoServicio.DataPropertyName = "TipoDeServicio";
            this.columnaTipoServicio.HeaderText = "Tipo de Servicio";
            this.columnaTipoServicio.Name = "columnaTipoServicio";
            this.columnaTipoServicio.ReadOnly = true;
            // 
            // columnaHabilitado
            // 
            this.columnaHabilitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaHabilitado.DataPropertyName = "Habilitado";
            this.columnaHabilitado.HeaderText = "Habilitado";
            this.columnaHabilitado.Name = "columnaHabilitado";
            this.columnaHabilitado.ReadOnly = true;
            // 
            // columnaKGSDisponibles
            // 
            this.columnaKGSDisponibles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaKGSDisponibles.DataPropertyName = "KGSDisponibles";
            this.columnaKGSDisponibles.HeaderText = "Kgs. Disponibles";
            this.columnaKGSDisponibles.Name = "columnaKGSDisponibles";
            this.columnaKGSDisponibles.ReadOnly = true;
            // 
            // columnasAsientosDisponibles
            // 
            this.columnasAsientosDisponibles.DataPropertyName = "AsientosDisponibles";
            this.columnasAsientosDisponibles.HeaderText = "Asientos Disponibles";
            this.columnasAsientosDisponibles.Name = "columnasAsientosDisponibles";
            this.columnasAsientosDisponibles.ReadOnly = true;
            // 
            // columnaFechaAlta
            // 
            this.columnaFechaAlta.DataPropertyName = "FechaAlta";
            this.columnaFechaAlta.HeaderText = "Fecha de Alta";
            this.columnaFechaAlta.Name = "columnaFechaAlta";
            this.columnaFechaAlta.ReadOnly = true;
            this.columnaFechaAlta.Visible = false;
            // 
            // columnaFechaBajaDefinitiva
            // 
            this.columnaFechaBajaDefinitiva.DataPropertyName = "FechaBajaDefinitiva";
            this.columnaFechaBajaDefinitiva.HeaderText = "FechaBajaDefinitiva";
            this.columnaFechaBajaDefinitiva.Name = "columnaFechaBajaDefinitiva";
            this.columnaFechaBajaDefinitiva.ReadOnly = true;
            this.columnaFechaBajaDefinitiva.Visible = false;
            // 
            // columnaNumereo
            // 
            this.columnaNumereo.DataPropertyName = "Numero";
            this.columnaNumereo.HeaderText = "Numero";
            this.columnaNumereo.Name = "columnaNumereo";
            this.columnaNumereo.ReadOnly = true;
            this.columnaNumereo.Visible = false;
            // 
            // columnaFueraDeServicio
            // 
            this.columnaFueraDeServicio.DataPropertyName = "FueraDeServicio";
            this.columnaFueraDeServicio.HeaderText = "Fuera de Servicio";
            this.columnaFueraDeServicio.Name = "columnaFueraDeServicio";
            this.columnaFueraDeServicio.ReadOnly = true;
            this.columnaFueraDeServicio.Visible = false;
            // 
            // columnaFechaFueraDeServicio
            // 
            this.columnaFechaFueraDeServicio.DataPropertyName = "FechaFueraDeServicio";
            this.columnaFechaFueraDeServicio.HeaderText = "Fecha  Puesta en Fuera De Servicio";
            this.columnaFechaFueraDeServicio.Name = "columnaFechaFueraDeServicio";
            this.columnaFechaFueraDeServicio.ReadOnly = true;
            this.columnaFechaFueraDeServicio.Visible = false;
            // 
            // columnaFechaReinicioDeServicio
            // 
            this.columnaFechaReinicioDeServicio.DataPropertyName = "FechaReinicioDeServicio";
            this.columnaFechaReinicioDeServicio.HeaderText = "Fecha Reinicio De Servicio";
            this.columnaFechaReinicioDeServicio.Name = "columnaFechaReinicioDeServicio";
            this.columnaFechaReinicioDeServicio.ReadOnly = true;
            this.columnaFechaReinicioDeServicio.Visible = false;
            // 
            // columnaBajaDefinitiva
            // 
            this.columnaBajaDefinitiva.DataPropertyName = "BajaDefinitiva";
            this.columnaBajaDefinitiva.HeaderText = "Está de Baja Definitiva";
            this.columnaBajaDefinitiva.Name = "columnaBajaDefinitiva";
            this.columnaBajaDefinitiva.ReadOnly = true;
            this.columnaBajaDefinitiva.Visible = false;
            // 
            // columnaButacas
            // 
            this.columnaButacas.DataPropertyName = "Butacas";
            this.columnaButacas.HeaderText = "Butacas ";
            this.columnaButacas.Name = "columnaButacas";
            this.columnaButacas.ReadOnly = true;
            this.columnaButacas.Visible = false;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(520, 267);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 23);
            this.botonNuevo.TabIndex = 3;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(601, 267);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 4;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(18, 52);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Marca";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(13, 22);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 0;
            this.labelModelo.Text = "Modelo";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(61, 18);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(161, 20);
            this.textModelo.TabIndex = 8;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(61, 48);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(161, 20);
            this.textMarca.TabIndex = 9;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(231, 22);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 10;
            this.labelEstado.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(278, 18);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 11;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // AbmMicrosWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 301);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.grillaMicros);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbmMicrosWindow";
            this.Text = "ABM Micros";
            this.Load += new System.EventHandler(this.AbmMicros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMicros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox comboTipoServicio;
        private System.Windows.Forms.DataGridView grillaMicros;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoServicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnaHabilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaKGSDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnasAsientosDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaBajaDefinitiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNumereo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnaFueraDeServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaFueraDeServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaReinicioDeServicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnaBajaDefinitiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaButacas;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label labelEstado;
    }
}