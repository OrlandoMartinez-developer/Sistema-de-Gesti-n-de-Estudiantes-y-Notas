namespace Sistema_de_Gestión_de_Estudiantes_y_Notas
{
    partial class Form1
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
            this.ConectarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConectarBD
            // 
            this.ConectarBD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConectarBD.Location = new System.Drawing.Point(301, 243);
            this.ConectarBD.Name = "ConectarBD";
            this.ConectarBD.Size = new System.Drawing.Size(134, 58);
            this.ConectarBD.TabIndex = 0;
            this.ConectarBD.Text = "Conectar BD";
            this.ConectarBD.UseVisualStyleBackColor = false;
            this.ConectarBD.Click += new System.EventHandler(this.ConectarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConectarBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConectarBD;
    }
}

