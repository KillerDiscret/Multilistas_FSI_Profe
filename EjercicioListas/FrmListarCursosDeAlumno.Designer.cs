namespace EjercicioListas
{
    partial class FrmListarCursosDeAlumno
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
            this.cboxalumnos = new System.Windows.Forms.ComboBox();
            this.lboxcursos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del alumno";
            // 
            // cboxalumnos
            // 
            this.cboxalumnos.FormattingEnabled = true;
            this.cboxalumnos.Location = new System.Drawing.Point(124, 22);
            this.cboxalumnos.Name = "cboxalumnos";
            this.cboxalumnos.Size = new System.Drawing.Size(110, 21);
            this.cboxalumnos.TabIndex = 1;
            this.cboxalumnos.SelectedIndexChanged += new System.EventHandler(this.cboxalumnos_SelectedIndexChanged);
            // 
            // lboxcursos
            // 
            this.lboxcursos.FormattingEnabled = true;
            this.lboxcursos.Location = new System.Drawing.Point(27, 86);
            this.lboxcursos.Name = "lboxcursos";
            this.lboxcursos.Size = new System.Drawing.Size(207, 134);
            this.lboxcursos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cursos matriculados";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(153, 241);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(73, 20);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmListarCursosDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 274);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxcursos);
            this.Controls.Add(this.cboxalumnos);
            this.Controls.Add(this.label1);
            this.Name = "FrmListarCursosDeAlumno";
            this.Text = "FrmListarCursosDeAlumno";
            this.Load += new System.EventHandler(this.FrmListarCursosDeAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxalumnos;
        private System.Windows.Forms.ListBox lboxcursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
    }
}