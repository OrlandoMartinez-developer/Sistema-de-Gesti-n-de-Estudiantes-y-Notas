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
            this.IsMdiContainer = true;
            this.AutoSize = true;
            this.MinimumSize = new Size(1024, 768); // Tamaño inicial recomendado
            
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

        private void cursosYHorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí deberías abrir el formulario de Cursos y Horarios
            
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

        
    }
}