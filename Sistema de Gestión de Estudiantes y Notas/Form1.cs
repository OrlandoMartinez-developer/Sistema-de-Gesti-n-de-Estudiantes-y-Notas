using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuProyecto;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    public partial class Form1 : Form
    {
        ConexionBD conexion = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void ConectarBD_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();  
            MessageBox.Show("Conexión exitosa con MySQL");
            conexion.CerrarConexion();
        }
    }
}
