using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios
{
    public partial class Cursos1 : Form
    {
        ConexionBD bd = new ConexionBD();

        public Cursos1()
        {
            InitializeComponent();
            CargarCursos();
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            try
            {
                MySqlConnection conexion = bd.Conectar();
                string consulta = "SELECT id_estudiante, CONCAT(nombre, ' ', apellido) AS NombreCompleto FROM Estudiantes";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataTable tablaEstudiantes = new DataTable();
                adaptador.Fill(tablaEstudiantes);

                cmbEstudiante.DataSource = tablaEstudiantes;
                cmbEstudiante.DisplayMember = "NombreCompleto";
                cmbEstudiante.ValueMember = "id_estudiante";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCursos()
        {
            try
            {
                MySqlConnection conexion = bd.Conectar();

                if (conexion == null || conexion.State != ConnectionState.Open)
                {
                    MessageBox.Show("Error de conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string consulta = "SELECT id_curso AS ID, nombre AS Curso FROM Cursos";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                DataTable tablaCursos = new DataTable();
                adaptador.Fill(tablaCursos);

                dgvCursos.DataSource = tablaCursos;
                dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de MySQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCursoEstudiante(int idEstudiante)
        {
            try
            {
                MySqlConnection conexion = bd.Conectar();
                string consulta = @"SELECT c.nombre 
                                  FROM Estudiantes e 
                                  LEFT JOIN Cursos c ON e.id_curso = c.id_curso 
                                  WHERE e.id_estudiante = @idEstudiante";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                object resultado = comando.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    lblCursoEstudiante.Text = resultado.ToString();
                    lblCursoEstudiante.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblCursoEstudiante.Text = "Sin curso asignado";
                    lblCursoEstudiante.ForeColor = System.Drawing.Color.Gray;
                }
            }
            catch (Exception ex)
            {
                lblCursoEstudiante.Text = "Error al cargar curso";
                lblCursoEstudiante.ForeColor = System.Drawing.Color.Red;
                Console.WriteLine($"Error al mostrar curso: {ex.Message}");
            }
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedValue != null && cmbEstudiante.SelectedValue is int)
            {
                int idEstudiante = (int)cmbEstudiante.SelectedValue;
                MostrarCursoEstudiante(idEstudiante);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurso.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection conexion = bd.Conectar();
                string consulta = "INSERT INTO Cursos (nombre) VALUES (@nombre)";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", txtCurso.Text);

                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Curso agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCurso.Clear();
                    CargarCursos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un curso para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCurso = Convert.ToInt32(dgvCursos.SelectedRows[0].Cells["ID"].Value);

            try
            {
                MySqlConnection conexion = bd.Conectar();
                string eliminarCurso = "DELETE FROM Cursos WHERE id_curso = @idCurso";
                MySqlCommand comandoCurso = new MySqlCommand(eliminarCurso, conexion);
                comandoCurso.Parameters.AddWithValue("@idCurso", idCurso);

                int resultado = comandoCurso.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Curso eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCursos();

                    // Actualizar la información del estudiante si estaba viendo uno
                    if (cmbEstudiante.SelectedValue != null)
                    {
                        MostrarCursoEstudiante((int)cmbEstudiante.SelectedValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarCurso_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedValue == null || dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un estudiante y un curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstudiante = (int)cmbEstudiante.SelectedValue;
            int idCurso = Convert.ToInt32(dgvCursos.SelectedRows[0].Cells["ID"].Value);

            try
            {
                MySqlConnection conexion = bd.Conectar();
                string asignarCurso = "UPDATE Estudiantes SET id_curso = @idCurso WHERE id_estudiante = @idEstudiante";
                MySqlCommand comandoAsignar = new MySqlCommand(asignarCurso, conexion);
                comandoAsignar.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comandoAsignar.Parameters.AddWithValue("@idCurso", idCurso);

                int resultado = comandoAsignar.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Curso asignado correctamente al estudiante", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCursoEstudiante(idEstudiante);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCursoEstudiante_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un estudiante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstudiante = (int)cmbEstudiante.SelectedValue;

            try
            {
                MySqlConnection conexion = bd.Conectar();
                string eliminarCurso = "UPDATE Estudiantes SET id_curso = NULL WHERE id_estudiante = @idEstudiante";
                MySqlCommand comando = new MySqlCommand(eliminarCurso, conexion);
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Curso eliminado correctamente del estudiante", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCursoEstudiante(idEstudiante);
                }
                else
                {
                    MessageBox.Show("El estudiante no tenía curso asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar curso del estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes implementar lógica adicional si necesitas manejar clicks específicos en celdas
        }
    }
}