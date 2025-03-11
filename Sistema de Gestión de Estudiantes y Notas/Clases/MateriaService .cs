using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    internal class MateriaService
    {
        private readonly ConexionBD _conexionBD;

        public MateriaService(ConexionBD conexionBD)
        {
            _conexionBD = conexionBD;
        }

        public Dictionary<int, string> ObtenerMaterias()
        {
            var materias = new Dictionary<int, string>();
            string query = "SELECT id_materia, nombre FROM Materias";

            using (var conexion = _conexionBD.Conectar())
            {
                if (conexion == null) return materias;

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materias.Add(reader.GetInt32("id_materia"), reader.GetString("nombre"));
                    }
                }
            }

            return materias;
        }
    }
}
