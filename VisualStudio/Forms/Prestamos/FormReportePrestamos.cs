using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms.Prestamos
{
    public partial class FormReportePrestamos : Form
    {
        public FormReportePrestamos()
        {
            InitializeComponent();
        }

        private void FormReportePrestamos_Load(object sender, EventArgs e)
        {
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            reporteDePrestamosTableAdapter.Fill(this.prestamosDevoluciones.ReporteDePrestamos,fechaInicial,fechaFinal);
            this.reportViewerPrestamos.RefreshReport();
        }


        private void ReportViewerPrestamos_Load(object sender, EventArgs e)
        {
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            reporteDePrestamosTableAdapter.Fill(this.prestamosDevoluciones.ReporteDePrestamos, fechaInicial, fechaFinal);
        }
    }
}
