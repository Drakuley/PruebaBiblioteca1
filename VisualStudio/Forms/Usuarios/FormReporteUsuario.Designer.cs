namespace PruebaBiblioteca1.Forms.Usuarios
{
    partial class FormReporteUsuario
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDeUsuariosDataSet = new PruebaBiblioteca1.ReporteDeUsuariosDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new PruebaBiblioteca1.ReporteDeUsuariosDataSetTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeUsuariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteDeUsuariosDataSet1";
            reportDataSource1.Value = this.prestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReporteUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
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
            // FormReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteUsuario";
            this.Text = "FormReporteUsuario";
            this.Load += new System.EventHandler(this.FormReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeUsuariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private ReporteDeUsuariosDataSet reporteDeUsuariosDataSet;
        private ReporteDeUsuariosDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
    }
}