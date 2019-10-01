namespace PruebaBiblioteca1.Forms
{
    partial class RegistroDePrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.txtBibliotecario = new System.Windows.Forms.TextBox();
            this.txtNumeroAdquisicion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cbFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.txtListo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bibliotecario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de Adquisición";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID o Nombre de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre de Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha a Devolver";
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(35, 76);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(48, 20);
            this.txtIdPrestamo.TabIndex = 9;
            // 
            // txtBibliotecario
            // 
            this.txtBibliotecario.Location = new System.Drawing.Point(191, 76);
            this.txtBibliotecario.Name = "txtBibliotecario";
            this.txtBibliotecario.Size = new System.Drawing.Size(135, 20);
            this.txtBibliotecario.TabIndex = 10;
            // 
            // txtNumeroAdquisicion
            // 
            this.txtNumeroAdquisicion.Location = new System.Drawing.Point(186, 146);
            this.txtNumeroAdquisicion.Name = "txtNumeroAdquisicion";
            this.txtNumeroAdquisicion.Size = new System.Drawing.Size(205, 20);
            this.txtNumeroAdquisicion.TabIndex = 11;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(224, 179);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(135, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(191, 219);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(224, 255);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtIdUsuario.TabIndex = 14;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Location = new System.Drawing.Point(224, 286);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtNombreUsuario.TabIndex = 15;
            // 
            // cbFechaDevolucion
            // 
            this.cbFechaDevolucion.Location = new System.Drawing.Point(191, 330);
            this.cbFechaDevolucion.Name = "cbFechaDevolucion";
            this.cbFechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.cbFechaDevolucion.TabIndex = 16;
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.Enabled = false;
            this.btnRegistrarLibro.Location = new System.Drawing.Point(435, 176);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(132, 23);
            this.btnRegistrarLibro.TabIndex = 17;
            this.btnRegistrarLibro.Text = "Registrar Libro";
            this.btnRegistrarLibro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Enabled = false;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(435, 283);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(132, 23);
            this.btnRegistrarUsuario.TabIndex = 18;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Location = new System.Drawing.Point(461, 74);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(135, 20);
            this.txtFechaPrestamo.TabIndex = 19;
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(233, 21);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(167, 22);
            this.lblPrestamos.TabIndex = 20;
            this.lblPrestamos.Text = "Registro Prestamos";
            // 
            // txtListo
            // 
            this.txtListo.Location = new System.Drawing.Point(435, 369);
            this.txtListo.Name = "txtListo";
            this.txtListo.Size = new System.Drawing.Size(132, 23);
            this.txtListo.TabIndex = 21;
            this.txtListo.Text = "Listo";
            this.txtListo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = ".";
            // 
            // RegistroDePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 404);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtListo);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.btnRegistrarLibro);
            this.Controls.Add(this.cbFechaDevolucion);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumeroAdquisicion);
            this.Controls.Add(this.txtBibliotecario);
            this.Controls.Add(this.txtIdPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroDePrestamo";
            this.Text = "RegistroDePrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.TextBox txtBibliotecario;
        private System.Windows.Forms.TextBox txtNumeroAdquisicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.DateTimePicker cbFechaDevolucion;
        private System.Windows.Forms.Button btnRegistrarLibro;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TextBox txtFechaPrestamo;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Button txtListo;
        private System.Windows.Forms.Label label10;
    }
}