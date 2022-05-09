namespace TPI.ABMs
{
    partial class AltaDepartamento
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
            this.gbAltaDepartamento = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.mtbIdDepartamento = new System.Windows.Forms.MaskedTextBox();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.gbDepartamentos = new System.Windows.Forms.GroupBox();
            this.dgbDepartamentos = new System.Windows.Forms.DataGridView();
            this.IdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAltaDepartamento = new System.Windows.Forms.Button();
            this.btnBajaDepartamento = new System.Windows.Forms.Button();
            this.gbAltaDepartamento.SuspendLayout();
            this.gbDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAltaDepartamento
            // 
            this.gbAltaDepartamento.Controls.Add(this.btnLimpiar);
            this.gbAltaDepartamento.Controls.Add(this.tbNombre);
            this.gbAltaDepartamento.Controls.Add(this.lblNombre);
            this.gbAltaDepartamento.Controls.Add(this.mtbIdDepartamento);
            this.gbAltaDepartamento.Controls.Add(this.lblIdDepartamento);
            this.gbAltaDepartamento.Location = new System.Drawing.Point(12, 12);
            this.gbAltaDepartamento.Name = "gbAltaDepartamento";
            this.gbAltaDepartamento.Size = new System.Drawing.Size(231, 184);
            this.gbAltaDepartamento.TabIndex = 42;
            this.gbAltaDepartamento.TabStop = false;
            this.gbAltaDepartamento.Text = "Nuevo Departamento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(73, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(109, 75);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(91, 20);
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
            // mtbIdDepartamento
            // 
            this.mtbIdDepartamento.Enabled = false;
            this.mtbIdDepartamento.Location = new System.Drawing.Point(109, 36);
            this.mtbIdDepartamento.Mask = "9999";
            this.mtbIdDepartamento.Name = "mtbIdDepartamento";
            this.mtbIdDepartamento.Size = new System.Drawing.Size(91, 20);
            this.mtbIdDepartamento.TabIndex = 42;
            this.mtbIdDepartamento.ValidatingType = typeof(int);
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Location = new System.Drawing.Point(6, 36);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(91, 13);
            this.lblIdDepartamento.TabIndex = 40;
            this.lblIdDepartamento.Text = "ID Departamento:";
            // 
            // gbDepartamentos
            // 
            this.gbDepartamentos.Controls.Add(this.dgbDepartamentos);
            this.gbDepartamentos.Location = new System.Drawing.Point(249, 12);
            this.gbDepartamentos.Name = "gbDepartamentos";
            this.gbDepartamentos.Size = new System.Drawing.Size(200, 184);
            this.gbDepartamentos.TabIndex = 43;
            this.gbDepartamentos.TabStop = false;
            this.gbDepartamentos.Text = "Listado Departamentos";
            // 
            // dgbDepartamentos
            // 
            this.dgbDepartamentos.AllowUserToAddRows = false;
            this.dgbDepartamentos.AllowUserToDeleteRows = false;
            this.dgbDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDepartamento,
            this.Nombre});
            this.dgbDepartamentos.Location = new System.Drawing.Point(26, 36);
            this.dgbDepartamentos.Name = "dgbDepartamentos";
            this.dgbDepartamentos.ReadOnly = true;
            this.dgbDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbDepartamentos.Size = new System.Drawing.Size(148, 129);
            this.dgbDepartamentos.TabIndex = 0;
            this.dgbDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbDepartamentos_CellClick);
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.DataPropertyName = "Id_Departamento";
            this.IdDepartamento.HeaderText = "ID";
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.ReadOnly = true;
            this.IdDepartamento.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 75;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(21, 212);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 44;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAltaDepartamento
            // 
            this.btnAltaDepartamento.Location = new System.Drawing.Point(121, 212);
            this.btnAltaDepartamento.Name = "btnAltaDepartamento";
            this.btnAltaDepartamento.Size = new System.Drawing.Size(106, 23);
            this.btnAltaDepartamento.TabIndex = 45;
            this.btnAltaDepartamento.Text = "Alta Departamento";
            this.btnAltaDepartamento.UseVisualStyleBackColor = true;
            this.btnAltaDepartamento.Click += new System.EventHandler(this.buttonAltaAfiliado_Click);
            // 
            // btnBajaDepartamento
            // 
            this.btnBajaDepartamento.Location = new System.Drawing.Point(275, 212);
            this.btnBajaDepartamento.Name = "btnBajaDepartamento";
            this.btnBajaDepartamento.Size = new System.Drawing.Size(110, 23);
            this.btnBajaDepartamento.TabIndex = 46;
            this.btnBajaDepartamento.Text = "Baja Departamento";
            this.btnBajaDepartamento.UseVisualStyleBackColor = true;
            this.btnBajaDepartamento.Click += new System.EventHandler(this.btnBajaDepartamento_Click);
            // 
            // AltaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBajaDepartamento);
            this.Controls.Add(this.btnAltaDepartamento);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbDepartamentos);
            this.Controls.Add(this.gbAltaDepartamento);
            this.Name = "AltaDepartamento";
            this.Text = "Alta Departamento";
            this.Load += new System.EventHandler(this.AltaDepartamento_Load);
            this.gbAltaDepartamento.ResumeLayout(false);
            this.gbAltaDepartamento.PerformLayout();
            this.gbDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAltaDepartamento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mtbIdDepartamento;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.GroupBox gbDepartamentos;
        private System.Windows.Forms.DataGridView dgbDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAltaDepartamento;
        private System.Windows.Forms.Button btnBajaDepartamento;
    }
}