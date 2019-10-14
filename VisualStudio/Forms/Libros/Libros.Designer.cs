namespace PruebaBiblioteca1.Forms
{
    partial class FrmLibros
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
            this.lblLibrosRegistrados = new System.Windows.Forms.Label();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresDataSet1 = new PruebaBiblioteca1.AutoresDataSet1();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblTxtEstatus = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblEjemplar = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.cbClasificaciones = new System.Windows.Forms.ComboBox();
            this.clasificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasificacionesDataSet1 = new PruebaBiblioteca1.ClasificacionesDataSet1();
            this.cbUbicaciones = new System.Windows.Forms.ComboBox();
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesDataSet = new PruebaBiblioteca1.UbicacionesDataSet();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumAdq = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataSet1 = new PruebaBiblioteca1.LibrosDataSet1();
            this.txtNumAdquisicion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEjemplar = new System.Windows.Forms.TextBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.librosTableAdapter = new PruebaBiblioteca1.LibrosDataSet1TableAdapters.LibrosTableAdapter();
            this.autoresTableAdapter = new PruebaBiblioteca1.AutoresDataSet1TableAdapters.AutoresTableAdapter();
            this.ubicacionesTableAdapter = new PruebaBiblioteca1.UbicacionesDataSetTableAdapters.UbicacionesTableAdapter();
            this.clasificacionesTableAdapter = new PruebaBiblioteca1.ClasificacionesDataSet1TableAdapters.ClasificacionesTableAdapter();
            this.numeroAdquisicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejemplarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibrosRegistrados
            // 
            this.lblLibrosRegistrados.AutoSize = true;
            this.lblLibrosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrosRegistrados.ForeColor = System.Drawing.Color.White;
            this.lblLibrosRegistrados.Location = new System.Drawing.Point(54, 13);
            this.lblLibrosRegistrados.Name = "lblLibrosRegistrados";
            this.lblLibrosRegistrados.Size = new System.Drawing.Size(180, 24);
            this.lblLibrosRegistrados.TabIndex = 38;
            this.lblLibrosRegistrados.Text = "Registro de Libros";
            // 
            // cbAutores
            // 
            this.cbAutores.DataSource = this.autoresBindingSource;
            this.cbAutores.DisplayMember = "nombreAutor";
            this.cbAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Location = new System.Drawing.Point(125, 124);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(148, 24);
            this.cbAutores.TabIndex = 37;
            this.cbAutores.ValueMember = "idAutor";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.autoresDataSet1;
            // 
            // autoresDataSet1
            // 
            this.autoresDataSet1.DataSetName = "AutoresDataSet1";
            this.autoresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAutor.ForeColor = System.Drawing.Color.White;
            this.lblAutor.Location = new System.Drawing.Point(12, 127);
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
            this.lblEstatus.Location = new System.Drawing.Point(12, 302);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(67, 16);
            this.lblEstatus.TabIndex = 32;
            this.lblEstatus.Text = "Estatus :";
            // 
            // lblTxtEstatus
            // 
            this.lblTxtEstatus.AutoSize = true;
            this.lblTxtEstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblTxtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtEstatus.ForeColor = System.Drawing.Color.Lime;
            this.lblTxtEstatus.Location = new System.Drawing.Point(141, 299);
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
            this.lblClasificacion.Location = new System.Drawing.Point(12, 263);
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
            this.lblEjemplar.Location = new System.Drawing.Point(12, 230);
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
            this.lblUbicacion.Location = new System.Drawing.Point(12, 198);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(86, 16);
            this.lblUbicacion.TabIndex = 28;
            this.lblUbicacion.Text = "Ubicación :";
            // 
            // cbClasificaciones
            // 
            this.cbClasificaciones.DataSource = this.clasificacionesBindingSource;
            this.cbClasificaciones.DisplayMember = "genero";
            this.cbClasificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificaciones.FormattingEnabled = true;
            this.cbClasificaciones.Location = new System.Drawing.Point(125, 255);
            this.cbClasificaciones.Name = "cbClasificaciones";
            this.cbClasificaciones.Size = new System.Drawing.Size(148, 24);
            this.cbClasificaciones.TabIndex = 27;
            this.cbClasificaciones.ValueMember = "clasificacion";
            // 
            // clasificacionesBindingSource
            // 
            this.clasificacionesBindingSource.DataMember = "Clasificaciones";
            this.clasificacionesBindingSource.DataSource = this.clasificacionesDataSet1;
            // 
            // clasificacionesDataSet1
            // 
            this.clasificacionesDataSet1.DataSetName = "ClasificacionesDataSet1";
            this.clasificacionesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbUbicaciones
            // 
            this.cbUbicaciones.DataSource = this.ubicacionesBindingSource;
            this.cbUbicaciones.DisplayMember = "descripcion";
            this.cbUbicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUbicaciones.FormattingEnabled = true;
            this.cbUbicaciones.Location = new System.Drawing.Point(125, 190);
            this.cbUbicaciones.Name = "cbUbicaciones";
            this.cbUbicaciones.Size = new System.Drawing.Size(148, 24);
            this.cbUbicaciones.TabIndex = 25;
            this.cbUbicaciones.ValueMember = "ubicacion";
            // 
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.ubicacionesDataSet;
            // 
            // ubicacionesDataSet
            // 
            this.ubicacionesDataSet.DataSetName = "UbicacionesDataSet";
            this.ubicacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 99);
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
            this.lblNumAdq.Location = new System.Drawing.Point(12, 54);
            this.lblNumAdq.Name = "lblNumAdq";
            this.lblNumAdq.Size = new System.Drawing.Size(97, 32);
            this.lblNumAdq.TabIndex = 23;
            this.lblNumAdq.Text = "Numero de \r\nAdquisición :";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoGenerateColumns = false;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroAdquisicionDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.clasificacionDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.ejemplarDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.Descripcion,
            this.Autor,
            this.genero,
            this.idAutorDataGridViewTextBoxColumn});
            this.dgvLibros.DataSource = this.librosBindingSource;
            this.dgvLibros.Location = new System.Drawing.Point(-2, -4);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(624, 436);
            this.dgvLibros.TabIndex = 22;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibros_CellContentClick);
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.librosDataSet1;
            // 
            // librosDataSet1
            // 
            this.librosDataSet1.DataSetName = "LibrosDataSet1";
            this.librosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumAdquisicion
            // 
            this.txtNumAdquisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAdquisicion.Location = new System.Drawing.Point(125, 64);
            this.txtNumAdquisicion.Name = "txtNumAdquisicion";
            this.txtNumAdquisicion.Size = new System.Drawing.Size(148, 22);
            this.txtNumAdquisicion.TabIndex = 39;
            this.txtNumAdquisicion.TextChanged += new System.EventHandler(this.TxtNumAdquisicion_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(125, 94);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 21);
            this.txtTitulo.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.txtEjemplar);
            this.panel1.Controls.Add(this.btnGenerarReporte);
            this.panel1.Controls.Add(this.lblLibrosRegistrados);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtNumAdquisicion);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.cbAutores);
            this.panel1.Controls.Add(this.lblNumAdq);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblEstatus);
            this.panel1.Controls.Add(this.cbUbicaciones);
            this.panel1.Controls.Add(this.lblTxtEstatus);
            this.panel1.Controls.Add(this.lblClasificacion);
            this.panel1.Controls.Add(this.cbClasificaciones);
            this.panel1.Controls.Add(this.lblEjemplar);
            this.panel1.Controls.Add(this.lblUbicacion);
            this.panel1.Location = new System.Drawing.Point(625, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 450);
            this.panel1.TabIndex = 42;
            // 
            // txtEjemplar
            // 
            this.txtEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplar.Location = new System.Drawing.Point(125, 224);
            this.txtEjemplar.Name = "txtEjemplar";
            this.txtEjemplar.Size = new System.Drawing.Size(148, 22);
            this.txtEjemplar.TabIndex = 67;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporte.AutoSize = true;
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(149, 154);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(124, 28);
            this.btnGenerarReporte.TabIndex = 66;
            this.btnGenerarReporte.Text = "Registrar Autor";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
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
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // ubicacionesTableAdapter
            // 
            this.ubicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // clasificacionesTableAdapter
            // 
            this.clasificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // numeroAdquisicionDataGridViewTextBoxColumn
            // 
            this.numeroAdquisicionDataGridViewTextBoxColumn.DataPropertyName = "numeroAdquisicion";
            this.numeroAdquisicionDataGridViewTextBoxColumn.HeaderText = "NumeroAdquisicion";
            this.numeroAdquisicionDataGridViewTextBoxColumn.Name = "numeroAdquisicionDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // clasificacionDataGridViewTextBoxColumn
            // 
            this.clasificacionDataGridViewTextBoxColumn.DataPropertyName = "clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.HeaderText = "clasificacion";
            this.clasificacionDataGridViewTextBoxColumn.Name = "clasificacionDataGridViewTextBoxColumn";
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // ejemplarDataGridViewTextBoxColumn
            // 
            this.ejemplarDataGridViewTextBoxColumn.DataPropertyName = "ejemplar";
            this.ejemplarDataGridViewTextBoxColumn.HeaderText = "Ejemplar";
            this.ejemplarDataGridViewTextBoxColumn.Name = "ejemplarDataGridViewTextBoxColumn";
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Ubicacion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            this.idAutorDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLibrosRegistrados;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblTxtEstatus;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblEjemplar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ComboBox cbClasificaciones;
        private System.Windows.Forms.ComboBox cbUbicaciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumAdq;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TextBox txtNumAdquisicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtEjemplar;
        private LibrosDataSet1 librosDataSet1;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private LibrosDataSet1TableAdapters.LibrosTableAdapter librosTableAdapter;
        private AutoresDataSet1 autoresDataSet1;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private AutoresDataSet1TableAdapters.AutoresTableAdapter autoresTableAdapter;
        private UbicacionesDataSet ubicacionesDataSet;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private UbicacionesDataSetTableAdapters.UbicacionesTableAdapter ubicacionesTableAdapter;
        private ClasificacionesDataSet1 clasificacionesDataSet1;
        private System.Windows.Forms.BindingSource clasificacionesBindingSource;
        private ClasificacionesDataSet1TableAdapters.ClasificacionesTableAdapter clasificacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAdquisicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejemplarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
    }
}