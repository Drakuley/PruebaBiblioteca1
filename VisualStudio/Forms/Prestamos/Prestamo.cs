using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void BtnPrestamoNuevo_Click(object sender, EventArgs e) => new Forms.RegistroDePrestamo().Show();
        

        private void BtnDevoluciones_Click(object sender, EventArgs e) => new Forms.Devoluciones.Devoluciones().Show();

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            new Forms.FrmLibros().Show();
            
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
