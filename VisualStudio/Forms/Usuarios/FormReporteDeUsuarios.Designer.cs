namespace PruebaBiblioteca1.Forms.Usuarios
{
    partial class FormReporteDeUsuarios
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
            this.reportViewerUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDeUsuariosDataSet = new PruebaBiblioteca1.ReporteDeUsuariosDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new PruebaBiblioteca1.ReporteDeUsuariosDataSetTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeUsuariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerUsuarios
            // 
            this.reportViewerUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteDeUsuariosDataSet1";
            reportDataSource1.Value = this.prestamosBindingSource;
            this.reportViewerUsuarios.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerUsuarios.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReporteUsuario.rdlc";
            this.reportViewerUsuarios.Location = new System.Drawing.Point(0, 0);
            this.reportViewerUsuarios.Name = "reportViewerUsuarios";
            this.reportViewerUsuarios.Size = new System.Drawing.Size(800, 450);
            this.reportViewerUsuarios.TabIndex = 0;
            this.reportViewerUsuarios.Load += new System.EventHandler(this.ReportViewerUsuarios_Load);
            // 
            // reporteDeUsuariosDataSet
            // 
            this.reporteDeUsuariosDataSet.DataSetName = "ReporteDeUsuariosDataSet";
            this.reporteDeUsuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.reporteDeUsuariosDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerUsuarios);
            this.Name = "FormReporteDeUsuarios";
            this.Text = "FormReporteDeUsuarios";
            this.Load += new System.EventHandler(this.FormReporteDeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeUsuariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerUsuarios;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private ReporteDeUsuariosDataSet reporteDeUsuariosDataSet;
        private ReporteDeUsuariosDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
    }
}