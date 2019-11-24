namespace PruebaBiblioteca1.Forms
{
    partial class FormReporteDevoluciones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerDevoluciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDeDevolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDevoluciones = new PruebaBiblioteca1.PrestamosDevoluciones();
            this.reporteDeDevolucionesTableAdapter = new PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.ReporteDeDevolucionesTableAdapter();
            this.tableAdapterManager = new PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeDevolucionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDevoluciones
            // 
            this.reportViewerDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ReporteDeDevolucionesDataSet1";
            reportDataSource2.Value = this.reporteDeDevolucionesBindingSource;
            this.reportViewerDevoluciones.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerDevoluciones.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReporteDevoluciones.rdlc";
            this.reportViewerDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDevoluciones.Name = "reportViewerDevoluciones";
            this.reportViewerDevoluciones.Size = new System.Drawing.Size(966, 450);
            this.reportViewerDevoluciones.TabIndex = 0;
            this.reportViewerDevoluciones.Load += new System.EventHandler(this.ReportViewerDevoluciones_Load);
            // 
            // reporteDeDevolucionesBindingSource
            // 
            this.reporteDeDevolucionesBindingSource.DataMember = "ReporteDeDevoluciones";
            this.reporteDeDevolucionesBindingSource.DataSource = this.prestamosDevoluciones;
            // 
            // prestamosDevoluciones
            // 
            this.prestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.prestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteDeDevolucionesTableAdapter
            // 
            this.reporteDeDevolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PruebaBiblioteca1.PrestamosDevolucionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormReporteDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.reportViewerDevoluciones);
            this.Name = "FormReporteDevoluciones";
            this.Text = "Reporte de Devoluciones";
            this.Load += new System.EventHandler(this.FormReporteDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeDevolucionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PrestamosDevoluciones prestamosDevoluciones;
        private System.Windows.Forms.BindingSource reporteDeDevolucionesBindingSource;
        private PrestamosDevolucionesTableAdapters.ReporteDeDevolucionesTableAdapter reporteDeDevolucionesTableAdapter;
        private PrestamosDevolucionesTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDevoluciones;
    }
}