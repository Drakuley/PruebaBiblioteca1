using Biblioteca4.PrestamosDevolucionesTableAdapters;
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
    public partial class Devoluciones : Form
    {
        public int idPrestamo = 0;
        int devolver = 0;
        String numAdquisicion = "";

        public Devoluciones(int idPrestamos, Form1 f1)
        {
            InitializeComponent();
            this.idPrestamo = idPrestamos;
            devolver = 1;
            frm1 = f1;
        }

        public Devoluciones()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDevoluciones.Devoluciones' Puede moverla o quitarla según sea necesario.
            //this.devolucionesTableAdapter.Fill(this.prestamosDevoluciones.Devoluciones);

            this.dataTable1TableAdapter.FillBy1(this.prestamosDevoluciones.DataTable1);
            if (devolver == 1)
            {
                this.txtIdDev.Text = (1 + new Consultas().ultimoIdDevolucion()) + "";
                txtPrestamo.Text = idPrestamo + "";
                txtBiblio.Text = 1 + ""; //TOMAR BLIOTECARIO DEL LOGIN

                cbFechaDev.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
                txtFechaDev.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
                numAdquisicion = new Consultas().NumAdquisicionPorIdPrestamo(idPrestamo).ToString();
                txtTitulo.Text = new Consultas().TituloDeLibroPorIdPrestamo(idPrestamo).ToString();
                txtPrestamo.Enabled = false;
                txtBusqueda.Visible = false;
                picture.Visible = false;
                panel3.Visible = false;
                cbFechaDev.Enabled = false;
            }
            else
            {
                estadoBusqueda();
                
            }

            btnAceptar.Enabled = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrestamo_TextChanged(object sender, EventArgs e)
        {
            if (devolver == 1)
            {
                if (txtPrestamo.Text != "")
                {
                    idPrestamo = Int32.Parse(txtPrestamo.Text);
                    if (idPrestamo != 0)
                    {
                    }
                }
                else
                {
                    txtTitulo.Text = "";
                    btnAceptar.Enabled = false;
                }
            }
            else //Busqueda
            {
                if (txtPrestamo.Text != "")
                {
                    idPrestamo = Int32.Parse(txtPrestamo.Text);
                    string str = new Consultas().EstatusPorIdPrestamo(idPrestamo);
                    if (str == "N")
                    {
                        if (idPrestamo != 0)
                        {
                            txtTitulo.Text = new Consultas().NumAdquisicionPorIdPrestamo(idPrestamo).ToString(); 

                        }
                    }
                    
                }
                else
                {
                    txtTitulo.Text = "";
                }

            }
        }

        private void CbFechaDev_ValueChanged(object sender, EventArgs e)
        {
            if (devolver == 1)
            {
                txtFechaDev.Text = cbFechaDev.Value.ToString("yyyy/MM/dd") + "";
            }
            else //Busqueda
            {
                txtFechaDev.Text = cbFechaDev.Value.ToString("yyyy/MM/dd") + "";

            }
        }

        private void TxtObs_TextChanged(object sender, EventArgs e)
        {
            if (devolver == 1)
            {
                if (txtObs.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
            else //Busqueda
            {
                btnAceptar.Enabled = false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            String numAdqui = new Consultas().NumAdquisicionPorIdPrestamo(Int32.Parse(txtPrestamo.Text)); ;
            new DataTable1TableAdapter().InsertDevoluciones(Int32.Parse(txtIdDev.Text), Int32.Parse(txtPrestamo.Text),
                numAdqui, Int32.Parse(txtBiblio.Text), txtFechaDev.Text, txtObs.Text);
            new DataTable1TableAdapter().UpdateEstatusLibro("Disponible", numAdqui);
            new DataTable1TableAdapter().UpdateEstatusPrestamo(Int32.Parse(txtPrestamo.Text));
            this.devolucionesTableAdapter.Fill(this.prestamosDevoluciones.Devoluciones);
            txtPrestamo.Text = "";
            txtObs.Text = "";
            txtIdDev.Text = "";
            txtTitulo.Text = "";
            cbFechaDev.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            txtBiblio.Text = "";
            devolver = 0;
            estadoBusqueda();
            //this.Dispose();
            raiseUpdate();

        }

        private void DevolucionesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (devolver == 0)
            {

                int renglon = devolucionesDataGridView.CurrentCellAddress.Y;
                int cell = devolucionesDataGridView.CurrentCellAddress.X;

                //idPrestamoTextBox.Text = renglon +"  " + cell ;
                txtIdDev.Text = devolucionesDataGridView.Rows[renglon].Cells[0].Value.ToString();

                foreach (DataRow row in new DevolucionesTableAdapter().DatosDevoluciones(Int32.Parse(txtIdDev.Text)).Rows)
                {
                    txtPrestamo.Text = row["idPrestamo"].ToString();
                    txtTitulo.Text = new Consultas().TituloDeLibroPorIdPrestamo(Int32.Parse(txtPrestamo.Text));
                    cbFechaDev.Text = row["fechaDevuelto"].ToString();
                    txtObs.Text = row["observaciones"].ToString();
                    int idBiblio = Int32.Parse (row["idBibliotecario"].ToString());
                    txtBiblio.Text = new Consultas().NombreBibliotecarioPorIdDevolucion(idBiblio);
                   // txtFechaPrestamo.Text = Convert.ToDateTime(row["fechaPrestamo"].ToString()).ToString("dd/MMMM/yyyy");
                }
            }


        }

            public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
            public event UpdateDelegate UpdateEventHandler;
            Form1 frm1;

            public class UpdateEventArgs : EventArgs
            {
                public string Data { get; set; }
            }

            protected void raiseUpdate()
            {
                UpdateEventArgs args = new UpdateEventArgs();
                UpdateEventHandler?.Invoke(this, args);
            }
        private void estadoBusqueda()
        {
            txtTitulo.Enabled = false;
            txtPrestamo.Enabled = false;
            txtIdDev.Enabled = false;
            cbFechaDev.Enabled = false;
            txtBusqueda.Visible = true;
            //cbEjemplar.Visible = true;
            txtObs.Enabled = false;
            txtBiblio.Enabled = false;
            picture.Visible = true;
            panel3.Visible = true;
        }

        private void TxtBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //new DataTable1TableAdapter().BusquedaDevolucionPrestamoAdquisicion();
            if (txtBusqueda.Text != "")
            {
                this.dataTable1TableAdapter.fillBusquedaDevolucionPrestamoAdquisicion(this.prestamosDevoluciones.DataTable1, txtBusqueda.Text);
            }
            else
            {
                this.dataTable1TableAdapter.FillBy1(this.prestamosDevoluciones.DataTable1);
            }
            


        }

        private void LBLTitulo_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            new GenerarReporteDevoluciones().Show();
        }
    }
}
