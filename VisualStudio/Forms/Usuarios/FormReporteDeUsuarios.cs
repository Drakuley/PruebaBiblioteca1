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
    public partial class FormReporteDeUsuarios : Form
    {
        public FormReporteDeUsuarios()
        {
            InitializeComponent();
        }

        private void FormReporteDeUsuarios_Load(object sender, EventArgs e)
        {
            decimal idUsuario = VariablesGlobales.Globales.idUsuario;

            prestamosTableAdapter.Fill(this.reporteDeUsuariosDataSet.Prestamos, idUsuario);
            this.reportViewerUsuarios.RefreshReport();
        }

        private void ReportViewerUsuarios_Load(object sender, EventArgs e)
        {
            decimal idUsuario = VariablesGlobales.Globales.idUsuario;
            prestamosTableAdapter.Fill(this.reporteDeUsuariosDataSet.Prestamos, idUsuario);
        }

        private void FormReporteDeUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FrmUsuarios().Show();
        }
    }
}
