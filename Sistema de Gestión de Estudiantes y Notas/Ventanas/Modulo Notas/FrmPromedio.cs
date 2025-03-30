using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas
{
    public partial class FrmPromedio : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public FrmPromedio()
        {
         
            InitializeComponent();
            CargarEstudiantes(cmbEstudiantes);
            CargarCursos(cmbCurso);
        }

        private void CargarEstudiantes(System.Windows.Forms.ComboBox cmbEstudiantes)
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    string consulta = "SELECT id_estudiante, nombre, apellido FROM Estudiantes";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    cmbEstudiantes.Items.Clear();

                    while (lector.Read())
                    {
                        int id = lector.GetInt32("id_estudiante");
                        string nombreCompleto = $"{lector["nombre"]} {lector["apellido"]}";
                        cmbEstudiantes.Items.Add(new KeyValuePair<int, string>(id, nombreCompleto));
                    }

                    lector.Close();
                    conexionBD.Desconectar();

                    cmbEstudiantes.DisplayMember = "Value"; // Muestra el nombre
                    cmbEstudiantes.ValueMember = "Key"; // Guarda el ID
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
        }


        private void CargarCursos(System.Windows.Forms.ComboBox cmbCurso)
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    string consulta = "SELECT id_curso, nombre FROM Cursos ORDER BY nombre ASC";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbCurso.Items.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id_curso");
                        string nombre = reader.GetString("nombre");
                        cmbCurso.Items.Add(new KeyValuePair<int, string>(id, nombre));
                    }

                    reader.Close();
                    conexionBD.Desconectar();

                    cmbCurso.DisplayMember = "Value"; // Muestra el nombre
                    cmbCurso.ValueMember = "Key"; // Guarda el ID
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedItem == null || cmbEstudiantes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso y un estudiante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var estudianteSeleccionado = (KeyValuePair<int, string>)cmbEstudiantes.SelectedItem;
                var cursoSeleccionado = (KeyValuePair<int, string>)cmbCurso.SelectedItem;

                int idEstudiante = estudianteSeleccionado.Key;
                int idCurso = cursoSeleccionado.Key;

                MySqlConnection conexion = conexionBD.Conectar();

                if (conexion != null)
                {
                    string consulta = "SELECT AVG(calificacion) AS promedio FROM Notas " +
                                      "WHERE id_estudiante = @idEstudiante AND id_curso = @idCurso";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                    cmd.Parameters.AddWithValue("@idCurso", idCurso);

                    object resultado = cmd.ExecuteScalar();
                    conexionBD.Desconectar();

                    if (resultado != DBNull.Value)
                    {
                        lblPromedio.Text = "Promedio: " + Convert.ToDouble(resultado).ToString("0.00");
                    }
                    else
                    {
                        lblPromedio.Text = "El estudiante no tiene notas registradas.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el promedio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPromedio_Click(object sender, EventArgs e)
        {

        }
    }

    // Clase auxiliar para manejar los valores en los ComboBox
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
