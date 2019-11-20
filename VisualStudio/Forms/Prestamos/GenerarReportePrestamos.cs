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
    public partial class GenerarReportePrestamos : Form
    {
        String fechaInicio = "";
        String fechaFin = "";
        public GenerarReportePrestamos()
        {
            InitializeComponent();
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.MaxDate = DateTime.Now;
            txtFechaFin.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
        }

        private void TxtNumAdquisicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerarReportePrestamos_Load(object sender, EventArgs e)
        {
            if (txtFechaInicio.Text == "")
            {
                btnGenerarReporte.Enabled = false;
            }
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime oDate = DateTime.Parse(txtFechaFin.Text);
            DateTime iDate = DateTime.Parse(txtFechaInicio.Text);
            //oDate.ToString("yyyy/MM/dd");
            //iDate.ToString("yyyy/MM/dd");
            //new ReportePrestamos(iDate.ToString("yyyy/MM/dd"), oDate.ToString("yyyy/MM/dd")).Show();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar.MaxSelectionCount = 1;

            if (txtFechaInicio.Text == "")
            {
                txtFechaInicio.Text = monthCalendar.SelectionRange.Start.ToString("dd/MMMM/yyyy");
                fechaInicio = monthCalendar.SelectionRange.Start.ToString("dd/MMMM/yyyy");
                lbl1.Visible = false;
                lbl2.Visible = true;
            }
            else
            {
                if (fechaFin == "")
                {
                    txtFechaFin.Text = monthCalendar.SelectionRange.Start.ToString("dd/MMMM/yyyy");
                    fechaFin = monthCalendar.SelectionRange.Start.ToString("dd/MMMM/yyyy");
                    fechaInicio = "";
                    lbl2.Visible = false;
                    lbl1.Visible = true;

                }
                else if (fechaInicio == "")
                {
                    txtFechaInicio.Text = monthCalendar.SelectionRange.Start.ToString("dd/MMMM/yyyy");
                    fechaInicio = monthCalendar.SelectionRange.Start.ToString("dd/MMMM/yyyy");
                    fechaFin = "";
                    lbl1.Visible = false;
                    lbl2.Visible = true;

                }
            }
            DateTime oDate = DateTime.Parse(txtFechaFin.Text);
            DateTime iDate = DateTime.Parse(txtFechaInicio.Text);

            if (oDate < iDate)
            {
                lblDisponible.Visible = true;
                btnGenerarReporte.Enabled = false;
            }
            else
            {
                lblDisponible.Visible = false;
                btnGenerarReporte.Enabled = true;
            }
        }

        private void TxtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            if (txtFechaInicio.Text == "")
            {
                btnGenerarReporte.Enabled = false;
            }
        }
    }
}
