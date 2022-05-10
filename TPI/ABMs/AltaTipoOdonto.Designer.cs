namespace TPI.ABMs
{
    partial class AltaTipoOdonto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrillaTipoOdonto = new System.Windows.Forms.DataGridView();
            this.lblTipoOdonto = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.tipoOdontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTipoOdonto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTipoOdonto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtTipoOdonto);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Controls.Add(this.lblTipoOdonto);
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Tipo Odontologo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GrillaTipoOdonto);
            this.groupBox2.Location = new System.Drawing.Point(279, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Tipo de Odontologos";
            // 
            // GrillaTipoOdonto
            // 
            this.GrillaTipoOdonto.AllowUserToAddRows = false;
            this.GrillaTipoOdonto.AllowUserToDeleteRows = false;
            this.GrillaTipoOdonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaTipoOdonto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoOdontologo,
            this.nombre});
            this.GrillaTipoOdonto.Location = new System.Drawing.Point(6, 19);
            this.GrillaTipoOdonto.Name = "GrillaTipoOdonto";
            this.GrillaTipoOdonto.ReadOnly = true;
            this.GrillaTipoOdonto.Size = new System.Drawing.Size(245, 150);
            this.GrillaTipoOdonto.TabIndex = 0;
            this.GrillaTipoOdonto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaTipoOdonto_CellClick);
            // 
            // lblTipoOdonto
            // 
            this.lblTipoOdonto.AutoSize = true;
            this.lblTipoOdonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOdonto.Location = new System.Drawing.Point(6, 33);
            this.lblTipoOdonto.Name = "lblTipoOdonto";
            this.lblTipoOdonto.Size = new System.Drawing.Size(118, 15);
            this.lblTipoOdonto.TabIndex = 0;
            this.lblTipoOdonto.Text = "Tipo de Odontologo:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(6, 70);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(55, 15);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(82, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(25, 221);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.Location = new System.Drawing.Point(158, 221);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(80, 23);
            this.btnGuardarTipo.TabIndex = 3;
            this.btnGuardarTipo.Text = "Guardar Tipo";
            this.btnGuardarTipo.UseVisualStyleBackColor = true;
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // btnELiminar
            // 
            this.btnELiminar.Location = new System.Drawing.Point(462, 221);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(80, 23);
            this.btnELiminar.TabIndex = 4;
            this.btnELiminar.Text = "Eliminar Tipo";
            this.btnELiminar.UseVisualStyleBackColor = true;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // tipoOdontologo
            // 
            this.tipoOdontologo.DataPropertyName = "tipoOdontologo";
            this.tipoOdontologo.HeaderText = "TipoOdontologo";
            this.tipoOdontologo.Name = "tipoOdontologo";
            this.tipoOdontologo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(131, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTipoOdonto
            // 
            this.txtTipoOdonto.Location = new System.Drawing.Point(131, 33);
            this.txtTipoOdonto.Name = "txtTipoOdonto";
            this.txtTipoOdonto.ReadOnly = true;
            this.txtTipoOdonto.Size = new System.Drawing.Size(82, 20);
            this.txtTipoOdonto.TabIndex = 25;
            this.txtTipoOdonto.Text = "0";
            // 
            // AltaTipoOdonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 270);
            this.Controls.Add(this.btnELiminar);
            this.Controls.Add(this.btnGuardarTipo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaTipoOdonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Tipo Odontologo";
            this.Load += new System.EventHandler(this.AltaTipoOdonto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTipoOdonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GrillaTipoOdonto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblTipoOdonto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardarTipo;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOdontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTipoOdonto;
    }
}