namespace PruebaBiblioteca1.Forms.Usuarios
{
    partial class FormReporteDeBibliotecarios
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
            this.reportViewerBibliotecario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDeBibliotecariosDataSet = new PruebaBiblioteca1.ReporteDeBibliotecariosDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new PruebaBiblioteca1.ReporteDeBibliotecariosDataSetTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeBibliotecariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBibliotecario
            // 
            this.reportViewerBibliotecario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteDeBibliotecariosDataSet1";
            reportDataSource1.Value = this.prestamosBindingSource;
            this.reportViewerBibliotecario.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBibliotecario.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReporteBibliotecario.rdlc";
            this.reportViewerBibliotecario.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBibliotecario.Name = "reportViewerBibliotecario";
            this.reportViewerBibliotecario.Size = new System.Drawing.Size(800, 450);
            this.reportViewerBibliotecario.TabIndex = 0;
            this.reportViewerBibliotecario.Load += new System.EventHandler(this.ReportViewerBibliotecario_Load);
            // 
            // reporteDeBibliotecariosDataSet
            // 
            this.reporteDeBibliotecariosDataSet.DataSetName = "ReporteDeBibliotecariosDataSet";
            this.reporteDeBibliotecariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.reporteDeBibliotecariosDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteDeBibliotecarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerBibliotecario);
            this.Name = "FormReporteDeBibliotecarios";
            this.Text = "Reporte de Préstamos por Bibliotecario";
            this.Load += new System.EventHandler(this.FormReporteDeBibliotecarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeBibliotecariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBibliotecario;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private ReporteDeBibliotecariosDataSet reporteDeBibliotecariosDataSet;
        private ReporteDeBibliotecariosDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
    }
}