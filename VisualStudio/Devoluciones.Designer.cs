namespace Biblioteca4
{
    partial class Devoluciones
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
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label fechaDevueltoLabel;
            System.Windows.Forms.Label idBibliotecarioLabel;
            System.Windows.Forms.Label LBLTitulo;
            System.Windows.Forms.Label idPrestamoLabel;
            System.Windows.Forms.Label idDevolucionLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFechaDev = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbFechaDev = new System.Windows.Forms.DateTimePicker();
            this.txtBiblio = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtIdDev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.devolucionesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAdquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreBibliotecarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDevoluciones = new Biblioteca4.PrestamosDevoluciones();
            this.devolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucionesTableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.DevolucionesTableAdapter();
            this.tableAdapterManager = new Biblioteca4.PrestamosDevolucionesTableAdapters.TableAdapterManager();
            this.dataTable1TableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.DataTable1TableAdapter();
            observacionesLabel = new System.Windows.Forms.Label();
            fechaDevueltoLabel = new System.Windows.Forms.Label();
            idBibliotecarioLabel = new System.Windows.Forms.Label();
            LBLTitulo = new System.Windows.Forms.Label();
            idPrestamoLabel = new System.Windows.Forms.Label();
            idDevolucionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            observacionesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            observacionesLabel.Location = new System.Drawing.Point(16, 322);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(117, 16);
            observacionesLabel.TabIndex = 70;
            observacionesLabel.Text = "Observaciones:";
            // 
            // fechaDevueltoLabel
            // 
            fechaDevueltoLabel.AutoSize = true;
            fechaDevueltoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            fechaDevueltoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            fechaDevueltoLabel.Location = new System.Drawing.Point(16, 286);
            fechaDevueltoLabel.Name = "fechaDevueltoLabel";
            fechaDevueltoLabel.Size = new System.Drawing.Size(121, 16);
            fechaDevueltoLabel.TabIndex = 69;
            fechaDevueltoLabel.Text = "Fecha Devuelto:";
            // 
            // idBibliotecarioLabel
            // 
            idBibliotecarioLabel.AutoSize = true;
            idBibliotecarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            idBibliotecarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idBibliotecarioLabel.Location = new System.Drawing.Point(16, 251);
            idBibliotecarioLabel.Name = "idBibliotecarioLabel";
            idBibliotecarioLabel.Size = new System.Drawing.Size(100, 16);
            idBibliotecarioLabel.TabIndex = 68;
            idBibliotecarioLabel.Text = "Bibliotecario:";
            // 
            // LBLTitulo
            // 
            LBLTitulo.AutoSize = true;
            LBLTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            LBLTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            LBLTitulo.Location = new System.Drawing.Point(16, 218);
            LBLTitulo.Name = "LBLTitulo";
            LBLTitulo.Size = new System.Drawing.Size(55, 16);
            LBLTitulo.TabIndex = 67;
            LBLTitulo.Text = "Titulo: ";
            LBLTitulo.Click += new System.EventHandler(this.LBLTitulo_Click);
            // 
            // idPrestamoLabel
            // 
            idPrestamoLabel.AutoSize = true;
            idPrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            idPrestamoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idPrestamoLabel.Location = new System.Drawing.Point(16, 185);
            idPrestamoLabel.Name = "idPrestamoLabel";
            idPrestamoLabel.Size = new System.Drawing.Size(95, 16);
            idPrestamoLabel.TabIndex = 66;
            idPrestamoLabel.Text = "id Prestamo:";
            // 
            // idDevolucionLabel
            // 
            idDevolucionLabel.AutoSize = true;
            idDevolucionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            idDevolucionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idDevolucionLabel.Location = new System.Drawing.Point(16, 153);
            idDevolucionLabel.Name = "idDevolucionLabel";
            idDevolucionLabel.Size = new System.Drawing.Size(107, 16);
            idDevolucionLabel.TabIndex = 65;
            idDevolucionLabel.Text = "id Devolucion:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(944, -138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 806);
            this.panel2.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.picture);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtFechaDev);
            this.panel1.Controls.Add(observacionesLabel);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(fechaDevueltoLabel);
            this.panel1.Controls.Add(this.cbFechaDev);
            this.panel1.Controls.Add(idBibliotecarioLabel);
            this.panel1.Controls.Add(this.txtBiblio);
            this.panel1.Controls.Add(LBLTitulo);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(idPrestamoLabel);
            this.panel1.Controls.Add(this.txtPrestamo);
            this.panel1.Controls.Add(idDevolucionLabel);
            this.panel1.Controls.Add(this.txtIdDev);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(952, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 696);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // picture
            // 
            this.picture.Image = global::Biblioteca4.Properties.Resources.lupa_1_;
            this.picture.Location = new System.Drawing.Point(146, 104);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(22, 20);
            this.picture.TabIndex = 78;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBusqueda.Location = new System.Drawing.Point(172, 104);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(179, 15);
            this.txtBusqueda.TabIndex = 76;
            this.txtBusqueda.Text = "Buscar";
            this.txtBusqueda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBusqueda_MouseClick);
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(171, 122);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 3);
            this.panel3.TabIndex = 77;
            // 
            // txtFechaDev
            // 
            this.txtFechaDev.Enabled = false;
            this.txtFechaDev.Location = new System.Drawing.Point(282, 315);
            this.txtFechaDev.Name = "txtFechaDev";
            this.txtFechaDev.Size = new System.Drawing.Size(70, 20);
            this.txtFechaDev.TabIndex = 72;
            this.txtFechaDev.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(19, 341);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(335, 104);
            this.txtObs.TabIndex = 71;
            this.txtObs.TextChanged += new System.EventHandler(this.TxtObs_TextChanged);
            // 
            // cbFechaDev
            // 
            this.cbFechaDev.Location = new System.Drawing.Point(158, 282);
            this.cbFechaDev.Name = "cbFechaDev";
            this.cbFechaDev.Size = new System.Drawing.Size(196, 20);
            this.cbFechaDev.TabIndex = 70;
            this.cbFechaDev.ValueChanged += new System.EventHandler(this.CbFechaDev_ValueChanged);
            // 
            // txtBiblio
            // 
            this.txtBiblio.Enabled = false;
            this.txtBiblio.Location = new System.Drawing.Point(172, 247);
            this.txtBiblio.Name = "txtBiblio";
            this.txtBiblio.Size = new System.Drawing.Size(182, 20);
            this.txtBiblio.TabIndex = 69;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(172, 214);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(182, 20);
            this.txtTitulo.TabIndex = 68;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(172, 181);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(182, 20);
            this.txtPrestamo.TabIndex = 67;
            this.txtPrestamo.TextChanged += new System.EventHandler(this.TxtPrestamo_TextChanged);
            // 
            // txtIdDev
            // 
            this.txtIdDev.Enabled = false;
            this.txtIdDev.Location = new System.Drawing.Point(172, 149);
            this.txtIdDev.Name = "txtIdDev";
            this.txtIdDev.Size = new System.Drawing.Size(59, 20);
            this.txtIdDev.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Registro de Devoluciones";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
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
            this.btnReporte.Location = new System.Drawing.Point(19, 494);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(335, 36);
            this.btnReporte.TabIndex = 61;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(19, 452);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(335, 36);
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // devolucionesDataGridView
            // 
            this.devolucionesDataGridView.AllowUserToAddRows = false;
            this.devolucionesDataGridView.AllowUserToDeleteRows = false;
            this.devolucionesDataGridView.AutoGenerateColumns = false;
            this.devolucionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devolucionesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devolucionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devolucionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDevolucion,
            this.idPrestamoDataGridViewTextBoxColumn,
            this.numeroAdquisicion,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaDevuelto,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.nombreBibliotecarioDataGridViewTextBoxColumn,
            this.observaciones});
            this.devolucionesDataGridView.DataSource = this.dataTable1BindingSource;
            this.devolucionesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.devolucionesDataGridView.Name = "devolucionesDataGridView";
            this.devolucionesDataGridView.ReadOnly = true;
            this.devolucionesDataGridView.Size = new System.Drawing.Size(946, 503);
            this.devolucionesDataGridView.TabIndex = 67;
            this.devolucionesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DevolucionesDataGridView_CellContentDoubleClick);
            // 
            // idDevolucion
            // 
            this.idDevolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDevolucion.DataPropertyName = "idDevolucion";
            this.idDevolucion.HeaderText = "idDevolucion";
            this.idDevolucion.Name = "idDevolucion";
            this.idDevolucion.ReadOnly = true;
            this.idDevolucion.Width = 94;
            // 
            // idPrestamoDataGridViewTextBoxColumn
            // 
            this.idPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPrestamoDataGridViewTextBoxColumn.DataPropertyName = "idPrestamo";
            this.idPrestamoDataGridViewTextBoxColumn.HeaderText = "idPrestamo";
            this.idPrestamoDataGridViewTextBoxColumn.Name = "idPrestamoDataGridViewTextBoxColumn";
            this.idPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPrestamoDataGridViewTextBoxColumn.Width = 84;
            // 
            // numeroAdquisicion
            // 
            this.numeroAdquisicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroAdquisicion.DataPropertyName = "numeroAdquisicion";
            this.numeroAdquisicion.HeaderText = "numeroAdquisicion";
            this.numeroAdquisicion.Name = "numeroAdquisicion";
            this.numeroAdquisicion.ReadOnly = true;
            this.numeroAdquisicion.Width = 121;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 54;
            // 
            // fechaDevuelto
            // 
            this.fechaDevuelto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaDevuelto.DataPropertyName = "fechaDevuelto";
            this.fechaDevuelto.HeaderText = "fechaDevuelto";
            this.fechaDevuelto.Name = "fechaDevuelto";
            this.fechaDevuelto.ReadOnly = true;
            this.fechaDevuelto.Width = 102;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 103;
            // 
            // nombreBibliotecarioDataGridViewTextBoxColumn
            // 
            this.nombreBibliotecarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreBibliotecarioDataGridViewTextBoxColumn.DataPropertyName = "nombreBibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.HeaderText = "nombreBibliotecario";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.Name = "nombreBibliotecarioDataGridViewTextBoxColumn";
            this.nombreBibliotecarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreBibliotecarioDataGridViewTextBoxColumn.Width = 124;
            // 
            // observaciones
            // 
            this.observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 101;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.prestamosDevoluciones;
            // 
            // prestamosDevoluciones
            // 
            this.prestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.prestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devolucionesBindingSource
            // 
            this.devolucionesBindingSource.DataMember = "Devoluciones";
            this.devolucionesBindingSource.DataSource = this.prestamosDevoluciones;
            // 
            // devolucionesTableAdapter
            // 
            this.devolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca4.PrestamosDevolucionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.devolucionesDataGridView);
            this.Controls.Add(this.panel2);
            this.Name = "Devoluciones";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFechaDev;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DateTimePicker cbFechaDev;
        private System.Windows.Forms.TextBox txtBiblio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.TextBox txtIdDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAceptar;
        private PrestamosDevoluciones prestamosDevoluciones;
        private System.Windows.Forms.BindingSource devolucionesBindingSource;
        private PrestamosDevolucionesTableAdapters.DevolucionesTableAdapter devolucionesTableAdapter;
        private PrestamosDevolucionesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView devolucionesDataGridView;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private PrestamosDevolucionesTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAdquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreBibliotecarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
    }
}