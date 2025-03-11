namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    partial class FrmNotas
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
            this.components = new System.ComponentModel.Container();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.estudianteServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(124, 512);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudiantes.TabIndex = 0;
            this.cmbEstudiantes.SelectedIndexChanged += new System.EventHandler(this.cmbEstudiantes_SelectedIndexChanged);
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(279, 512);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 1;
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(438, 512);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(100, 20);
            this.TxtNota.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(544, 504);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 34);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(101, 90);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(880, 315);
            this.dgvNotas.TabIndex = 4;
            // 
            // estudianteServiceBindingSource
            // 
            this.estudianteServiceBindingSource.DataSource = typeof(Sistema_de_Gestión_de_Estudiantes_y_Notas.EstudianteService);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 727);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbEstudiantes);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.BindingSource estudianteServiceBindingSource;
    }
}