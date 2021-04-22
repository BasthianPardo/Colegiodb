using Colegiodb.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegiodb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            comboCursos.DataSource = bd.Cursos.ToList();
            comboCursos.DisplayMember = "Nombre";

            

        }

        private void comboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();

            Curso cursoSeleccionada = (Curso) comboCursos.SelectedItem;

            List<Estudiante> estudiantesDelCurso = 
                bd.Estudiantes.
                Where(Estudiante => Estudiante.idCurso ==cursoSeleccionada.idCurso).
                ToList();

            GridNombres.DataSource = estudiantesDelCurso;

            GridNombres.Columns[3].Visible = false;
            GridNombres.Columns[4].Visible = false;

            textProfesor.Text = cursoSeleccionada.Profesore.Nombre;



            
        }

    
    }
}
