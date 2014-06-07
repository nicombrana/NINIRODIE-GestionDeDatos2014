namespace FrbaBus.View.Abm_Micro
{
    partial class MicroWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicroWindow));
            this.tabControlMicro = new System.Windows.Forms.TabControl();
            this.tabInfoBasica = new System.Windows.Forms.TabPage();
            this.comboTipoServicio = new System.Windows.Forms.ComboBox();
            this.datePickerFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.textKgsDisponibles = new System.Windows.Forms.TextBox();
            this.textPatente = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.labelFechaAlta = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelKgsDisponibles = new System.Windows.Forms.Label();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.labelPatente = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.tabEstado = new System.Windows.Forms.TabPage();
            this.panelHabilitaciones = new System.Windows.Forms.Panel();
            this.datePickerReincorporacion = new System.Windows.Forms.DateTimePicker();
            this.datePickerBaja = new System.Windows.Forms.DateTimePicker();
            this.labelFechaReincorporacio = new System.Windows.Forms.Label();
            this.labelFechaBaja = new System.Windows.Forms.Label();
            this.radioBajaDefinitiva = new System.Windows.Forms.RadioButton();
            this.radioFueraDeServicio = new System.Windows.Forms.RadioButton();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.tabButacas = new System.Windows.Forms.TabPage();
            this.gridButacas = new System.Windows.Forms.DataGridView();
            this.labelHeader = new System.Windows.Forms.Label();
            this.botonOk = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.tabControlMicro.SuspendLayout();
            this.tabInfoBasica.SuspendLayout();
            this.tabEstado.SuspendLayout();
            this.panelHabilitaciones.SuspendLayout();
            this.tabButacas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridButacas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMicro
            // 
            this.tabControlMicro.Controls.Add(this.tabInfoBasica);
            this.tabControlMicro.Controls.Add(this.tabEstado);
            this.tabControlMicro.Controls.Add(this.tabButacas);
            this.tabControlMicro.Location = new System.Drawing.Point(12, 35);
            this.tabControlMicro.Name = "tabControlMicro";
            this.tabControlMicro.SelectedIndex = 0;
            this.tabControlMicro.Size = new System.Drawing.Size(321, 211);
            this.tabControlMicro.TabIndex = 0;
            // 
            // tabInfoBasica
            // 
            this.tabInfoBasica.Controls.Add(this.comboTipoServicio);
            this.tabInfoBasica.Controls.Add(this.datePickerFechaAlta);
            this.tabInfoBasica.Controls.Add(this.textKgsDisponibles);
            this.tabInfoBasica.Controls.Add(this.textPatente);
            this.tabInfoBasica.Controls.Add(this.textModelo);
            this.tabInfoBasica.Controls.Add(this.textMarca);
            this.tabInfoBasica.Controls.Add(this.textNumero);
            this.tabInfoBasica.Controls.Add(this.labelFechaAlta);
            this.tabInfoBasica.Controls.Add(this.labelNumero);
            this.tabInfoBasica.Controls.Add(this.labelKgsDisponibles);
            this.tabInfoBasica.Controls.Add(this.labelTipoServicio);
            this.tabInfoBasica.Controls.Add(this.labelPatente);
            this.tabInfoBasica.Controls.Add(this.labelModelo);
            this.tabInfoBasica.Controls.Add(this.labelMarca);
            this.tabInfoBasica.Location = new System.Drawing.Point(4, 22);
            this.tabInfoBasica.Name = "tabInfoBasica";
            this.tabInfoBasica.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoBasica.Size = new System.Drawing.Size(313, 185);
            this.tabInfoBasica.TabIndex = 0;
            this.tabInfoBasica.Text = "Informacion Basica";
            this.tabInfoBasica.UseVisualStyleBackColor = true;
            // 
            // comboTipoServicio
            // 
            this.comboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoServicio.FormattingEnabled = true;
            this.comboTipoServicio.Location = new System.Drawing.Point(108, 131);
            this.comboTipoServicio.Name = "comboTipoServicio";
            this.comboTipoServicio.Size = new System.Drawing.Size(190, 21);
            this.comboTipoServicio.TabIndex = 15;
            // 
            // datePickerFechaAlta
            // 
            this.datePickerFechaAlta.CustomFormat = "MMMM dd, yyyy - dddd";
            this.datePickerFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerFechaAlta.Location = new System.Drawing.Point(108, 35);
            this.datePickerFechaAlta.Name = "datePickerFechaAlta";
            this.datePickerFechaAlta.Size = new System.Drawing.Size(190, 20);
            this.datePickerFechaAlta.TabIndex = 14;
            this.datePickerFechaAlta.Value = new System.DateTime(2013, 6, 16, 0, 0, 0, 0);
            // 
            // textKgsDisponibles
            // 
            this.textKgsDisponibles.Location = new System.Drawing.Point(108, 156);
            this.textKgsDisponibles.Name = "textKgsDisponibles";
            this.textKgsDisponibles.Size = new System.Drawing.Size(190, 20);
            this.textKgsDisponibles.TabIndex = 12;
            // 
            // textPatente
            // 
            this.textPatente.Location = new System.Drawing.Point(108, 107);
            this.textPatente.Name = "textPatente";
            this.textPatente.Size = new System.Drawing.Size(190, 20);
            this.textPatente.TabIndex = 11;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(108, 83);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(190, 20);
            this.textModelo.TabIndex = 10;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(108, 59);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(190, 20);
            this.textMarca.TabIndex = 9;
            // 
            // textNumero
            // 
            this.textNumero.Enabled = false;
            this.textNumero.Location = new System.Drawing.Point(108, 11);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(190, 20);
            this.textNumero.TabIndex = 7;
            // 
            // labelFechaAlta
            // 
            this.labelFechaAlta.AutoSize = true;
            this.labelFechaAlta.Location = new System.Drawing.Point(26, 38);
            this.labelFechaAlta.Name = "labelFechaAlta";
            this.labelFechaAlta.Size = new System.Drawing.Size(73, 13);
            this.labelFechaAlta.TabIndex = 6;
            this.labelFechaAlta.Text = "Fecha de Alta";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(55, 14);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 5;
            this.labelNumero.Text = "Numero";
            // 
            // labelKgsDisponibles
            // 
            this.labelKgsDisponibles.AutoSize = true;
            this.labelKgsDisponibles.Location = new System.Drawing.Point(14, 158);
            this.labelKgsDisponibles.Name = "labelKgsDisponibles";
            this.labelKgsDisponibles.Size = new System.Drawing.Size(85, 13);
            this.labelKgsDisponibles.TabIndex = 4;
            this.labelKgsDisponibles.Text = "Kgs. Disponibles";
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(15, 134);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.labelTipoServicio.TabIndex = 3;
            this.labelTipoServicio.Text = "Tipo de Servicio";
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Location = new System.Drawing.Point(55, 110);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(44, 13);
            this.labelPatente.TabIndex = 2;
            this.labelPatente.Text = "Patente";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(57, 86);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(62, 62);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca";
            // 
            // tabEstado
            // 
            this.tabEstado.Controls.Add(this.panelHabilitaciones);
            this.tabEstado.Controls.Add(this.checkHabilitado);
            this.tabEstado.Location = new System.Drawing.Point(4, 22);
            this.tabEstado.Name = "tabEstado";
            this.tabEstado.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstado.Size = new System.Drawing.Size(313, 185);
            this.tabEstado.TabIndex = 1;
            this.tabEstado.Text = "Estado";
            this.tabEstado.UseVisualStyleBackColor = true;
            // 
            // panelHabilitaciones
            // 
            this.panelHabilitaciones.Controls.Add(this.datePickerReincorporacion);
            this.panelHabilitaciones.Controls.Add(this.datePickerBaja);
            this.panelHabilitaciones.Controls.Add(this.labelFechaReincorporacio);
            this.panelHabilitaciones.Controls.Add(this.labelFechaBaja);
            this.panelHabilitaciones.Controls.Add(this.radioBajaDefinitiva);
            this.panelHabilitaciones.Controls.Add(this.radioFueraDeServicio);
            this.panelHabilitaciones.Location = new System.Drawing.Point(11, 33);
            this.panelHabilitaciones.Name = "panelHabilitaciones";
            this.panelHabilitaciones.Size = new System.Drawing.Size(289, 124);
            this.panelHabilitaciones.TabIndex = 1;
            // 
            // datePickerReincorporacion
            // 
            this.datePickerReincorporacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerReincorporacion.Location = new System.Drawing.Point(152, 95);
            this.datePickerReincorporacion.Name = "datePickerReincorporacion";
            this.datePickerReincorporacion.Size = new System.Drawing.Size(129, 20);
            this.datePickerReincorporacion.TabIndex = 6;
            // 
            // datePickerBaja
            // 
            this.datePickerBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerBaja.Location = new System.Drawing.Point(152, 66);
            this.datePickerBaja.Name = "datePickerBaja";
            this.datePickerBaja.Size = new System.Drawing.Size(129, 20);
            this.datePickerBaja.TabIndex = 5;
            // 
            // labelFechaReincorporacio
            // 
            this.labelFechaReincorporacio.AutoSize = true;
            this.labelFechaReincorporacio.Location = new System.Drawing.Point(12, 99);
            this.labelFechaReincorporacio.Name = "labelFechaReincorporacio";
            this.labelFechaReincorporacio.Size = new System.Drawing.Size(133, 13);
            this.labelFechaReincorporacio.TabIndex = 4;
            this.labelFechaReincorporacio.Text = "Fecha de Reincorporación";
            // 
            // labelFechaBaja
            // 
            this.labelFechaBaja.AutoSize = true;
            this.labelFechaBaja.Location = new System.Drawing.Point(67, 70);
            this.labelFechaBaja.Name = "labelFechaBaja";
            this.labelFechaBaja.Size = new System.Drawing.Size(78, 13);
            this.labelFechaBaja.TabIndex = 2;
            this.labelFechaBaja.Text = "Fecha De Baja";
            // 
            // radioBajaDefinitiva
            // 
            this.radioBajaDefinitiva.AutoSize = true;
            this.radioBajaDefinitiva.Location = new System.Drawing.Point(37, 35);
            this.radioBajaDefinitiva.Name = "radioBajaDefinitiva";
            this.radioBajaDefinitiva.Size = new System.Drawing.Size(93, 17);
            this.radioBajaDefinitiva.TabIndex = 1;
            this.radioBajaDefinitiva.TabStop = true;
            this.radioBajaDefinitiva.Text = "Baja Definitiva";
            this.radioBajaDefinitiva.UseVisualStyleBackColor = true;
            this.radioBajaDefinitiva.CheckedChanged += new System.EventHandler(this.radioBajaDefinitiva_CheckedChanged);
            // 
            // radioFueraDeServicio
            // 
            this.radioFueraDeServicio.AutoSize = true;
            this.radioFueraDeServicio.Location = new System.Drawing.Point(37, 12);
            this.radioFueraDeServicio.Name = "radioFueraDeServicio";
            this.radioFueraDeServicio.Size = new System.Drawing.Size(110, 17);
            this.radioFueraDeServicio.TabIndex = 0;
            this.radioFueraDeServicio.TabStop = true;
            this.radioFueraDeServicio.Text = "Fuera De Servicio";
            this.radioFueraDeServicio.UseVisualStyleBackColor = true;
            this.radioFueraDeServicio.CheckedChanged += new System.EventHandler(this.radioFueraDeServicio_CheckedChanged);
            // 
            // checkHabilitado
            // 
            this.checkHabilitado.AutoSize = true;
            this.checkHabilitado.Location = new System.Drawing.Point(6, 6);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkHabilitado.TabIndex = 0;
            this.checkHabilitado.Text = "Habilitado";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            this.checkHabilitado.CheckedChanged += new System.EventHandler(this.checkHabilitado_CheckedChanged);
            // 
            // tabButacas
            // 
            this.tabButacas.Controls.Add(this.gridButacas);
            this.tabButacas.Location = new System.Drawing.Point(4, 22);
            this.tabButacas.Name = "tabButacas";
            this.tabButacas.Padding = new System.Windows.Forms.Padding(3);
            this.tabButacas.Size = new System.Drawing.Size(313, 185);
            this.tabButacas.TabIndex = 2;
            this.tabButacas.Text = "Butacas";
            this.tabButacas.UseVisualStyleBackColor = true;
            // 
            // gridButacas
            // 
            this.gridButacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridButacas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridButacas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridButacas.Location = new System.Drawing.Point(3, 3);
            this.gridButacas.Name = "gridButacas";
            this.gridButacas.RowHeadersVisible = false;
            this.gridButacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridButacas.Size = new System.Drawing.Size(307, 179);
            this.gridButacas.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(57, 23);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Micro";
            // 
            // botonOk
            // 
            this.botonOk.Location = new System.Drawing.Point(177, 252);
            this.botonOk.Name = "botonOk";
            this.botonOk.Size = new System.Drawing.Size(75, 23);
            this.botonOk.TabIndex = 2;
            this.botonOk.Text = "Ok";
            this.botonOk.UseVisualStyleBackColor = true;
            this.botonOk.Click += new System.EventHandler(this.botonOk_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(258, 252);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // MicroWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 278);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonOk);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.tabControlMicro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MicroWindow";
            this.Text = "MicroWindow";
            this.Load += new System.EventHandler(this.MicroWindow_Load);
            this.tabControlMicro.ResumeLayout(false);
            this.tabInfoBasica.ResumeLayout(false);
            this.tabInfoBasica.PerformLayout();
            this.tabEstado.ResumeLayout(false);
            this.tabEstado.PerformLayout();
            this.panelHabilitaciones.ResumeLayout(false);
            this.panelHabilitaciones.PerformLayout();
            this.tabButacas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridButacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMicro;
        private System.Windows.Forms.TabPage tabInfoBasica;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TabPage tabEstado;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelKgsDisponibles;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.TextBox textKgsDisponibles;
        private System.Windows.Forms.TextBox textPatente;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label labelFechaAlta;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.DateTimePicker datePickerFechaAlta;
        private System.Windows.Forms.ComboBox comboTipoServicio;
        private System.Windows.Forms.Button botonOk;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.CheckBox checkHabilitado;
        private System.Windows.Forms.Panel panelHabilitaciones;
        private System.Windows.Forms.RadioButton radioBajaDefinitiva;
        private System.Windows.Forms.RadioButton radioFueraDeServicio;
        private System.Windows.Forms.Label labelFechaReincorporacio;
        private System.Windows.Forms.Label labelFechaBaja;
        private System.Windows.Forms.DateTimePicker datePickerReincorporacion;
        private System.Windows.Forms.DateTimePicker datePickerBaja;
        private System.Windows.Forms.TabPage tabButacas;
        private System.Windows.Forms.DataGridView gridButacas;

    }
}