using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms.Libros
{
    public partial class ReporteDeLibros : Form
    {
        public ReporteDeLibros()
        {
            InitializeComponent();
        }

        private void ReporteDeLibros_Load(object sender, EventArgs e)
        {
            string titulo = VariablesGlobales.Globales.titulo;
            string fechaIn = VariablesGlobales.Globales.fechaInicial;
            string fechaFin = VariablesGlobales.Globales.fechaFinal;
            //MessageBox.Show(titulo + "  " + fechaIn + "  " + fechaFin);
            prestamosTableAdapter.Fill(this.reporteLibrosDataSet1.Prestamos, titulo, fechaIn, fechaFin);
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            string titulo = VariablesGlobales.Globales.titulo;
            string fechaIn = VariablesGlobales.Globales.fechaInicial;
            string fechaFin = VariablesGlobales.Globales.fechaFinal;
            prestamosTableAdapter.Fill(this.reporteLibrosDataSet1.Prestamos, titulo, fechaIn, fechaFin);
        }
    }
}
