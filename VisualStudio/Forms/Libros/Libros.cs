using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBiblioteca1.Forms
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void DgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clasificacionesDataSet1.Clasificaciones' Puede moverla o quitarla según sea necesario.
            this.clasificacionesTableAdapter.Fill(this.clasificacionesDataSet1.Clasificaciones);
            // TODO: esta línea de código carga datos en la tabla 'ubicacionesDataSet.Ubicaciones' Puede moverla o quitarla según sea necesario.
            this.ubicacionesTableAdapter.Fill(this.ubicacionesDataSet.Ubicaciones);
            // TODO: esta línea de código carga datos en la tabla 'autoresDataSet1.Autores' Puede moverla o quitarla según sea necesario.
            this.autoresTableAdapter.Fill(this.autoresDataSet1.Autores);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet1.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet1.Libros);

        }

        private void TxtNumAdquisicion_TextChanged(object sender, EventArgs e)
        {
            if (librosTableAdapter.exixtenLibrosConNumAdquisicion(txtNumAdquisicion.Text) > 0)
            {
                librosTableAdapter.FillDGVLibrosPorNumeroAdquisicion(this.librosDataSet1.Libros, txtNumAdquisicion.Text);
                btnAceptar.Text = "MODIFICAR";
            }
            else
            {
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
                btnAceptar.Text = "REGISTRAR";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "MODIFICAR")
            {
                librosTableAdapter.UpdateQueryLibros(txtTitulo.Text, (decimal)cbAutores.SelectedValue, (string)cbUbicaciones.SelectedValue, txtEjemplar.Text, (decimal)cbClasificaciones.SelectedValue, lblTxtEstatus.Text, txtNumAdquisicion.Text);
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            }
            else if (btnAceptar.Text == "REGISTRAR")
            {
                librosTableAdapter.InsertQueryLibros(txtNumAdquisicion.Text, txtTitulo.Text, (decimal)cbAutores.SelectedValue, (string)cbUbicaciones.SelectedValue, txtEjemplar.Text, (decimal)cbClasificaciones.SelectedValue, "Disponible");
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (librosTableAdapter.exixtenLibrosConNumAdquisicion(txtNumAdquisicion.Text) > 0)
            {
                librosTableAdapter.DeleteQueryLibros(txtNumAdquisicion.Text);
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            }
        }
    }
}
