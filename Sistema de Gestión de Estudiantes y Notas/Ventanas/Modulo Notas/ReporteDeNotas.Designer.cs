namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas.Modulo_Notas
{
    partial class ReporteDeNotas
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
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.dgvReporteNotas = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(49, 307);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudiantes.TabIndex = 0;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(210, 307);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 1;
            // 
            // dgvReporteNotas
            // 
            this.dgvReporteNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteNotas.Location = new System.Drawing.Point(45, 57);
            this.dgvReporteNotas.Name = "dgvReporteNotas";
            this.dgvReporteNotas.Size = new System.Drawing.Size(646, 219);
            this.dgvReporteNotas.TabIndex = 2;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(534, 307);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(109, 35);
            this.btnPDF.TabIndex = 3;
            this.btnPDF.Text = "Exportar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(379, 307);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(109, 35);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // ReporteDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dgvReporteNotas);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbEstudiantes);
            this.Name = "ReporteDeNotas";
            this.Text = "ReporteDeNotas";
            this.Load += new System.EventHandler(this.ReporteDeNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.DataGridView dgvReporteNotas;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnReporte;
    }
}