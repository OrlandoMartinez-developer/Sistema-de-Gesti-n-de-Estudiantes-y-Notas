using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    internal class EstudianteService
    {
        private readonly ConexionBD _conexionBD;

        public EstudianteService(ConexionBD conexionBD)
        {
            _conexionBD = conexionBD;
        }

        public Dictionary<int, string> ObtenerEstudiantes()
        {
            var estudiantes = new Dictionary<int, string>();
            string query = "SELECT id_estudiante, CONCAT(nombre, ' ', apellido) AS nombre_completo FROM Estudiantes";

            using (var conexion = _conexionBD.Conectar())
            {
                if (conexion == null) return estudiantes;

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estudiantes.Add(reader.GetInt32("id_estudiante"), reader.GetString("nombre_completo"));
                    }
                }
            }

            return estudiantes;
        }
    }
}
