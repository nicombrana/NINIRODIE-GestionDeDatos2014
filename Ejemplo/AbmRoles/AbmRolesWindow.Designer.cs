namespace FrbaBus.View.Abm_Roles
{
    partial class AbmRolesWindow
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.grillaRoles = new System.Windows.Forms.DataGridView();
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 34);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(76, 27);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(183, 20);
            this.textNombre.TabIndex = 1;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(177, 55);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(81, 27);
            this.botonLimpiar.TabIndex = 2;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // grillaRoles
            // 
            this.grillaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRoles.EnableHeadersVisualStyles = false;
            this.grillaRoles.Location = new System.Drawing.Point(15, 88);
            this.grillaRoles.Name = "grillaRoles";
            this.grillaRoles.ReadOnly = true;
            this.grillaRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaRoles.Size = new System.Drawing.Size(243, 120);
            this.grillaRoles.TabIndex = 3;
            this.grillaRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRoles_CellClick);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(88, 216);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(76, 24);
            this.botonNuevo.TabIndex = 4;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(182, 216);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 24);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // AbmRolesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 262);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.grillaRoles);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "AbmRolesWindow";
            this.Text = "AbmRolesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.grillaRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView grillaRoles;
        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonEditar;
    }
}