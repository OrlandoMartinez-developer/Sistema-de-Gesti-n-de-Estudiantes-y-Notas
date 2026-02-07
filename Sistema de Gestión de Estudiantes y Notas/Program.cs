using System;
using System.Windows.Forms;

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

