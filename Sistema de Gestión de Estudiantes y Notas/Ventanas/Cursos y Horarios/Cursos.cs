using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar opciones de exportación
            using (var formExportar = new Form())
            {
                formExportar.Text = "Opciones de Exportación";
                formExportar.Size = new Size(300, 200);
                formExportar.StartPosition = FormStartPosition.CenterParent;

                var btnPDF = new Button() { Text = "Exportar a PDF", Left = 50, Top = 20, Width = 200 };
                var btnWord = new Button() { Text = "Exportar a Word", Left = 50, Top = 60, Width = 200 };
                var btnVistaPrevia = new Button() { Text = "Vista Previa", Left = 50, Top = 100, Width = 200 };

                btnPDF.Click += (s, ev) => { formExportar.DialogResult = DialogResult.Yes; formExportar.Close(); };
                btnWord.Click += (s, ev) => { formExportar.DialogResult = DialogResult.No; formExportar.Close(); };
                btnVistaPrevia.Click += (s, ev) => { formExportar.DialogResult = DialogResult.OK; formExportar.Close(); };

                formExportar.Controls.Add(btnPDF);
                formExportar.Controls.Add(btnWord);
                formExportar.Controls.Add(btnVistaPrevia);

                var result = formExportar.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    ExportarAPDF();
                }
                else if (result == DialogResult.No)
                {
                    ExportarAWord();
                }
                else if (result == DialogResult.OK)
                {
                    MostrarVistaPrevia();
                }
            }
        }

        private void ExportarAPDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar horario como PDF";
            saveFileDialog.FileName = $"Horario_{DateTime.Now:yyyyMMddHHmmss}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Especificar el namespace completo para evitar ambigüedad
                    iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 10, 10);
                    iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    // Título del documento - usar el namespace completo
                    iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA_BOLD,
                        18f,
                        iTextSharp.text.BaseColor.BLACK);

                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Horario del Curso", titleFont);
                    title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    title.SpacingAfter = 20f;
                    document.Add(title);

                    // Crear tabla para el horario
                    iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(6);
                    table.WidthPercentage = 100;

                    // Configuración de celdas
                    iTextSharp.text.pdf.PdfPCell cell;
                    iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA_BOLD,
                        10f,
                        iTextSharp.text.BaseColor.BLACK);

                    iTextSharp.text.Font cellFont = iTextSharp.text.FontFactory.GetFont(
                        iTextSharp.text.FontFactory.HELVETICA,
                        9f,
                        iTextSharp.text.BaseColor.BLACK);

                    // Encabezados de columnas (días de la semana)
                    string[] dias = { "Hora", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                    foreach (string dia in dias)
                    {
                        cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(dia, headerFont));
                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(200, 200, 200);
                        table.AddCell(cell);
                    }

                    // Obtener datos del DataGridView y organizarlos
                    DataTable horarios = (DataTable)dgvHorarios.DataSource;
                    DataView view = new DataView(horarios);
                    view.Sort = "hora_inicio ASC";

                    // Agrupar por horas
                    string[,] celdas = new string[24, 5]; // 24 horas, 5 días

                    foreach (DataRowView row in view)
                    {
                        string horaInicio = row["hora_inicio"].ToString().Substring(0, 5);
                        string dia = row["Dia"].ToString();
                        string materia = row["Materia"].ToString();
                        string docente = row["Docente"].ToString();

                        int columna = Array.IndexOf(dias, dia) - 1;
                        if (columna >= 0 && columna < 5)
                        {
                            int fila = int.Parse(horaInicio.Split(':')[0]);
                            celdas[fila, columna] = $"{materia}\n{docente}";
                        }
                    }

                    // Llenar la tabla
                    for (int hora = 7; hora < 20; hora++)
                    {
                        // Celda de hora
                        cell = new iTextSharp.text.pdf.PdfPCell(
                            new iTextSharp.text.Phrase($"{hora}:00 - {hora + 1}:00", cellFont));
                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        table.AddCell(cell);

                        // Celdas para cada día
                        for (int dia = 0; dia < 5; dia++)
                        {
                            string contenido = celdas[hora, dia] ?? "";
                            cell = new iTextSharp.text.pdf.PdfPCell(
                                new iTextSharp.text.Phrase(contenido, cellFont));
                            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                            cell.MinimumHeight = 40f;
                            table.AddCell(cell);
                        }
                    }

                    document.Add(table);
                    document.Close();

                    MessageBox.Show("Horario exportado a PDF correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportarAWord()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Documento Word (*.docx)|*.docx";
            saveFileDialog.Title = "Guardar horario como Word";
            saveFileDialog.FileName = $"Horario_{DateTime.Now:yyyyMMddHHmmss}.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();

                    // Título del documento
                    Microsoft.Office.Interop.Word.Paragraph titlePara = wordDoc.Paragraphs.Add();
                    titlePara.Range.Text = "Horario del Curso";
                    titlePara.Range.Font.Bold = 1;
                    titlePara.Range.Font.Size = 18;
                    titlePara.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    titlePara.Range.InsertParagraphAfter();

                    // Crear tabla
                    Microsoft.Office.Interop.Word.Table wordTable = wordDoc.Tables.Add(
                        wordDoc.Paragraphs[1].Range, 14, 6);

                    // Encabezados de columnas
                    string[] headers = { "Hora", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        wordTable.Cell(1, i + 1).Range.Text = headers[i];
                        wordTable.Cell(1, i + 1).Range.Font.Bold = 1;
                        wordTable.Cell(1, i + 1).Range.ParagraphFormat.Alignment =
                            Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    // Obtener datos del DataGridView
                    DataTable horarios = (DataTable)dgvHorarios.DataSource;
                    DataView view = new DataView(horarios);
                    view.Sort = "hora_inicio ASC";

                    // Organizar datos por horas y días
                    string[,] celdas = new string[24, 5];
                    foreach (DataRowView row in view)
                    {
                        string horaInicio = row["hora_inicio"].ToString().Substring(0, 5);
                        string dia = row["Dia"].ToString();
                        string materia = row["Materia"].ToString();
                        string docente = row["Docente"].ToString();

                        int columna = Array.IndexOf(headers, dia) - 1;
                        if (columna >= 0 && columna < 5)
                        {
                            int fila = int.Parse(horaInicio.Split(':')[0]);
                            celdas[fila, columna] = $"{materia}\n{docente}";
                        }
                    }

                    // Llenar la tabla
                    for (int hora = 7; hora < 20; hora++)
                    {
                        int filaTabla = hora - 6;

                        // Celda de hora
                        wordTable.Cell(filaTabla + 1, 1).Range.Text = $"{hora}:00 - {hora + 1}:00";
                        wordTable.Cell(filaTabla + 1, 1).Range.ParagraphFormat.Alignment =
                            Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                        // Celdas para cada día
                        for (int dia = 0; dia < 5; dia++)
                        {
                            string contenido = celdas[hora, dia] ?? "";
                            wordTable.Cell(filaTabla + 1, dia + 2).Range.Text = contenido;
                            wordTable.Cell(filaTabla + 1, dia + 2).Range.ParagraphFormat.Alignment =
                                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        }
                    }

                    // Ajustar formato de la tabla
                    wordTable.Rows[1].Range.Font.Bold = 1;
                    wordTable.Borders.Enable = 1;
                    wordTable.Rows.Height = wordApp.InchesToPoints(0.5f);

                    // Guardar y cerrar
                    wordDoc.SaveAs2(saveFileDialog.FileName);
                    wordDoc.Close();
                    wordApp.Quit();

                    MessageBox.Show("Horario exportado a Word correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a Word: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarVistaPrevia()
        {
            try
            {
                Form vistaPreviaForm = new Form();
                vistaPreviaForm.Text = "Vista Previa del Horario";
                vistaPreviaForm.Size = new Size(800, 600);
                vistaPreviaForm.StartPosition = FormStartPosition.CenterParent;

                DataGridView dgvVistaPrevia = new DataGridView();
                dgvVistaPrevia.Dock = DockStyle.Fill;
                dgvVistaPrevia.ReadOnly = true;
                dgvVistaPrevia.AllowUserToAddRows = false;
                dgvVistaPrevia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Crear tabla para la vista previa
                DataTable tablaVistaPrevia = new DataTable();
                tablaVistaPrevia.Columns.Add("Hora", typeof(string));
                tablaVistaPrevia.Columns.Add("Lunes", typeof(string));
                tablaVistaPrevia.Columns.Add("Martes", typeof(string));
                tablaVistaPrevia.Columns.Add("Miércoles", typeof(string));
                tablaVistaPrevia.Columns.Add("Jueves", typeof(string));
                tablaVistaPrevia.Columns.Add("Viernes", typeof(string));

                // Obtener datos del DataGridView
                DataTable horarios = (DataTable)dgvHorarios.DataSource;
                DataView view = new DataView(horarios);
                view.Sort = "hora_inicio ASC";

                // Organizar datos por horas y días
                string[,] celdas = new string[24, 5];
                foreach (DataRowView row in view)
                {
                    string horaInicio = row["hora_inicio"].ToString().Substring(0, 5);
                    string dia = row["Dia"].ToString();
                    string materia = row["Materia"].ToString();
                    string docente = row["Docente"].ToString();

                    int columna = -1;
                    switch (dia)
                    {
                        case "Lunes": columna = 0; break;
                        case "Martes": columna = 1; break;
                        case "Miércoles": columna = 2; break;
                        case "Jueves": columna = 3; break;
                        case "Viernes": columna = 4; break;
                    }

                    if (columna >= 0)
                    {
                        int fila = int.Parse(horaInicio.Split(':')[0]);
                        celdas[fila, columna] = $"{materia}\n({docente})";
                    }
                }

                // Llenar la tabla
                for (int hora = 7; hora < 20; hora++)
                {
                    DataRow fila = tablaVistaPrevia.NewRow();
                    fila["Hora"] = $"{hora}:00 - {hora + 1}:00";

                    for (int dia = 0; dia < 5; dia++)
                    {
                        string nombreColumna = "";
                        switch (dia)
                        {
                            case 0: nombreColumna = "Lunes"; break;
                            case 1: nombreColumna = "Martes"; break;
                            case 2: nombreColumna = "Miércoles"; break;
                            case 3: nombreColumna = "Jueves"; break;
                            case 4: nombreColumna = "Viernes"; break;
                        }

                        fila[nombreColumna] = celdas[hora, dia] ?? "";
                    }

                    tablaVistaPrevia.Rows.Add(fila);
                }

                dgvVistaPrevia.DataSource = tablaVistaPrevia;

                // Ajustar estilo
                dgvVistaPrevia.RowHeadersVisible = false;
                dgvVistaPrevia.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dgvVistaPrevia.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvVistaPrevia.Font, FontStyle.Bold);
                dgvVistaPrevia.EnableHeadersVisualStyles = false;

                // Botones de exportación
                Button btnExportarPDF = new Button() { Text = "Exportar a PDF", Width = 120, Top = 10 };
                Button btnExportarWord = new Button() { Text = "Exportar a Word", Width = 120, Top = 10, Left = 130 };

                btnExportarPDF.Click += (s, ev) => { vistaPreviaForm.DialogResult = DialogResult.Yes; vistaPreviaForm.Close(); };
                btnExportarWord.Click += (s, ev) => { vistaPreviaForm.DialogResult = DialogResult.No; vistaPreviaForm.Close(); };

                Panel panelBotones = new Panel();
                panelBotones.Dock = DockStyle.Bottom;
                panelBotones.Height = 50;
                panelBotones.Controls.Add(btnExportarPDF);
                panelBotones.Controls.Add(btnExportarWord);

                vistaPreviaForm.Controls.Add(dgvVistaPrevia);
                vistaPreviaForm.Controls.Add(panelBotones);

                var result = vistaPreviaForm.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    ExportarAPDF();
                }
                else if (result == DialogResult.No)
                {
                    ExportarAWord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar vista previa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
