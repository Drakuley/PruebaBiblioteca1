using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms.Devoluciones
{
    public partial class GenerarReporteDevoluciones : Form
    {
        public GenerarReporteDevoluciones()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Globales.fechaFinal = dtpFechaFinal.Text;
            VariablesGlobales.Globales.fechaInicial = dtpFechaInicial.Text;
            if (Convert.ToDateTime(dtpFechaInicial.Text) > Convert.ToDateTime(dtpFechaFinal.Text))
            {
                MessageBox.Show("Rango de fechas incorrecto, Asegurese que la fecha inicial se anterior a la fecha final");
            }
            else
            {
                new FormReporteDevoluciones().Show();
            }
        }
    }
}
