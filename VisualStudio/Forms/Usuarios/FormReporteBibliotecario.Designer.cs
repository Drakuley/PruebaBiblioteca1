﻿namespace PruebaBiblioteca1.Forms.Usuarios
{
    partial class FormReporteBibliotecario
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
            this.reporteDeBibliotecariosDataSet = new PruebaBiblioteca1.ReporteDeBibliotecariosDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new PruebaBiblioteca1.ReporteDeBibliotecariosDataSetTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeBibliotecariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteDeBibliotecariosDataSet1";
            reportDataSource1.Value = this.prestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PruebaBiblioteca1.Reportes.ReporteBibliotecario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
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
            // FormReporteBibliotecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteBibliotecario";
            this.Text = "FormReporteBibliotecario";
            this.Load += new System.EventHandler(this.FormReporteBibliotecario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeBibliotecariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private ReporteDeBibliotecariosDataSet reporteDeBibliotecariosDataSet;
        private ReporteDeBibliotecariosDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
    }
}