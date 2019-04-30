namespace EjercicioListas
{
    partial class FrmListarAlumnosMatriculados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxcursos = new System.Windows.Forms.ListBox();
            this.lboxalumnos = new System.Windows.Forms.ListBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumnos matriculados";
            // 
            // lboxcursos
            // 
            this.lboxcursos.FormattingEnabled = true;
            this.lboxcursos.Location = new System.Drawing.Point(16, 50);
            this.lboxcursos.Name = "lboxcursos";
            this.lboxcursos.Size = new System.Drawing.Size(98, 147);
            this.lboxcursos.TabIndex = 2;
            this.lboxcursos.SelectedIndexChanged += new System.EventHandler(this.lboxcursos_SelectedIndexChanged);
            // 
            // lboxalumnos
            // 
            this.lboxalumnos.FormattingEnabled = true;
            this.lboxalumnos.Location = new System.Drawing.Point(167, 50);
            this.lboxalumnos.Name = "lboxalumnos";
            this.lboxalumnos.Size = new System.Drawing.Size(104, 147);
            this.lboxalumnos.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(184, 217);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(65, 25);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmListarAlumnosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 255);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lboxalumnos);
            this.Controls.Add(this.lboxcursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListarAlumnosMatriculados";
            this.Text = "FrmListarAlumnosMatriculados";
            this.Load += new System.EventHandler(this.FrmListarAlumnosMatriculados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxcursos;
        private System.Windows.Forms.ListBox lboxalumnos;
        private System.Windows.Forms.Button btnsalir;
    }
}