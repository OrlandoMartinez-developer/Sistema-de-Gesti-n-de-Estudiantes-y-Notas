using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Estudiante;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Menu_Principal
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Convierte el formulario en un contenedor 
        }


        private void AbrirFormulario(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
        private void cursosYHorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Estudiantes frmEstudiantes = new Estudiantes();
            AbrirFormulario(frmEstudiantes);
        }
    }
}
