namespace TPI.ABMs
{
    partial class AltaBarrio
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
            this.labelNroBarrio = new System.Windows.Forms.Label();
            this.textBoxNroBarrio = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAltaBarrio = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dataGridViewBarrio = new System.Windows.Forms.DataGridView();
            this.NroBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarrio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNroBarrio
            // 
            this.labelNroBarrio.AutoSize = true;
            this.labelNroBarrio.Location = new System.Drawing.Point(30, 21);
            this.labelNroBarrio.Name = "labelNroBarrio";
            this.labelNroBarrio.Size = new System.Drawing.Size(54, 13);
            this.labelNroBarrio.TabIndex = 39;
            this.labelNroBarrio.Text = "NroBarrio:";
            // 
            // textBoxNroBarrio
            // 
            this.textBoxNroBarrio.Location = new System.Drawing.Point(94, 21);
            this.textBoxNroBarrio.Name = "textBoxNroBarrio";
            this.textBoxNroBarrio.ReadOnly = true;
            this.textBoxNroBarrio.Size = new System.Drawing.Size(121, 20);
            this.textBoxNroBarrio.TabIndex = 38;
            this.textBoxNroBarrio.Text = "0";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(21, 214);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 37;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(278, 214);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 23);
            this.buttonEliminar.TabIndex = 35;
            this.buttonEliminar.Text = "Baja Barrio";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAltaBarrio
            // 
            this.buttonAltaBarrio.Location = new System.Drawing.Point(106, 214);
            this.buttonAltaBarrio.Name = "buttonAltaBarrio";
            this.buttonAltaBarrio.Size = new System.Drawing.Size(95, 23);
            this.buttonAltaBarrio.TabIndex = 34;
            this.buttonAltaBarrio.Text = "Alta Barrio";
            this.buttonAltaBarrio.UseVisualStyleBackColor = true;
            this.buttonAltaBarrio.Click += new System.EventHandler(this.buttonAltaBarrio_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(94, 149);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(121, 23);
            this.buttonLimpiar.TabIndex = 36;
            this.buttonLimpiar.Text = "Limpiar Celdas";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // dataGridViewBarrio
            // 
            this.dataGridViewBarrio.AllowUserToAddRows = false;
            this.dataGridViewBarrio.AllowUserToDeleteRows = false;
            this.dataGridViewBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroBarrio,
            this.Nombre,
            this.NroLocalidad});
            this.dataGridViewBarrio.Location = new System.Drawing.Point(19, 19);
            this.dataGridViewBarrio.Name = "dataGridViewBarrio";
            this.dataGridViewBarrio.ReadOnly = true;
            this.dataGridViewBarrio.Size = new System.Drawing.Size(323, 172);
            this.dataGridViewBarrio.TabIndex = 31;
            this.dataGridViewBarrio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarrio_CellClick);
            // 
            // NroBarrio
            // 
            this.NroBarrio.DataPropertyName = "NroBarrio";
            this.NroBarrio.HeaderText = "Nro Barrio";
            this.NroBarrio.Name = "NroBarrio";
            this.NroBarrio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NroLocalidad
            // 
            this.NroLocalidad.DataPropertyName = "NroLocalidad";
            this.NroLocalidad.HeaderText = "Nro Localidad";
            this.NroLocalidad.Name = "NroLocalidad";
            this.NroLocalidad.ReadOnly = true;
            // 
            // comboBoxLocalidad
            // 
            this.comboBoxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocalidad.FormattingEnabled = true;
            this.comboBoxLocalidad.Location = new System.Drawing.Point(94, 100);
            this.comboBoxLocalidad.Name = "comboBoxLocalidad";
            this.comboBoxLocalidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocalidad.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(94, 59);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNom.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Localidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxLocalidad);
            this.groupBox1.Controls.Add(this.labelNroBarrio);
            this.groupBox1.Controls.Add(this.textBoxNroBarrio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 196);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barrio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewBarrio);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 196);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Barrios";
            // 
            // AltaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAltaBarrio);
            this.Controls.Add(this.buttonActualizar);
            this.Name = "AltaBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaBarrio";
            this.Load += new System.EventHandler(this.AltaBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarrio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNroBarrio;
        private System.Windows.Forms.TextBox textBoxNroBarrio;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAltaBarrio;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridView dataGridViewBarrio;
        private System.Windows.Forms.ComboBox comboBoxLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroLocalidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}