namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Menu_Principal
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstudiantesRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstudiantesConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorEstudiantes1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEstudiantesModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstudiantesEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotasRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotasConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorNotas1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNotasPromedio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotasEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateriasGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateriasAsignacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHorarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHorariosCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHorariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportesNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportesEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportesRendimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorReportes1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuReportesExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemaConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorSistema1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSistemaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemaCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistemaSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparador1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparador2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstudiantes,
            this.menuNotas,
            this.menuMaterias,
            this.menuHorarios,
            this.menuReportes,
            this.menuSistema});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuPrincipal.Size = new System.Drawing.Size(1000, 31);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuEstudiantes
            // 
            this.menuEstudiantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstudiantesRegistrar,
            this.menuEstudiantesConsultar,
            this.separadorEstudiantes1,
            this.menuEstudiantesModificar,
            this.menuEstudiantesEliminar});
            this.menuEstudiantes.ForeColor = System.Drawing.Color.White;
            this.menuEstudiantes.Name = "menuEstudiantes";
            this.menuEstudiantes.Size = new System.Drawing.Size(95, 23);
            this.menuEstudiantes.Text = "📚 Estudiantes";
            // 
            // menuEstudiantesRegistrar
            // 
            this.menuEstudiantesRegistrar.Name = "menuEstudiantesRegistrar";
            this.menuEstudiantesRegistrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuEstudiantesRegistrar.Size = new System.Drawing.Size(200, 24);
            this.menuEstudiantesRegistrar.Text = "Registrar";
            this.menuEstudiantesRegistrar.Click += new System.EventHandler(this.menuEstudiantesRegistrar_Click);
            // 
            // menuEstudiantesConsultar
            // 
            this.menuEstudiantesConsultar.Name = "menuEstudiantesConsultar";
            this.menuEstudiantesConsultar.Size = new System.Drawing.Size(200, 24);
            this.menuEstudiantesConsultar.Text = "Consultar";
            this.menuEstudiantesConsultar.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // separadorEstudiantes1
            // 
            this.separadorEstudiantes1.Name = "separadorEstudiantes1";
            this.separadorEstudiantes1.Size = new System.Drawing.Size(197, 6);
            // 
            // menuEstudiantesModificar
            // 
            this.menuEstudiantesModificar.Name = "menuEstudiantesModificar";
            this.menuEstudiantesModificar.Size = new System.Drawing.Size(200, 24);
            this.menuEstudiantesModificar.Text = "Modificar";
            this.menuEstudiantesModificar.Click += new System.EventHandler(this.menuEstudiantesModificar_Click);
            // 
            // menuEstudiantesEliminar
            // 
            this.menuEstudiantesEliminar.Name = "menuEstudiantesEliminar";
            this.menuEstudiantesEliminar.Size = new System.Drawing.Size(200, 24);
            this.menuEstudiantesEliminar.Text = "Eliminar";
            this.menuEstudiantesEliminar.Click += new System.EventHandler(this.menuEstudiantesEliminar_Click);
            // 
            // menuNotas
            // 
            this.menuNotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNotasRegistrar,
            this.menuNotasConsultar,
            this.separadorNotas1,
            this.menuNotasPromedio,
            this.menuNotasEstadisticas});
            this.menuNotas.ForeColor = System.Drawing.Color.White;
            this.menuNotas.Name = "menuNotas";
            this.menuNotas.Size = new System.Drawing.Size(69, 23);
            this.menuNotas.Text = "📝 Notas";
            // 
            // menuNotasRegistrar
            // 
            this.menuNotasRegistrar.Name = "menuNotasRegistrar";
            this.menuNotasRegistrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuNotasRegistrar.Size = new System.Drawing.Size(185, 24);
            this.menuNotasRegistrar.Text = "Registrar";
            this.menuNotasRegistrar.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // menuNotasConsultar
            // 
            this.menuNotasConsultar.Name = "menuNotasConsultar";
            this.menuNotasConsultar.Size = new System.Drawing.Size(185, 24);
            this.menuNotasConsultar.Text = "Consultar";
            this.menuNotasConsultar.Click += new System.EventHandler(this.menuNotasConsultar_Click);
            // 
            // separadorNotas1
            // 
            this.separadorNotas1.Name = "separadorNotas1";
            this.separadorNotas1.Size = new System.Drawing.Size(182, 6);
            // 
            // menuNotasPromedio
            // 
            this.menuNotasPromedio.Name = "menuNotasPromedio";
            this.menuNotasPromedio.Size = new System.Drawing.Size(185, 24);
            this.menuNotasPromedio.Text = "Promedio";
            this.menuNotasPromedio.Click += new System.EventHandler(this.promedioToolStripMenuItem_Click);
            // 
            // menuNotasEstadisticas
            // 
            this.menuNotasEstadisticas.Name = "menuNotasEstadisticas";
            this.menuNotasEstadisticas.Size = new System.Drawing.Size(185, 24);
            this.menuNotasEstadisticas.Text = "Estadísticas";
            this.menuNotasEstadisticas.Click += new System.EventHandler(this.menuNotasEstadisticas_Click);
            // 
            // menuMaterias
            // 
            this.menuMaterias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMateriasGestion,
            this.menuMateriasAsignacion});
            this.menuMaterias.ForeColor = System.Drawing.Color.White;
            this.menuMaterias.Name = "menuMaterias";
            this.menuMaterias.Size = new System.Drawing.Size(87, 23);
            this.menuMaterias.Text = "📖 Materias";
            // 
            // menuMateriasGestion
            // 
            this.menuMateriasGestion.Name = "menuMateriasGestion";
            this.menuMateriasGestion.Size = new System.Drawing.Size(205, 24);
            this.menuMateriasGestion.Text = "Gestión de Materias";
            this.menuMateriasGestion.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // menuMateriasAsignacion
            // 
            this.menuMateriasAsignacion.Name = "menuMateriasAsignacion";
            this.menuMateriasAsignacion.Size = new System.Drawing.Size(205, 24);
            this.menuMateriasAsignacion.Text = "Asignar a Estudiantes";
            this.menuMateriasAsignacion.Click += new System.EventHandler(this.menuMateriasAsignacion_Click);
            // 
            // menuHorarios
            // 
            this.menuHorarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHorariosCursos,
            this.menuHorariosGestion});
            this.menuHorarios.ForeColor = System.Drawing.Color.White;
            this.menuHorarios.Name = "menuHorarios";
            this.menuHorarios.Size = new System.Drawing.Size(88, 23);
            this.menuHorarios.Text = "🕒 Horarios";
            // 
            // menuHorariosCursos
            // 
            this.menuHorariosCursos.Name = "menuHorariosCursos";
            this.menuHorariosCursos.Size = new System.Drawing.Size(192, 24);
            this.menuHorariosCursos.Text = "Gestión de Cursos";
            this.menuHorariosCursos.Click += new System.EventHandler(this.horariosToolStripMenuItem_Click);
            // 
            // menuHorariosGestion
            // 
            this.menuHorariosGestion.Name = "menuHorariosGestion";
            this.menuHorariosGestion.Size = new System.Drawing.Size(192, 24);
            this.menuHorariosGestion.Text = "Gestión de Horarios";
            this.menuHorariosGestion.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportesNotas,
            this.menuReportesEstudiantes,
            this.menuReportesRendimiento,
            this.separadorReportes1,
            this.menuReportesExportar});
            this.menuReportes.ForeColor = System.Drawing.Color.White;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(86, 23);
            this.menuReportes.Text = "📊 Reportes";
            // 
            // menuReportesNotas
            // 
            this.menuReportesNotas.Name = "menuReportesNotas";
            this.menuReportesNotas.Size = new System.Drawing.Size(213, 24);
            this.menuReportesNotas.Text = "Reporte de Notas";
            this.menuReportesNotas.Click += new System.EventHandler(this.NotasToolStripMenuItem1_Click);
            // 
            // menuReportesEstudiantes
            // 
            this.menuReportesEstudiantes.Name = "menuReportesEstudiantes";
            this.menuReportesEstudiantes.Size = new System.Drawing.Size(213, 24);
            this.menuReportesEstudiantes.Text = "Reporte de Estudiantes";
            this.menuReportesEstudiantes.Click += new System.EventHandler(this.menuReportesEstudiantes_Click);
            // 
            // menuReportesRendimiento
            // 
            this.menuReportesRendimiento.Name = "menuReportesRendimiento";
            this.menuReportesRendimiento.Size = new System.Drawing.Size(213, 24);
            this.menuReportesRendimiento.Text = "Análisis de Rendimiento";
            this.menuReportesRendimiento.Click += new System.EventHandler(this.menuReportesRendimiento_Click);
            // 
            // separadorReportes1
            // 
            this.separadorReportes1.Name = "separadorReportes1";
            this.separadorReportes1.Size = new System.Drawing.Size(210, 6);
            // 
            // menuReportesExportar
            // 
            this.menuReportesExportar.Name = "menuReportesExportar";
            this.menuReportesExportar.Size = new System.Drawing.Size(213, 24);
            this.menuReportesExportar.Text = "Exportar Datos";
            this.menuReportesExportar.Click += new System.EventHandler(this.menuReportesExportar_Click);
            // 
            // menuSistema
            // 
            this.menuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSistemaUsuarios,
            this.menuSistemaConfiguracion,
            this.separadorSistema1,
            this.menuSistemaAcercaDe,
            this.menuSistemaCerrarSesion,
            this.menuSistemaSalir});
            this.menuSistema.ForeColor = System.Drawing.Color.White;
            this.menuSistema.Name = "menuSistema";
            this.menuSistema.Size = new System.Drawing.Size(79, 23);
            this.menuSistema.Text = "⚙️ Sistema";
            // 
            // menuSistemaUsuarios
            // 
            this.menuSistemaUsuarios.Name = "menuSistemaUsuarios";
            this.menuSistemaUsuarios.Size = new System.Drawing.Size(180, 24);
            this.menuSistemaUsuarios.Text = "Usuarios";
            this.menuSistemaUsuarios.Click += new System.EventHandler(this.menuSistemaUsuarios_Click);
            // 
            // menuSistemaConfiguracion
            // 
            this.menuSistemaConfiguracion.Name = "menuSistemaConfiguracion";
            this.menuSistemaConfiguracion.Size = new System.Drawing.Size(180, 24);
            this.menuSistemaConfiguracion.Text = "Configuración";
            this.menuSistemaConfiguracion.Click += new System.EventHandler(this.menuSistemaConfiguracion_Click);
            // 
            // separadorSistema1
            // 
            this.separadorSistema1.Name = "separadorSistema1";
            this.separadorSistema1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuSistemaAcercaDe
            // 
            this.menuSistemaAcercaDe.Name = "menuSistemaAcercaDe";
            this.menuSistemaAcercaDe.Size = new System.Drawing.Size(180, 24);
            this.menuSistemaAcercaDe.Text = "Acerca de...";
            this.menuSistemaAcercaDe.Click += new System.EventHandler(this.menuSistemaAcercaDe_Click);
            // 
            // menuSistemaCerrarSesion
            // 
            this.menuSistemaCerrarSesion.Name = "menuSistemaCerrarSesion";
            this.menuSistemaCerrarSesion.Size = new System.Drawing.Size(180, 24);
            this.menuSistemaCerrarSesion.Text = "Cerrar Sesión";
            this.menuSistemaCerrarSesion.Click += new System.EventHandler(this.menuSistemaCerrarSesion_Click);
            // 
            // menuSistemaSalir
            // 
            this.menuSistemaSalir.Name = "menuSistemaSalir";
            this.menuSistemaSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuSistemaSalir.Size = new System.Drawing.Size(180, 24);
            this.menuSistemaSalir.Text = "Salir";
            this.menuSistemaSalir.Click += new System.EventHandler(this.menuSistemaSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioActual,
            this.lblSeparador1,
            this.lblFechaHora,
            this.lblSeparador2,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(106, 19);
            this.lblUsuarioActual.Text = "Usuario: Admin";
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.ForeColor = System.Drawing.Color.White;
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(13, 19);
            this.lblSeparador1.Text = "|";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(143, 19);
            this.lblFechaHora.Text = "01/01/2024 12:00:00 PM";
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.ForeColor = System.Drawing.Color.White;
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(13, 19);
            this.lblSeparador2.Text = "|";
            // 
            // lblEstado
            // 
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(710, 19);
            this.lblEstado.Spring = true;
            this.lblEstado.Text = "Listo";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContenedor.Controls.Add(this.lblSubtitulo);
            this.panelContenedor.Controls.Add(this.lblBienvenida);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 31);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 545);
            this.panelContenedor.TabIndex = 2;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblBienvenida.Location = new System.Drawing.Point(0, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(1000, 100);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Sistema de Gestión Académica";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 100);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(1000, 30);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestión de Estudiantes y Notas";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Estudiantes y Notas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantesRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantesConsultar;
        private System.Windows.Forms.ToolStripSeparator separadorEstudiantes1;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantesModificar;
        private System.Windows.Forms.ToolStripMenuItem menuEstudiantesEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuNotas;
        private System.Windows.Forms.ToolStripMenuItem menuNotasRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuNotasConsultar;
        private System.Windows.Forms.ToolStripSeparator separadorNotas1;
        private System.Windows.Forms.ToolStripMenuItem menuNotasPromedio;
        private System.Windows.Forms.ToolStripMenuItem menuNotasEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem menuMaterias;
        private System.Windows.Forms.ToolStripMenuItem menuMateriasGestion;
        private System.Windows.Forms.ToolStripMenuItem menuMateriasAsignacion;
        private System.Windows.Forms.ToolStripMenuItem menuHorarios;
        private System.Windows.Forms.ToolStripMenuItem menuHorariosCursos;
        private System.Windows.Forms.ToolStripMenuItem menuHorariosGestion;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuReportesNotas;
        private System.Windows.Forms.ToolStripMenuItem menuReportesEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem menuReportesRendimiento;
        private System.Windows.Forms.ToolStripSeparator separadorReportes1;
        private System.Windows.Forms.ToolStripMenuItem menuReportesExportar;
        private System.Windows.Forms.ToolStripMenuItem menuSistema;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaConfiguracion;
        private System.Windows.Forms.ToolStripSeparator separadorSistema1;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActual;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparador1;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparador2;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}