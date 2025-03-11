using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sistema_de_Gestión_de_Estudiantes_y_Notas;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    public partial class FrmNotas : Form
    {
        private readonly ConexionBD _conexionBD;
        private readonly EstudianteService _estudianteService;
        private readonly MateriaService _materiaService;
        private readonly NotaService _notaService;

        public FrmNotas()
        {
            InitializeComponent();
            _conexionBD = new ConexionBD();
            _estudianteService = new EstudianteService(_conexionBD);
            _materiaService = new MateriaService(_conexionBD);
            _notaService = new NotaService(_conexionBD);
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            if (_conexionBD.Conectar() != null)
            {
                CargarEstudiantes();
                CargarMaterias();
                CargarNotas();
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CargarEstudiantes()
        {
            var estudiantes = _estudianteService.ObtenerEstudiantes();
            cmbEstudiantes.DataSource = new BindingSource(estudiantes, null);
            cmbEstudiantes.DisplayMember = "Value";
            cmbEstudiantes.ValueMember = "Key";
        }

        private void CargarMaterias()
        {
            var materias = _materiaService.ObtenerMaterias();
            cmbMateria.DataSource = new BindingSource(materias, null);
            cmbMateria.DisplayMember = "Value";
            cmbMateria.ValueMember = "Key";
        }

        private void CargarNotas()
        {
            dgvNotas.DataSource = _notaService.ObtenerNotas();
            dgvNotas.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEstudiantes.SelectedItem == null || cmbMateria.SelectedItem == null || string.IsNullOrWhiteSpace(TxtNota.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TxtNota.Text, out decimal calificacion) || calificacion < 0 || calificacion > 100)
            {
                MessageBox.Show("Ingrese una calificación válida (0 - 100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstudiante = ((KeyValuePair<int, string>)cmbEstudiantes.SelectedItem).Key;
            int idMateria = ((KeyValuePair<int, string>)cmbMateria.SelectedItem).Key;

            try
            {
                _notaService.GuardarNota(idEstudiante, idMateria, calificacion);
                MessageBox.Show("Nota guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarNotas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e) => CargarEstudiantes();

    }
}