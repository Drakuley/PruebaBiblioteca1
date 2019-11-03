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
    public partial class FrmMenú : Form
    {
        public FrmMenú()
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
            this.Hide();
            
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            new Forms.FrmUsuarios().Show();
            this.Hide();
        }

        private void BtnBibliotecarios_Click(object sender, EventArgs e)
        {
            new Forms.FrmBibliotecarios().Show();
            this.Hide();
        }

        private void BtnCambiarBibliotecario_Click(object sender, EventArgs e)
        {
            new Forms.Login().Show();
            this.Close();
        }
    }
}
