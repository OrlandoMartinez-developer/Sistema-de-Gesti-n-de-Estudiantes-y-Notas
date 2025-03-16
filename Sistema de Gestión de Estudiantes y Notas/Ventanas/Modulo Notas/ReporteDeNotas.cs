using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas
{
    public partial class ReporteDeNotas : Form
    {
        ConexionBD conexionBD = new ConexionBD();
        public ReporteDeNotas()
        {
            InitializeComponent();
            CargarEstudiantes();
            CargarCursos();
        }

        private void ReporteDeNotas_Load(object sender, EventArgs e)
        {

        }
        private void CargarEstudiantes()
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
                    cmbEstudiantes.Items.Add(new KeyValuePair<int, string>(0, "Todos los estudiantes"));

                    while (lector.Read())
                    {
                        int id = lector.GetInt32("id_estudiante");
                        string nombreCompleto = $"{lector["nombre"]} {lector["apellido"]}";
                        cmbEstudiantes.Items.Add(new KeyValuePair<int, string>(id, nombreCompleto));
                    }

                    lector.Close();
                    conexionBD.Desconectar();
                    cmbEstudiantes.DisplayMember = "Value";
                    cmbEstudiantes.ValueMember = "Key";
                    cmbEstudiantes.SelectedIndex = 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
        }
        private void CargarCursos()
        {
            try
            {
                MySqlConnection conexion = conexionBD.Conectar();
                if (conexion != null)
                {
                    string consulta = "SELECT id_curso, nombre FROM Cursos ORDER BY nombre ASC";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader lector = comando.ExecuteReader();

                    cmbCurso.Items.Clear();
                    cmbCurso.Items.Add(new KeyValuePair<int, string>(0, "Todos los cursos"));

                    while (lector.Read())
                    {
                        int id = lector.GetInt32("id_curso");
                        string nombre = lector.GetString("nombre");
                        cmbCurso.Items.Add(new KeyValuePair<int, string>(id, nombre));
                    }

                    lector.Close();
                    conexionBD.Desconectar();
                    cmbCurso.DisplayMember = "Value";
                    cmbCurso.ValueMember = "Key";
                    cmbCurso.SelectedIndex = 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            var estudianteSeleccionado = (KeyValuePair<int, string>)cmbEstudiantes.SelectedItem;
            var cursoSeleccionado = (KeyValuePair<int, string>)cmbCurso.SelectedItem;

            int idEstudiante = estudianteSeleccionado.Key;
            int idCurso = cursoSeleccionado.Key;

            try
            {
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
                    dgvReporteNotas.DataSource = dt;

                    conexionBD.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvReporteNotas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF (*.pdf)|*.pdf";
            saveFile.FileName = "ReporteNotas.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
                    doc.Open();

                    doc.Add(new Paragraph("Reporte de Notas\n\n"));
                    PdfPTable table = new PdfPTable(dgvReporteNotas.Columns.Count);
                    foreach (DataGridViewColumn column in dgvReporteNotas.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    foreach (DataGridViewRow row in dgvReporteNotas.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Reporte exportado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar PDF: " + ex.Message);
                }
            }
        }
    }
}
