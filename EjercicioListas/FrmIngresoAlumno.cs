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
    public partial class FrmIngresoAlumno : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();
        public FrmIngresoAlumno()
        {
            InitializeComponent();
        }

        private void FrmIngresoAlumno_Load(object sender, EventArgs e)
        {
            lboxcursos.DisplayMember = "Nombre";
            lboxcursos.ValueMember = "Codigo";
            lboxcursos.DataSource = CMatriculaUPC.Cursos;
            lboxcursos.SelectedIndex = -1;
        }

        private void btnmatricula_Click(object sender, EventArgs e)
        {
            CAlumno alumno = new CAlumno();
            alumno.TIU = Convert.ToInt32(txttiu.Text);
            alumno.NombreCompleto = txtnombrealumno.Text;
            foreach (CCurso curso in lboxcursos.SelectedItems)
                objmatricula.InsertarAlumnoEnCurso(curso.Codigo, alumno);
            txttiu.Clear();
            txtnombrealumno.Clear();
            lboxcursos.SelectedIndex = -1;
            txttiu.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
