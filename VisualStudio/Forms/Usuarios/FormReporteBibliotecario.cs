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
    public partial class FormReporteBibliotecario : Form
    {
        public FormReporteBibliotecario()
        {
            InitializeComponent();
        }

        private void FormReporteBibliotecario_Load(object sender, EventArgs e)
        {
            decimal idBibliotecario = VariablesGlobales.Globales.idBibliotecario;
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            prestamosTableAdapter.Fill(this.reporteDeBibliotecariosDataSet.Prestamos, idBibliotecario, fechaInicial, fechaFinal);

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            decimal idBibliotecario = VariablesGlobales.Globales.idBibliotecario;
            string fechaInicial = VariablesGlobales.Globales.fechaInicial;
            string fechaFinal = VariablesGlobales.Globales.fechaFinal;

            prestamosTableAdapter.Fill(this.reporteDeBibliotecariosDataSet.Prestamos, idBibliotecario, fechaInicial, fechaFinal);
        }
    }
}
