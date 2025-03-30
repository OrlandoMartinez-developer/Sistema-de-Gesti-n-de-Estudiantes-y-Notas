using MySql.Data.MySqlClient;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Menu_Principal;
using System;
using System.Windows.Forms;
using TuProyecto;

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
            string usuario = texusuario.Text;
            string contrasena = texcontrasena.Text;

            if (AutenticarUsuario(usuario, contrasena, out string tipoUsuario, out int? idDocente))
            {
                this.Hide();

                switch (tipoUsuario)
                {
                    case "Administrador":
                        new FrmMenu().Show();
                        break;
                    case "Docente":
                        new FrmMenu().Show();
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
    }
}