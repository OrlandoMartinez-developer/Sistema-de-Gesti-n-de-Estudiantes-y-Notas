using System;
using MySql.Data.MySqlClient;

namespace TuProyecto
{
    public class ConexionBD
    {
        private MySqlConnection conexion;

        // 📌 CAMBIA estos valores según tu configuración
        private string cadenaConexion = "server=mysql-cero.alwaysdata.net; database=cero_sistema_estudiantes; user=cero_free; password=Cero!@#88M; SslMode=none;";

        public ConexionBD()
        {
            conexion = new MySqlConnection(cadenaConexion);
        }

        // Método para abrir la conexión
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    Console.WriteLine("✅ Conexión abierta.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al conectar: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("🔒 Conexión cerrada.");
            }
        }

        // Obtener la conexión para usar en consultas
        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
