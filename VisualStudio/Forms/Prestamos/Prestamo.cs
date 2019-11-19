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

        private void BtnPrestamoNuevo_Click(object sender, EventArgs e) => new Forms.RegistroDePrestamo().Show();
        

        private void BtnDevoluciones_Click(object sender, EventArgs e) => new Forms.Devoluciones.Devoluciones().Show();

 
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

        private void FrmMenú_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.DataTable2' Puede moverla o quitarla según sea necesario.
            this.dataTable2TableAdapter.Fill(this.prestamosDevoluciones.DataTable2);
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Devoluciones' Puede moverla o quitarla según sea necesario.
            this.devolucionesTableAdapter.Fill(this.prestamosDevoluciones.Devoluciones);
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.prestamosDevoluciones.Prestamos);

            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }
        public DataTable Form1Carga()
        {
            return this.prestamosTableAdapter.GetDataBy1();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //usuariosTableAdapter.FillDGVporNombreDeUsuario(this.usuariosDataSet1.Usuarios, txtNombreUsuario.Text);
            switch (busqueda)
            {
                case "Nombres":

                    break;
                case "Fechas":

                    break;
                case "ID Prestamo":

                    break;

            }
        }

        private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void DgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // int carry = prestamosDataGridView.CurrentCellAddress.Y;
            //int renglon = prestamosDataGridView.CurrentCellAddress.Y;
            //int cell = prestamosDataGridView.CurrentCellAddress.X;
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);

            //idPrestamoTextBox.Text = renglon +"  " + cell ;
            //idPrestamoTextBox.Text = prestamosDataGridView.Rows(carry).cells(0).value;

        }
    }
}
