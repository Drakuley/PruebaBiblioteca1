namespace PruebaBiblioteca1.Forms.Usuarios
{
    partial class GenerarReporteUsuario
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Tiutlo = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(28, 67);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 26;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // Tiutlo
            // 
            this.Tiutlo.AutoSize = true;
            this.Tiutlo.Location = new System.Drawing.Point(25, 21);
            this.Tiutlo.Name = "Tiutlo";
            this.Tiutlo.Size = new System.Drawing.Size(57, 13);
            this.Tiutlo.TabIndex = 25;
            this.Tiutlo.Text = "ID Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(88, 18);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(73, 20);
            this.txtIdUsuario.TabIndex = 24;
            // 
            // GenerarReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 114);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.Tiutlo);
            this.Controls.Add(this.txtIdUsuario);
            this.Name = "GenerarReporteUsuario";
            this.Text = "GenerarReporteDeUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label Tiutlo;
        private System.Windows.Forms.TextBox txtIdUsuario;
    }
}