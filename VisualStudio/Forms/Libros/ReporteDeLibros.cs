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

            this.reportViewer1.RefreshReport();
        }
    }
}
