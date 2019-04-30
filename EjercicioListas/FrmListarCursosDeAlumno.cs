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
    public partial class FrmListarCursosDeAlumno : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();
        public FrmListarCursosDeAlumno()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListarCursosDeAlumno_Load(object sender, EventArgs e)
        {
            cboxalumnos.DisplayMember = "NombreCompleto";
            cboxalumnos.ValueMember = "TIU";
            cboxalumnos.DataSource = CMatriculaUPC.ListaAlumnos;
        }

        private void cboxalumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CAlumno alumno = (CAlumno)cboxalumnos.SelectedItem;
            lboxcursos.DisplayMember = "Nombre";
            lboxcursos.ValueMember = "Codigo";
            lboxcursos.DataSource = objmatricula.ListarCursosQueLlevaUnAlumno(alumno.TIU);
        }
    }
}
