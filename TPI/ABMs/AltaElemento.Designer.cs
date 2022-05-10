namespace TPI.ABMs
{
    partial class AltaElemento
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPres = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNroElemento = new System.Windows.Forms.Label();
            this.cmbNombreElemento = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNroElemento = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBajaElemento = new System.Windows.Forms.Button();
            this.btnAltaElemento = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPres)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPres);
            this.groupBox2.Location = new System.Drawing.Point(288, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 256);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de elemento";
            // 
            // dataGridViewPres
            // 
            this.dataGridViewPres.AllowUserToAddRows = false;
            this.dataGridViewPres.AllowUserToDeleteRows = false;
            this.dataGridViewPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPres.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewPres.Name = "dataGridViewPres";
            this.dataGridViewPres.ReadOnly = true;
            this.dataGridViewPres.Size = new System.Drawing.Size(488, 231);
            this.dataGridViewPres.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNroElemento);
            this.groupBox1.Controls.Add(this.cmbNombreElemento);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtNroElemento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 139);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta elemento";
            // 
            // lblNroElemento
            // 
            this.lblNroElemento.AutoSize = true;
            this.lblNroElemento.Location = new System.Drawing.Point(6, 16);
            this.lblNroElemento.Name = "lblNroElemento";
            this.lblNroElemento.Size = new System.Drawing.Size(68, 13);
            this.lblNroElemento.TabIndex = 39;
            this.lblNroElemento.Text = "Nº elemento:";
            // 
            // cmbNombreElemento
            // 
            this.cmbNombreElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreElemento.FormattingEnabled = true;
            this.cmbNombreElemento.Location = new System.Drawing.Point(122, 39);
            this.cmbNombreElemento.Name = "cmbNombreElemento";
            this.cmbNombreElemento.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreElemento.TabIndex = 39;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(122, 92);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 23);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtNroElemento
            // 
            this.txtNroElemento.Location = new System.Drawing.Point(122, 13);
            this.txtNroElemento.Name = "txtNroElemento";
            this.txtNroElemento.ReadOnly = true;
            this.txtNroElemento.Size = new System.Drawing.Size(121, 20);
            this.txtNroElemento.TabIndex = 38;
            this.txtNroElemento.Text = "0";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(41, 274);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 39);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBajaElemento
            // 
            this.btnBajaElemento.Location = new System.Drawing.Point(649, 274);
            this.btnBajaElemento.Name = "btnBajaElemento";
            this.btnBajaElemento.Size = new System.Drawing.Size(95, 39);
            this.btnBajaElemento.TabIndex = 44;
            this.btnBajaElemento.Text = "Baja de elemento";
            this.btnBajaElemento.UseVisualStyleBackColor = true;
            // 
            // btnAltaElemento
            // 
            this.btnAltaElemento.Location = new System.Drawing.Point(134, 274);
            this.btnAltaElemento.Name = "btnAltaElemento";
            this.btnAltaElemento.Size = new System.Drawing.Size(95, 39);
            this.btnAltaElemento.TabIndex = 43;
            this.btnAltaElemento.Text = "Alta de elemento";
            this.btnAltaElemento.UseVisualStyleBackColor = true;
            this.btnAltaElemento.Click += new System.EventHandler(this.btnAltaElemento_Click);
            // 
            // AltaElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBajaElemento);
            this.Controls.Add(this.btnAltaElemento);
            this.Name = "AltaElemento";
            this.Text = "AltaElemento";
            this.Load += new System.EventHandler(this.AltaElemento_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPres)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNroElemento;
        private System.Windows.Forms.ComboBox cmbNombreElemento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNroElemento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBajaElemento;
        private System.Windows.Forms.Button btnAltaElemento;
    }
}