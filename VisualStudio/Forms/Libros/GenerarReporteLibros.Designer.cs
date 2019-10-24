namespace PruebaBiblioteca1.Forms.Libros
{
    partial class GenerarReporteLibros
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTituloLibro = new System.Windows.Forms.ComboBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataSet1 = new PruebaBiblioteca1.LibrosDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.librosTableAdapter = new PruebaBiblioteca1.LibrosDataSet1TableAdapters.LibrosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip = new System.Windows.Forms.ToolStrip();
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtFechaIn = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet1)).BeginInit();
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar el Reporte de Libros";
            // 
            // cbTituloLibro
            // 
            this.cbTituloLibro.DataSource = this.librosBindingSource;
            this.cbTituloLibro.DisplayMember = "titulo";
            this.cbTituloLibro.FormattingEnabled = true;
            this.cbTituloLibro.Location = new System.Drawing.Point(216, 82);
            this.cbTituloLibro.Name = "cbTituloLibro";
            this.cbTituloLibro.Size = new System.Drawing.Size(235, 21);
            this.cbTituloLibro.TabIndex = 1;
            this.cbTituloLibro.ValueMember = "titulo";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo del Libro :";
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Inicial :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(26, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Final :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(228, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Formato de Fecha : dia/mes/año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(228, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Formato de Fecha : dia/mes/año";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(334, 292);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(134, 28);
            this.btnGenerarReporte.TabIndex = 9;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(202, 156);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(249, 20);
            this.dtpFechaInicial.TabIndex = 10;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(202, 233);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(249, 20);
            this.dtpFechaFinal.TabIndex = 11;
            // 
            // selectSinQueSeRepitanTitulosDeLibrosToolStrip
            // 
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton});
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.Location = new System.Drawing.Point(0, 0);
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.Name = "selectSinQueSeRepitanTitulosDeLibrosToolStrip";
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.Size = new System.Drawing.Size(488, 25);
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.TabIndex = 12;
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.Text = "selectSinQueSeRepitanTitulosDeLibrosToolStrip";
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.Visible = false;
            // 
            // selectSinQueSeRepitanTitulosDeLibrosToolStripButton
            // 
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton.Name = "selectSinQueSeRepitanTitulosDeLibrosToolStripButton";
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton.Size = new System.Drawing.Size(212, 22);
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton.Text = "selectSinQueSeRepitanTitulosDeLibros";
            this.selectSinQueSeRepitanTitulosDeLibrosToolStripButton.Click += new System.EventHandler(this.SelectSinQueSeRepitanTitulosDeLibrosToolStripButton_Click);
            // 
            // txtFechaIn
            // 
            this.txtFechaIn.Location = new System.Drawing.Point(202, 125);
            this.txtFechaIn.Name = "txtFechaIn";
            this.txtFechaIn.Size = new System.Drawing.Size(249, 20);
            this.txtFechaIn.TabIndex = 13;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(202, 207);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(249, 20);
            this.txtFechaFin.TabIndex = 14;
            // 
            // GenerarReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 340);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaIn);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.selectSinQueSeRepitanTitulosDeLibrosToolStrip);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTituloLibro);
            this.Controls.Add(this.label1);
            this.Name = "GenerarReporteLibros";
            this.Text = "GenerarReporteLibros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenerarReporteLibros_FormClosed);
            this.Load += new System.EventHandler(this.GenerarReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet1)).EndInit();
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.ResumeLayout(false);
            this.selectSinQueSeRepitanTitulosDeLibrosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTituloLibro;
        private System.Windows.Forms.Label label2;
        private LibrosDataSet1 librosDataSet1;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private LibrosDataSet1TableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.ToolStrip selectSinQueSeRepitanTitulosDeLibrosToolStrip;
        private System.Windows.Forms.ToolStripButton selectSinQueSeRepitanTitulosDeLibrosToolStripButton;
        private System.Windows.Forms.TextBox txtFechaIn;
        private System.Windows.Forms.TextBox txtFechaFin;
    }
}