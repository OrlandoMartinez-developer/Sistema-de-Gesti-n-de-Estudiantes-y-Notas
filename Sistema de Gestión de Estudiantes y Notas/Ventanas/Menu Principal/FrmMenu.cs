using System;
using System.Drawing;
using System.Windows.Forms;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Estudiante;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Materia;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Menu_Principal
{
    public partial class FrmMenu : Form
    {
      
        public string rolUsuarioActual = "Admin"; // Reemplaza con tu lógica para obtener el rol

        public FrmMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.AutoSize = true;
            this.MinimumSize = new Size(1024, 768); // Tamaño inicial recomendado

            // Ocultar el botón "Docentes" si el usuario es un docente
            
        }

        private void AbrirFormulario(Form formulario)
        {
            // Cerrar el formulario hijo actual si existe
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
            }

            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Mostrar el formulario antes de ajustar el tamaño para que sus dimensiones sean correctas
            formulario.Show();

            // Ajustar el tamaño del formulario principal al del formulario hijo
            this.ClientSize = new Size(formulario.Width, formulario.Height + menuStrip1.Height);

            // Asegurarse de que el formulario hijo ocupe todo el espacio disponible
            formulario.Dock = DockStyle.Fill;
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            AbrirFormulario(cursos);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            AbrirFormulario(frmInicio);
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes frmEstudiantes = new Estudiantes();
            AbrirFormulario(frmEstudiantes);
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotas frmNotas = new FrmNotas();
            AbrirFormulario(frmNotas);
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos1 frmCursos = new Cursos1();
            AbrirFormulario(frmCursos);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            AbrirFormulario(materias);
        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPromedio frmPromedio = new FrmPromedio();
            AbrirFormulario(frmPromedio);
        }


        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteDeNotas reporteDeNotas = new ReporteDeNotas();
            AbrirFormulario(reporteDeNotas);
        }

        private void NotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteDeNotas reporteDeNotas = new ReporteDeNotas();
            AbrirFormulario(reporteDeNotas);
        }
    }
}