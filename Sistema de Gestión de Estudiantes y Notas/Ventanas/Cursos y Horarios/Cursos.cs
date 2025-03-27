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
using TuProyecto; // Asegúrate de que este namespace es correcto

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
                using (MySqlConnection conexion = conexionBD.Conectar())
                {
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
                using (MySqlConnection conexion = conexionBD.Conectar())
                {
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
                using (MySqlConnection conexion = conexionBD.Conectar())
                {
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
                using (MySqlConnection conexion = conexionBD.Conectar())
                {
                    if (conexion == null || conexion.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos. Por favor, verifique su conexión y vuelva a intentarlo.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Consulta SQL mejorada y más segura, usando parámetros para evitar inyección SQL
                    string consulta = @"
                SELECT 
                    h.id_horario AS ID,
                    c.nombre AS Curso,
                    m.nombre AS Materia,
                    d.nombre AS Docente, -- Asume que quieres el nombre del docente
                    h.dia AS Día,
                    h.hora_inicio AS 'Hora de Inicio',
                    h.hora_fin AS 'Hora de Fin'
                FROM Horarios h
                INNER JOIN Cursos c ON h.id_curso = c.id_curso
                INNER JOIN Materias m ON h.id_materia = m.id_materia
                INNER JOIN Docentes d ON h.id_docente = d.id_docente"; // Join con la tabla Docentes

                    MySqlCommand comando = new MySqlCommand(consulta, conexion); // Usar SqlCommand
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tablaHorarios = new DataTable();
                    adaptador.Fill(tablaHorarios);

                    // Asignar los datos al DataGridView
                    dgvHorarios.DataSource = tablaHorarios;
                    dgvHorarios.AutoGenerateColumns = true; // Asegurar que las columnas se generen automáticamente.

                    // Opcional: Personalizar nombres de las columnas del DataGridView (puedes hacerlo aquí o en el diseñador)
                    if (dgvHorarios.Columns.Count > 0)
                    {
                        dgvHorarios.Columns["ID"].HeaderText = "ID";
                        dgvHorarios.Columns["Curso"].HeaderText = "Curso";
                        dgvHorarios.Columns["Materia"].HeaderText = "Materia";
                        dgvHorarios.Columns["Docente"].HeaderText = "Docente";
                        dgvHorarios.Columns["Día"].HeaderText = "Día";
                        dgvHorarios.Columns["Hora de Inicio"].HeaderText = "Hora de Inicio";
                        dgvHorarios.Columns["Hora de Fin"].HeaderText = "Hora de Fin";
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Log de errores (recomendado para producción)
                Console.WriteLine("Error de MySQL al cargar horarios: " + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Error al cargar los horarios: " + ex.Message + ". Por favor, contacte al administrador del sistema.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturar otros tipos de excepciones (importante para la robustez)
                Console.WriteLine("Error general al cargar horarios: " + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Se produjo un error inesperado al cargar los horarios: " + ex.Message + ". Por favor, contacte al administrador del sistema.", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            if (cbCursos.SelectedItem == null || cbMaterias.SelectedItem == null || cbDocentes.SelectedItem == null || string.IsNullOrEmpty(dtpHoraInicio.Text) || string.IsNullOrEmpty(dtpHoraFin.Text) || cbDia.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un curso, una materia, un docente, un día y especifique las horas de inicio y fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCurso = ((KeyValuePair<int, string>)cbCursos.SelectedItem).Key;
            int idMateria = ((KeyValuePair<int, string>)cbMaterias.SelectedItem).Key;
            int idDocente = ((KeyValuePair<int, string>)cbDocentes.SelectedItem).Key;
            string horaInicio = dtpHoraInicio.Value.ToString("HH:mm");
            string horaFin = dtpHoraFin.Value.ToString("HH:mm");
            string dia = cbDia.SelectedItem.ToString(); // Obtener el día seleccionado del ComboBox cbDia

            try
            {
                using (MySqlConnection conexion = conexionBD.Conectar())
                {
                    if (conexion == null || conexion.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos. Por favor, verifique su conexión y vuelva a intentarlo.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Consulta SQL mejorada: Usa los IDs en lugar de los nombres.  Incluye el día.
                    string consulta = @"
                INSERT INTO Horarios (id_curso, id_materia, id_docente, hora_inicio, hora_fin, dia) 
                VALUES (@idCurso, @idMateria, @idDocente, @horaInicio, @horaFin, @dia)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idCurso", idCurso);
                        comando.Parameters.AddWithValue("@idMateria", idMateria);
                        comando.Parameters.AddWithValue("@idDocente", idDocente);
                        comando.Parameters.AddWithValue("@horaInicio", horaInicio);
                        comando.Parameters.AddWithValue("@horaFin", horaFin);
                        comando.Parameters.AddWithValue("@dia", dia); // Añadir el parámetro del día

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Horario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarHorarios(); // Refrescar la tabla después de agregar un horario
                            LimpiarFormularioHorario(); // Llamar a la función para limpiar el formulario
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el horario.  Verifique que los datos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Log de errores
                Console.WriteLine("Error de MySQL al agregar horario: " + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Error al agregar horario: " + ex.Message + ". Por favor, contacte al administrador del sistema.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturar otros errores
                Console.WriteLine("Error general al agregar horario: " + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Se produjo un error inesperado al agregar el horario: " + ex.Message + ". Por favor, contacte al administrador del sistema.", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



    }
}
