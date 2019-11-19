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
    public partial class ReportePrestamos : Form
    {
        String fechaInicio;
        String fechaFin;
        public ReportePrestamos(String fechaInicio, String fechaFin)
        {
            InitializeComponent();
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PrestamosDevoluciones.DataTable1' Puede moverla o quitarla según sea necesario.
            //this.DataTable1TableAdapter.(this.PrestamosDevoluciones.DataTable1);
            this.dataTable2TableAdapter.FillBy(this.PrestamosDevoluciones.DataTable2, fechaInicio, fechaFin);
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.FillBy(this.PrestamosDevoluciones.DataTable2, fechaInicio, fechaFin);
        }

    }
}
