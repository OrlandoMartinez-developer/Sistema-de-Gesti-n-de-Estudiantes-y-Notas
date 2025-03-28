namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios
{
    partial class Cursos
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
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.cbDocentes = new System.Windows.Forms.ComboBox();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(56, 291);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 21);
            this.cbCursos.TabIndex = 0;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(54, 331);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(94, 20);
            this.dtpHoraInicio.TabIndex = 1;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(54, 56);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(848, 219);
            this.dgvHorarios.TabIndex = 2;
            // 
            // cbDocentes
            // 
            this.cbDocentes.FormattingEnabled = true;
            this.cbDocentes.Location = new System.Drawing.Point(311, 291);
            this.cbDocentes.Name = "cbDocentes";
            this.cbDocentes.Size = new System.Drawing.Size(121, 21);
            this.cbDocentes.TabIndex = 3;
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(183, 291);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(121, 21);
            this.cbMaterias.TabIndex = 4;
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves ",
            "Viernes"});
            this.cbDia.Location = new System.Drawing.Point(438, 291);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 5;
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(270, 331);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHorario.TabIndex = 6;
            this.btnAgregarHorario.Text = "Agregar";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(357, 331);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarHorario.TabIndex = 7;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(163, 332);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(89, 20);
            this.dtpHoraFin.TabIndex = 8;
            this.dtpHoraFin.Value = new System.DateTime(2025, 3, 27, 18, 30, 8, 0);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.btnAgregarHorario);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.cbDocentes);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.cbCursos);
            this.Name = "Cursos";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.ComboBox cbDocentes;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
    }
}