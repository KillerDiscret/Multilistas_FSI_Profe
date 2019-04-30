using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresoDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresodeCurso frm = new FrmIngresodeCurso();
            frm.ShowDialog();
        }

        private void ingresoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoAlumno frm = new FrmIngresoAlumno();
            frm.ShowDialog();
        }

        private void listaDeAlumnosMatriculadosEnUnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarAlumnosMatriculados frm = new FrmListarAlumnosMatriculados();
            frm.ShowDialog();
        }

        private void listarCursosQueLlevaUnAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarCursosDeAlumno frm = new FrmListarCursosDeAlumno();
            frm.ShowDialog();
        }

        private void alumnoConTIUMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMatriculaUPC objmatricula = new CMatriculaUPC();
            CAlumno alumno = objmatricula.DameAlumnoConTIUMayor();
            MessageBox.Show("Codigo " + alumno.TIU.ToString(),"TIU mayor");
        }

        private void cursoConMásAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMatriculaUPC objmatricula = new CMatriculaUPC();
            CCurso curso = objmatricula.DameCursoConMasAlumnos();
            MessageBox.Show("Curso: " + curso.Nombre);
        }
    }
}
