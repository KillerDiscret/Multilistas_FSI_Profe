namespace EjercicioListas
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoConMásAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoConTIUMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeCursoToolStripMenuItem,
            this.ingresoDeAlumnoToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // ingresoDeCursoToolStripMenuItem
            // 
            this.ingresoDeCursoToolStripMenuItem.Name = "ingresoDeCursoToolStripMenuItem";
            this.ingresoDeCursoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresoDeCursoToolStripMenuItem.Text = "Ingreso de curso";
            this.ingresoDeCursoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeCursoToolStripMenuItem_Click);
            // 
            // ingresoDeAlumnoToolStripMenuItem
            // 
            this.ingresoDeAlumnoToolStripMenuItem.Name = "ingresoDeAlumnoToolStripMenuItem";
            this.ingresoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresoDeAlumnoToolStripMenuItem.Text = "Ingreso de alumno";
            this.ingresoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeAlumnoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem,
            this.cursoConMásAlumnosToolStripMenuItem,
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem,
            this.alumnoConTIUMayorToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem
            // 
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Name = "listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem";
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Text = "Lista de alumnos matriculados en un curso";
            this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem.Click += new System.EventHandler(this.listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem_Click);
            // 
            // cursoConMásAlumnosToolStripMenuItem
            // 
            this.cursoConMásAlumnosToolStripMenuItem.Name = "cursoConMásAlumnosToolStripMenuItem";
            this.cursoConMásAlumnosToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.cursoConMásAlumnosToolStripMenuItem.Text = "Curso con más alumnos";
            this.cursoConMásAlumnosToolStripMenuItem.Click += new System.EventHandler(this.cursoConMásAlumnosToolStripMenuItem_Click);
            // 
            // listarCursosQueLlevaUnAlumnoToolStripMenuItem
            // 
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Name = "listarCursosQueLlevaUnAlumnoToolStripMenuItem";
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Text = "Listar cursos que lleva un alumno";
            this.listarCursosQueLlevaUnAlumnoToolStripMenuItem.Click += new System.EventHandler(this.listarCursosQueLlevaUnAlumnoToolStripMenuItem_Click);
            // 
            // alumnoConTIUMayorToolStripMenuItem
            // 
            this.alumnoConTIUMayorToolStripMenuItem.Name = "alumnoConTIUMayorToolStripMenuItem";
            this.alumnoConTIUMayorToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.alumnoConTIUMayorToolStripMenuItem.Text = "Alumno con TIU mayor";
            this.alumnoConTIUMayorToolStripMenuItem.Click += new System.EventHandler(this.alumnoConTIUMayorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ejercicio de multilistas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoConMásAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCursosQueLlevaUnAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoConTIUMayorToolStripMenuItem;
    }
}

