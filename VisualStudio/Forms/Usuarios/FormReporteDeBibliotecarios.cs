using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms.Usuarios
{
    public partial class FormReporteDeBibliotecarios : Form
    {
        public FormReporteDeBibliotecarios()
        {
            InitializeComponent();
        }

        private void FormReporteDeBibliotecarios_Load(object sender, EventArgs e)
        {
            decimal idBibliotecario = VariablesGlobales.Globales.idBibliotecario;
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            prestamosTableAdapter.Fill(this.reporteDeBibliotecariosDataSet.Prestamos, idBibliotecario, fechaInicial, fechaFinal);

            this.reportViewerBibliotecario.RefreshReport();
        }

        private void ReportViewerBibliotecario_Load(object sender, EventArgs e)
        {
            decimal idBibliotecario = VariablesGlobales.Globales.idBibliotecario;
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            prestamosTableAdapter.Fill(this.reporteDeBibliotecariosDataSet.Prestamos, idBibliotecario, fechaInicial, fechaFinal);
        }
    }
}
