using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas;
using TuProyecto; 

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios
{
    public partial class Cursos : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public Cursos()
        {
            InitializeComponent();
            CargarCursos();
            CargarMaterias(); // Simplificado el nombre del método
            CargarDocentes();
            CargarHorarios();
            InicializarComboBoxDias(); // Inicializar el ComboBox de Días
        }

        private void InicializarComboBoxDias()
        {
            // Limpiar y agregar los días de la semana al ComboBox cbDia
            cbDia.Items.Clear();
            cbDia.Items.Add("Lunes");
            cbDia.Items.Add("Martes");
            cbDia.Items.Add("Miércoles");
            cbDia.Items.Add("Jueves");
            cbDia.Items.Add("Viernes");
            cbDia.SelectedIndex = 0; // Establecer un valor por defecto
        }
        private void CargarCursos()
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();
                
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string consulta = "SELECT id_curso, nombre FROM Cursos ORDER BY nombre ASC";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    cbCursos.Items.Clear();
                    // No es necesario agregar "Todos los cursos" aquí, se maneja en la lógica de filtrado de horarios
                    while (lector.Read())
                    {
                        int id = lector.GetInt32("id_curso");
                        string nombre = lector.GetString("nombre");
                        cbCursos.Items.Add(new KeyValuePair<int, string>(id, nombre));
                    }

                    lector.Close();
                    conexionBD.Desconectar();
                    cbCursos.DisplayMember = "Value";
                    cbCursos.ValueMember = "Key";
                    if (cbCursos.Items.Count > 0)
                        cbCursos.SelectedIndex = 0; //selecciona el primero si hay items

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error de MySQL al cargar cursos: " + ex.Message + "\n" + ex.StackTrace); // Registro de errores
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al cargar cursos: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error general al cargar cursos: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void CargarMaterias() // Simplificado el nombre
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();
                
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Consulta SQL para seleccionar las materias con ID
                    string consulta = "SELECT id_materia, nombre FROM Materias";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    cbMaterias.Items.Clear();
                    while (lector.Read())
                    {
                        int id = lector.GetInt32("id_materia");
                        string nombre = lector.GetString("nombre");
                        cbMaterias.Items.Add(new KeyValuePair<int, string>(id, nombre));
                    }

                    lector.Close();
                    conexionBD.Desconectar();
                    cbMaterias.DisplayMember = "Value"; // Establecer propiedades para mostrar el nombre y usar el ID
                    cbMaterias.ValueMember = "Key";
                    if (cbMaterias.Items.Count > 0)
                        cbMaterias.SelectedIndex = 0;
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error de MySQL al cargar materias: " + ex.Message + "\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al cargar materias: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error general al cargar materias: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void CargarDocentes()
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();
                
                    if (conexion == null)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Consulta SQL para seleccionar los Docentes con ID
                    string consulta = "SELECT id_docente, nombre FROM Docentes";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    cbDocentes.Items.Clear();
                    while (lector.Read())
                    {
                        int id = lector.GetInt32("id_docente");
                        string nombre = lector.GetString("nombre");
                        cbDocentes.Items.Add(new KeyValuePair<int, string>(id, nombre));
                    }

                    lector.Close();
                    conexionBD.Desconectar();
                    cbDocentes.DisplayMember = "Value"; // Establecer propiedades para mostrar el nombre y usar el ID
                    cbDocentes.ValueMember = "Key";
                    if (cbDocentes.Items.Count > 0)
                        cbDocentes.SelectedIndex = 0;
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar docentes: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error de MySQL al cargar docentes: " + ex.Message + "\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al cargar docentes: " + ex.Message, "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error general al cargar docentes: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
        private void CargarHorarios()
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();
                
                    if (conexion == null || conexion.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Error de conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string consulta = @"
                SELECT 
                    h.id_horario AS ID,
                    g.nombre AS Grado,  -- Nombre del grado (si existe tabla Grados_Academicos)
                    c.nombre AS Curso,
                    m.nombre AS Materia,
                    d.nombre AS Docente,
                    h.dia AS Día,
                    h.hora_inicio AS 'Hora Inicio',
                    h.hora_fin AS 'Hora Fin'
                FROM Horarios h
                INNER JOIN Cursos c ON h.id_curso = c.id_curso
                LEFT JOIN Grados_Academicos g ON h.id_grado = g.id_grado  -- Ajusta según tu esquema
                INNER JOIN Materias m ON h.id_materia = m.id_materia
                INNER JOIN Docentes d ON h.id_docente = d.id_docente";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tablaHorarios = new DataTable();
                    adaptador.Fill(tablaHorarios);

                    dgvHorarios.DataSource = tablaHorarios;
                    dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
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



        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cbCursos.SelectedItem == null || cbMaterias.SelectedItem == null ||
                cbDocentes.SelectedItem == null || cbDia.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener valores
            int idCurso = ((KeyValuePair<int, string>)cbCursos.SelectedItem).Key;
            int idMateria = ((KeyValuePair<int, string>)cbMaterias.SelectedItem).Key;
            int idDocente = ((KeyValuePair<int, string>)cbDocentes.SelectedItem).Key;
            string horaInicio = dtpHoraInicio.Value.ToString("HH:mm:ss");  // Formato TIME de MySQL
            string horaFin = dtpHoraFin.Value.ToString("HH:mm:ss");
            string dia = cbDia.SelectedItem.ToString();

            try
            {
                using (MySqlConnection conexion = conexionBD.Conectar())
                {
                    if (conexion == null || conexion.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Error de conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Consulta INSERT (incluye id_grado e id_curso)
                    string consulta = @"
                INSERT INTO Horarios 
                    (id_grado, id_curso, id_materia, id_docente, dia, hora_inicio, hora_fin) 
                VALUES 
                    (@idGrado, @idCurso, @idMateria, @idDocente, @dia, @horaInicio, @horaFin)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    
                        // Asignar parámetros
                        comando.Parameters.AddWithValue("@idGrado", idCurso);  // Asume que id_grado = id_curso
                        comando.Parameters.AddWithValue("@idCurso", idCurso);
                        comando.Parameters.AddWithValue("@idMateria", idMateria);
                        comando.Parameters.AddWithValue("@idDocente", idDocente);
                        comando.Parameters.AddWithValue("@dia", dia);
                        comando.Parameters.AddWithValue("@horaInicio", horaInicio);
                        comando.Parameters.AddWithValue("@horaFin", horaFin);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Horario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarHorarios();  // Actualizar la vista
                            LimpiarFormularioHorario();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                }
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

        private void LimpiarFormularioHorario()
        {
            cbCursos.SelectedIndex = -1;
            cbMaterias.SelectedIndex = -1;
            cbDocentes.SelectedIndex = -1;
            cbDia.SelectedIndex = -1; // Asegúrate de limpiar el ComboBox de días
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = DateTime.Now;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos1 cursos = new Cursos1();
            cursos.ShowDialog();
        }
    }
}
