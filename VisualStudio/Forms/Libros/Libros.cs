﻿using System;
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
        public int renglon;
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void DgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = dgvLibros.CurrentCellAddress.Y;
            txtNumAdquisicion.Text = dgvLibros.Rows[renglon].Cells[0].FormattedValue.ToString();
            txtTitulo.Text = dgvLibros.CurrentRow.Cells[1].Value.ToString();
            cbAutores.SelectedValue = dgvLibros.CurrentRow.Cells[2].Value;
            cbUbicaciones.SelectedValue = dgvLibros.CurrentRow.Cells[3].FormattedValue.ToString();
            txtEjemplar.Text = dgvLibros.CurrentRow.Cells[4].FormattedValue.ToString();
            cbClasificaciones.SelectedValue = dgvLibros.CurrentRow.Cells[5].Value;
            lblTxtEstatus.Text = dgvLibros.CurrentRow.Cells[6].FormattedValue.ToString();

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

            cbAutores.SelectedValue = (decimal)cbAutores.SelectionStart;
            cbUbicaciones.SelectedValue = cbUbicaciones.SelectionStart;
            cbClasificaciones.SelectedValue = (decimal)cbClasificaciones.SelectionStart;
        }

        private void TxtNumAdquisicion_TextChanged(object sender, EventArgs e)
        {
            if(txtNumAdquisicion.Text == "")
            {
                txtTitulo.Text = "";
                cbAutores.SelectedValue = (decimal)cbAutores.SelectionStart;
                cbUbicaciones.SelectedValue = cbUbicaciones.SelectionStart;
                txtEjemplar.Text = "";
                cbClasificaciones.SelectedValue = (decimal)cbClasificaciones.SelectionStart;
                lblTxtEstatus.Text = "Disponible";
                lblTxtEstatus.ForeColor = Color.Lime;
            }
            else if (librosTableAdapter.exixtenLibrosConNumAdquisicion(txtNumAdquisicion.Text) > 0)
            {

                if (librosTableAdapter.estatusPorNumeroAdquisicion(txtNumAdquisicion.Text) > 0)
                {
                    lblTxtEstatus.Text = "Disponible";
                    lblTxtEstatus.ForeColor = Color.Lime;
                }
                else
                {
                    lblTxtEstatus.Text = "No Disponible";
                    lblTxtEstatus.ForeColor = Color.Gold;
                }
                librosTableAdapter.FillDGVLibrosPorNumeroAdquisicion(this.librosDataSet1.Libros, txtNumAdquisicion.Text);
                btnAceptar.Text = "MODIFICAR";
            }
            else
            {
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
                lblTxtEstatus.Text = "Disponible";
                btnAceptar.Text = "REGISTRAR";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNumAdquisicion.Text==""|| txtTitulo.Text == "" || cbAutores.Text == "" || cbUbicaciones.Text == "" || txtEjemplar.Text == "" || cbClasificaciones.SelectedText == "")
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else if (btnAceptar.Text == "MODIFICAR")
            {
                librosTableAdapter.UpdateQueryLibros(txtTitulo.Text, (decimal)cbAutores.SelectedValue, (string)cbUbicaciones.SelectedValue, txtEjemplar.Text, (decimal)cbClasificaciones.SelectedValue, lblTxtEstatus.Text, txtNumAdquisicion.Text);
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            }
            else if (btnAceptar.Text == "REGISTRAR")
            {
                if (librosTableAdapter.exixtenLibrosConNumAdquisicion(txtNumAdquisicion.Text) > 0)
                {
                    MessageBox.Show("El libro que quieres registrar ya existe");
                }
                else
                {
                    librosTableAdapter.InsertQueryLibros(txtNumAdquisicion.Text, txtTitulo.Text, (decimal)cbAutores.SelectedValue, (string)cbUbicaciones.SelectedValue, txtEjemplar.Text, (decimal)cbClasificaciones.SelectedValue, "Disponible");
                    this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
                    txtNumAdquisicion.Text = "";
                    txtTitulo.Text = "";
                    cbAutores.SelectedValue = (decimal)cbAutores.SelectionStart;
                    cbUbicaciones.SelectedValue = cbUbicaciones.SelectionStart;
                    txtEjemplar.Text = "";
                    cbClasificaciones.SelectedValue = (decimal)cbClasificaciones.SelectionStart;

                    txtNumAdquisicion.Focus();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNumAdquisicion.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else if (librosTableAdapter.exixtenLibrosConNumAdquisicion(txtNumAdquisicion.Text) > 0)
            {
                librosTableAdapter.DeleteQueryLibros(txtNumAdquisicion.Text);
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
                txtNumAdquisicion.Text = "";
                txtTitulo.Text = "";
                cbAutores.SelectedValue = (decimal)cbAutores.SelectionStart;
                cbUbicaciones.SelectedValue = cbUbicaciones.SelectionStart;
                txtEjemplar.Text = "";
                cbClasificaciones.SelectedValue = (decimal)cbClasificaciones.SelectionStart;

                txtNumAdquisicion.Focus();
            }
            else
            {
                MessageBox.Show("El libro que quieres eliminar no existe");
            }
        }

        private void BtnRegistrarAutores_Click(object sender, EventArgs e)
        {
            new Autores.FrmAutores().Show();
            this.Hide();
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {
            if(txtTitulo.Text == "")
            {
                this.librosTableAdapter.Fill(this.librosDataSet1.Libros);
            }
            else
            {
                this.librosTableAdapter.FillDGVLibrosPorTitulo(this.librosDataSet1.Libros, txtTitulo.Text);
            }
            
        }
    }
}
