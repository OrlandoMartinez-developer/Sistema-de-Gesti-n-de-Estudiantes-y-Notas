using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TuProyecto
{
    public class ConexionBD
    {
        private MySqlConnection conexion;
        private string cadenaConexion = "server=mysql-cero.alwaysdata.net; database=cero_sistema_estudiantes; user=cero_free; password=Cero!@#88M; SslMode=none";

        public ConexionBD()
        {
            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection Conectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("✅ Conexión abierta.");
                }
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("❌ Error de MySQL: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error general: " + ex.Message);
                return null;
            }
        }

        public void Desconectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("🔒 Conexión cerrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cerrar conexión: " + ex.Message);
            }
        }
    }
}
