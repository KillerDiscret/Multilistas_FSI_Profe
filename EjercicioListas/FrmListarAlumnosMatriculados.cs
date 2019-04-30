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
    public partial class FrmListarAlumnosMatriculados : Form
    {
        public FrmListarAlumnosMatriculados()
        {
            InitializeComponent();
        }

        private void FrmListarAlumnosMatriculados_Load(object sender, EventArgs e)
        {
            lboxcursos.DisplayMember = "Nombre";
            lboxcursos.ValueMember = "Codigo";
            lboxcursos.DataSource = CMatriculaUPC.Cursos;
        }

        private void lboxcursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CCurso curso = (CCurso)lboxcursos.SelectedItem;
            lboxalumnos.DisplayMember = "NombreCompleto";
            lboxalumnos.ValueMember = "TIU";
            lboxalumnos.DataSource = curso.Alumnos;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
