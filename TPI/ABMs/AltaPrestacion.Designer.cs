namespace TPI.ABMs
{
    partial class AltaPrestacion
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
            this.txtEdadMinima = new System.Windows.Forms.MaskedTextBox();
            this.lblCodPrestacion = new System.Windows.Forms.Label();
            this.txtCodPrestacion = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBajaPrestacion = new System.Windows.Forms.Button();
            this.btnAltaPrestacion = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewExpe = new System.Windows.Forms.DataGridView();
            this.codPrestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdadMinima
            // 
            this.txtEdadMinima.Location = new System.Drawing.Point(147, 87);
            this.txtEdadMinima.Mask = "99";
            this.txtEdadMinima.Name = "txtEdadMinima";
            this.txtEdadMinima.Size = new System.Drawing.Size(22, 20);
            this.txtEdadMinima.TabIndex = 40;
            this.txtEdadMinima.ValidatingType = typeof(int);
            // 
            // lblCodPrestacion
            // 
            this.lblCodPrestacion.AutoSize = true;
            this.lblCodPrestacion.Location = new System.Drawing.Point(30, 26);
            this.lblCodPrestacion.Name = "lblCodPrestacion";
            this.lblCodPrestacion.Size = new System.Drawing.Size(110, 13);
            this.lblCodPrestacion.TabIndex = 39;
            this.lblCodPrestacion.Text = "Código de prestación:";
            // 
            // txtCodPrestacion
            // 
            this.txtCodPrestacion.Location = new System.Drawing.Point(146, 23);
            this.txtCodPrestacion.Name = "txtCodPrestacion";
            this.txtCodPrestacion.Size = new System.Drawing.Size(121, 20);
            this.txtCodPrestacion.TabIndex = 38;
            this.txtCodPrestacion.Text = "0";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(94, 208);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 39);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBajaPrestacion
            // 
            this.btnBajaPrestacion.Location = new System.Drawing.Point(648, 252);
            this.btnBajaPrestacion.Name = "btnBajaPrestacion";
            this.btnBajaPrestacion.Size = new System.Drawing.Size(95, 39);
            this.btnBajaPrestacion.TabIndex = 35;
            this.btnBajaPrestacion.Text = "Baja de prestacion";
            this.btnBajaPrestacion.UseVisualStyleBackColor = true;
            // 
            // btnAltaPrestacion
            // 
            this.btnAltaPrestacion.Location = new System.Drawing.Point(187, 208);
            this.btnAltaPrestacion.Name = "btnAltaPrestacion";
            this.btnAltaPrestacion.Size = new System.Drawing.Size(95, 39);
            this.btnAltaPrestacion.TabIndex = 34;
            this.btnAltaPrestacion.Text = "Alta de prestacion";
            this.btnAltaPrestacion.UseVisualStyleBackColor = true;
            this.btnAltaPrestacion.Click += new System.EventHandler(this.btnAltaPrestacion_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(128, 172);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Edad mínima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Descripción:";
            // 
            // dataGridViewExpe
            // 
            this.dataGridViewExpe.AllowUserToAddRows = false;
            this.dataGridViewExpe.AllowUserToDeleteRows = false;
            this.dataGridViewExpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPrestacion,
            this.descripcion,
            this.edadMinima});
            this.dataGridViewExpe.Location = new System.Drawing.Point(324, 23);
            this.dataGridViewExpe.Name = "dataGridViewExpe";
            this.dataGridViewExpe.ReadOnly = true;
            this.dataGridViewExpe.Size = new System.Drawing.Size(464, 198);
            this.dataGridViewExpe.TabIndex = 31;
            // 
            // codPrestacion
            // 
            this.codPrestacion.HeaderText = "Cód. de prestación";
            this.codPrestacion.Name = "codPrestacion";
            this.codPrestacion.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // edadMinima
            // 
            this.edadMinima.HeaderText = "Edad mínima";
            this.edadMinima.Name = "edadMinima";
            this.edadMinima.ReadOnly = true;
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(146, 49);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(121, 21);
            this.cmbDescripcion.TabIndex = 39;
            // 
            // AltaPrestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.txtEdadMinima);
            this.Controls.Add(this.lblCodPrestacion);
            this.Controls.Add(this.txtCodPrestacion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBajaPrestacion);
            this.Controls.Add(this.btnAltaPrestacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewExpe);
            this.Name = "AltaPrestacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestaciones";
            this.Load += new System.EventHandler(this.Prestaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtEdadMinima;
        private System.Windows.Forms.Label lblCodPrestacion;
        private System.Windows.Forms.TextBox txtCodPrestacion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBajaPrestacion;
        private System.Windows.Forms.Button btnAltaPrestacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewExpe;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPrestacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadMinima;
    }
}