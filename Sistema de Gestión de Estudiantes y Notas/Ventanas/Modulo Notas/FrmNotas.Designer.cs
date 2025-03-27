using System.Drawing;

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
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnpromedio = new System.Windows.Forms.Button();
            this.estudianteServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteServiceBindingSource)).BeginInit();
            this.SuspendLayout();

            this.BackColor = Color.FromArgb(238, 238, 238); // Fondo principal gris neutro
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(54, 110);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudiantes.TabIndex = 0;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(54, 186);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 1;
            // 
            // TxtNota
            // 
            this.TxtNota.Location = new System.Drawing.Point(245, 186);
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(121, 20);
            this.TxtNota.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(44, 301);
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
            this.dgvNotas.Location = new System.Drawing.Point(501, 110);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(544, 546);
            this.dgvNotas.TabIndex = 4;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(245, 110);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(175, 301);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 34);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(301, 301);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(97, 34);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnpromedio
            // 
            this.btnpromedio.Location = new System.Drawing.Point(44, 394);
            this.btnpromedio.Name = "btnpromedio";
            this.btnpromedio.Size = new System.Drawing.Size(97, 34);
            this.btnpromedio.TabIndex = 10;
            this.btnpromedio.Text = "Promedio";
            this.btnpromedio.UseVisualStyleBackColor = true;
            this.btnpromedio.Click += new System.EventHandler(this.btnpromedio_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(166, 394);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(97, 34);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 727);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnpromedio);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbEstudiantes);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

           
this.cmbEstudiantes.BackColor = Color.White;
            this.cmbEstudiantes.ForeColor = Color.FromArgb(66, 66, 66);
            this.cmbMateria.BackColor = Color.White;
            this.cmbMateria.ForeColor = Color.FromArgb(66, 66, 66);
            this.cmbCurso.BackColor = Color.White;
            this.cmbCurso.ForeColor = Color.FromArgb(66, 66, 66);

            // Estilo del TextBox
            this.TxtNota.BackColor = Color.White;
            this.TxtNota.ForeColor = Color.FromArgb(66, 66, 66);

            // Estilo de los botones
            this.btnGuardar.BackColor = Color.FromArgb(33, 150, 243);
            this.btnGuardar.ForeColor = Color.White;
            this.btnEditar.BackColor = Color.FromArgb(255, 193, 7);
            this.btnEditar.ForeColor = Color.White;
            this.btneliminar.BackColor = Color.FromArgb(244, 67, 54);
            this.btneliminar.ForeColor = Color.White;
            this.btnpromedio.BackColor = Color.FromArgb(102, 187, 106);
            this.btnpromedio.ForeColor = Color.White;
            this.btnReporte.BackColor = Color.FromArgb(76, 175, 80);
            this.btnReporte.ForeColor = Color.White;

            // Estilo del DataGridView
            dgvNotas.BackgroundColor = Color.White;
            dgvNotas.ForeColor = Color.FromArgb(66, 66, 66);
            dgvNotas.GridColor = Color.FromArgb(158, 158, 158);
            dgvNotas.DefaultCellStyle.BackColor = Color.White;
            dgvNotas.DefaultCellStyle.ForeColor = Color.FromArgb(66, 66, 66);
            dgvNotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dgvNotas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotas.EnableHeadersVisualStyles = false;

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.BindingSource estudianteServiceBindingSource;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnpromedio;
        private System.Windows.Forms.Button btnReporte;
    }
}