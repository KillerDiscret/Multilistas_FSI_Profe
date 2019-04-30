namespace EjercicioListas
{
    partial class FrmIngresoAlumno
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
            this.label3 = new System.Windows.Forms.Label();
            this.txttiu = new System.Windows.Forms.TextBox();
            this.txtnombrealumno = new System.Windows.Forms.TextBox();
            this.lboxcursos = new System.Windows.Forms.ListBox();
            this.btnmatricula = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cursos";
            // 
            // txttiu
            // 
            this.txttiu.Location = new System.Drawing.Point(20, 47);
            this.txttiu.Name = "txttiu";
            this.txttiu.Size = new System.Drawing.Size(194, 20);
            this.txttiu.TabIndex = 3;
            // 
            // txtnombrealumno
            // 
            this.txtnombrealumno.Location = new System.Drawing.Point(20, 120);
            this.txtnombrealumno.Name = "txtnombrealumno";
            this.txtnombrealumno.Size = new System.Drawing.Size(192, 20);
            this.txtnombrealumno.TabIndex = 4;
            // 
            // lboxcursos
            // 
            this.lboxcursos.FormattingEnabled = true;
            this.lboxcursos.Location = new System.Drawing.Point(237, 47);
            this.lboxcursos.Name = "lboxcursos";
            this.lboxcursos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxcursos.Size = new System.Drawing.Size(109, 160);
            this.lboxcursos.TabIndex = 5;
            // 
            // btnmatricula
            // 
            this.btnmatricula.Location = new System.Drawing.Point(20, 163);
            this.btnmatricula.Name = "btnmatricula";
            this.btnmatricula.Size = new System.Drawing.Size(87, 24);
            this.btnmatricula.TabIndex = 6;
            this.btnmatricula.Text = "Matricula";
            this.btnmatricula.UseVisualStyleBackColor = true;
            this.btnmatricula.Click += new System.EventHandler(this.btnmatricula_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(132, 163);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(79, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmIngresoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 219);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmatricula);
            this.Controls.Add(this.lboxcursos);
            this.Controls.Add(this.txtnombrealumno);
            this.Controls.Add(this.txttiu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresoAlumno";
            this.Text = "FrmIngresoAlumno";
            this.Load += new System.EventHandler(this.FrmIngresoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttiu;
        private System.Windows.Forms.TextBox txtnombrealumno;
        private System.Windows.Forms.ListBox lboxcursos;
        private System.Windows.Forms.Button btnmatricula;
        private System.Windows.Forms.Button btnsalir;
    }
}