using ActividadSQL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            BDContext bd = new BDContext();
            Curso cursoSeleccionado = (Curso) comboCurso.SelectedItem;
            List<Profesores> ProfesoresDeCurso = bd.Profesores.Where(Curso => Curso.idProfesor == cursoSeleccionado.idProfesor).ToList();
            dataProfes.DataSource = ProfesoresDeCurso;
            List<Alumnos> AlumnosDelCurso = bd.Alumnos.Where(Curso => Curso.idCurso == cursoSeleccionado.idCurso).ToList();
            dataAlumnos.DataSource = AlumnosDelCurso;
            dataAlumnos.Columns[4].Visible = false;
        }

        private void dataProfes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BDContext bd = new BDContext();

            comboCurso.DataSource = bd.Curso.ToList(); //Se pasan al grid view en formato lista
            comboCurso.DisplayMember = "NombreCurso"; 


        }
    }
}
