using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms
{
    public partial class FormReporteDevoluciones : Form
    {
        public FormReporteDevoluciones()
        {
            InitializeComponent();
        }


        private void FormReporteDevoluciones_Load(object sender, EventArgs e)
        {
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.ReporteDeDevoluciones' Puede moverla o quitarla según sea necesario.
            this.reporteDeDevolucionesTableAdapter.Fill(this.prestamosDevoluciones.ReporteDeDevoluciones,fechaInicial,fechaFinal);

            this.reportViewerDevoluciones.RefreshReport();
        }

        private void ReportViewerDevoluciones_Load(object sender, EventArgs e)
        {
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;
            this.reporteDeDevolucionesTableAdapter.Fill(this.prestamosDevoluciones.ReporteDeDevoluciones, fechaInicial, fechaFinal);
        }
    }
}
