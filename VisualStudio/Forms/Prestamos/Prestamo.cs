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
        int idPrestamo = 0;
        public String busqueda;
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void BtnPrestamoNuevo_Click(object sender, EventArgs e)
        {
            new Forms.RegistroDePrestamo().Show();
        }
            
   


        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            new Forms.Devoluciones.Devoluciones().Show();
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
            this.Hide();
        }

        private void FrmMenú_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Forms.Login().Show();
            this.Hide();
        }

        private void TxtBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txt.Text = "";
        }

        private void BtnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            new Forms.Prestamos.GenerarReportePrestamos().Show();
        }

        private void FrmMenú_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos' Puede moverla o quitarla según sea necesario.
            //this.prestamosTableAdapter.Fill(this.prestamosDevoluciones.Prestamos);
            //// TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos1' Puede moverla o quitarla según sea necesario.
            //this.prestamos1TableAdapter.Fill(this.prestamosDevoluciones.Prestamos1);
            //// TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos' Puede moverla o quitarla según sea necesario.
            //this.prestamosTableAdapter.Fill(this.prestamosDevoluciones.Prestamos);
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);

        }

        public DataTable FrmMenuCarga()
        {
            return this.prestamosTableAdapter.GetDataBy1();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                this.prestamosTableAdapter.FillBy5(this.prestamosDevoluciones.Prestamos, txt.Text);
            }
            else
            {
                this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Forms.RegistroDePrestamo r1 = new Forms.RegistroDePrestamo(this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();
        }

        private void PrestamosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
        }

        private void PrestamosDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
            Forms.RegistroDePrestamo r1 = new Forms.RegistroDePrestamo(idPrestamo, this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();
        }

        private void BtnDevolverPrestamo_Click(object sender, EventArgs e)
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
            Forms.Devoluciones.Devoluciones r1 = new Forms.Devoluciones.Devoluciones(idPrestamo, this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();
        }

        private void F3_UpdateEventHandler1(object sender, Forms.RegistroDePrestamo.UpdateEventArgs args)
        {
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }

        private void F3_UpdateEventHandler1(object sender, Forms.Devoluciones.Devoluciones.UpdateEventArgs args)
        {
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }

        private void IdPrestamoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
