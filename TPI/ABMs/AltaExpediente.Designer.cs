namespace TPI.ABMs
{
    partial class AltaExpediente
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
            this.dataGridViewExpe = new System.Windows.Forms.DataGridView();
            this.NroExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reintegro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAltaExpe = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelNroExpe = new System.Windows.Forms.Label();
            this.textBoxNroExpe = new System.Windows.Forms.TextBox();
            this.maskedTextBoxFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxReintegro = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExpe
            // 
            this.dataGridViewExpe.AllowUserToAddRows = false;
            this.dataGridViewExpe.AllowUserToDeleteRows = false;
            this.dataGridViewExpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroExpediente,
            this.FechaInicio,
            this.Reintegro});
            this.dataGridViewExpe.Location = new System.Drawing.Point(240, 41);
            this.dataGridViewExpe.Name = "dataGridViewExpe";
            this.dataGridViewExpe.ReadOnly = true;
            this.dataGridViewExpe.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewExpe.TabIndex = 5;
            this.dataGridViewExpe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpe_CellClick);
            // 
            // NroExpediente
            // 
            this.NroExpediente.DataPropertyName = "NroExpe";
            this.NroExpediente.HeaderText = "Nro Expediente";
            this.NroExpediente.Name = "NroExpediente";
            this.NroExpediente.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // Reintegro
            // 
            this.Reintegro.DataPropertyName = "Reintegro";
            this.Reintegro.HeaderText = "Reintegro";
            this.Reintegro.Name = "Reintegro";
            this.Reintegro.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FechaInicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reintegro";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(15, 168);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(316, 224);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 23);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Baja Expediente";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAltaExpe
            // 
            this.buttonAltaExpe.Location = new System.Drawing.Point(108, 168);
            this.buttonAltaExpe.Name = "buttonAltaExpe";
            this.buttonAltaExpe.Size = new System.Drawing.Size(95, 23);
            this.buttonAltaExpe.TabIndex = 13;
            this.buttonAltaExpe.Text = "Alta Expediente";
            this.buttonAltaExpe.UseVisualStyleBackColor = true;
            this.buttonAltaExpe.Click += new System.EventHandler(this.buttonAltaExpe_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(49, 132);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(127, 23);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar Celdas";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelNroExpe
            // 
            this.labelNroExpe.AutoSize = true;
            this.labelNroExpe.Location = new System.Drawing.Point(12, 9);
            this.labelNroExpe.Name = "labelNroExpe";
            this.labelNroExpe.Size = new System.Drawing.Size(48, 13);
            this.labelNroExpe.TabIndex = 28;
            this.labelNroExpe.Text = "NroExpe";
            // 
            // textBoxNroExpe
            // 
            this.textBoxNroExpe.Location = new System.Drawing.Point(76, 6);
            this.textBoxNroExpe.Name = "textBoxNroExpe";
            this.textBoxNroExpe.ReadOnly = true;
            this.textBoxNroExpe.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroExpe.TabIndex = 27;
            this.textBoxNroExpe.Text = "0";
            // 
            // maskedTextBoxFechaInicio
            // 
            this.maskedTextBoxFechaInicio.Location = new System.Drawing.Point(76, 64);
            this.maskedTextBoxFechaInicio.Mask = "00/00/0000";
            this.maskedTextBoxFechaInicio.Name = "maskedTextBoxFechaInicio";
            this.maskedTextBoxFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFechaInicio.TabIndex = 29;
            this.maskedTextBoxFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxReintegro
            // 
            this.maskedTextBoxReintegro.Location = new System.Drawing.Point(76, 94);
            this.maskedTextBoxReintegro.Mask = "999999999";
            this.maskedTextBoxReintegro.Name = "maskedTextBoxReintegro";
            this.maskedTextBoxReintegro.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxReintegro.TabIndex = 30;
            this.maskedTextBoxReintegro.ValidatingType = typeof(int);
            // 
            // AltaExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 278);
            this.Controls.Add(this.maskedTextBoxReintegro);
            this.Controls.Add(this.maskedTextBoxFechaInicio);
            this.Controls.Add(this.labelNroExpe);
            this.Controls.Add(this.textBoxNroExpe);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAltaExpe);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewExpe);
            this.Name = "AltaExpediente";
            this.Text = "AltaExpediente";
            this.Load += new System.EventHandler(this.AltaExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewExpe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reintegro;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAltaExpe;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelNroExpe;
        private System.Windows.Forms.TextBox textBoxNroExpe;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxReintegro;
    }
}