namespace TPI
{
    partial class AltaCiudades
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
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.grillaCiudades = new System.Windows.Forms.DataGridView();
            this.Id_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(169, 290);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(75, 35);
            this.btnLimpiarDatos.TabIndex = 11;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // grillaCiudades
            // 
            this.grillaCiudades.AllowUserToAddRows = false;
            this.grillaCiudades.AllowUserToDeleteRows = false;
            this.grillaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Ciudad,
            this.Nombre,
            this.Id_Departamento});
            this.grillaCiudades.Location = new System.Drawing.Point(27, 113);
            this.grillaCiudades.Name = "grillaCiudades";
            this.grillaCiudades.ReadOnly = true;
            this.grillaCiudades.Size = new System.Drawing.Size(348, 150);
            this.grillaCiudades.TabIndex = 10;
            this.grillaCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCiudades_CellClick);
            // 
            // Id_Ciudad
            // 
            this.Id_Ciudad.DataPropertyName = "Id_Ciudad";
            this.Id_Ciudad.HeaderText = "Id_Ciudad";
            this.Id_Ciudad.Name = "Id_Ciudad";
            this.Id_Ciudad.ReadOnly = true;
            this.Id_Ciudad.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Id_Departamento
            // 
            this.Id_Departamento.DataPropertyName = "Id_Departamento";
            this.Id_Departamento.HeaderText = "Id_Departamento";
            this.Id_Departamento.Name = "Id_Departamento";
            this.Id_Departamento.ReadOnly = true;
            this.Id_Departamento.Width = 80;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(24, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCiudad.Location = new System.Drawing.Point(300, 290);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(75, 35);
            this.btnAgregarCiudad.TabIndex = 7;
            this.btnAgregarCiudad.Text = "Agregar ciudad";
            this.btnAgregarCiudad.UseVisualStyleBackColor = true;
            this.btnAgregarCiudad.Click += new System.EventHandler(this.btnAgregarCiudad_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Blue;
            this.lbltitulo.Location = new System.Drawing.Point(142, 6);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(84, 20);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Ciudades";
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Location = new System.Drawing.Point(548, 195);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.ReadOnly = true;
            this.txtIdCiudad.Size = new System.Drawing.Size(62, 20);
            this.txtIdCiudad.TabIndex = 43;
            this.txtIdCiudad.Text = "0";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.Black;
            this.lblCiudad.Location = new System.Drawing.Point(421, 195);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(80, 17);
            this.lblCiudad.TabIndex = 42;
            this.lblCiudad.Text = "Id_Ciudad";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(40, 290);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 36);
            this.btnActualizar.TabIndex = 41;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(490, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar Ciudad";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(146, 79);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamento.TabIndex = 45;
            // 
            // AltaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 347);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.grillaCiudades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregarCiudad);
            this.Controls.Add(this.lbltitulo);
            this.Name = "AltaCiudades";
            this.Text = "AltaCiudades";
            this.Load += new System.EventHandler(this.AltaCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.DataGridView grillaCiudades;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarCiudad;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Departamento;
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartamento;
    }
}