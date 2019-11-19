using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca4
{
    public partial class Form1 : Form
    {
        int idPrestamo = 0;

        public String busqueda;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new Devoluciones().Show();
        }

        private void PrestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prestamosDevoluciones);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos' Puede moverla o quitarla según sea necesario.
            //this.devolucionesTableAdapter.Fill(this.prestamosDevoluciones.Devoluciones);
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos' Puede moverla o quitarla según sea necesario.
            //this.prestamosTableAdapter.Fill(this.prestamosDevoluciones.Prestamos);
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);

        }

        public DataTable Form1Carga()
        {           
            return this.prestamosTableAdapter.GetDataBy1();
        }



        private void TextBox2_TextChanged(object sender, EventArgs e)
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

        
        private void Button9_Click(object sender, EventArgs e)
        {
            RegistroDePrestamo r1 = new RegistroDePrestamo(this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();

        }

        private void PrestamosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // int carry = prestamosDataGridView.CurrentCellAddress.Y;
            //int renglon = prestamosDataGridView.CurrentCellAddress.Y;
            //int cell = prestamosDataGridView.CurrentCellAddress.X;
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
            
            //idPrestamoTextBox.Text = renglon +"  " + cell ;
            //idPrestamoTextBox.Text = prestamosDataGridView.Rows(carry).cells(0).value;

        }

        private void Button5_Click(object sender, EventArgs e) //Devolver
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
            Devoluciones r1 = new Devoluciones(idPrestamo, this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
            RegistroDePrestamo r1 = new RegistroDePrestamo(idPrestamo, this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();
        }

         

        private void PrestamosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
        }

        private void PrestamosDataGridView_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idPrestamo = Int32.Parse(idPrestamoTextBox.Text);
            RegistroDePrestamo r1 = new RegistroDePrestamo(idPrestamo, this);
            r1.UpdateEventHandler += F3_UpdateEventHandler1;
            r1.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }

    

        private void F3_UpdateEventHandler1(object sender, RegistroDePrestamo.UpdateEventArgs args)
        {
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }

        private void F3_UpdateEventHandler1(object sender, Devoluciones.UpdateEventArgs args)
        {
            this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                this.prestamosTableAdapter.FillBy5(this.prestamosDevoluciones.Prestamos, txtBusqueda.Text);
            }
            else
            {
                this.prestamosTableAdapter.FillBy4(this.prestamosDevoluciones.Prestamos);
            }
        }

        private void TxtBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            new GenerarReportePrestamos().Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 392);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}

