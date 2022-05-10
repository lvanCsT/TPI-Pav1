namespace TPI.ABMs
{
    partial class AltaUsuario
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
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonAltaUsuario = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxRep_Pass = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxNom_Usu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNroAfiliado = new System.Windows.Forms.TextBox();
            this.labelNroAfiliado = new System.Windows.Forms.Label();
            this.buttonBajaUsuario = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonActualizar);
            this.groupBox1.Controls.Add(this.buttonAltaUsuario);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.textBoxRep_Pass);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.textBoxNom_Usu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta De Usuario:";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(159, 352);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(113, 40);
            this.buttonActualizar.TabIndex = 8;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonAltaUsuario
            // 
            this.buttonAltaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltaUsuario.Location = new System.Drawing.Point(246, 475);
            this.buttonAltaUsuario.Name = "buttonAltaUsuario";
            this.buttonAltaUsuario.Size = new System.Drawing.Size(150, 37);
            this.buttonAltaUsuario.TabIndex = 7;
            this.buttonAltaUsuario.Text = "Alta Usuario";
            this.buttonAltaUsuario.UseVisualStyleBackColor = true;
            this.buttonAltaUsuario.Click += new System.EventHandler(this.buttonAltaUsuario_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(46, 475);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(136, 37);
            this.buttonLimpiar.TabIndex = 6;
            this.buttonLimpiar.Text = "Limpiar celdas";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxRep_Pass
            // 
            this.textBoxRep_Pass.Location = new System.Drawing.Point(224, 182);
            this.textBoxRep_Pass.Name = "textBoxRep_Pass";
            this.textBoxRep_Pass.PasswordChar = '*';
            this.textBoxRep_Pass.Size = new System.Drawing.Size(172, 36);
            this.textBoxRep_Pass.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(224, 123);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(172, 36);
            this.textBoxPass.TabIndex = 4;
            // 
            // textBoxNom_Usu
            // 
            this.textBoxNom_Usu.Location = new System.Drawing.Point(224, 64);
            this.textBoxNom_Usu.Name = "textBoxNom_Usu";
            this.textBoxNom_Usu.Size = new System.Drawing.Size(172, 36);
            this.textBoxNom_Usu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = " Repetir Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = " Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNroAfiliado);
            this.groupBox2.Controls.Add(this.labelNroAfiliado);
            this.groupBox2.Controls.Add(this.buttonBajaUsuario);
            this.groupBox2.Controls.Add(this.dataGridViewUsuarios);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(499, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 547);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Usuarios: ";
            // 
            // textBoxNroAfiliado
            // 
            this.textBoxNroAfiliado.Location = new System.Drawing.Point(142, 351);
            this.textBoxNroAfiliado.Name = "textBoxNroAfiliado";
            this.textBoxNroAfiliado.ReadOnly = true;
            this.textBoxNroAfiliado.Size = new System.Drawing.Size(150, 26);
            this.textBoxNroAfiliado.TabIndex = 10;
            this.textBoxNroAfiliado.Text = "0";
            // 
            // labelNroAfiliado
            // 
            this.labelNroAfiliado.AutoSize = true;
            this.labelNroAfiliado.Location = new System.Drawing.Point(7, 351);
            this.labelNroAfiliado.Name = "labelNroAfiliado";
            this.labelNroAfiliado.Size = new System.Drawing.Size(120, 20);
            this.labelNroAfiliado.TabIndex = 9;
            this.labelNroAfiliado.Text = "Nro Afiliado: ";
            // 
            // buttonBajaUsuario
            // 
            this.buttonBajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBajaUsuario.Location = new System.Drawing.Point(142, 474);
            this.buttonBajaUsuario.Name = "buttonBajaUsuario";
            this.buttonBajaUsuario.Size = new System.Drawing.Size(150, 37);
            this.buttonBajaUsuario.TabIndex = 8;
            this.buttonBajaUsuario.Text = "Baja Usuario";
            this.buttonBajaUsuario.UseVisualStyleBackColor = true;
            this.buttonBajaUsuario.Click += new System.EventHandler(this.buttonBajaUsuario_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario,
            this.Password,
            this.NroAfiliado});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(7, 36);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(425, 203);
            this.dataGridViewUsuarios.TabIndex = 0;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "NombreUsuario";
            this.NombreUsuario.HeaderText = "Nombre ";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 125;
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
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta De Usuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRep_Pass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxNom_Usu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAltaUsuario;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonBajaUsuario;
        private System.Windows.Forms.TextBox textBoxNroAfiliado;
        private System.Windows.Forms.Label labelNroAfiliado;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAfiliado;
    }
}