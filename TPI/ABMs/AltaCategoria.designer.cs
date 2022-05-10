namespace TPI
{
    partial class AltaCategoria
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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grillaCategoria = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodDesc = new System.Windows.Forms.TextBox();
            this.CodCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.Location = new System.Drawing.Point(261, 296);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiarDatos.TabIndex = 13;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(365, 296);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 36);
            this.btnAgregarCategoria.TabIndex = 12;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(189, 61);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(252, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(59, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 17);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // grillaCategoria
            // 
            this.grillaCategoria.AllowUserToAddRows = false;
            this.grillaCategoria.AllowUserToDeleteRows = false;
            this.grillaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCategoria,
            this.Descripcion});
            this.grillaCategoria.Location = new System.Drawing.Point(62, 112);
            this.grillaCategoria.Name = "grillaCategoria";
            this.grillaCategoria.ReadOnly = true;
            this.grillaCategoria.Size = new System.Drawing.Size(379, 150);
            this.grillaCategoria.TabIndex = 9;
            this.grillaCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCategoria_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(524, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Categoria";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(82, 293);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 36);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(455, 221);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(121, 17);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "CodDescripcion";
            // 
            // txtCodDesc
            // 
            this.txtCodDesc.Location = new System.Drawing.Point(582, 221);
            this.txtCodDesc.Name = "txtCodDesc";
            this.txtCodDesc.ReadOnly = true;
            this.txtCodDesc.Size = new System.Drawing.Size(62, 20);
            this.txtCodDesc.TabIndex = 39;
            this.txtCodDesc.Text = "0";
            // 
            // CodCategoria
            // 
            this.CodCategoria.DataPropertyName = "CodCategoria";
            this.CodCategoria.HeaderText = "CodCategoria";
            this.CodCategoria.Name = "CodCategoria";
            this.CodCategoria.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Blue;
            this.lbltitulo.Location = new System.Drawing.Point(193, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(96, 20);
            this.lbltitulo.TabIndex = 8;
            this.lbltitulo.Text = "Categorias";
            // 
            // AltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 341);
            this.Controls.Add(this.txtCodDesc);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.grillaCategoria);
            this.Controls.Add(this.lbltitulo);
            this.Name = "AltaCategoria";
            this.Text = "AltaCategoria";
            this.Load += new System.EventHandler(this.AltaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView grillaCategoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lbltitulo;
    }
}