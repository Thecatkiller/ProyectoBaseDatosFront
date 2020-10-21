namespace ProyectoBaseDatosFront.views
{
    partial class FrmFactoresRiesgoPaciente
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.dgvFactorRiesgoPaciente = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorRiesgoPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(89, 15);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(185, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(89, 41);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(185, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // dgvFactorRiesgoPaciente
            // 
            this.dgvFactorRiesgoPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorRiesgoPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nomFactor,
            this.colPresenta,
            this.colComentario,
            this.colFechaRegistro});
            this.dgvFactorRiesgoPaciente.Location = new System.Drawing.Point(12, 98);
            this.dgvFactorRiesgoPaciente.Name = "dgvFactorRiesgoPaciente";
            this.dgvFactorRiesgoPaciente.Size = new System.Drawing.Size(569, 340);
            this.dgvFactorRiesgoPaciente.TabIndex = 4;
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo Factor Riesgo";
            this.cod.Name = "cod";
            // 
            // nomFactor
            // 
            this.nomFactor.HeaderText = "Nombre";
            this.nomFactor.Name = "nomFactor";
            // 
            // colPresenta
            // 
            this.colPresenta.HeaderText = "Presenta";
            this.colPresenta.Name = "colPresenta";
            // 
            // colComentario
            // 
            this.colComentario.HeaderText = "Comentario";
            this.colComentario.Name = "colComentario";
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.HeaderText = "Fecha Registro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            // 
            // FrmFactoresRiesgoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFactorRiesgoPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombres);
            this.Name = "FrmFactoresRiesgoPaciente";
            this.Text = "FrmFactoresRiesgoPaciente";
            this.Load += new System.EventHandler(this.FrmFactoresRiesgoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorRiesgoPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DataGridView dgvFactorRiesgoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaRegistro;
    }
}