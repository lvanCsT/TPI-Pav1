namespace TPI
{
    partial class AltaEstado
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
            this.lblCodEstado = new System.Windows.Forms.Label();
            this.gbAltaEstados = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mtbCodEstado = new System.Windows.Forms.MaskedTextBox();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.dgbEstados = new System.Windows.Forms.DataGridView();
            this.CodigoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAltaEstado = new System.Windows.Forms.Button();
            this.btnBajaEstado = new System.Windows.Forms.Button();
            this.gbAltaEstados.SuspendLayout();
            this.gbEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodEstado
            // 
            this.lblCodEstado.AutoSize = true;
            this.lblCodEstado.Location = new System.Drawing.Point(6, 36);
            this.lblCodEstado.Name = "lblCodEstado";
            this.lblCodEstado.Size = new System.Drawing.Size(94, 13);
            this.lblCodEstado.TabIndex = 40;
            this.lblCodEstado.Text = "Código de Estado:";
            this.lblCodEstado.Click += new System.EventHandler(this.lblCodPrestacion_Click);
            // 
            // gbAltaEstados
            // 
            this.gbAltaEstados.Controls.Add(this.btnLimpiar);
            this.gbAltaEstados.Controls.Add(this.rtbDescripcion);
            this.gbAltaEstados.Controls.Add(this.lblDescripcion);
            this.gbAltaEstados.Controls.Add(this.tbNombre);
            this.gbAltaEstados.Controls.Add(this.lblNombre);
            this.gbAltaEstados.Controls.Add(this.mtbCodEstado);
            this.gbAltaEstados.Controls.Add(this.lblCodEstado);
            this.gbAltaEstados.Location = new System.Drawing.Point(23, 12);
            this.gbAltaEstados.Name = "gbAltaEstados";
            this.gbAltaEstados.Size = new System.Drawing.Size(290, 258);
            this.gbAltaEstados.TabIndex = 41;
            this.gbAltaEstados.TabStop = false;
            this.gbAltaEstados.Text = "Nuevo Estado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(71, 213);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(109, 122);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(150, 60);
            this.rtbDescripcion.TabIndex = 47;
            this.rtbDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(109, 75);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(150, 20);
            this.tbNombre.TabIndex = 44;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // mtbCodEstado
            // 
            this.mtbCodEstado.Location = new System.Drawing.Point(109, 36);
            this.mtbCodEstado.Mask = "9999";
            this.mtbCodEstado.Name = "mtbCodEstado";
            this.mtbCodEstado.Size = new System.Drawing.Size(150, 20);
            this.mtbCodEstado.TabIndex = 42;
            this.mtbCodEstado.ValidatingType = typeof(int);
            // 
            // gbEstados
            // 
            this.gbEstados.Controls.Add(this.dgbEstados);
            this.gbEstados.Location = new System.Drawing.Point(319, 12);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(347, 258);
            this.gbEstados.TabIndex = 42;
            this.gbEstados.TabStop = false;
            this.gbEstados.Text = "Listado Estados";
            // 
            // dgbEstados
            // 
            this.dgbEstados.AllowUserToAddRows = false;
            this.dgbEstados.AllowUserToDeleteRows = false;
            this.dgbEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoEstado,
            this.Nombre,
            this.Descripción});
            this.dgbEstados.Location = new System.Drawing.Point(26, 36);
            this.dgbEstados.Name = "dgbEstados";
            this.dgbEstados.ReadOnly = true;
            this.dgbEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbEstados.Size = new System.Drawing.Size(304, 200);
            this.dgbEstados.TabIndex = 0;
            this.dgbEstados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEstados_CellClick);
            // 
            // CodigoEstado
            // 
            this.CodigoEstado.DataPropertyName = "CodEstado";
            this.CodigoEstado.HeaderText = "Código";
            this.CodigoEstado.Name = "CodigoEstado";
            this.CodigoEstado.ReadOnly = true;
            this.CodigoEstado.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 70;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 130;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(32, 288);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAltaEstado
            // 
            this.btnAltaEstado.Location = new System.Drawing.Point(132, 288);
            this.btnAltaEstado.Name = "btnAltaEstado";
            this.btnAltaEstado.Size = new System.Drawing.Size(75, 23);
            this.btnAltaEstado.TabIndex = 44;
            this.btnAltaEstado.Text = "Alta Estado";
            this.btnAltaEstado.UseVisualStyleBackColor = true;
            this.btnAltaEstado.Click += new System.EventHandler(this.btnAltaEstado_Click);
            // 
            // btnBajaEstado
            // 
            this.btnBajaEstado.Location = new System.Drawing.Point(345, 288);
            this.btnBajaEstado.Name = "btnBajaEstado";
            this.btnBajaEstado.Size = new System.Drawing.Size(85, 23);
            this.btnBajaEstado.TabIndex = 45;
            this.btnBajaEstado.Text = "Baja Estado";
            this.btnBajaEstado.UseVisualStyleBackColor = true;
            this.btnBajaEstado.Click += new System.EventHandler(this.btnBajaEstado_Click);
            // 
            // AltaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 353);
            this.Controls.Add(this.btnBajaEstado);
            this.Controls.Add(this.btnAltaEstado);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbEstados);
            this.Controls.Add(this.gbAltaEstados);
            this.Name = "AltaEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estados";
            this.Load += new System.EventHandler(this.AltaEstado_Load);
            this.gbAltaEstados.ResumeLayout(false);
            this.gbAltaEstados.PerformLayout();
            this.gbEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodEstado;
        private System.Windows.Forms.GroupBox gbAltaEstados;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mtbCodEstado;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.DataGridView dgbEstados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAltaEstado;
        private System.Windows.Forms.Button btnBajaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
    }
}