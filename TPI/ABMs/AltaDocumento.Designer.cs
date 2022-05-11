namespace TPI.ABMs
{
    partial class AltaDocumento
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
            this.btnAltaDocumento = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBoxListadoDoc = new System.Windows.Forms.GroupBox();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.CodigoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDatosDoc = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.maskedCodDoc = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigoDocumento = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBajaDocumento = new System.Windows.Forms.Button();
            this.groupBoxListadoDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            this.groupBoxDatosDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAltaDocumento
            // 
            this.btnAltaDocumento.Location = new System.Drawing.Point(173, 226);
            this.btnAltaDocumento.Name = "btnAltaDocumento";
            this.btnAltaDocumento.Size = new System.Drawing.Size(75, 23);
            this.btnAltaDocumento.TabIndex = 63;
            this.btnAltaDocumento.Text = "Alta Documento";
            this.btnAltaDocumento.UseVisualStyleBackColor = true;
            this.btnAltaDocumento.Click += new System.EventHandler(this.btnAltaDocumento_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(73, 226);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 62;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBoxListadoDoc
            // 
            this.groupBoxListadoDoc.Controls.Add(this.dgvDoc);
            this.groupBoxListadoDoc.Location = new System.Drawing.Point(378, 12);
            this.groupBoxListadoDoc.Name = "groupBoxListadoDoc";
            this.groupBoxListadoDoc.Size = new System.Drawing.Size(325, 208);
            this.groupBoxListadoDoc.TabIndex = 61;
            this.groupBoxListadoDoc.TabStop = false;
            this.groupBoxListadoDoc.Text = "Listado de Documentos";
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDocumento,
            this.Nombre,
            this.Descripcion});
            this.dgvDoc.Location = new System.Drawing.Point(16, 22);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.ReadOnly = true;
            this.dgvDoc.Size = new System.Drawing.Size(294, 164);
            this.dgvDoc.TabIndex = 56;
            this.dgvDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellClick);
            // 
            // CodigoDocumento
            // 
            this.CodigoDocumento.DataPropertyName = "CodDocumento";
            this.CodigoDocumento.HeaderText = "Codigo";
            this.CodigoDocumento.Name = "CodigoDocumento";
            this.CodigoDocumento.ReadOnly = true;
            this.CodigoDocumento.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // groupBoxDatosDoc
            // 
            this.groupBoxDatosDoc.Controls.Add(this.btnLimpiar);
            this.groupBoxDatosDoc.Controls.Add(this.maskedCodDoc);
            this.groupBoxDatosDoc.Controls.Add(this.lblCodigoDocumento);
            this.groupBoxDatosDoc.Controls.Add(this.rtbDescripcion);
            this.groupBoxDatosDoc.Controls.Add(this.lblDescripcion);
            this.groupBoxDatosDoc.Controls.Add(this.tbNombre);
            this.groupBoxDatosDoc.Controls.Add(this.lblNombre);
            this.groupBoxDatosDoc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosDoc.Name = "groupBoxDatosDoc";
            this.groupBoxDatosDoc.Size = new System.Drawing.Size(338, 208);
            this.groupBoxDatosDoc.TabIndex = 60;
            this.groupBoxDatosDoc.TabStop = false;
            this.groupBoxDatosDoc.Text = "Datos de Documento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(155, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // maskedCodDoc
            // 
            this.maskedCodDoc.Location = new System.Drawing.Point(155, 19);
            this.maskedCodDoc.Mask = "9999";
            this.maskedCodDoc.Name = "maskedCodDoc";
            this.maskedCodDoc.Size = new System.Drawing.Size(150, 20);
            this.maskedCodDoc.TabIndex = 52;
            this.maskedCodDoc.Text = "0";
            this.maskedCodDoc.ValidatingType = typeof(int);
            // 
            // lblCodigoDocumento
            // 
            this.lblCodigoDocumento.AutoSize = true;
            this.lblCodigoDocumento.Location = new System.Drawing.Point(14, 22);
            this.lblCodigoDocumento.Name = "lblCodigoDocumento";
            this.lblCodigoDocumento.Size = new System.Drawing.Size(116, 13);
            this.lblCodigoDocumento.TabIndex = 51;
            this.lblCodigoDocumento.Text = "Código de Documento:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(155, 81);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(150, 60);
            this.rtbDescripcion.TabIndex = 50;
            this.rtbDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 84);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(155, 49);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(150, 20);
            this.tbNombre.TabIndex = 48;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 13);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre del Documento:";
            // 
            // btnBajaDocumento
            // 
            this.btnBajaDocumento.Location = new System.Drawing.Point(378, 226);
            this.btnBajaDocumento.Name = "btnBajaDocumento";
            this.btnBajaDocumento.Size = new System.Drawing.Size(100, 23);
            this.btnBajaDocumento.TabIndex = 64;
            this.btnBajaDocumento.Text = "Baja Documento";
            this.btnBajaDocumento.UseVisualStyleBackColor = true;
            this.btnBajaDocumento.Click += new System.EventHandler(this.btnBajaDocumento_Click);
            // 
            // AltaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 416);
            this.Controls.Add(this.btnBajaDocumento);
            this.Controls.Add(this.btnAltaDocumento);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxListadoDoc);
            this.Controls.Add(this.groupBoxDatosDoc);
            this.Name = "AltaDocumento";
            this.Text = "AltaDocumento";
            this.Load += new System.EventHandler(this.AltaDocumento_Load);
            this.groupBoxListadoDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            this.groupBoxDatosDoc.ResumeLayout(false);
            this.groupBoxDatosDoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaDocumento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBoxListadoDoc;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.GroupBox groupBoxDatosDoc;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.MaskedTextBox maskedCodDoc;
        private System.Windows.Forms.Label lblCodigoDocumento;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnBajaDocumento;
    }
}