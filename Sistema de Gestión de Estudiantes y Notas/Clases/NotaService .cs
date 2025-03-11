using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    internal class NotaService
    {
        private readonly ConexionBD _conexionBD;

        public NotaService(ConexionBD conexionBD)
        {
            _conexionBD = conexionBD;
        }

        public void GuardarNota(int idEstudiante, int idMateria, decimal calificacion)
        {
            string query = "INSERT INTO Notas (id_estudiante, id_materia, calificacion, fecha_registro) VALUES (@idEst, @idMat, @cal, NOW())";

            using (var conexion = _conexionBD.Conectar())
            {
                if (conexion == null) return;

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idEst", idEstudiante);
                    cmd.Parameters.AddWithValue("@idMat", idMateria);
                    cmd.Parameters.AddWithValue("@cal", calificacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerNotas()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT n.id_nota, CONCAT(e.nombre, ' ', e.apellido) AS Estudiante, m.nombre AS Materia, n.calificacion AS Nota, n.fecha_registro AS Fecha 
                            FROM Notas n 
                            JOIN Estudiantes e ON n.id_estudiante = e.id_estudiante 
                            JOIN Materias m ON n.id_materia = m.id_materia";

            using (var conexion = _conexionBD.Conectar())
            {
                if (conexion == null) return dt;

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
