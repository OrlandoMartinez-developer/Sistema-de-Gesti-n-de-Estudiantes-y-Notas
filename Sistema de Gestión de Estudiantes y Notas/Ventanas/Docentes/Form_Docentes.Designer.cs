namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas
{
    partial class Form_Docentes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAsignaciones = new System.Windows.Forms.TabPage();
            this.dgvMatYHor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnEliminarAsignacion = new System.Windows.Forms.Button();
            this.btnGuardarAsignacion = new System.Windows.Forms.Button();
            this.tabPageDocentes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarDocente = new System.Windows.Forms.Button();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnEditarDocente = new System.Windows.Forms.Button();
            this.btnNuevoDocente = new System.Windows.Forms.Button();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatYHor)).BeginInit();
            this.tabPageDocentes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAsignaciones);
            this.tabControl1.Controls.Add(this.tabPageDocentes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAsignaciones
            // 
            this.tabPageAsignaciones.Controls.Add(this.cmbDocentes);
            this.tabPageAsignaciones.Controls.Add(this.dgvMatYHor);
            this.tabPageAsignaciones.Controls.Add(this.label3);
            this.tabPageAsignaciones.Controls.Add(this.label2);
            this.tabPageAsignaciones.Controls.Add(this.label1);
            this.tabPageAsignaciones.Controls.Add(this.cmbCurso);
            this.tabPageAsignaciones.Controls.Add(this.cmbMateria);
            this.tabPageAsignaciones.Controls.Add(this.btnEliminarAsignacion);
            this.tabPageAsignaciones.Controls.Add(this.btnGuardarAsignacion);
            this.tabPageAsignaciones.Location = new System.Drawing.Point(4, 22);
            this.tabPageAsignaciones.Name = "tabPageAsignaciones";
            this.tabPageAsignaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsignaciones.Size = new System.Drawing.Size(792, 424);
            this.tabPageAsignaciones.TabIndex = 0;
            this.tabPageAsignaciones.Text = "Asignaciones";
            this.tabPageAsignaciones.UseVisualStyleBackColor = true;
            // 
            // dgvMatYHor
            // 
            this.dgvMatYHor.AllowUserToAddRows = false;
            this.dgvMatYHor.AllowUserToDeleteRows = false;
            this.dgvMatYHor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatYHor.Location = new System.Drawing.Point(20, 20);
            this.dgvMatYHor.Name = "dgvMatYHor";
            this.dgvMatYHor.ReadOnly = true;
            this.dgvMatYHor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatYHor.Size = new System.Drawing.Size(750, 250);
            this.dgvMatYHor.TabIndex = 0;
            this.dgvMatYHor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatYHor_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Docente";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(300, 320);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(150, 21);
            this.cmbCurso.TabIndex = 3;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(460, 320);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(150, 21);
            this.cmbMateria.TabIndex = 2;
            // 
            // btnEliminarAsignacion
            // 
            this.btnEliminarAsignacion.Location = new System.Drawing.Point(650, 350);
            this.btnEliminarAsignacion.Name = "btnEliminarAsignacion";
            this.btnEliminarAsignacion.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarAsignacion.TabIndex = 1;
            this.btnEliminarAsignacion.Text = "Eliminar Asignación";
            this.btnEliminarAsignacion.UseVisualStyleBackColor = true;
            this.btnEliminarAsignacion.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardarAsignacion
            // 
            this.btnGuardarAsignacion.Location = new System.Drawing.Point(650, 310);
            this.btnGuardarAsignacion.Name = "btnGuardarAsignacion";
            this.btnGuardarAsignacion.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarAsignacion.TabIndex = 0;
            this.btnGuardarAsignacion.Text = "Guardar Asignación";
            this.btnGuardarAsignacion.UseVisualStyleBackColor = true;
            this.btnGuardarAsignacion.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabPageDocentes
            // 
            this.tabPageDocentes.Controls.Add(this.groupBox1);
            this.tabPageDocentes.Controls.Add(this.dgvDocentes);
            this.tabPageDocentes.Controls.Add(this.btnCancelar);
            this.tabPageDocentes.Controls.Add(this.btnGuardarDocente);
            this.tabPageDocentes.Controls.Add(this.btnEliminarDocente);
            this.tabPageDocentes.Controls.Add(this.btnEditarDocente);
            this.tabPageDocentes.Controls.Add(this.btnNuevoDocente);
            this.tabPageDocentes.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocentes.Name = "tabPageDocentes";
            this.tabPageDocentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocentes.Size = new System.Drawing.Size(792, 424);
            this.tabPageDocentes.TabIndex = 1;
            this.tabPageDocentes.Text = "Gestión de Docentes";
            this.tabPageDocentes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEspecialidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(20, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Docente";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(300, 80);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(80, 20);
            this.txtEspecialidad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Especialidad";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(200, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(90, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(100, 80);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(90, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(200, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(20, 20);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(750, 250);
            this.dgvDocentes.TabIndex = 5;
        
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(650, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
           
            // 
            // btnGuardarDocente
            // 
            this.btnGuardarDocente.Location = new System.Drawing.Point(650, 340);
            this.btnGuardarDocente.Name = "btnGuardarDocente";
            this.btnGuardarDocente.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarDocente.TabIndex = 3;
            this.btnGuardarDocente.Text = "Guardar";
            this.btnGuardarDocente.UseVisualStyleBackColor = true;
            
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(650, 220);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarDocente.TabIndex = 2;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;   // 
            // btnEditarDocente
            // 
            this.btnEditarDocente.Location = new System.Drawing.Point(650, 180);
            this.btnEditarDocente.Name = "btnEditarDocente";
            this.btnEditarDocente.Size = new System.Drawing.Size(120, 30);
            this.btnEditarDocente.TabIndex = 1;
            this.btnEditarDocente.Text = "Editar";
            this.btnEditarDocente.UseVisualStyleBackColor = true;

            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.Location = new System.Drawing.Point(650, 140);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(120, 30);
            this.btnNuevoDocente.TabIndex = 0;
            this.btnNuevoDocente.Text = "Nuevo";
            this.btnNuevoDocente.UseVisualStyleBackColor = true;
      
            // cmbDocentes
            // 
            this.cmbDocentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(87, 320);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(150, 21);
            this.cmbDocentes.TabIndex = 7;
            // 
            // Form_Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Docentes";
            this.Text = "Gestión de Docentes";
            this.Load += new System.EventHandler(this.Form_Docentes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAsignaciones.ResumeLayout(false);
            this.tabPageAsignaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatYHor)).EndInit();
            this.tabPageDocentes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAsignaciones;
        private System.Windows.Forms.TabPage tabPageDocentes;
        private System.Windows.Forms.DataGridView dgvMatYHor;
        private System.Windows.Forms.Button btnGuardarAsignacion;
        private System.Windows.Forms.Button btnEliminarAsignacion;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnNuevoDocente;
        private System.Windows.Forms.Button btnEditarDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnGuardarDocente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbDocentes;
    }
}