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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibrosRegistrados
            // 
            this.lblLibrosRegistrados.AutoSize = true;
            this.lblLibrosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosRegistrados.Location = new System.Drawing.Point(222, 9);
            this.lblLibrosRegistrados.Name = "lblLibrosRegistrados";
            this.lblLibrosRegistrados.Size = new System.Drawing.Size(183, 24);
            this.lblLibrosRegistrados.TabIndex = 38;
            this.lblLibrosRegistrados.Text = "Libros Registrados";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(708, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(616, 116);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(45, 16);
            this.lblAutor.TabIndex = 36;
            this.lblAutor.Text = "Autor :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(604, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(268, 48);
            this.button4.TabIndex = 35;
            this.button4.Text = "Generar Reporte";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(739, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 36);
            this.button2.TabIndex = 34;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(604, 336);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(129, 36);
            this.btn_Registrar.TabIndex = 33;
            this.btn_Registrar.Text = "Guardar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(614, 305);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(58, 16);
            this.lblEstatus.TabIndex = 32;
            this.lblEstatus.Text = "Estatus :";
            // 
            // lblTxtEstatus
            // 
            this.lblTxtEstatus.AutoSize = true;
            this.lblTxtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTxtEstatus.Location = new System.Drawing.Point(704, 301);
            this.lblTxtEstatus.Name = "lblTxtEstatus";
            this.lblTxtEstatus.Size = new System.Drawing.Size(93, 20);
            this.lblTxtEstatus.TabIndex = 31;
            this.lblTxtEstatus.Text = "Disponible";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(612, 269);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(90, 16);
            this.lblClasificacion.TabIndex = 30;
            this.lblClasificacion.Text = "Clasificación :";
            // 
            // lblEjemplar
            // 
            this.lblEjemplar.AutoSize = true;
            this.lblEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplar.Location = new System.Drawing.Point(614, 232);
            this.lblEjemplar.Name = "lblEjemplar";
            this.lblEjemplar.Size = new System.Drawing.Size(68, 16);
            this.lblEjemplar.TabIndex = 29;
            this.lblEjemplar.Text = "Ejemplar :";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(614, 193);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(75, 16);
            this.lblUbicacion.TabIndex = 28;
            this.lblUbicacion.Text = "Ubicación :";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(708, 269);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 24);
            this.comboBox3.TabIndex = 27;
            // 
            // cbb_ejemplar
            // 
            this.cbb_ejemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ejemplar.FormattingEnabled = true;
            this.cbb_ejemplar.Location = new System.Drawing.Point(708, 232);
            this.cbb_ejemplar.Name = "cbb_ejemplar";
            this.cbb_ejemplar.Size = new System.Drawing.Size(148, 24);
            this.cbb_ejemplar.TabIndex = 26;
            // 
            // cbb_Ubicacion
            // 
            this.cbb_Ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ubicacion.FormattingEnabled = true;
            this.cbb_Ubicacion.Location = new System.Drawing.Point(708, 190);
            this.cbb_Ubicacion.Name = "cbb_Ubicacion";
            this.cbb_Ubicacion.Size = new System.Drawing.Size(148, 24);
            this.cbb_Ubicacion.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(614, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 16);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Título :";
            // 
            // lblNumAdq
            // 
            this.lblNumAdq.AutoSize = true;
            this.lblNumAdq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAdq.Location = new System.Drawing.Point(614, 15);
            this.lblNumAdq.Name = "lblNumAdq";
            this.lblNumAdq.Size = new System.Drawing.Size(84, 32);
            this.lblNumAdq.TabIndex = 23;
            this.lblNumAdq.Text = "Numero de \r\nAdquisición :";
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Adquisicion,
            this.Titulo,
            this.Autores,
            this.Ubicacion,
            this.Ejemplar,
            this.Clasificacion,
            this.Estatus});
            this.dgvLibros.Location = new System.Drawing.Point(12, 45);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(583, 381);
            this.dgvLibros.TabIndex = 22;
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
            this.txtNumAdquisicion.Location = new System.Drawing.Point(704, 25);
            this.txtNumAdquisicion.Name = "txtNumAdquisicion";
            this.txtNumAdquisicion.Size = new System.Drawing.Size(148, 22);
            this.txtNumAdquisicion.TabIndex = 39;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(708, 64);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 38);
            this.txtTitulo.TabIndex = 40;
            // 
            // btnRegistrarAutores
            // 
            this.btnRegistrarAutores.Location = new System.Drawing.Point(751, 152);
            this.btnRegistrarAutores.Name = "btnRegistrarAutores";
            this.btnRegistrarAutores.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrarAutores.TabIndex = 41;
            this.btnRegistrarAutores.Text = "Registrar Autores";
            this.btnRegistrarAutores.UseVisualStyleBackColor = true;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.btnRegistrarAutores);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumAdquisicion);
            this.Controls.Add(this.lblLibrosRegistrados);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblTxtEstatus);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblEjemplar);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cbb_ejemplar);
            this.Controls.Add(this.cbb_Ubicacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumAdq);
            this.Controls.Add(this.dgvLibros);
            this.Name = "Libros";
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibrosRegistrados;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Registrar;
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
    }
}