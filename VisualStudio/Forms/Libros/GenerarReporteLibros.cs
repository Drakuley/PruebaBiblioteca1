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
    public partial class GenerarReporteLibros : Form
    {
        public GenerarReporteLibros()
        {
            InitializeComponent();
        }

        private void GenerarReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet1.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            try
            {
                this.librosTableAdapter.selectSinQueSeRepitanTitulosDeLibros(this.librosDataSet1.Libros);
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Globales.titulo = cbTituloLibro.SelectedText;
            VariablesGlobales.Globales.fechaFinal = txtFechaFin.Text;
            VariablesGlobales.Globales.fechaInicial = txtFechaIn.Text;
            new ReporteDeLibros().Show();
        }

        private void GenerarReporteLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Forms.FrmLibros().Show();
        }

        private void SelectSinQueSeRepitanTitulosDeLibrosToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
