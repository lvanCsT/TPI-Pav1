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
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dataGridViewPres = new System.Windows.Forms.DataGridView();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPres)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEdadMinima
            // 
            this.txtEdadMinima.Location = new System.Drawing.Point(123, 77);
            this.txtEdadMinima.Mask = "99";
            this.txtEdadMinima.Name = "txtEdadMinima";
            this.txtEdadMinima.Size = new System.Drawing.Size(22, 20);
            this.txtEdadMinima.TabIndex = 40;
            this.txtEdadMinima.ValidatingType = typeof(int);
            // 
            // lblCodPrestacion
            // 
            this.lblCodPrestacion.AutoSize = true;
            this.lblCodPrestacion.Location = new System.Drawing.Point(6, 16);
            this.lblCodPrestacion.Name = "lblCodPrestacion";
            this.lblCodPrestacion.Size = new System.Drawing.Size(110, 13);
            this.lblCodPrestacion.TabIndex = 39;
            this.lblCodPrestacion.Text = "Código de prestación:";
            // 
            // txtCodPrestacion
            // 
            this.txtCodPrestacion.Location = new System.Drawing.Point(122, 13);
            this.txtCodPrestacion.Name = "txtCodPrestacion";
            this.txtCodPrestacion.ReadOnly = true;
            this.txtCodPrestacion.Size = new System.Drawing.Size(121, 20);
            this.txtCodPrestacion.TabIndex = 38;
            this.txtCodPrestacion.Text = "0";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(94, 274);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 39);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBajaPrestacion
            // 
            this.btnBajaPrestacion.Location = new System.Drawing.Point(649, 274);
            this.btnBajaPrestacion.Name = "btnBajaPrestacion";
            this.btnBajaPrestacion.Size = new System.Drawing.Size(95, 39);
            this.btnBajaPrestacion.TabIndex = 35;
            this.btnBajaPrestacion.Text = "Baja de prestacion";
            this.btnBajaPrestacion.UseVisualStyleBackColor = true;
            // 
            // btnAltaPrestacion
            // 
            this.btnAltaPrestacion.Location = new System.Drawing.Point(187, 274);
            this.btnAltaPrestacion.Name = "btnAltaPrestacion";
            this.btnAltaPrestacion.Size = new System.Drawing.Size(95, 39);
            this.btnAltaPrestacion.TabIndex = 34;
            this.btnAltaPrestacion.Text = "Alta de prestacion";
            this.btnAltaPrestacion.UseVisualStyleBackColor = true;
            this.btnAltaPrestacion.Click += new System.EventHandler(this.btnAltaPrestacion_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(104, 162);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(44, 80);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(72, 13);
            this.lblEdad.TabIndex = 33;
            this.lblEdad.Text = "Edad mínima:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(50, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // dataGridViewPres
            // 
            this.dataGridViewPres.AllowUserToAddRows = false;
            this.dataGridViewPres.AllowUserToDeleteRows = false;
            this.dataGridViewPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPres.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPres.Name = "dataGridViewPres";
            this.dataGridViewPres.ReadOnly = true;
            this.dataGridViewPres.Size = new System.Drawing.Size(488, 231);
            this.dataGridViewPres.TabIndex = 31;
            this.dataGridViewPres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPres_CellClick);
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(122, 39);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(121, 21);
            this.cmbDescripcion.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodPrestacion);
            this.groupBox1.Controls.Add(this.cmbDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtEdadMinima);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtCodPrestacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 256);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta prestacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPres);
            this.groupBox2.Location = new System.Drawing.Point(288, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 256);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de prestaciones";
            // 
            // AltaPrestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBajaPrestacion);
            this.Controls.Add(this.btnAltaPrestacion);
            this.Name = "AltaPrestacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestaciones";
            this.Load += new System.EventHandler(this.Prestaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPres)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtEdadMinima;
        private System.Windows.Forms.Label lblCodPrestacion;
        private System.Windows.Forms.TextBox txtCodPrestacion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBajaPrestacion;
        private System.Windows.Forms.Button btnAltaPrestacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView dataGridViewPres;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}