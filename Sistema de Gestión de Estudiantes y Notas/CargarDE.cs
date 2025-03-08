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
    internal class CargarDE
    {
        private ConexionBD conexion = new ConexionBD();

        // Método para obtener los datos de estudiantes y sus notas
        public DataTable ObtenerDatos()
        {
            DataTable dt = new DataTable();
            try
            {
                string consulta = @"
                    SELECT 
                        e.id_estudiante AS ID, 
                        e.nombre AS Estudiante, 
                        m.nombre AS Materia, 
                        n.calificacion AS Nota
                    FROM Notas n
                    JOIN Estudiantes e ON n.id_estudiante = e.id_estudiante
                    JOIN Materias m ON n.id_materia = m.id_materia";

                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion.ObtenerConexion());
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al obtener datos: " + ex.Message);
            }

            return dt;
        }
    }
}
