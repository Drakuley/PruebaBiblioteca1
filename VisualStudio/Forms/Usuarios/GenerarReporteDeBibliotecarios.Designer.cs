namespace PruebaBiblioteca1.Forms.Usuarios
{
    partial class GenerarReporteDeBibliotecarios
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
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.Tiutlo = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbNombreBibliotecario = new System.Windows.Forms.ComboBox();
            this.bibliotecariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecariosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecariosDataSet1 = new PruebaBiblioteca1.BibliotecariosDataSet1();
            this.bibliotecariosTableAdapter = new PruebaBiblioteca1.BibliotecariosDataSet1TableAdapters.BibliotecariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinal.Location = new System.Drawing.Point(76, 80);
            this.dtpFechaFinal.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFinal.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaFinal.TabIndex = 39;
            this.dtpFechaFinal.Value = new System.DateTime(2019, 11, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "FIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "INICIO";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicial.Location = new System.Drawing.Point(76, 54);
            this.dtpFechaInicial.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicial.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaInicial.TabIndex = 35;
            this.dtpFechaInicial.Value = new System.DateTime(2019, 11, 23, 0, 0, 0, 0);
            // 
            // Tiutlo
            // 
            this.Tiutlo.AutoSize = true;
            this.Tiutlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiutlo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.Tiutlo.Location = new System.Drawing.Point(22, 19);
            this.Tiutlo.Name = "Tiutlo";
            this.Tiutlo.Size = new System.Drawing.Size(100, 16);
            this.Tiutlo.TabIndex = 34;
            this.Tiutlo.Text = "Bibliotecario:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(23, 115);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(248, 37);
            this.btnGenerar.TabIndex = 58;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // cbNombreBibliotecario
            // 
            this.cbNombreBibliotecario.DataSource = this.bibliotecariosBindingSource;
            this.cbNombreBibliotecario.DisplayMember = "nombreBibliotecario";
            this.cbNombreBibliotecario.FormattingEnabled = true;
            this.cbNombreBibliotecario.Location = new System.Drawing.Point(128, 18);
            this.cbNombreBibliotecario.Name = "cbNombreBibliotecario";
            this.cbNombreBibliotecario.Size = new System.Drawing.Size(147, 21);
            this.cbNombreBibliotecario.TabIndex = 59;
            this.cbNombreBibliotecario.ValueMember = "idBibliotecario";
            // 
            // bibliotecariosBindingSource
            // 
            this.bibliotecariosBindingSource.DataMember = "Bibliotecarios";
            this.bibliotecariosBindingSource.DataSource = this.bibliotecariosDataSet1BindingSource;
            // 
            // bibliotecariosDataSet1BindingSource
            // 
            this.bibliotecariosDataSet1BindingSource.DataSource = this.bibliotecariosDataSet1;
            this.bibliotecariosDataSet1BindingSource.Position = 0;
            // 
            // bibliotecariosDataSet1
            // 
            this.bibliotecariosDataSet1.DataSetName = "BibliotecariosDataSet1";
            this.bibliotecariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecariosTableAdapter
            // 
            this.bibliotecariosTableAdapter.ClearBeforeFill = true;
            // 
            // GenerarReporteDeBibliotecarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(293, 164);
            this.Controls.Add(this.cbNombreBibliotecario);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.Tiutlo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenerarReporteDeBibliotecarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reporte de Préstamos por Bibliotecarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenerarReporteDeBibliotecarios_FormClosed);
            this.Load += new System.EventHandler(this.GenerarReporteDeBibliotecarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecariosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label Tiutlo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbNombreBibliotecario;
        private System.Windows.Forms.BindingSource bibliotecariosDataSet1BindingSource;
        private BibliotecariosDataSet1 bibliotecariosDataSet1;
        private System.Windows.Forms.BindingSource bibliotecariosBindingSource;
        private BibliotecariosDataSet1TableAdapters.BibliotecariosTableAdapter bibliotecariosTableAdapter;
    }
}