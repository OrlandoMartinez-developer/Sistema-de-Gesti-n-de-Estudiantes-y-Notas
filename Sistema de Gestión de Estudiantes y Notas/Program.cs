using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicio());

        }
    }
}

