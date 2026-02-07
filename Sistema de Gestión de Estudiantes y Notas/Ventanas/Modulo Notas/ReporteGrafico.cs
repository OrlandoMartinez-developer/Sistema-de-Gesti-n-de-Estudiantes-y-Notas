using System;
using System.Windows.Forms;
using CoBD; 
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas
{
    public partial class ReporteGrafico : Form

    {
        ConexionBD conexionBD = new ConexionBD();
        public ReporteGrafico(int idEstudiante, int idCurso)
        {
            InitializeComponent();
            GenerarGrafico(idEstudiante, idCurso);
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void GenerarGrafico(int idEstudiante, int idCurso)
        {
            try
            {
                // Crear la conexión a la base de datos
                MySqlConnection conexion = conexionBD.Conectar();
                if (conexion != null)
                {
                    string consulta = "SELECT e.nombre, e.apellido, c.nombre AS curso, n.calificacion " +
                                      "FROM Notas n " +
                                      "JOIN Estudiantes e ON n.id_estudiante = e.id_estudiante " +
                                      "JOIN Cursos c ON n.id_curso = c.id_curso " +
                                      "WHERE (@idEstudiante = 0 OR n.id_estudiante = @idEstudiante) " +
                                      "AND (@idCurso = 0 OR n.id_curso = @idCurso)";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                    cmd.Parameters.AddWithValue("@idCurso", idCurso);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    // Crear un gráfico de barras
                    chartReporte.Series.Clear();
                    var serie = chartReporte.Series.Add("Calificación");
                    serie.ChartType = SeriesChartType.Bar;

                    // Llenar el gráfico con los datos
                    foreach (DataRow row in dt.Rows)
                    {
                        serie.Points.AddXY(row["curso"].ToString(), Convert.ToDouble(row["calificacion"]));
                    }

                    conexionBD.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar gráfico: " + ex.Message);
            }
        }
    }
}
