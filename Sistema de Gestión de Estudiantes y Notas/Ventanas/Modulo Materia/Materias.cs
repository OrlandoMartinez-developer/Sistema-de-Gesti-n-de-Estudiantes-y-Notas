using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CoBD;


namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Materia
{
    public partial class Materias : Form
    {
        ConexionBD conexionBD = new ConexionBD();

        public Materias()
        {
            InitializeComponent();
            CargarMaterias();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.ReadOnly = true;
        }

        private void CargarMaterias()
        {
            try
            {
                string query = "SELECT id_materia, nombre FROM Materias ORDER BY nombre";
                MySqlCommand cmd = new MySqlCommand(query, conexionBD.Conectar());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMaterias.DataSource = dt;

                // Ocultar la columna de ID si existe
                if (dgvMaterias.Columns.Contains("id_materia"))
                {
                    dgvMaterias.Columns["id_materia"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message);
            }
            finally
            {
                conexionBD.Desconectar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMateria.Text))
            {
                MessageBox.Show("Ingrese el nombre de la materia");
                txtMateria.Focus();
                return;
            }

            string nombreMateria = txtMateria.Text.Trim();

            try
            {
                // Verificar si la materia ya existe
                string verificarQuery = "SELECT COUNT(*) FROM Materias WHERE nombre = @nombre";
                MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, conexionBD.Conectar());
                verificarCmd.Parameters.AddWithValue("@nombre", nombreMateria);

                int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("Esta materia ya está registrada");
                    return;
                }

                // Insertar la nueva materia
                string insertQuery = "INSERT INTO Materias (nombre) VALUES (@nombre)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conexionBD.Conectar());
                insertCmd.Parameters.AddWithValue("@nombre", nombreMateria);

                int result = insertCmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Materia agregada correctamente");
                    txtMateria.Clear();
                    CargarMaterias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar materia: " + ex.Message);
            }
            finally
            {
                conexionBD.Desconectar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una materia para eliminar");
                return;
            }

            DataGridViewRow selectedRow = dgvMaterias.SelectedRows[0];

            // Verificar que tenemos los datos necesarios
            if (selectedRow.Cells["id_materia"]?.Value == null ||
                selectedRow.Cells["nombre"]?.Value == null)
            {
                MessageBox.Show("No se puede obtener la información de la materia seleccionada");
                return;
            }

            int idMateria = Convert.ToInt32(selectedRow.Cells["id_materia"].Value);
            string nombreMateria = selectedRow.Cells["nombre"].Value.ToString();

            // Confirmar eliminación
            if (MessageBox.Show($"¿Está seguro de eliminar la materia: {nombreMateria}?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Primero verificar si la materia está asignada a algún estudiante
                    string verificarRelacionQuery = "SELECT COUNT(*) FROM Estudiantes_Materias WHERE id_materia = @id";
                    MySqlCommand verificarCmd = new MySqlCommand(verificarRelacionQuery, conexionBD.Conectar());
                    verificarCmd.Parameters.AddWithValue("@id", idMateria);

                    int tieneRelaciones = Convert.ToInt32(verificarCmd.ExecuteScalar());

                    if (tieneRelaciones > 0)
                    {
                        MessageBox.Show("No se puede eliminar esta materia porque está asignada a uno o más estudiantes");
                        return;
                    }

                    // Eliminar la materia
                    string deleteQuery = "DELETE FROM Materias WHERE id_materia = @id";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conexionBD.Conectar());
                    deleteCmd.Parameters.AddWithValue("@id", idMateria);

                    int result = deleteCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Materia eliminada correctamente");
                        CargarMaterias();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar materia: " + ex.Message);
                }
                finally
                {
                    conexionBD.Desconectar();
                }
            }
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes implementar la edición aquí si lo deseas
        }

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir que se presione Enter para agregar
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregar_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}