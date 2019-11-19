namespace PruebaBiblioteca1
{
    partial class Form1
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBibliotecarios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnDevolverPrestamo = new System.Windows.Forms.Button();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.iDPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDelPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAdquiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaADevolverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDevoluciones = new Biblioteca4.PrestamosDevoluciones();
            this.idPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new Biblioteca4.PrestamosDevolucionesTableAdapters.TableAdapterManager();
            this.devolucionesTableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.DevolucionesTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(255, -43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 783);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnBibliotecarios);
            this.panel3.Controls.Add(this.btnLibros);
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Controls.Add(this.btnDevoluciones);
            this.panel3.Controls.Add(this.btnPrestamos);
            this.panel3.Location = new System.Drawing.Point(2, -235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 1467);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 875);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cambiar Bibliotecario";
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnBibliotecarios.Location = new System.Drawing.Point(3, 734);
            this.btnBibliotecarios.Name = "btnBibliotecarios";
            this.btnBibliotecarios.Size = new System.Drawing.Size(251, 66);
            this.btnBibliotecarios.TabIndex = 11;
            this.btnBibliotecarios.Text = "    Bibliotecarios";
            this.btnBibliotecarios.UseVisualStyleBackColor = false;
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
            this.btnLibros.Location = new System.Drawing.Point(3, 647);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(251, 66);
            this.btnLibros.TabIndex = 10;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
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
            this.btnUsuarios.Location = new System.Drawing.Point(2, 559);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(251, 66);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
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
            this.btnDevoluciones.Location = new System.Drawing.Point(2, 475);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(251, 66);
            this.btnDevoluciones.TabIndex = 8;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = false;
            this.btnDevoluciones.Click += new System.EventHandler(this.Button6_Click);
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
            this.btnPrestamos.Location = new System.Drawing.Point(2, 393);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(251, 66);
            this.btnPrestamos.TabIndex = 7;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Préstamos";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(766, 658);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 37);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar Préstamo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.Button8_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(937, 658);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 37);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo Préstamo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.Button9_Click);
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
            this.btnGenerarReporte.Location = new System.Drawing.Point(595, 658);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 37);
            this.btnGenerarReporte.TabIndex = 15;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // btnDevolverPrestamo
            // 
            this.btnDevolverPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolverPrestamo.AutoSize = true;
            this.btnDevolverPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnDevolverPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnDevolverPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnDevolverPrestamo.Location = new System.Drawing.Point(424, 658);
            this.btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            this.btnDevolverPrestamo.Size = new System.Drawing.Size(165, 37);
            this.btnDevolverPrestamo.TabIndex = 22;
            this.btnDevolverPrestamo.Text = "Devolver Prestamo";
            this.btnDevolverPrestamo.UseVisualStyleBackColor = false;
            this.btnDevolverPrestamo.Click += new System.EventHandler(this.Button5_Click);
            // 
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AllowUserToAddRows = false;
            this.prestamosDataGridView.AllowUserToDeleteRows = false;
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPrestamoDataGridViewTextBoxColumn,
            this.fechaDelPrestamoDataGridViewTextBoxColumn,
            this.numAdquiDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.bibliotecarioDataGridViewTextBoxColumn,
            this.fechaADevolverDataGridViewTextBoxColumn});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource1;
            this.prestamosDataGridView.Location = new System.Drawing.Point(278, 82);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.ReadOnly = true;
            this.prestamosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prestamosDataGridView.Size = new System.Drawing.Size(808, 562);
            this.prestamosDataGridView.TabIndex = 23;
            this.prestamosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrestamosDataGridView_CellContentClick_1);
            this.prestamosDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrestamosDataGridView_CellContentDoubleClick_1);
            // 
            // iDPrestamoDataGridViewTextBoxColumn
            // 
            this.iDPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDPrestamoDataGridViewTextBoxColumn.DataPropertyName = "ID Prestamo";
            this.iDPrestamoDataGridViewTextBoxColumn.HeaderText = "ID Prestamo";
            this.iDPrestamoDataGridViewTextBoxColumn.Name = "iDPrestamoDataGridViewTextBoxColumn";
            this.iDPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPrestamoDataGridViewTextBoxColumn.Width = 83;
            // 
            // fechaDelPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaDelPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDelPrestamoDataGridViewTextBoxColumn.DataPropertyName = "Fecha del Prestamo";
            this.fechaDelPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha del Prestamo";
            this.fechaDelPrestamoDataGridViewTextBoxColumn.Name = "fechaDelPrestamoDataGridViewTextBoxColumn";
            this.fechaDelPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDelPrestamoDataGridViewTextBoxColumn.Width = 115;
            // 
            // numAdquiDataGridViewTextBoxColumn
            // 
            this.numAdquiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numAdquiDataGridViewTextBoxColumn.DataPropertyName = "Num_ Adqui_";
            this.numAdquiDataGridViewTextBoxColumn.HeaderText = "Num_ Adqui_";
            this.numAdquiDataGridViewTextBoxColumn.Name = "numAdquiDataGridViewTextBoxColumn";
            this.numAdquiDataGridViewTextBoxColumn.ReadOnly = true;
            this.numAdquiDataGridViewTextBoxColumn.Width = 88;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 58;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 68;
            // 
            // bibliotecarioDataGridViewTextBoxColumn
            // 
            this.bibliotecarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "Bibliotecario";
            this.bibliotecarioDataGridViewTextBoxColumn.HeaderText = "Bibliotecario";
            this.bibliotecarioDataGridViewTextBoxColumn.Name = "bibliotecarioDataGridViewTextBoxColumn";
            this.bibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.bibliotecarioDataGridViewTextBoxColumn.Width = 89;
            // 
            // fechaADevolverDataGridViewTextBoxColumn
            // 
            this.fechaADevolverDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaADevolverDataGridViewTextBoxColumn.DataPropertyName = "Fecha a Devolver";
            this.fechaADevolverDataGridViewTextBoxColumn.HeaderText = "Fecha a Devolver";
            this.fechaADevolverDataGridViewTextBoxColumn.Name = "fechaADevolverDataGridViewTextBoxColumn";
            this.fechaADevolverDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaADevolverDataGridViewTextBoxColumn.Width = 107;
            // 
            // prestamosBindingSource1
            // 
            this.prestamosBindingSource1.DataMember = "Prestamos";
            this.prestamosBindingSource1.DataSource = this.prestamosDevoluciones;
            // 
            // prestamosDevoluciones
            // 
            this.prestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.prestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idPrestamoTextBox
            // 
            this.idPrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource1, "ID Prestamo", true));
            this.idPrestamoTextBox.Location = new System.Drawing.Point(278, 7);
            this.idPrestamoTextBox.Name = "idPrestamoTextBox";
            this.idPrestamoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPrestamoTextBox.TabIndex = 24;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(278, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.Location = new System.Drawing.Point(907, 50);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(179, 15);
            this.txtBusqueda.TabIndex = 79;
            this.txtBusqueda.Text = "Buscar";
            this.txtBusqueda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBusqueda_MouseClick);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(906, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 3);
            this.panel1.TabIndex = 80;
            // 
            // picture
            // 
            this.picture.Image = global::Biblioteca4.Properties.Resources.Lupa2;
            this.picture.Location = new System.Drawing.Point(881, 50);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(22, 20);
            this.picture.TabIndex = 81;
            this.picture.TabStop = false;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca4.PrestamosDevolucionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // devolucionesTableAdapter
            // 
            this.devolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1113, 707);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.idPrestamoTextBox);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.btnDevolverPrestamo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBibliotecarios;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private PrestamosDevoluciones prestamosDevoluciones;
        private PrestamosDevolucionesTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private PrestamosDevolucionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnDevolverPrestamo;
        private PrestamosDevolucionesTableAdapters.DevolucionesTableAdapter devolucionesTableAdapter;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private System.Windows.Forms.BindingSource prestamosBindingSource1;
        private System.Windows.Forms.TextBox idPrestamoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDelPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAdquiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaADevolverDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView prestamosDataGridView;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel1;
    }
}

