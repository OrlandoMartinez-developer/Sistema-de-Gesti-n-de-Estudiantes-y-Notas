using System;
using System.Drawing;
using System.Windows.Forms;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Estudiante;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Materia;
using Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas;

namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Menu_Principal
{
    public partial class FrmMenu : Form
    {
        #region Propiedades

        public string rolUsuarioActual = "Admin";
        public string nombreUsuarioActual = "Administrador";
        private Timer timerReloj;
        private Form formularioActivo;

        #endregion

        #region Constructor

        public FrmMenu()
        {
            InitializeComponent();
            ConfigurarFormulario();
            InicializarReloj();
            ConfigurarPermisosPorRol();
        }

        public FrmMenu(string usuario, string rol)
        {
            InitializeComponent();
            nombreUsuarioActual = usuario;
            rolUsuarioActual = rol;
            ConfigurarFormulario();
            InicializarReloj();
            ConfigurarPermisosPorRol();
        }

        #endregion

        #region Configuración Inicial

        private void ConfigurarFormulario()
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1024, 768);
            this.Text = "Sistema de Gestión de Estudiantes y Notas";

            // Configurar el panel contenedor si existe
            if (panelContenedor != null)
            {
                panelContenedor.Dock = DockStyle.Fill;
            }
        }

        private void InicializarReloj()
        {
            // Configurar el timer para actualizar la fecha y hora
            timerReloj = new Timer();
            timerReloj.Interval = 1000; // Actualizar cada segundo
            timerReloj.Tick += TimerReloj_Tick;
            timerReloj.Start();

            // Actualizar inmediatamente
            ActualizarFechaHora();
        }

        private void TimerReloj_Tick(object sender, EventArgs e)
        {
            ActualizarFechaHora();
        }

        private void ActualizarFechaHora()
        {
            if (lblFechaHora != null)
            {
                lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            }
        }

        private void ConfigurarPermisosPorRol()
        {
            if (lblUsuarioActual != null)
            {
                lblUsuarioActual.Text = $"Usuario: {nombreUsuarioActual} ({rolUsuarioActual})";
            }

            // Configurar permisos según el rol
            switch (rolUsuarioActual.ToUpper())
            {
                case "DOCENTE":
                    // Los docentes pueden ver solo notas y estudiantes
                    menuEstudiantes.Enabled = true;
                    menuNotas.Enabled = true;
                    menuMaterias.Enabled = false;
                    menuHorarios.Enabled = false;
                    menuReportes.Enabled = true;
                    menuSistema.Enabled = false;

                    // Limitar opciones de estudiantes
                    if (menuEstudiantesRegistrar != null) menuEstudiantesRegistrar.Visible = false;
                    if (menuEstudiantesEliminar != null) menuEstudiantesEliminar.Visible = false;
                    break;

                case "ADMIN":
                case "ADMINISTRADOR":
                    // El administrador tiene acceso completo
                    menuEstudiantes.Enabled = true;
                    menuNotas.Enabled = true;
                    menuMaterias.Enabled = true;
                    menuHorarios.Enabled = true;
                    menuReportes.Enabled = true;
                    menuSistema.Enabled = true;
                    break;

                case "SECRETARIA":
                    // La secretaría puede gestionar estudiantes y reportes
                    menuEstudiantes.Enabled = true;
                    menuNotas.Enabled = false;
                    menuMaterias.Enabled = true;
                    menuHorarios.Enabled = true;
                    menuReportes.Enabled = true;
                    menuSistema.Enabled = false;
                    break;

                default:
                    // Por defecto, acceso limitado
                    menuEstudiantes.Enabled = true;
                    menuNotas.Enabled = false;
                    menuMaterias.Enabled = false;
                    menuHorarios.Enabled = false;
                    menuReportes.Enabled = false;
                    menuSistema.Enabled = false;
                    break;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ActualizarEstado("Sistema iniciado correctamente");
            MostrarMensajeBienvenida();
        }

        private void MostrarMensajeBienvenida()
        {
            if (lblBienvenida != null)
            {
                lblBienvenida.Text = $"Bienvenido, {nombreUsuarioActual}";
            }
        }

        #endregion

        #region Gestión de Formularios Hijos

        private void AbrirFormulario(Form formulario)
        {
            try
            {
                if (formulario == null)
                {
                    MessageBox.Show("Error al cargar el formulario.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Cerrar el formulario activo anterior
                CerrarFormularioActivo();

                // Ocultar labels de bienvenida
                if (lblBienvenida != null) lblBienvenida.Visible = false;
                if (lblSubtitulo != null) lblSubtitulo.Visible = false;

                // Configurar el nuevo formulario
                formulario.MdiParent = this;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.WindowState = FormWindowState.Maximized;

                // Suscribirse al evento FormClosed
                formulario.FormClosed += FormularioHijo_FormClosed;

                // Mostrar el formulario
                formulario.Show();
                formularioActivo = formulario;

                // Actualizar estado
                ActualizarEstado($"Módulo abierto: {formulario.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ActualizarEstado("Error al abrir módulo");
            }
        }

        private void CerrarFormularioActivo()
        {
            if (formularioActivo != null && !formularioActivo.IsDisposed)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            // También cerrar cualquier otro hijo que pueda estar abierto
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Mostrar labels de bienvenida nuevamente
            if (lblBienvenida != null) lblBienvenida.Visible = true;
            if (lblSubtitulo != null) lblSubtitulo.Visible = true;
        }

        private void FormularioHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioActivo = null;
            ActualizarEstado("Listo");

            // Mostrar labels de bienvenida
            if (lblBienvenida != null) lblBienvenida.Visible = true;
            if (lblSubtitulo != null) lblSubtitulo.Visible = true;
        }

        private void ActualizarEstado(string mensaje)
        {
            if (lblEstado != null)
            {
                lblEstado.Text = mensaje;
            }
        }

        #endregion

        #region Eventos del Menú - Estudiantes

        private void menuEstudiantesRegistrar_Click(object sender, EventArgs e)
        {
            Estudiantes frmEstudiantes = new Estudiantes();
            AbrirFormulario(frmEstudiantes);
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes frmEstudiantes = new Estudiantes();
            AbrirFormulario(frmEstudiantes);
        }

        private void menuEstudiantesModificar_Click(object sender, EventArgs e)
        {
            Estudiantes frmEstudiantes = new Estudiantes();
            AbrirFormulario(frmEstudiantes);
        }

        private void menuEstudiantesEliminar_Click(object sender, EventArgs e)
        {
            Estudiantes frmEstudiantes = new Estudiantes();
            AbrirFormulario(frmEstudiantes);
        }

        #endregion

        #region Eventos del Menú - Notas

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotas frmNotas = new FrmNotas();
            AbrirFormulario(frmNotas);
        }

        private void menuNotasConsultar_Click(object sender, EventArgs e)
        {
            FrmNotas frmNotas = new FrmNotas();
            AbrirFormulario(frmNotas);
        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPromedio frmPromedio = new FrmPromedio();
            AbrirFormulario(frmPromedio);
        }

        private void menuNotasEstadisticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de estadísticas en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

        #region Eventos del Menú - Materias

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            AbrirFormulario(materias);
        }

        private void menuMateriasAsignacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de asignación de materias en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

        #region Eventos del Menú - Horarios

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            AbrirFormulario(cursos);
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos1 frmCursos = new Cursos1();
            AbrirFormulario(frmCursos);
        }

        #endregion

        #region Eventos del Menú - Reportes

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteDeNotas reporteDeNotas = new ReporteDeNotas();
            AbrirFormulario(reporteDeNotas);
        }

        private void NotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteDeNotas reporteDeNotas = new ReporteDeNotas();
            AbrirFormulario(reporteDeNotas);
        }

        private void menuReportesEstudiantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte de estudiantes en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuReportesRendimiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Análisis de rendimiento en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuReportesExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de exportación en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

        #region Eventos del Menú - Sistema

        private void menuSistemaUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestión de usuarios en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuSistemaConfiguracion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuración del sistema en desarrollo",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuSistemaAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sistema de Gestión de Estudiantes y Notas\n\n" +
                "Versión 1.0.0\n" +
                "© 2024 Todos los derechos reservados\n\n" +
                "Desarrollado para la gestión académica integral",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuSistemaCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                CerrarFormularioActivo();

                if (timerReloj != null)
                {
                    timerReloj.Stop();
                }

                FrmInicio frmLogin = new FrmInicio();
                frmLogin.Show();
                this.Close();
            }
        }

        private void menuSistemaSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (timerReloj != null)
                {
                    timerReloj.Stop();
                }

                Application.Exit();
            }
        }

        #endregion

        #region Limpieza de Recursos

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Limpiar recursos cuando el formulario se está cerrando
            if (timerReloj != null)
            {
                timerReloj.Stop();
                timerReloj.Dispose();
                timerReloj = null;
            }
        }

        #endregion
    }
}