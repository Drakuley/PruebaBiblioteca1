namespace PruebaBiblioteca1
{
    partial class FrmMenú
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenú));
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnBibliotecarios = new System.Windows.Forms.Button();
            this.btnCambiarBibliotecario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.iDPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDelPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAdquiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaADevolverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDevoluciones = new PruebaBiblioteca1.PrestamosDevoluciones();
            this.btnDevolverPrestamo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.idPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prestamosTableAdapter = new PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.PrestamosTableAdapter();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrestamos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(641, 19);
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
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
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
            this.btnLibros.Click += new System.EventHandler(this.BtnLibros_Click);
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
            this.btnBibliotecarios.Click += new System.EventHandler(this.BtnBibliotecarios_Click);
            // 
            // btnCambiarBibliotecario
            // 
            this.btnCambiarBibliotecario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCambiarBibliotecario.AutoSize = true;
            this.btnCambiarBibliotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.btnCambiarBibliotecario.FlatAppearance.BorderSize = 0;
            this.btnCambiarBibliotecario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiarBibliotecario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarBibliotecario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarBibliotecario.ForeColor = System.Drawing.Color.White;
            this.btnCambiarBibliotecario.Location = new System.Drawing.Point(0, 415);
            this.btnCambiarBibliotecario.Name = "btnCambiarBibliotecario";
            this.btnCambiarBibliotecario.Size = new System.Drawing.Size(251, 66);
            this.btnCambiarBibliotecario.TabIndex = 12;
            this.btnCambiarBibliotecario.Text = "Cambiar Bibliotecario";
            this.btnCambiarBibliotecario.UseVisualStyleBackColor = false;
            this.btnCambiarBibliotecario.Click += new System.EventHandler(this.BtnCambiarBibliotecario_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btnCambiarBibliotecario);
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
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AllowUserToAddRows = false;
            this.prestamosDataGridView.AllowUserToDeleteRows = false;
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPrestamoDataGridViewTextBoxColumn,
            this.fechaDelPrestamoDataGridViewTextBoxColumn,
            this.numAdquiDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.bibliotecarioDataGridViewTextBoxColumn,
            this.fechaADevolverDataGridViewTextBoxColumn});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource;
            this.prestamosDataGridView.Location = new System.Drawing.Point(281, 66);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.ReadOnly = true;
            this.prestamosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prestamosDataGridView.Size = new System.Drawing.Size(808, 405);
            this.prestamosDataGridView.TabIndex = 24;
            this.prestamosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrestamosDataGridView_CellContentClick);
            this.prestamosDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrestamosDataGridView_CellContentDoubleClick);
            // 
            // iDPrestamoDataGridViewTextBoxColumn
            // 
            this.iDPrestamoDataGridViewTextBoxColumn.DataPropertyName = "ID Prestamo";
            this.iDPrestamoDataGridViewTextBoxColumn.HeaderText = "ID Prestamo";
            this.iDPrestamoDataGridViewTextBoxColumn.Name = "iDPrestamoDataGridViewTextBoxColumn";
            this.iDPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDelPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaDelPrestamoDataGridViewTextBoxColumn.DataPropertyName = "Fecha del Prestamo";
            this.fechaDelPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha del Prestamo";
            this.fechaDelPrestamoDataGridViewTextBoxColumn.Name = "fechaDelPrestamoDataGridViewTextBoxColumn";
            this.fechaDelPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numAdquiDataGridViewTextBoxColumn
            // 
            this.numAdquiDataGridViewTextBoxColumn.DataPropertyName = "Num_ Adqui_";
            this.numAdquiDataGridViewTextBoxColumn.HeaderText = "Núm. de Adquisición";
            this.numAdquiDataGridViewTextBoxColumn.Name = "numAdquiDataGridViewTextBoxColumn";
            this.numAdquiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bibliotecarioDataGridViewTextBoxColumn
            // 
            this.bibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "Bibliotecario";
            this.bibliotecarioDataGridViewTextBoxColumn.HeaderText = "Bibliotecario";
            this.bibliotecarioDataGridViewTextBoxColumn.Name = "bibliotecarioDataGridViewTextBoxColumn";
            this.bibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaADevolverDataGridViewTextBoxColumn
            // 
            this.fechaADevolverDataGridViewTextBoxColumn.DataPropertyName = "Fecha a Devolver";
            this.fechaADevolverDataGridViewTextBoxColumn.HeaderText = "Fecha a Devolver";
            this.fechaADevolverDataGridViewTextBoxColumn.Name = "fechaADevolverDataGridViewTextBoxColumn";
            this.fechaADevolverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.prestamosDevoluciones;
            // 
            // prestamosDevoluciones
            // 
            this.prestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.prestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnDevolverPrestamo.Location = new System.Drawing.Point(411, 494);
            this.btnDevolverPrestamo.Name = "btnDevolverPrestamo";
            this.btnDevolverPrestamo.Size = new System.Drawing.Size(165, 37);
            this.btnDevolverPrestamo.TabIndex = 28;
            this.btnDevolverPrestamo.Text = "Devolver Prestamo";
            this.btnDevolverPrestamo.UseVisualStyleBackColor = false;
            this.btnDevolverPrestamo.Click += new System.EventHandler(this.BtnDevolverPrestamo_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(753, 494);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 37);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar Préstamo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(924, 494);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 37);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo Préstamo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.btnGenerarReporte.Location = new System.Drawing.Point(582, 494);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(165, 37);
            this.btnGenerarReporte.TabIndex = 25;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click_1);
            // 
            // idPrestamoTextBox
            // 
            this.idPrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "ID Prestamo", true));
            this.idPrestamoTextBox.Location = new System.Drawing.Point(295, 12);
            this.idPrestamoTextBox.Name = "idPrestamoTextBox";
            this.idPrestamoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPrestamoTextBox.TabIndex = 29;
            this.idPrestamoTextBox.TextChanged += new System.EventHandler(this.IdPrestamoTextBox_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(295, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.White;
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt.ForeColor = System.Drawing.Color.Black;
            this.txt.Location = new System.Drawing.Point(910, 25);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(179, 15);
            this.txt.TabIndex = 80;
            this.txt.Text = "Buscar";
            this.txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBusqueda_MouseClick);
            this.txt.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel3.Location = new System.Drawing.Point(910, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 3);
            this.panel3.TabIndex = 81;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(885, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(22, 20);
            this.picture.TabIndex = 82;
            this.picture.TabStop = false;
            // 
            // FrmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1104, 543);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.idPrestamoTextBox);
            this.Controls.Add(this.btnDevolverPrestamo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenú_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenú_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnBibliotecarios;
        private System.Windows.Forms.Button btnCambiarBibliotecario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView prestamosDataGridView;
        private System.Windows.Forms.Button btnDevolverPrestamo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox idPrestamoTextBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Panel panel3;
        private PrestamosDevoluciones prestamosDevoluciones;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private PrestamosDevolucionesTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDelPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAdquiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaADevolverDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picture;
    }
}

