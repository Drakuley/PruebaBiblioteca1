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

        }
    }
}
