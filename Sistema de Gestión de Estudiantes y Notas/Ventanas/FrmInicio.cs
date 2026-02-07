using System;
using System.Windows.Forms;
using CoBD;
using MySql.Data.MySqlClient;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    public partial class FrmInicio : Form
    {
        private ConexionBD conexionBD = new ConexionBD();

        public FrmInicio()
        {
            InitializeComponent();
        }

        private bool AutenticarUsuario(string usuario, string contrasena, out string tipoUsuario, out int? idDocente)
        {
            tipoUsuario = null;
            idDocente = null;
            string query = "SELECT tipo, id_docente FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

            using (var connection = conexionBD.Conectar())
            {
                try
                {

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tipoUsuario = reader["tipo"].ToString();
                                idDocente = !reader.IsDBNull(reader.GetOrdinal("id_docente")) ?
                                           reader.GetInt32("id_docente") : (int?)null;
                                return true;
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error de base de datos: {ex.Message}");
                    return false;
                }
            }
            return false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (AutenticarUsuario(usuario, contrasena, out string tipoUsuario, out int? idDocente))
            {
                this.Hide();

                switch (tipoUsuario)
                {
                    case "Administrador":
                        new Ventanas.Menu_Principal.FrmMenu().Show();
                        break;
                    case "Docente":
                        new Ventanas.Menu_Principal.FrmMenu().Show();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario no reconocido.");
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void texusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void btnMostrarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = false;
        }

        private void btnMostrarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }
    }
}