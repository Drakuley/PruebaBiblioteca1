namespace PruebaBiblioteca1.Forms.Devoluciones
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
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label fechaDevueltoLabel;
            System.Windows.Forms.Label idBibliotecarioLabel;
            System.Windows.Forms.Label LBLTitulo;
            System.Windows.Forms.Label idPrestamoLabel;
            System.Windows.Forms.Label idDevolucionLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFechaDev = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.devolucionesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAdquisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevuelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdDev = new System.Windows.Forms.TextBox();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtBiblio = new System.Windows.Forms.TextBox();
            this.txtFechaDev = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            observacionesLabel = new System.Windows.Forms.Label();
            fechaDevueltoLabel = new System.Windows.Forms.Label();
            idBibliotecarioLabel = new System.Windows.Forms.Label();
            LBLTitulo = new System.Windows.Forms.Label();
            idPrestamoLabel = new System.Windows.Forms.Label();
            idDevolucionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(617, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 546);
            this.panel2.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.txtFechaDev);
            this.panel1.Controls.Add(this.txtBiblio);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.txtPrestamo);
            this.panel1.Controls.Add(this.txtIdDev);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(observacionesLabel);
            this.panel1.Controls.Add(fechaDevueltoLabel);
            this.panel1.Controls.Add(this.cbFechaDev);
            this.panel1.Controls.Add(idBibliotecarioLabel);
            this.panel1.Controls.Add(LBLTitulo);
            this.panel1.Controls.Add(idPrestamoLabel);
            this.panel1.Controls.Add(idDevolucionLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(620, -107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 696);
            this.panel1.TabIndex = 66;
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            observacionesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            observacionesLabel.Location = new System.Drawing.Point(16, 339);
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
            fechaDevueltoLabel.Location = new System.Drawing.Point(16, 303);
            fechaDevueltoLabel.Name = "fechaDevueltoLabel";
            fechaDevueltoLabel.Size = new System.Drawing.Size(121, 16);
            fechaDevueltoLabel.TabIndex = 69;
            fechaDevueltoLabel.Text = "Fecha Devuelto:";
            // 
            // cbFechaDev
            // 
            this.cbFechaDev.Location = new System.Drawing.Point(156, 303);
            this.cbFechaDev.Name = "cbFechaDev";
            this.cbFechaDev.Size = new System.Drawing.Size(196, 20);
            this.cbFechaDev.TabIndex = 70;
            // 
            // idBibliotecarioLabel
            // 
            idBibliotecarioLabel.AutoSize = true;
            idBibliotecarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            idBibliotecarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idBibliotecarioLabel.Location = new System.Drawing.Point(16, 268);
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
            LBLTitulo.Location = new System.Drawing.Point(16, 235);
            LBLTitulo.Name = "LBLTitulo";
            LBLTitulo.Size = new System.Drawing.Size(55, 16);
            LBLTitulo.TabIndex = 67;
            LBLTitulo.Text = "Titulo: ";
            // 
            // idPrestamoLabel
            // 
            idPrestamoLabel.AutoSize = true;
            idPrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            idPrestamoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idPrestamoLabel.Location = new System.Drawing.Point(16, 202);
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
            idDevolucionLabel.Location = new System.Drawing.Point(16, 170);
            idDevolucionLabel.Name = "idDevolucionLabel";
            idDevolucionLabel.Size = new System.Drawing.Size(107, 16);
            idDevolucionLabel.TabIndex = 65;
            idDevolucionLabel.Text = "id Devolucion:";
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
            this.btnReporte.Location = new System.Drawing.Point(18, 545);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(335, 36);
            this.btnReporte.TabIndex = 61;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(18, 503);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(335, 36);
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // devolucionesDataGridView
            // 
            this.devolucionesDataGridView.AllowUserToAddRows = false;
            this.devolucionesDataGridView.AllowUserToDeleteRows = false;
            this.devolucionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devolucionesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devolucionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devolucionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDevolucion,
            this.numeroAdquisicion,
            this.fechaDevuelto,
            this.observaciones});
            this.devolucionesDataGridView.Location = new System.Drawing.Point(-3, 2);
            this.devolucionesDataGridView.Name = "devolucionesDataGridView";
            this.devolucionesDataGridView.ReadOnly = true;
            this.devolucionesDataGridView.Size = new System.Drawing.Size(625, 480);
            this.devolucionesDataGridView.TabIndex = 71;
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
            // numeroAdquisicion
            // 
            this.numeroAdquisicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroAdquisicion.DataPropertyName = "numeroAdquisicion";
            this.numeroAdquisicion.HeaderText = "numeroAdquisicion";
            this.numeroAdquisicion.Name = "numeroAdquisicion";
            this.numeroAdquisicion.ReadOnly = true;
            this.numeroAdquisicion.Width = 121;
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
            // observaciones
            // 
            this.observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Registro de Devoluciones";
            // 
            // txtIdDev
            // 
            this.txtIdDev.Enabled = false;
            this.txtIdDev.Location = new System.Drawing.Point(139, 169);
            this.txtIdDev.Name = "txtIdDev";
            this.txtIdDev.Size = new System.Drawing.Size(59, 20);
            this.txtIdDev.TabIndex = 73;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(139, 198);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(182, 20);
            this.txtPrestamo.TabIndex = 74;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(139, 231);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(182, 20);
            this.txtTitulo.TabIndex = 75;
            // 
            // txtBiblio
            // 
            this.txtBiblio.Enabled = false;
            this.txtBiblio.Location = new System.Drawing.Point(139, 264);
            this.txtBiblio.Name = "txtBiblio";
            this.txtBiblio.Size = new System.Drawing.Size(182, 20);
            this.txtBiblio.TabIndex = 76;
            // 
            // txtFechaDev
            // 
            this.txtFechaDev.Enabled = false;
            this.txtFechaDev.Location = new System.Drawing.Point(250, 332);
            this.txtFechaDev.Name = "txtFechaDev";
            this.txtFechaDev.Size = new System.Drawing.Size(70, 20);
            this.txtFechaDev.TabIndex = 77;
            this.txtFechaDev.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(19, 369);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(335, 104);
            this.txtObs.TabIndex = 78;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBusqueda.Location = new System.Drawing.Point(175, 143);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(179, 15);
            this.txtBusqueda.TabIndex = 79;
            this.txtBusqueda.Text = "Buscar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(175, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 3);
            this.panel3.TabIndex = 80;
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(983, 482);
            this.Controls.Add(this.devolucionesDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Devoluciones";
            this.Text = "Devoluciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtFechaDev;
        private System.Windows.Forms.TextBox txtBiblio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.TextBox txtIdDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cbFechaDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView devolucionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAdquisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
    }
}