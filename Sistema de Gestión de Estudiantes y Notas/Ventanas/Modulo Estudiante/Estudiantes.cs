using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Estudiante
{
    public partial class Estudiantes : Form
    {
        private readonly ConexionBD bd = new ConexionBD();
        private readonly DataTable dtEstudiantes = new DataTable();

        public Estudiantes()
        {
            InitializeComponent();
            CargarComboboxes();
            CargarEstudiantes();
            ConfigurarDataGridView();
        }

        private void CargarComboboxes()
        {
            CargarCursos();
            CargarGrados();
        }

        private void CargarCursos()
        {
            try
            {
                string query = "SELECT id_curso, nombre FROM Cursos ORDER BY nombre";
                using (MySqlCommand cmd = new MySqlCommand(query, bd.Conectar()))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCurso.DataSource = dt;
                        cmbCurso.DisplayMember = "nombre";
                        cmbCurso.ValueMember = "id_curso";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }

        private void CargarGrados()
        {
            try
            {
                string query = "SELECT id_grado, nombre FROM Grados_Academicos ORDER BY nombre"; // Cambiado el nombre de la tabla
                using (MySqlCommand cmd = new MySqlCommand(query, bd.Conectar()))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbGrado.DataSource = dt;
                        cmbGrado.DisplayMember = "nombre";
                        cmbGrado.ValueMember = "id_grado";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grados: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }

        private void CargarEstudiantes()
        {
            try
            {
                string query = @"SELECT e.id_estudiante, e.nombre, e.apellido,
                                       DATE_FORMAT(e.fecha_nacimiento, '%d/%m/%Y') as fecha_nacimiento,
                                       e.correo, e.telefono, e.direccion,
                                       g.nombre as grado, c.nombre as curso
                                FROM Estudiantes e
                                LEFT JOIN Grados_Academicos g ON e.id_grado = g.id_grado 
                                LEFT JOIN Cursos c ON e.id_curso = c.id_curso
                                ORDER BY e.apellido, e.nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, bd.Conectar()))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        dtEstudiantes.Clear();
                        da.Fill(dtEstudiantes);
                        dataGridView1.DataSource = dtEstudiantes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["id_estudiante"].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string query = @"INSERT INTO Estudiantes
                                       (nombre, apellido, fecha_nacimiento, correo,
                                        telefono, direccion, id_grado, id_curso)
                                       VALUES (@nombre, @apellido, @fecha, @correo,
                                               @telefono, @direccion, @grado, @curso)";

                    using (MySqlCommand cmd = new MySqlCommand(query, bd.Conectar()))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(txtFechaN.Text));
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@grado", cmbGrado.SelectedValue);
                        cmd.Parameters.AddWithValue("@curso", cmbCurso.SelectedValue);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Estudiante agregado correctamente");
                            LimpiarCampos();
                            CargarEstudiantes();
                        }
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1062)
                {
                    MessageBox.Show("Error: El correo electrónico ya está registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar estudiante: " + ex.Message);
                }
                finally
                {
                    bd.Desconectar();
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio");
                txtApellido.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtFechaN.Text, out _))
            {
                MessageBox.Show("Formato de fecha incorrecto (Use DD/MM/AAAA)");
                txtFechaN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido");
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cmbGrado.SelectedIndex = 0;
            cmbCurso.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un estudiante para eliminar");
                return;
            }

            int idEstudiante = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_estudiante"].Value);
            string nombreEstudiante = dataGridView1.SelectedRows[0].Cells["nombre"].Value + " " +
                                       dataGridView1.SelectedRows[0].Cells["apellido"].Value;

            if (MessageBox.Show($"¿Está seguro de eliminar al estudiante: {nombreEstudiante}?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Estudiantes WHERE id_estudiante = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, bd.Conectar()))
                    {
                        cmd.Parameters.AddWithValue("@id", idEstudiante);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Estudiante eliminado correctamente");
                            CargarEstudiantes();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}");
                }
                finally
                {
                    bd.Desconectar();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un estudiante para editar");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            txtNombre.Text = row.Cells["nombre"].Value.ToString();
            txtApellido.Text = row.Cells["apellido"].Value.ToString();
            txtFechaN.Text = row.Cells["fecha_nacimiento"].Value.ToString();
            txtCorreo.Text = row.Cells["correo"].Value.ToString();
            txtTelefono.Text = row.Cells["telefono"]?.Value?.ToString() ?? "";
            txtDireccion.Text = row.Cells["direccion"]?.Value?.ToString() ?? "";

            foreach (DataRowView item in cmbGrado.Items)
            {
                if (item["nombre"].ToString() == row.Cells["grado"].Value?.ToString())
                {
                    cmbGrado.SelectedItem = item;
                    break;
                }
            }

            foreach (DataRowView item in cmbCurso.Items)
            {
                if (item["nombre"].ToString() == row.Cells["curso"].Value?.ToString())
                {
                    cmbCurso.SelectedItem = item;
                    break;
                }
            }

            btnAgregar.Text = "Actualizar";
            btnAgregar.Tag = row.Cells["id_estudiante"].Value;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnAgregar.Text = "Agregar";
            btnAgregar.Tag = null;
        }

        private void txtFechaN_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFechaN.Text))
                txtFechaN.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEditar_Click(sender, e);
        }
    }
}