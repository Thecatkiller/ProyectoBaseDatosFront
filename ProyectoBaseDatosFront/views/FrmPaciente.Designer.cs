namespace ProyectoBaseDatosFront.views
{
    partial class FrmPaciente
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
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colApellido,
            this.colDocumento,
            this.colSexo,
            this.colGrupoSanguineo,
            this.colEdad,
            this.colCorreo,
            this.colCelular});
            this.dgvPacientes.Location = new System.Drawing.Point(12, 37);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(1049, 510);
            this.dgvPacientes.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombres";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellidos";
            this.colApellido.Name = "colApellido";
            // 
            // colDocumento
            // 
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.Name = "colDocumento";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            // 
            // colGrupoSanguineo
            // 
            this.colGrupoSanguineo.HeaderText = "Grupo Sanguineo";
            this.colGrupoSanguineo.Name = "colGrupoSanguineo";
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.Name = "colEdad";
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 547);
            this.Controls.Add(this.dgvPacientes);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
    }
}