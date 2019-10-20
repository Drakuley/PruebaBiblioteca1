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
    public partial class FormReporteUsuario : Form
    {
        public FormReporteUsuario()
        {
            InitializeComponent();
        }

        private void FormReporteUsuario_Load(object sender, EventArgs e)
        {
            decimal idUsuario = VariablesGlobales.Globales.idUsuario;

            prestamosTableAdapter.Fill(this.reporteDeUsuariosDataSet.Prestamos, idUsuario);
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            decimal idUsuario = VariablesGlobales.Globales.idUsuario;
            prestamosTableAdapter.Fill(this.reporteDeUsuariosDataSet.Prestamos, idUsuario);

        }
    }
}
