namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    partial class FrmInicio
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.texusuario = new System.Windows.Forms.TextBox();
            this.texcontrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntrar.Location = new System.Drawing.Point(102, 217);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(110, 33);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // texusuario
            // 
            this.texusuario.Location = new System.Drawing.Point(102, 152);
            this.texusuario.Name = "texusuario";
            this.texusuario.Size = new System.Drawing.Size(110, 20);
            this.texusuario.TabIndex = 1;
            // 
            // texcontrasena
            // 
            this.texcontrasena.Location = new System.Drawing.Point(102, 191);
            this.texcontrasena.Name = "texcontrasena";
            this.texcontrasena.Size = new System.Drawing.Size(110, 20);
            this.texcontrasena.TabIndex = 2;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 361);
            this.Controls.Add(this.texcontrasena);
            this.Controls.Add(this.texusuario);
            this.Controls.Add(this.btnEntrar);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox texusuario;
        private System.Windows.Forms.TextBox texcontrasena;
    }
}