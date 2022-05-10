namespace TPI.ABMs
{
    partial class AltaAtenciones
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
            this.dataGridViewAtencion = new System.Windows.Forms.DataGridView();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroExpe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAltaAfiliado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNroAfiliado = new System.Windows.Forms.TextBox();
            this.labelNroExpe = new System.Windows.Forms.Label();
            this.textBoxNroExpe = new System.Windows.Forms.TextBox();
            this.labelNroAfiliado = new System.Windows.Forms.Label();
            this.maskedTextBoxFechaAte = new System.Windows.Forms.MaskedTextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtencion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBaja);
            this.groupBox1.Controls.Add(this.dataGridViewAtencion);
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Atenciones";
            // 
            // dataGridViewAtencion
            // 
            this.dataGridViewAtencion.AllowUserToAddRows = false;
            this.dataGridViewAtencion.AllowUserToDeleteRows = false;
            this.dataGridViewAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroAfiliado,
            this.CodCategoria,
            this.FechaAtencion,
            this.Matricula,
            this.NroExpe});
            this.dataGridViewAtencion.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAtencion.Name = "dataGridViewAtencion";
            this.dataGridViewAtencion.ReadOnly = true;
            this.dataGridViewAtencion.RowHeadersWidth = 51;
            this.dataGridViewAtencion.RowTemplate.Height = 24;
            this.dataGridViewAtencion.Size = new System.Drawing.Size(681, 263);
            this.dataGridViewAtencion.TabIndex = 0;
            this.dataGridViewAtencion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtencion_CellContentClick);
            // 
            // NroAfiliado
            // 
            this.NroAfiliado.DataPropertyName = "NroAfiliado";
            this.NroAfiliado.HeaderText = "Nro Afiliado";
            this.NroAfiliado.MinimumWidth = 6;
            this.NroAfiliado.Name = "NroAfiliado";
            this.NroAfiliado.ReadOnly = true;
            this.NroAfiliado.Width = 125;
            // 
            // CodCategoria
            // 
            this.CodCategoria.DataPropertyName = "CodCategoria";
            this.CodCategoria.HeaderText = "Categoria";
            this.CodCategoria.MinimumWidth = 6;
            this.CodCategoria.Name = "CodCategoria";
            this.CodCategoria.ReadOnly = true;
            this.CodCategoria.Width = 125;
            // 
            // FechaAtencion
            // 
            this.FechaAtencion.DataPropertyName = "FechaAtencion";
            this.FechaAtencion.HeaderText = "Fecha Atencion";
            this.FechaAtencion.MinimumWidth = 6;
            this.FechaAtencion.Name = "FechaAtencion";
            this.FechaAtencion.ReadOnly = true;
            this.FechaAtencion.Width = 125;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 125;
            // 
            // NroExpe
            // 
            this.NroExpe.DataPropertyName = "NroExpe";
            this.NroExpe.HeaderText = "Nro Expediente";
            this.NroExpe.MinimumWidth = 6;
            this.NroExpe.Name = "NroExpe";
            this.NroExpe.ReadOnly = true;
            this.NroExpe.Width = 125;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(324, 192);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(100, 28);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAltaAfiliado
            // 
            this.buttonAltaAfiliado.Location = new System.Drawing.Point(442, 192);
            this.buttonAltaAfiliado.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAltaAfiliado.Name = "buttonAltaAfiliado";
            this.buttonAltaAfiliado.Size = new System.Drawing.Size(100, 28);
            this.buttonAltaAfiliado.TabIndex = 14;
            this.buttonAltaAfiliado.Text = "Alta Atencion";
            this.buttonAltaAfiliado.UseVisualStyleBackColor = true;
            this.buttonAltaAfiliado.Click += new System.EventHandler(this.buttonAltaAfiliado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMatricula);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonActualizar);
            this.groupBox2.Controls.Add(this.textBoxNroAfiliado);
            this.groupBox2.Controls.Add(this.buttonAltaAfiliado);
            this.groupBox2.Controls.Add(this.labelNroExpe);
            this.groupBox2.Controls.Add(this.textBoxNroExpe);
            this.groupBox2.Controls.Add(this.labelNroAfiliado);
            this.groupBox2.Controls.Add(this.maskedTextBoxFechaAte);
            this.groupBox2.Controls.Add(this.buttonLimpiar);
            this.groupBox2.Controls.Add(this.comboBoxCateg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(863, 305);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Atencion";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(442, 149);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(132, 22);
            this.textBoxMatricula.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Matricula";
            // 
            // textBoxNroAfiliado
            // 
            this.textBoxNroAfiliado.Location = new System.Drawing.Point(442, 24);
            this.textBoxNroAfiliado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroAfiliado.Name = "textBoxNroAfiliado";
            this.textBoxNroAfiliado.ReadOnly = true;
            this.textBoxNroAfiliado.Size = new System.Drawing.Size(132, 22);
            this.textBoxNroAfiliado.TabIndex = 31;
            this.textBoxNroAfiliado.Text = "0";
            // 
            // labelNroExpe
            // 
            this.labelNroExpe.AutoSize = true;
            this.labelNroExpe.Location = new System.Drawing.Point(288, 116);
            this.labelNroExpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNroExpe.Name = "labelNroExpe";
            this.labelNroExpe.Size = new System.Drawing.Size(126, 16);
            this.labelNroExpe.TabIndex = 30;
            this.labelNroExpe.Text = "Numero Expediente";
            // 
            // textBoxNroExpe
            // 
            this.textBoxNroExpe.Location = new System.Drawing.Point(442, 116);
            this.textBoxNroExpe.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNroExpe.Name = "textBoxNroExpe";
            this.textBoxNroExpe.Size = new System.Drawing.Size(132, 22);
            this.textBoxNroExpe.TabIndex = 29;
            // 
            // labelNroAfiliado
            // 
            this.labelNroAfiliado.AutoSize = true;
            this.labelNroAfiliado.Location = new System.Drawing.Point(288, 24);
            this.labelNroAfiliado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNroAfiliado.Name = "labelNroAfiliado";
            this.labelNroAfiliado.Size = new System.Drawing.Size(103, 16);
            this.labelNroAfiliado.TabIndex = 26;
            this.labelNroAfiliado.Text = "Numero Afiliado";
            // 
            // maskedTextBoxFechaAte
            // 
            this.maskedTextBoxFechaAte.Location = new System.Drawing.Point(442, 86);
            this.maskedTextBoxFechaAte.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxFechaAte.Mask = "00/00/0000";
            this.maskedTextBoxFechaAte.Name = "maskedTextBoxFechaAte";
            this.maskedTextBoxFechaAte.Size = new System.Drawing.Size(132, 22);
            this.maskedTextBoxFechaAte.TabIndex = 24;
            this.maskedTextBoxFechaAte.ValidatingType = typeof(System.DateTime);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(347, 249);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(169, 28);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar Celdas";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Location = new System.Drawing.Point(442, 54);
            this.comboBoxCateg.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCateg.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Atencion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(719, 21);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(119, 33);
            this.buttonBaja.TabIndex = 34;
            this.buttonBaja.Text = "Dar Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // AltaAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaAtenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Atenciones";
            this.Load += new System.EventHandler(this.AltaAtenciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtencion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonAltaAfiliado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaAte;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.ComboBox comboBoxCateg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNroAfiliado;
        private System.Windows.Forms.Label labelNroExpe;
        private System.Windows.Forms.TextBox textBoxNroExpe;
        private System.Windows.Forms.DataGridView dataGridViewAtencion;
        private System.Windows.Forms.TextBox textBoxNroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroExpe;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBaja;
    }
}