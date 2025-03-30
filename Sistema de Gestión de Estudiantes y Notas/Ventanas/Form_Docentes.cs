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
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas
{
    public partial class Form_Docentes: Form
    {
        ConexionBD conexionBD = new ConexionBD();
        public Form_Docentes()
        {
            InitializeComponent();
        }

        private void Form_Johan_Load(object sender, EventArgs e)
        {
            CargarDocentes(cmbDocentes);
            CargarCursos(cmbCurso);
            CargarMaterias(cmbMateria);
            CargarMatYHor(dgvMatYHor);

        }
        private void CargarDocentes(System.Windows.Forms.ComboBox cmbDocentes)
        {
            try
            {
                // Crear una instancia de la conexión

                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    // Consulta SQL para seleccionar nombre y apellido
                    string consulta = "SELECT nombre, apellido FROM Docentes";

                    // Crear comando MySQL
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    // Limpiar el ComboBox antes de agregar los elementos
                    cmbDocentes.Items.Clear();

                    // Rellenar el ComboBox con los datos obtenidos
                    while (lector.Read())
                    {
                        string nombreCompleto = $"{lector["nombre"]} {lector["apellido"]}";
                        cmbDocentes.Items.Add(nombreCompleto);
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
                MessageBox.Show("Error al cargar Docentes: " + ex.Message);
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

        private void dgvDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvMatYHor.Rows[e.RowIndex];
                    string docente = fila.Cells["docente"].Value.ToString();
                    string curso = fila.Cells["curso"].Value.ToString();
                    string materia = fila.Cells["materia"].Value.ToString();
                    string horario = fila.Cells["horario"].Value.ToString();
                    cmbDocentes.SelectedItem = docente;
                    cmbCurso.SelectedItem = curso;
                    cmbMateria.SelectedItem = materia;
                    cmbHora_In.SelectedItem = horario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
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
            private void dgvMatYHor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvMatYHor.Rows[e.RowIndex];
                    string docentes = fila.Cells["docentes"].Value.ToString();
                    string curso = fila.Cells["curso"].Value.ToString();
                    string materia = fila.Cells["materia"].Value.ToString();
                    string horario = fila.Cells["horario"].Value.ToString();
                    cmbDocentes.SelectedItem = docentes;
                    cmbCurso.SelectedItem = curso;
                    cmbMateria.SelectedItem = materia;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }
        private void CargarMatYHor(DataGridView dgvMatYHor)
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
                    dgvMatYHor.DataSource = tabla;

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

