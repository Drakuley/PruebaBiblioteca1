namespace PruebaBiblioteca1.Forms
{
    partial class Libros
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
            this.lblLibrosRegistrados = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblTxtEstatus = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblEjemplar = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbb_ejemplar = new System.Windows.Forms.ComboBox();
            this.cbb_Ubicacion = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumAdq = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Num_Adquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumAdquisicion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnRegistrarAutores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibrosRegistrados
            // 
            this.lblLibrosRegistrados.AutoSize = true;
            this.lblLibrosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosRegistrados.ForeColor = System.Drawing.Color.White;
            this.lblLibrosRegistrados.Location = new System.Drawing.Point(108, 13);
            this.lblLibrosRegistrados.Name = "lblLibrosRegistrados";
            this.lblLibrosRegistrados.Size = new System.Drawing.Size(67, 24);
            this.lblLibrosRegistrados.TabIndex = 38;
            this.lblLibrosRegistrados.Text = "Libros";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAutor.ForeColor = System.Drawing.Color.White;
            this.lblAutor.Location = new System.Drawing.Point(18, 144);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 16);
            this.lblAutor.TabIndex = 36;
            this.lblAutor.Text = "Autor :";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(18, 297);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(67, 16);
            this.lblEstatus.TabIndex = 32;
            this.lblEstatus.Text = "Estatus :";
            // 
            // lblTxtEstatus
            // 
            this.lblTxtEstatus.AutoSize = true;
            this.lblTxtEstatus.BackColor = System.Drawing.Color.White;
            this.lblTxtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTxtEstatus.Location = new System.Drawing.Point(153, 296);
            this.lblTxtEstatus.Name = "lblTxtEstatus";
            this.lblTxtEstatus.Size = new System.Drawing.Size(93, 20);
            this.lblTxtEstatus.TabIndex = 31;
            this.lblTxtEstatus.Text = "Disponible";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblClasificacion.ForeColor = System.Drawing.Color.White;
            this.lblClasificacion.Location = new System.Drawing.Point(16, 263);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(105, 16);
            this.lblClasificacion.TabIndex = 30;
            this.lblClasificacion.Text = "Clasificación :";
            // 
            // lblEjemplar
            // 
            this.lblEjemplar.AutoSize = true;
            this.lblEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEjemplar.ForeColor = System.Drawing.Color.White;
            this.lblEjemplar.Location = new System.Drawing.Point(18, 233);
            this.lblEjemplar.Name = "lblEjemplar";
            this.lblEjemplar.Size = new System.Drawing.Size(78, 16);
            this.lblEjemplar.TabIndex = 29;
            this.lblEjemplar.Text = "Ejemplar :";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUbicacion.ForeColor = System.Drawing.Color.White;
            this.lblUbicacion.Location = new System.Drawing.Point(18, 203);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(86, 16);
            this.lblUbicacion.TabIndex = 28;
            this.lblUbicacion.Text = "Ubicación :";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(125, 258);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 24);
            this.comboBox3.TabIndex = 27;
            // 
            // cbb_ejemplar
            // 
            this.cbb_ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ejemplar.FormattingEnabled = true;
            this.cbb_ejemplar.Location = new System.Drawing.Point(125, 227);
            this.cbb_ejemplar.Name = "cbb_ejemplar";
            this.cbb_ejemplar.Size = new System.Drawing.Size(148, 24);
            this.cbb_ejemplar.TabIndex = 26;
            // 
            // cbb_Ubicacion
            // 
            this.cbb_Ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ubicacion.FormattingEnabled = true;
            this.cbb_Ubicacion.Location = new System.Drawing.Point(125, 197);
            this.cbb_Ubicacion.Name = "cbb_Ubicacion";
            this.cbb_Ubicacion.Size = new System.Drawing.Size(148, 24);
            this.cbb_Ubicacion.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 114);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 16);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Título :";
            // 
            // lblNumAdq
            // 
            this.lblNumAdq.AutoSize = true;
            this.lblNumAdq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblNumAdq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNumAdq.ForeColor = System.Drawing.Color.White;
            this.lblNumAdq.Location = new System.Drawing.Point(16, 71);
            this.lblNumAdq.Name = "lblNumAdq";
            this.lblNumAdq.Size = new System.Drawing.Size(97, 32);
            this.lblNumAdq.TabIndex = 23;
            this.lblNumAdq.Text = "Numero de \r\nAdquisición :";
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Adquisicion,
            this.Titulo,
            this.Autores,
            this.Ubicacion,
            this.Ejemplar,
            this.Clasificacion,
            this.Estatus});
            this.dgvLibros.Location = new System.Drawing.Point(-2, -4);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(624, 436);
            this.dgvLibros.TabIndex = 22;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibros_CellContentClick);
            // 
            // Num_Adquisicion
            // 
            this.Num_Adquisicion.Frozen = true;
            this.Num_Adquisicion.HeaderText = "Num_Adq";
            this.Num_Adquisicion.Name = "Num_Adquisicion";
            this.Num_Adquisicion.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.Frozen = true;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autores
            // 
            this.Autores.Frozen = true;
            this.Autores.HeaderText = "Autor";
            this.Autores.Name = "Autores";
            // 
            // Ubicacion
            // 
            this.Ubicacion.Frozen = true;
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // Ejemplar
            // 
            this.Ejemplar.Frozen = true;
            this.Ejemplar.HeaderText = "Ejemplar";
            this.Ejemplar.Name = "Ejemplar";
            this.Ejemplar.ReadOnly = true;
            // 
            // Clasificacion
            // 
            this.Clasificacion.Frozen = true;
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.Frozen = true;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // txtNumAdquisicion
            // 
            this.txtNumAdquisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAdquisicion.Location = new System.Drawing.Point(125, 81);
            this.txtNumAdquisicion.Name = "txtNumAdquisicion";
            this.txtNumAdquisicion.Size = new System.Drawing.Size(148, 22);
            this.txtNumAdquisicion.TabIndex = 39;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(125, 109);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 21);
            this.txtTitulo.TabIndex = 40;
            // 
            // btnRegistrarAutores
            // 
            this.btnRegistrarAutores.Location = new System.Drawing.Point(168, 166);
            this.btnRegistrarAutores.Name = "btnRegistrarAutores";
            this.btnRegistrarAutores.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrarAutores.TabIndex = 41;
            this.btnRegistrarAutores.Text = "Registrar Autores";
            this.btnRegistrarAutores.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.lblLibrosRegistrados);
            this.panel1.Controls.Add(this.btnRegistrarAutores);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtNumAdquisicion);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblNumAdq);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Controls.Add(this.cbb_Ubicacion);
            this.panel1.Controls.Add(this.lblTxtEstatus);
            this.panel1.Controls.Add(this.cbb_ejemplar);
            this.panel1.Controls.Add(this.lblClasificacion);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.lblEjemplar);
            this.panel1.Controls.Add(this.lblUbicacion);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(625, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 450);
            this.panel1.TabIndex = 42;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporte.AutoSize = true;
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(15, 387);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(256, 36);
            this.btnReporte.TabIndex = 64;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(151, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 36);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(15, 345);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 36);
            this.btnAceptar.TabIndex = 62;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(617, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 546);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(125, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 33);
            this.panel3.TabIndex = 65;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.panel1);
            this.Name = "Libros";
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLibrosRegistrados;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblTxtEstatus;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblEjemplar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbb_ejemplar;
        private System.Windows.Forms.ComboBox cbb_Ubicacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumAdq;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Adquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.TextBox txtNumAdquisicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnRegistrarAutores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}