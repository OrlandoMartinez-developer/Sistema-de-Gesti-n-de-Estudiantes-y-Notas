namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Cursos_y_Horarios
{
    partial class Cursos1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos1));
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.lblCursoEstudiante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(48, 65);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(161, 250);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(235, 145);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(114, 33);
            this.txtCurso.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(255, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Orange;
            this.btnEliminar.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(402, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(384, 145);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(110, 36);
            this.cmbEstudiante.TabIndex = 4;
            // 
            // lblCursoEstudiante
            // 
            this.lblCursoEstudiante.AutoSize = true;
            this.lblCursoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoEstudiante.Location = new System.Drawing.Point(281, 86);
            this.lblCursoEstudiante.Name = "lblCursoEstudiante";
            this.lblCursoEstudiante.Size = new System.Drawing.Size(168, 20);
            this.lblCursoEstudiante.TabIndex = 5;
            this.lblCursoEstudiante.Text = "Curso del Etudiante";
            this.lblCursoEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCursoEstudiante.Click += new System.EventHandler(this.lblCursoEstudiante_Click);
            // 
            // Cursos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 395);
            this.Controls.Add(this.lblCursoEstudiante);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.dgvCursos);
            this.DoubleBuffered = true;
            this.Name = "Cursos1";
            this.Text = "Cursos1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Label lblCursoEstudiante;
    }
}