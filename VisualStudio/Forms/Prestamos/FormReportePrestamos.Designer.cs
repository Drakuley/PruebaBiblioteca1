namespace PruebaBiblioteca1.Forms.Prestamos
{
    partial class FormReportePrestamos
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
            this.reportViewerPrestamos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamosDevoluciones = new PruebaBiblioteca1.PrestamosDevoluciones();
            this.reporteDePrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDePrestamosTableAdapter = new PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.ReporteDePrestamosTableAdapter();
            this.tableAdapterManager = new PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDePrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerPrestamos
            // 
            this.reportViewerPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrestamos.DocumentMapWidth = 68;
            reportDataSource1.Name = "ReporteDePrestamosDataSet1";
            reportDataSource1.Value = this.reporteDePrestamosBindingSource;
            this.reportViewerPrestamos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPrestamos.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReportePrestamos.rdlc";
            this.reportViewerPrestamos.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrestamos.Name = "reportViewerPrestamos";
            this.reportViewerPrestamos.Size = new System.Drawing.Size(885, 450);
            this.reportViewerPrestamos.TabIndex = 0;
            this.reportViewerPrestamos.Load += new System.EventHandler(this.ReportViewerPrestamos_Load);
            // 
            // prestamosDevoluciones
            // 
            this.prestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.prestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteDePrestamosBindingSource
            // 
            this.reporteDePrestamosBindingSource.DataMember = "ReporteDePrestamos";
            this.reporteDePrestamosBindingSource.DataSource = this.prestamosDevoluciones;
            // 
            // reporteDePrestamosTableAdapter
            // 
            this.reporteDePrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.reportViewerPrestamos);
            this.Name = "FormReportePrestamos";
            this.Text = "FormReportePrestamos";
            this.Load += new System.EventHandler(this.FormReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDePrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrestamos;
        private PrestamosDevoluciones prestamosDevoluciones;
        private System.Windows.Forms.BindingSource reporteDePrestamosBindingSource;
        private PrestamosDevolucionesTableAdapters.ReporteDePrestamosTableAdapter reporteDePrestamosTableAdapter;
        private PrestamosDevolucionesTableAdapters.TableAdapterManager tableAdapterManager;
    }
}