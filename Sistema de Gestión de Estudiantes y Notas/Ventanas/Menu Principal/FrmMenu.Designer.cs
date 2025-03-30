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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosYHorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.cursosYHorToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(66, 39);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(109, 39);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(67, 39);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(88, 39);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // cursosYHorToolStripMenuItem
            // 
            this.cursosYHorToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursosYHorToolStripMenuItem.Name = "cursosYHorToolStripMenuItem";
            this.cursosYHorToolStripMenuItem.Size = new System.Drawing.Size(154, 39);
            this.cursosYHorToolStripMenuItem.Text = "Cursos Y Horarios";
            this.cursosYHorToolStripMenuItem.Click += new System.EventHandler(this.cursosYHorToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasToolStripMenuItem1,
            this.graficoToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(87, 39);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // notasToolStripMenuItem1
            // 
            this.notasToolStripMenuItem1.Name = "notasToolStripMenuItem1";
            this.notasToolStripMenuItem1.Size = new System.Drawing.Size(180, 40);
            this.notasToolStripMenuItem1.Text = "Notas";
            // 
            // graficoToolStripMenuItem
            // 
            this.graficoToolStripMenuItem.Name = "graficoToolStripMenuItem";
            this.graficoToolStripMenuItem.Size = new System.Drawing.Size(180, 40);
            this.graficoToolStripMenuItem.Text = "Grafico";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosYHorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graficoToolStripMenuItem;
    }
}