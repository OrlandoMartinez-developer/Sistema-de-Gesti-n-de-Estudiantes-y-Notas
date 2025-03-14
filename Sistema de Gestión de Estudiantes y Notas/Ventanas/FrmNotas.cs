﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_de_Gestión_de_Estudiantes_y_Notas;
using TuProyecto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    public partial class FrmNotas : Form
    {
        ConexionBD conexionBD = new ConexionBD();


        public FrmNotas()
        {
            InitializeComponent();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            CargarEstudiantes(cmbEstudiantes);
            CargarCursos(cmbCurso);
            CargarMaterias(cmbMateria);
            CargarNotas(dgvNotas);
           
        }

        private void CargarEstudiantes(System.Windows.Forms.ComboBox cmbEstudiantes)
        {
            try
            {
                // Crear una instancia de la conexión
             
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    // Consulta SQL para seleccionar nombre y apellido
                    string consulta = "SELECT nombre, apellido FROM Estudiantes";

                    // Crear comando MySQL
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    // Limpiar el ComboBox antes de agregar los elementos
                    cmbEstudiantes.Items.Clear();

                    // Rellenar el ComboBox con los datos obtenidos
                    while (lector.Read())
                    {
                        string nombreCompleto = $"{lector["nombre"]} {lector["apellido"]}";
                        cmbEstudiantes.Items.Add(nombreCompleto);
                    }

                    // Cerrar el lector y la conexión
                    lector.Close();
                    conexionBD.Desconectar();
                }
                else
                {
                    MessageBox.Show("No se pudo establecer la conexión con la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void CargarCursos(System.Windows.Forms.ComboBox cmbCurso)
        {
            try
            {
                ConexionBD conexionBD = new ConexionBD();
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    string consulta = "SELECT nombre FROM Cursos ORDER BY nombre ASC";  // Ajusta el nombre de la tabla si es diferente
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbCurso.Items.Clear();  // Limpiar el ComboBox antes de llenarlo

                    while (reader.Read())
                    {
                        cmbCurso.Items.Add(reader["nombre"].ToString());
                    }

                    reader.Close();
                    conexionBD.Desconectar();
                }
                else
                {
                    MessageBox.Show(" No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Error en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error inesperado: " + ex.Message);
            }
        }
 

        private void CargarMaterias(System.Windows.Forms.ComboBox cmbMateria) 
        {
            try
            {
                // Crear una instancia de la conexión
                ConexionBD conexionBD = new ConexionBD();
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    // Consulta SQL para seleccionar las materias
                    string consulta = "SELECT nombre FROM Materias";

                    // Crear comando MySQL
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    // Limpiar el ComboBox antes de agregar los elementos
                    cmbMateria.Items.Clear(); // Usa el mismo nombre del parámetro

                    // Rellenar el ComboBox con los datos obtenidos
                    while (lector.Read())
                    {
                        cmbMateria.Items.Add(lector["nombre"].ToString());
                    }

                    // Cerrar el lector y la conexión
                    lector.Close();
                    conexionBD.Desconectar();
                }
                else
                {
                    MessageBox.Show(" No se pudo establecer la conexión con la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Error al cargar materias: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error general: " + ex.Message);
            }
        }

        private void CargarNotas(DataGridView dgvNotas)
        {
            try
            {
                // Crear una instancia de la conexión
                ConexionBD conexionBD = new ConexionBD();
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    // Consulta SQL
                    string consulta = @"
                SELECT 
                    e.id_estudiante, 
                    CONCAT(e.nombre, ' ', e.apellido) AS estudiante,
                    c.nombre AS curso,
                    m.nombre AS materia,
                    n.calificacion
                FROM Estudiantes e
                LEFT JOIN Cursos c ON e.id_curso = c.id_curso
                LEFT JOIN Notas n ON e.id_estudiante = n.id_estudiante
                LEFT JOIN Materias m ON n.id_materia = m.id_materia;
            ";

                    // Crear el adaptador y el DataTable
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataTable tabla = new System.Data.DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    adaptador.Fill(tabla);

                    // Asignar los datos al DataGridView
                    dgvNotas.DataSource = tabla;

                    // Cerrar la conexión
                    conexionBD.Desconectar();
                }
                else
                {
                    MessageBox.Show("No se pudo establecer la conexión con la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Error al cargar las notas: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error general: " + ex.Message);
            }
        }


        private int idNotaSeleccionada = -1; // Variable global para almacenar el ID de la nota seleccionada

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se hizo clic en una fila válida
            {
                DataGridViewRow fila = dgvNotas.Rows[e.RowIndex];

                // Obtener valores de la fila seleccionada
                string estudiante = fila.Cells["estudiante"].Value.ToString();
                string materia = fila.Cells["materia"].Value.ToString();
                string calificacion = fila.Cells["calificacion"].Value.ToString();

                // Buscar el ID de la nota seleccionada en la base de datos
                ConexionBD conexionBD = new ConexionBD();
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    string consulta = @"
                SELECT n.id_nota FROM Notas n
                JOIN Estudiantes e ON n.id_estudiante = e.id_estudiante
                JOIN Materias m ON n.id_materia = m.id_materia
                WHERE CONCAT(e.nombre, ' ', e.apellido) = @estudiante
                AND m.nombre = @materia";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@estudiante", estudiante);
                    cmd.Parameters.AddWithValue("@materia", materia);
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        idNotaSeleccionada = Convert.ToInt32(resultado); // Guardar el ID de la nota
                    }

                    conexionBD.Desconectar();
                }

                // Asignar los valores a los controles
                cmbEstudiantes.SelectedItem = estudiante;
                cmbMateria.SelectedItem = materia;
                TxtNota.Text = calificacion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstudiantes.SelectedItem == null || cmbMateria.SelectedItem == null || cmbCurso.SelectedItem == null || string.IsNullOrWhiteSpace(TxtNota.Text))
                {
                    MessageBox.Show("Debes seleccionar un estudiante, una materia, un curso y escribir una calificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(TxtNota.Text, out decimal calificacion) || calificacion < 0 || calificacion > 100)
                {
                    MessageBox.Show("La calificación debe ser un número entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConexionBD conexionBD = new ConexionBD();
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    string[] nombreApellido = cmbEstudiantes.SelectedItem.ToString().Split(' ');
                    if (nombreApellido.Length < 2)
                    {
                        MessageBox.Show("Error: No se pudo obtener el nombre y apellido correctamente.");
                        return;
                    }

                    string nombre = nombreApellido[0];
                    string apellido = nombreApellido[1];

                    // Obtener id_estudiante
                    string consultaEstudiante = "SELECT id_estudiante FROM Estudiantes WHERE nombre = @nombre AND apellido = @apellido";
                    MySqlCommand cmdEstudiante = new MySqlCommand(consultaEstudiante, conexion);
                    cmdEstudiante.Parameters.AddWithValue("@nombre", nombre);
                    cmdEstudiante.Parameters.AddWithValue("@apellido", apellido);
                    object resultadoEstudiante = cmdEstudiante.ExecuteScalar();

                    if (resultadoEstudiante == null)
                    {
                        MessageBox.Show(" No se encontró el estudiante en la base de datos.");
                        return;
                    }
                    int idEstudiante = Convert.ToInt32(resultadoEstudiante);

                    // Obtener id_materia
                    string consultaMateria = "SELECT id_materia FROM Materias WHERE nombre = @nombre";
                    MySqlCommand cmdMateria = new MySqlCommand(consultaMateria, conexion);
                    cmdMateria.Parameters.AddWithValue("@nombre", cmbMateria.SelectedItem.ToString());
                    object resultadoMateria = cmdMateria.ExecuteScalar();

                    if (resultadoMateria == null)
                    {
                        MessageBox.Show(" No se encontró la materia en la base de datos.");
                        return;
                    }
                    int idMateria = Convert.ToInt32(resultadoMateria);

                    // Obtener id_curso
                    string consultaCurso = "SELECT id_curso FROM Cursos WHERE nombre = @nombre"; // Cambio: Correcta referencia a la tabla Cursos
                    MySqlCommand cmdCurso = new MySqlCommand(consultaCurso, conexion);
                    cmdCurso.Parameters.AddWithValue("@nombre", cmbCurso.SelectedItem.ToString());
                    object resultadoCurso = cmdCurso.ExecuteScalar();

                    if (resultadoCurso == null)
                    {
                        MessageBox.Show("❌ No se encontró el curso en la base de datos.");
                        return;
                    }
                    int idCurso = Convert.ToInt32(resultadoCurso);

                    // Verificar si ya existe una nota en la misma materia y curso
                    string consultaNotas = @"
                SELECT id_nota FROM Notas 
                WHERE id_estudiante = @idEstudiante 
                AND id_materia = @idMateria 
                AND id_curso = @idCurso"; // Cambio: Campo id_curso en lugar de curso

                    MySqlCommand cmdNotas = new MySqlCommand(consultaNotas, conexion);
                    cmdNotas.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                    cmdNotas.Parameters.AddWithValue("@idMateria", idMateria);
                    cmdNotas.Parameters.AddWithValue("@idCurso", idCurso);

                    object resultadoNota = cmdNotas.ExecuteScalar();

                    if (resultadoNota != null) // Si ya existe una nota para esta materia y curso
                    {
                        MessageBox.Show(" El estudiante ya tiene una nota registrada para esta materia en este curso. No se pueden agregar más.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insertar nueva nota si no hay ninguna en el curso actual
                    string consultaInsertar = "INSERT INTO Notas (id_estudiante, id_materia, calificacion, id_curso, fecha_registro) VALUES (@idEstudiante, @idMateria, @calificacion, @idCurso, NOW())"; // Cambio: id_curso
                    MySqlCommand cmdInsertar = new MySqlCommand(consultaInsertar, conexion);
                    cmdInsertar.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                    cmdInsertar.Parameters.AddWithValue("@idMateria", idMateria);
                    cmdInsertar.Parameters.AddWithValue("@calificacion", calificacion);
                    cmdInsertar.Parameters.AddWithValue("@idCurso", idCurso);

                    int filasAfectadas = cmdInsertar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show(" Nota guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarNotas(dgvNotas);
                    }
                    else
                    {
                        MessageBox.Show(" No se pudo guardar la nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conexionBD.Desconectar();
                }
                else
                {
                    MessageBox.Show(" No se pudo establecer la conexión con la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Error en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error inesperado: " + ex.Message);
            }
        }

    }



}
