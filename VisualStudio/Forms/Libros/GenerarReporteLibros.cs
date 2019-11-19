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
            VariablesGlobales.Globales.titulo = Convert.ToString(cbTituloLibro.SelectedValue);
            VariablesGlobales.Globales.fechaFinal = dtpFechaFinal.Text;
            VariablesGlobales.Globales.fechaInicial = dtpFechaInicial.Text;
            String titulo = Convert.ToString(cbTituloLibro.SelectedValue);
            String fechaFin = dtpFechaFinal.Text;
            String fechaIn = dtpFechaInicial.Text;

            if (Convert.ToDateTime(dtpFechaInicial.Text) >= Convert.ToDateTime(dtpFechaFinal.Text))
            {
                MessageBox.Show("Rango de fechas incorrecto, Asegurese que la fecha inicial se anterior a la fecha final");
            }
            //MessageBox.Show("Titulo : " + titulo + "\nFechaInicial : " + fechaIn + "\nFechaFinal : " + fechaFin);
            if (Convert.ToInt32(this.librosTableAdapter.ElLibroTienePrestamosEntreFechas(titulo, fechaIn, fechaFin)) == 0)
            {
                
                MessageBox.Show("No hay prestamos de ese libro en el rango de fechas seleccioandas");
            }
            else
            {
                new ReporteDeLibros().Show();
            }
            
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
