using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca4
{
    public partial class ReporteDevoluciones : Form
    {
        String fechaInicio;
        String fechaFin;
        public ReporteDevoluciones(String fechaInicio, String fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            InitializeComponent();
        }

        private void ReporteDevoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PrestamosDevoluciones.DataTable1' Puede moverla o quitarla según sea necesario.
           // this.DataTable1TableAdapter.(this.PrestamosDevoluciones.DataTable1);

            this.DataTable1TableAdapter.FillDevolucionesPorFecha(this.PrestamosDevoluciones.DataTable1, fechaInicio, fechaFin);
            //prestamosTableAdapter.Fill(this.reporteDeBibliotecariosDataSet.Prestamos, idBibliotecario, fechaInicial, fechaFinal);

            this.reportViewerBibliotecario.RefreshReport();

        }

        private void ReportViewerBibliotecario_Load(object sender, EventArgs e)
        {

            this.DataTable1TableAdapter.FillDevolucionesPorFecha(this.PrestamosDevoluciones.DataTable1, fechaInicio, fechaFin);
        }
    }
}
