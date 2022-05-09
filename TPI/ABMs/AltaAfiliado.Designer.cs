namespace TPI
{
    partial class AltaAfiliado
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
            this.maskedTextBoxNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.labelNroAfiliado = new System.Windows.Forms.Label();
            this.textBoxNroAfiliado = new System.Windows.Forms.TextBox();
            this.maskedTextBoxFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxBarrio = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAltaAfiliado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAfiliados = new System.Windows.Forms.DataGridView();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxNroCalle);
            this.groupBox1.Controls.Add(this.maskedTextBoxNroDocumento);
            this.groupBox1.Controls.Add(this.labelNroAfiliado);
            this.groupBox1.Controls.Add(this.textBoxNroAfiliado);
            this.groupBox1.Controls.Add(this.maskedTextBoxFechaNac);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.comboBoxBarrio);
            this.groupBox1.Controls.Add(this.comboBoxTipoDoc);
            this.groupBox1.Controls.Add(this.comboBoxCateg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxCalle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxApe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Afiliado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBoxNroCalle
            // 
            this.maskedTextBoxNroCalle.Location = new System.Drawing.Point(131, 242);
            this.maskedTextBoxNroCalle.Mask = "999999";
            this.maskedTextBoxNroCalle.Name = "maskedTextBoxNroCalle";
            this.maskedTextBoxNroCalle.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNroCalle.TabIndex = 18;
            this.maskedTextBoxNroCalle.ValidatingType = typeof(int);
            // 
            // maskedTextBoxNroDocumento
            // 
            this.maskedTextBoxNroDocumento.Location = new System.Drawing.Point(131, 164);
            this.maskedTextBoxNroDocumento.Mask = "99999999";
            this.maskedTextBoxNroDocumento.Name = "maskedTextBoxNroDocumento";
            this.maskedTextBoxNroDocumento.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNroDocumento.TabIndex = 13;
            this.maskedTextBoxNroDocumento.ValidatingType = typeof(int);
            // 
            // labelNroAfiliado
            // 
            this.labelNroAfiliado.AutoSize = true;
            this.labelNroAfiliado.Location = new System.Drawing.Point(136, 14);
            this.labelNroAfiliado.Name = "labelNroAfiliado";
            this.labelNroAfiliado.Size = new System.Drawing.Size(58, 13);
            this.labelNroAfiliado.TabIndex = 26;
            this.labelNroAfiliado.Text = "NroAfiliado";
            // 
            // textBoxNroAfiliado
            // 
            this.textBoxNroAfiliado.Location = new System.Drawing.Point(200, 11);
            this.textBoxNroAfiliado.Name = "textBoxNroAfiliado";
            this.textBoxNroAfiliado.ReadOnly = true;
            this.textBoxNroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroAfiliado.TabIndex = 25;
            this.textBoxNroAfiliado.Text = "0";
            // 
            // maskedTextBoxFechaNac
            // 
            this.maskedTextBoxFechaNac.Location = new System.Drawing.Point(131, 190);
            this.maskedTextBoxFechaNac.Mask = "00/00/0000";
            this.maskedTextBoxFechaNac.Name = "maskedTextBoxFechaNac";
            this.maskedTextBoxFechaNac.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFechaNac.TabIndex = 24;
            this.maskedTextBoxFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(125, 307);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(127, 23);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar Celdas";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // comboBoxBarrio
            // 
            this.comboBoxBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBarrio.FormattingEnabled = true;
            this.comboBoxBarrio.Location = new System.Drawing.Point(131, 268);
            this.comboBoxBarrio.Name = "comboBoxBarrio";
            this.comboBoxBarrio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBarrio.TabIndex = 23;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(131, 137);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDoc.TabIndex = 22;
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Location = new System.Drawing.Point(131, 113);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCateg.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nro Calle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Barrio";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(131, 216);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalle.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nro Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo documento";
            // 
            // textBoxApe
            // 
            this.textBoxApe.Location = new System.Drawing.Point(131, 86);
            this.textBoxApe.Name = "textBoxApe";
            this.textBoxApe.Size = new System.Drawing.Size(100, 20);
            this.textBoxApe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(131, 60);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // buttonAltaAfiliado
            // 
            this.buttonAltaAfiliado.Location = new System.Drawing.Point(235, 343);
            this.buttonAltaAfiliado.Name = "buttonAltaAfiliado";
            this.buttonAltaAfiliado.Size = new System.Drawing.Size(75, 23);
            this.buttonAltaAfiliado.TabIndex = 4;
            this.buttonAltaAfiliado.Text = "AltaAfiliado";
            this.buttonAltaAfiliado.UseVisualStyleBackColor = true;
            this.buttonAltaAfiliado.Click += new System.EventHandler(this.buttonAltaAfiliado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAfiliados);
            this.groupBox2.Location = new System.Drawing.Point(362, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 248);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado Afiliados";
            // 
            // dataGridViewAfiliados
            // 
            this.dataGridViewAfiliados.AllowUserToAddRows = false;
            this.dataGridViewAfiliados.AllowUserToDeleteRows = false;
            this.dataGridViewAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroAfiliado,
            this.CodCat,
            this.Ape,
            this.nom,
            this.tipodoc,
            this.nrodoc,
            this.fechanaci,
            this.calle,
            this.nrocalle,
            this.barrio});
            this.dataGridViewAfiliados.Location = new System.Drawing.Point(8, 19);
            this.dataGridViewAfiliados.Name = "dataGridViewAfiliados";
            this.dataGridViewAfiliados.ReadOnly = true;
            this.dataGridViewAfiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAfiliados.Size = new System.Drawing.Size(375, 213);
            this.dataGridViewAfiliados.TabIndex = 0;
            this.dataGridViewAfiliados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAfiliados_CellClick);
            // 
            // NroAfiliado
            // 
            this.NroAfiliado.DataPropertyName = "NroAfiliado";
            this.NroAfiliado.HeaderText = "Nro Afiliado";
            this.NroAfiliado.Name = "NroAfiliado";
            this.NroAfiliado.ReadOnly = true;
            // 
            // CodCat
            // 
            this.CodCat.DataPropertyName = "CodCategoria";
            this.CodCat.HeaderText = "Codigo Categoria";
            this.CodCat.Name = "CodCat";
            this.CodCat.ReadOnly = true;
            // 
            // Ape
            // 
            this.Ape.DataPropertyName = "Apellido";
            this.Ape.HeaderText = "Apellido";
            this.Ape.Name = "Ape";
            this.Ape.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "Nombre";
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // tipodoc
            // 
            this.tipodoc.DataPropertyName = "TipoDoc";
            this.tipodoc.HeaderText = "Tipo de documento";
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.ReadOnly = true;
            // 
            // nrodoc
            // 
            this.nrodoc.DataPropertyName = "NroDoc";
            this.nrodoc.HeaderText = "Nro documento";
            this.nrodoc.Name = "nrodoc";
            this.nrodoc.ReadOnly = true;
            // 
            // fechanaci
            // 
            this.fechanaci.DataPropertyName = "Fecha_Nacimiento";
            this.fechanaci.HeaderText = "Fecha nacimiento";
            this.fechanaci.Name = "fechanaci";
            this.fechanaci.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "Calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nrocalle
            // 
            this.nrocalle.DataPropertyName = "Nro_Calle";
            this.nrocalle.HeaderText = "Nro calle";
            this.nrocalle.Name = "nrocalle";
            this.nrocalle.ReadOnly = true;
            // 
            // barrio
            // 
            this.barrio.DataPropertyName = "Id_Barrio";
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(568, 343);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(85, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Baja Afiliado";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(89, 343);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 12;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // AltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 399);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAltaAfiliado);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaAfiliado";
            this.Text = "Alta de Afiliado";
            this.Load += new System.EventHandler(this.AltaAfiliado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAltaAfiliado;
        private System.Windows.Forms.TextBox textBoxApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaNac;
        private System.Windows.Forms.ComboBox comboBoxBarrio;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.ComboBox comboBoxCateg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAfiliados;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelNroAfiliado;
        private System.Windows.Forms.TextBox textBoxNroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNroCalle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNroDocumento;
    }
}

