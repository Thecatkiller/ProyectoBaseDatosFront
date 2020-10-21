namespace ProyectoBaseDatosFront.views
{
    partial class FrmMain
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
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnTrabajadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(12, 12);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(156, 54);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.Location = new System.Drawing.Point(203, 12);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Size = new System.Drawing.Size(156, 54);
            this.btnTrabajadores.TabIndex = 1;
            this.btnTrabajadores.Text = "Trabajadores";
            this.btnTrabajadores.UseVisualStyleBackColor = true;
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 773);
            this.Controls.Add(this.btnTrabajadores);
            this.Controls.Add(this.btnPacientes);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnTrabajadores;
    }
}