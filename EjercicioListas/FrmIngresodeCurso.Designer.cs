namespace EjercicioListas
{
    partial class FrmIngresodeCurso
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
            this.txtcodigocurso = new System.Windows.Forms.TextBox();
            this.txtnombrecurso = new System.Windows.Forms.TextBox();
            this.btningresarcurso = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del curso";
            // 
            // txtcodigocurso
            // 
            this.txtcodigocurso.Location = new System.Drawing.Point(20, 39);
            this.txtcodigocurso.Name = "txtcodigocurso";
            this.txtcodigocurso.Size = new System.Drawing.Size(250, 20);
            this.txtcodigocurso.TabIndex = 2;
            // 
            // txtnombrecurso
            // 
            this.txtnombrecurso.Location = new System.Drawing.Point(21, 119);
            this.txtnombrecurso.Name = "txtnombrecurso";
            this.txtnombrecurso.Size = new System.Drawing.Size(248, 20);
            this.txtnombrecurso.TabIndex = 3;
            // 
            // btningresarcurso
            // 
            this.btningresarcurso.Location = new System.Drawing.Point(21, 159);
            this.btningresarcurso.Name = "btningresarcurso";
            this.btningresarcurso.Size = new System.Drawing.Size(106, 25);
            this.btningresarcurso.TabIndex = 4;
            this.btningresarcurso.Text = "Ingresar curso";
            this.btningresarcurso.UseVisualStyleBackColor = true;
            this.btningresarcurso.Click += new System.EventHandler(this.btningresarcurso_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(187, 159);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(81, 24);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmIngresodeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresarcurso);
            this.Controls.Add(this.txtnombrecurso);
            this.Controls.Add(this.txtcodigocurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresodeCurso";
            this.Text = "FrmIngresodeCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigocurso;
        private System.Windows.Forms.TextBox txtnombrecurso;
        private System.Windows.Forms.Button btningresarcurso;
        private System.Windows.Forms.Button btnsalir;
    }
}