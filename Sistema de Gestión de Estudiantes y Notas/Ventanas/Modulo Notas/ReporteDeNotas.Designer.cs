﻿using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.dgvReporteNotas = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.contextMenuReporte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generarReportePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteGraficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteNotas)).BeginInit();
            this.contextMenuReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.BackColor = System.Drawing.Color.White;
            this.cmbEstudiantes.ForeColor = System.Drawing.Color.Black;
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(49, 307);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(150, 21);
            this.cmbEstudiantes.TabIndex = 0;
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.White;
            this.cmbCurso.ForeColor = System.Drawing.Color.Black;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(210, 307);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(150, 21);
            this.cmbCurso.TabIndex = 1;
            // 
            // dgvReporteNotas
            // 
            this.dgvReporteNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteNotas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteNotas.Location = new System.Drawing.Point(47, 57);
            this.dgvReporteNotas.Name = "dgvReporteNotas";
            this.dgvReporteNotas.Size = new System.Drawing.Size(700, 220);
            this.dgvReporteNotas.TabIndex = 2;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(391, 296);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(150, 40);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // contextMenuReporte
            // 
            this.contextMenuReporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReportePDFToolStripMenuItem,
            this.generarReporteGraficoToolStripMenuItem});
            this.contextMenuReporte.Name = "contextMenuStrip1";
            this.contextMenuReporte.Size = new System.Drawing.Size(198, 48);
            // 
            // generarReportePDFToolStripMenuItem
            // 
            this.generarReportePDFToolStripMenuItem.Name = "generarReportePDFToolStripMenuItem";
            this.generarReportePDFToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.generarReportePDFToolStripMenuItem.Text = "Generar reporte PDF";
            this.generarReportePDFToolStripMenuItem.Click += new System.EventHandler(this.generarReportePDFToolStripMenuItem_Click);
            // 
            // generarReporteGraficoToolStripMenuItem
            // 
            this.generarReporteGraficoToolStripMenuItem.Name = "generarReporteGraficoToolStripMenuItem";
            this.generarReporteGraficoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.generarReporteGraficoToolStripMenuItem.Text = "Generar reporte Gráfico";
            this.generarReporteGraficoToolStripMenuItem.Click += new System.EventHandler(this.generarReporteGraficoToolStripMenuItem_Click);
            // 
            // ReporteDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvReporteNotas);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbEstudiantes);
            this.Name = "ReporteDeNotas";
            this.Text = "ReporteDeNotas";
            this.Load += new System.EventHandler(this.ReporteDeNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteNotas)).EndInit();
            this.contextMenuReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.DataGridView dgvReporteNotas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ContextMenuStrip contextMenuReporte;
        private System.Windows.Forms.ToolStripMenuItem generarReportePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteGraficoToolStripMenuItem;
    }

}