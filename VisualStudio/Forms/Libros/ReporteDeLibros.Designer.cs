namespace PruebaBiblioteca1.Forms.Libros
{
    partial class ReporteDeLibros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteLibrosDataSet1 = new PruebaBiblioteca1.ReporteLibrosDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamosTableAdapter = new PruebaBiblioteca1.ReporteLibrosDataSet1TableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteLibrosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.reporteLibrosDataSet1;
            // 
            // reporteLibrosDataSet1
            // 
            this.reporteLibrosDataSet1.DataSetName = "ReporteLibrosDataSet1";
            this.reporteLibrosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteLibrosDataSet1";
            reportDataSource1.Value = this.prestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDeLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDeLibros";
            this.Text = "ReporteDeLibros";
            this.Load += new System.EventHandler(this.ReporteDeLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteLibrosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private ReporteLibrosDataSet1 reporteLibrosDataSet1;
        private ReporteLibrosDataSet1TableAdapters.PrestamosTableAdapter prestamosTableAdapter;
    }
}