namespace Biblioteca4
{
    partial class ReporteDevoluciones
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
            this.autoresTableAdapter1 = new Biblioteca4.BiblioDBDataSetTableAdapters.AutoresTableAdapter();
            this.autoresTableAdapter2 = new Biblioteca4.BiblioDBDataSetTableAdapters.AutoresTableAdapter();
            this.reportViewerBibliotecario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamosDevoluciones = new Biblioteca4.PrestamosDevoluciones();
            this.DataTable1TableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.DataTable1TableAdapter();
            this.PrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamosTableAdapter = new Biblioteca4.PrestamosDevolucionesTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoresTableAdapter1
            // 
            this.autoresTableAdapter1.ClearBeforeFill = true;
            // 
            // autoresTableAdapter2
            // 
            this.autoresTableAdapter2.ClearBeforeFill = true;
            // 
            // reportViewerBibliotecario
            // 
            this.reportViewerBibliotecario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Devoluciones";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewerBibliotecario.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBibliotecario.LocalReport.ReportEmbeddedResource = "Biblioteca4.Dev.rdlc";
            this.reportViewerBibliotecario.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBibliotecario.Name = "reportViewerBibliotecario";
            this.reportViewerBibliotecario.ServerReport.BearerToken = null;
            this.reportViewerBibliotecario.Size = new System.Drawing.Size(800, 450);
            this.reportViewerBibliotecario.TabIndex = 1;
            this.reportViewerBibliotecario.Load += new System.EventHandler(this.ReportViewerBibliotecario_Load);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.PrestamosDevoluciones;
            // 
            // PrestamosDevoluciones
            // 
            this.PrestamosDevoluciones.DataSetName = "PrestamosDevoluciones";
            this.PrestamosDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // PrestamosBindingSource
            // 
            this.PrestamosBindingSource.DataMember = "Prestamos";
            this.PrestamosBindingSource.DataSource = this.PrestamosDevoluciones;
            // 
            // PrestamosTableAdapter
            // 
            this.PrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerBibliotecario);
            this.Name = "ReporteDevoluciones";
            this.Text = "ReporteDevoluciones";
            this.Load += new System.EventHandler(this.ReporteDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BiblioDBDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter1;
        private BiblioDBDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBibliotecario;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private PrestamosDevoluciones PrestamosDevoluciones;
        private PrestamosDevolucionesTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource PrestamosBindingSource;
        private PrestamosDevolucionesTableAdapters.PrestamosTableAdapter PrestamosTableAdapter;
    }
}