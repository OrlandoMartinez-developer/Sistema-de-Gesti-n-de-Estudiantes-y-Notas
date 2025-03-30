namespace Sistema_de_Gestión_de_Estudiantes_y_Notas.Ventanas
{
    partial class Form_Docentes
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
            this.dgvMatYHor = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.cmbHora_Fin = new System.Windows.Forms.ComboBox();
            this.cmbHora_In = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatYHor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatYHor
            // 
            this.dgvMatYHor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatYHor.Location = new System.Drawing.Point(155, 12);
            this.dgvMatYHor.Name = "dgvMatYHor";
            this.dgvMatYHor.Size = new System.Drawing.Size(476, 314);
            this.dgvMatYHor.TabIndex = 0;
            this.dgvMatYHor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(671, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(671, 145);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(97, 34);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // cmbDocentes
            // 
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(155, 345);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(121, 21);
            this.cmbDocentes.TabIndex = 14;
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(155, 425);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 15;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(155, 385);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 17;
            // 
            // cmbHora_Fin
            // 
            this.cmbHora_Fin.FormattingEnabled = true;
            this.cmbHora_Fin.Location = new System.Drawing.Point(510, 385);
            this.cmbHora_Fin.Name = "cmbHora_Fin";
            this.cmbHora_Fin.Size = new System.Drawing.Size(121, 21);
            this.cmbHora_Fin.TabIndex = 19;
            // 
            // cmbHora_In
            // 
            this.cmbHora_In.FormattingEnabled = true;
            this.cmbHora_In.Location = new System.Drawing.Point(510, 345);
            this.cmbHora_In.Name = "cmbHora_In";
            this.cmbHora_In.Size = new System.Drawing.Size(121, 21);
            this.cmbHora_In.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Docentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hora Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora Final";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form_Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHora_Fin);
            this.Controls.Add(this.cmbHora_In);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbDocentes);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvMatYHor);
            this.Name = "Form_Docentes";
            this.Text = "Form_Johan";
            this.Load += new System.EventHandler(this.Form_Johan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatYHor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatYHor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cmbDocentes;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.ComboBox cmbHora_Fin;
        private System.Windows.Forms.ComboBox cmbHora_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}