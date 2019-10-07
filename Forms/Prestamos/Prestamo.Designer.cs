namespace PruebaBiblioteca1
{
    partial class Menú
    {
     ///holaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
     //De quien eres?



        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBibliotecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnPrestamoNuevo = new System.Windows.Forms.Button();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnBibliotecarios = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrestamo,
            this.titulo,
            this.fechaDevolver,
            this.nombreUsuario,
            this.idBibliotecario});
            this.dgvPrestamos.Location = new System.Drawing.Point(258, 55);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(723, 433);
            this.dgvPrestamos.TabIndex = 1;
            // 
            // idPrestamo
            // 
            this.idPrestamo.HeaderText = "ID Préstamo";
            this.idPrestamo.Name = "idPrestamo";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            // 
            // fechaDevolver
            // 
            this.fechaDevolver.HeaderText = "Fecha a devolver";
            this.fechaDevolver.Name = "fechaDevolver";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "Nombre del Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // idBibliotecario
            // 
            this.idBibliotecario.HeaderText = "ID Bibliotecario";
            this.idBibliotecario.Name = "idBibliotecario";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporte.AutoSize = true;
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(468, 494);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 37);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnPrestamoNuevo
            // 
            this.btnPrestamoNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrestamoNuevo.AutoSize = true;
            this.btnPrestamoNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnPrestamoNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnPrestamoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamoNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamoNuevo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamoNuevo.Location = new System.Drawing.Point(810, 494);
            this.btnPrestamoNuevo.Name = "btnPrestamoNuevo";
            this.btnPrestamoNuevo.Size = new System.Drawing.Size(165, 37);
            this.btnPrestamoNuevo.TabIndex = 3;
            this.btnPrestamoNuevo.Text = "Nuevo Préstamo";
            this.btnPrestamoNuevo.UseVisualStyleBackColor = false;
            this.btnPrestamoNuevo.Click += new System.EventHandler(this.BtnPrestamoNuevo_Click);
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPrestamo.AutoSize = true;
            this.btnModificarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnModificarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnModificarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrestamo.Location = new System.Drawing.Point(639, 494);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(165, 37);
            this.btnModificarPrestamo.TabIndex = 4;
            this.btnModificarPrestamo.Text = "Modificar Préstamo";
            this.btnModificarPrestamo.UseVisualStyleBackColor = false;
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrestamos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(583, 19);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(107, 22);
            this.lblPrestamos.TabIndex = 5;
            this.lblPrestamos.Text = "Préstamos";
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrestamos.AutoSize = true;
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestamos.Image")));
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 55);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(251, 66);
            this.btnPrestamos.TabIndex = 7;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDevoluciones.AutoSize = true;
            this.btnDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.Image = ((System.Drawing.Image)(resources.GetObject("btnDevoluciones.Image")));
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.Location = new System.Drawing.Point(0, 127);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(251, 66);
            this.btnDevoluciones.TabIndex = 8;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = false;
            this.btnDevoluciones.Click += new System.EventHandler(this.BtnDevoluciones_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.AutoSize = true;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 199);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(251, 66);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnLibros
            // 
            this.btnLibros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLibros.AutoSize = true;
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.Image = ((System.Drawing.Image)(resources.GetObject("btnLibros.Image")));
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.Location = new System.Drawing.Point(0, 271);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(251, 66);
            this.btnLibros.TabIndex = 10;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            // 
            // btnBibliotecarios
            // 
            this.btnBibliotecarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBibliotecarios.AutoSize = true;
            this.btnBibliotecarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnBibliotecarios.FlatAppearance.BorderSize = 0;
            this.btnBibliotecarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBibliotecarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBibliotecarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBibliotecarios.ForeColor = System.Drawing.Color.White;
            this.btnBibliotecarios.Image = ((System.Drawing.Image)(resources.GetObject("btnBibliotecarios.Image")));
            this.btnBibliotecarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBibliotecarios.Location = new System.Drawing.Point(0, 343);
            this.btnBibliotecarios.Name = "btnBibliotecarios";
            this.btnBibliotecarios.Size = new System.Drawing.Size(251, 66);
            this.btnBibliotecarios.TabIndex = 11;
            this.btnBibliotecarios.Text = "    Bibliotecarios";
            this.btnBibliotecarios.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 66);
            this.button5.TabIndex = 12;
            this.button5.Text = "Cambiar Bibliotecario";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnBibliotecarios);
            this.panel1.Controls.Add(this.btnLibros);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnDevoluciones);
            this.panel1.Controls.Add(this.btnPrestamos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 608);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 546);
            this.panel2.TabIndex = 6;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.btnPrestamoNuevo);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.panel1);
            this.Name = "Menú";
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Menú_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnPrestamoNuevo;
        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnBibliotecarios;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBibliotecario;
        private System.Windows.Forms.Panel panel2;
    }
}

