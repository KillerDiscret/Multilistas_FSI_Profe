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
    public partial class FrmIngresodeCurso : Form
    {
        CMatriculaUPC objmatricula = new CMatriculaUPC();
        public FrmIngresodeCurso()
        {
            InitializeComponent();
        }

        private void btningresarcurso_Click(object sender, EventArgs e)
        {
            if(!objmatricula.CursoExiste(txtcodigocurso.Text))
            {
                CCurso curso = new CCurso();
                curso.Codigo = txtcodigocurso.Text;
                curso.Nombre = txtnombrecurso.Text;
                objmatricula.InsertarCurso(curso);
            }
            txtcodigocurso.Clear();
            txtnombrecurso.Clear();
            txtcodigocurso.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
