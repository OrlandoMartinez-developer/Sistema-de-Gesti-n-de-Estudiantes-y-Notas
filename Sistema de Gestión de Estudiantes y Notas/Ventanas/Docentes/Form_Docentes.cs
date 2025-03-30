using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas
{
    public partial class Form_Docentes : Form
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        private int docenteSeleccionadoId = -1;
        private bool modoEdicionDocente = false;

        public Form_Docentes()
        {
            InitializeComponent();
        }

        private void Form_Docentes_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar pestañas
            tabControl1.SelectedIndex = 0;

            // Configurar ComboBox de docentes
            cmbDocentes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarDatosIniciales()
        {
            try
            {
                CargarComboDocentes();
                CargarCursos();
                CargarMaterias();
                CargarAsignacionesDocentes();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar datos iniciales", ex);
            }
        }

        private void CargarComboDocentes()
        {
            try
            {
                var conexion = conexionBD.Conectar();
                
                    const string consulta = @"SELECT id_docente, CONCAT(nombre, ' ', apellido) AS nombre_completo 
                                           FROM Docentes ORDER BY nombre, apellido";
                    var adaptador = new MySqlDataAdapter(consulta, conexion);
                    var tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbDocentes.DataSource = tabla;
                    cmbDocentes.DisplayMember = "nombre_completo";
                    cmbDocentes.ValueMember = "id_docente";
                
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar docentes", ex);
            }
        }

        private void CargarCursos()
        {
            try
            {
                var conexion = conexionBD.Conectar();
                
                    const string consulta = "SELECT id_curso, nombre FROM Cursos ORDER BY nombre ASC";
                    var adaptador = new MySqlDataAdapter(consulta, conexion);
                    var tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbCurso.DataSource = tabla;
                    cmbCurso.DisplayMember = "nombre";
                    cmbCurso.ValueMember = "id_curso";
                
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar cursos", ex);
            }
        }

        private void CargarMaterias()
        {
            try
            {
                var conexion = conexionBD.Conectar();
                
                    const string consulta = "SELECT id_materia, nombre FROM Materias ORDER BY nombre";
                    var adaptador = new MySqlDataAdapter(consulta, conexion);
                    var tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbMateria.DataSource = tabla;
                    cmbMateria.DisplayMember = "nombre";
                    cmbMateria.ValueMember = "id_materia";
                
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar materias", ex);
            }
        }

        private void CargarAsignacionesDocentes()
        {
            try
            {
                var conexion = conexionBD.Conectar();
                
                    const string consulta = @"
                        SELECT 
                            d.id_docente,
                            CONCAT(d.nombre, ' ', d.apellido) AS docente,
                            c.nombre AS curso,
                            m.nombre AS materia
                        FROM Docentes d
                        LEFT JOIN Horarios h ON d.id_docente = h.id_docente
                        LEFT JOIN Cursos c ON h.id_curso = c.id_curso
                        LEFT JOIN Materias m ON h.id_materia = m.id_materia
                        ORDER BY docente, curso, materia";

                    var adaptador = new MySqlDataAdapter(consulta, conexion);
                    var tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvMatYHor.DataSource = tabla;

                    // Configurar columnas si es necesario
                    if (dgvMatYHor.Columns.Count == 0)
                    {
                        dgvMatYHor.AutoGenerateColumns = false;
                        dgvMatYHor.Columns.Add("id_docente", "ID Docente");
                        dgvMatYHor.Columns.Add("docente", "Docente");
                        dgvMatYHor.Columns.Add("curso", "Curso");
                        dgvMatYHor.Columns.Add("materia", "Materia");

                        dgvMatYHor.Columns["id_docente"].DataPropertyName = "id_docente";
                        dgvMatYHor.Columns["docente"].DataPropertyName = "docente";
                        dgvMatYHor.Columns["curso"].DataPropertyName = "curso";
                        dgvMatYHor.Columns["materia"].DataPropertyName = "materia";

                        dgvMatYHor.Columns["id_docente"].Visible = false;
                    }
                
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar asignaciones", ex);
            }
        }

        private void cmbDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocentes.SelectedValue != null && int.TryParse(cmbDocentes.SelectedValue.ToString(), out int id))
            {
                docenteSeleccionadoId = id;
            }
        }

        private void dgvMatYHor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var fila = dgvMatYHor.Rows[e.RowIndex];
                docenteSeleccionadoId = Convert.ToInt32(fila.Cells["id_docente"].Value);
                cmbDocentes.SelectedValue = docenteSeleccionadoId;

                // Seleccionar curso y materia correspondientes
                if (fila.Cells["curso"].Value != null)
                    cmbCurso.Text = fila.Cells["curso"].Value.ToString();

                if (fila.Cells["materia"].Value != null)
                    cmbMateria.Text = fila.Cells["materia"].Value.ToString();
            }
            catch (Exception ex)
            {
                MostrarError("Error al seleccionar fila", ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var conexion = conexionBD.Conectar();
                
                    var idCurso = (int)cmbCurso.SelectedValue;
                    var idMateria = (int)cmbMateria.SelectedValue;
                    docenteSeleccionadoId = (int)cmbDocentes.SelectedValue;

                    if (ExisteAsignacion(conexion, docenteSeleccionadoId, idCurso, idMateria))
                    {
                        MessageBox.Show("Esta asignación ya existe.", "Advertencia",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    CrearAsignacion(conexion, docenteSeleccionadoId, idCurso, idMateria);
                    MessageBox.Show("Asignación creada correctamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAsignacionesDocentes();
                
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar asignación", ex);
            }
        }

        private bool ValidarCampos()
        {
            if (cmbDocentes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un docente.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCurso.SelectedIndex == -1 || cmbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un curso y una materia.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ExisteAsignacion(MySqlConnection conexion, int idDocente, int idCurso, int idMateria)
        {
            const string consulta = @"SELECT COUNT(*) FROM Horarios 
                                    WHERE id_docente = @idDocente 
                                    AND id_curso = @idCurso 
                                    AND id_materia = @idMateria";

            var comando = new MySqlCommand(consulta, conexion);
            
                comando.Parameters.AddWithValue("@idDocente", idDocente);
                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                return Convert.ToInt32(comando.ExecuteScalar()) > 0;
            
        }

        private void CrearAsignacion(MySqlConnection conexion, int idDocente, int idCurso, int idMateria)
        {
            const string consulta = @"INSERT INTO Horarios 
                                   (id_docente, id_curso, id_materia) 
                                   VALUES (@idDocente, @idCurso, @idMateria)";

            var comando = new MySqlCommand(consulta, conexion);
            
                comando.Parameters.AddWithValue("@idDocente", idDocente);
                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.ExecuteNonQuery();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbDocentes.SelectedIndex == -1 || cmbCurso.SelectedIndex == -1 || cmbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una asignación completa para eliminar.",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta asignación?", "Confirmar",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var conexion = conexionBD.Conectar();
                
                    var idCurso = (int)cmbCurso.SelectedValue;
                    var idMateria = (int)cmbMateria.SelectedValue;
                    docenteSeleccionadoId = (int)cmbDocentes.SelectedValue;

                    EliminarAsignacion(conexion, docenteSeleccionadoId, idCurso, idMateria);
                    MessageBox.Show("Asignación eliminada correctamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAsignacionesDocentes();
                    LimpiarSeleccion();
                
            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar asignación", ex);
            }
        }

        private void EliminarAsignacion(MySqlConnection conexion, int idDocente, int idCurso, int idMateria)
        {
            const string consulta = @"DELETE FROM Horarios 
                                    WHERE id_docente = @idDocente 
                                    AND id_curso = @idCurso 
                                    AND id_materia = @idMateria";

            var comando = new MySqlCommand(consulta, conexion);
            
                comando.Parameters.AddWithValue("@idDocente", idDocente);
                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.ExecuteNonQuery();
            
        }

        private void LimpiarSeleccion()
        {
            docenteSeleccionadoId = -1;
            cmbDocentes.SelectedIndex = -1;
            cmbCurso.SelectedIndex = -1;
            cmbMateria.SelectedIndex = -1;
        }

        private void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show($"{mensaje}: {ex.Message}", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}