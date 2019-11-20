using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaBiblioteca1.PrestamosDevolucionesTableAdapters;
using PruebaBiblioteca1.Forms.Prestamos;

namespace PruebaBiblioteca1.Forms
{
    public partial class RegistroDePrestamo : Form
    {
        int idPrestamo = 0;
        int estatus = 0;
        public RegistroDePrestamo(FrmMenú f1)
        {
            InitializeComponent();
            estatus = 0;
            frm1 = f1;
        }

        public RegistroDePrestamo(int prestamo, FrmMenú f1)
        {
            InitializeComponent();
            idPrestamo = prestamo;
            estatus = 1;
            frm1 = f1;
        }

        public RegistroDePrestamo()
        {
            InitializeComponent();
        }

        private void TxtNumeroAdquisicion_TextChanged(object sender, EventArgs e)
        {
            lblDisponible.Visible = false;
            if (txtNumeroAdquisicion.Text != "")
            {
                txtTitulo.Text = Convert.ToString(new Consultas().TituloLibro(txtNumeroAdquisicion.Text));
                lblDisponible.Visible = false;
                try
                {
                    if (new Consultas().EstatusLibro(txtNumeroAdquisicion.Text).Equals("Disponible"))
                    {
                        lblDisponible.Visible = false;

                    }
                    else
                    {
                        lblDisponible.Visible = true;

                        if (estatus == 1)
                        {
                            btnRegistrar.Enabled = false;

                        }
                    }
                }
                catch (Exception es)
                {

                }

                if (txtTitulo.Text == "" && txtNumeroAdquisicion.Text != "")
                {
                    btnLibro.Enabled = true;
                    btnRegistrar.Enabled = false;
                }
                else
                {
                    btnLibro.Enabled = false;

                }

                if (txtTitulo.Text != "" && txtIdUsuario.Text != "" && !lblDisponible.Visible && !lblTresPrestamos.Visible)
                {
                    btnRegistrar.Enabled = true;
                }
                else
                {
                    btnRegistrar.Enabled = false;
                }

            }
            else
            {
                txtTitulo.Text = "";
                btnLibro.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void RegistroDePrestamo_Load(object sender, EventArgs e)
        {
            this.prestamosTableAdapter1.Fill(this.prestamosDevoluciones.Prestamos);
            txtIdPrestamo.Text = "" + (Convert.ToInt32(prestamos1TableAdapter1.numeroPrestamo()) + 1);

            txtBibliotecario.Text = "1";



            if (estatus == 0) //Agregar registro
            {
                this.datosNuevoPrestamo();
                btnRegistrar.Enabled = false;
            }
            else //modificar
            {
                txtIdPrestamo.Text = idPrestamo + "";
                foreach (DataRow row in new DataTable1TableAdapter().AbsolutamenteTodosDatos(idPrestamo).Rows)
                {
                    txtNumeroAdquisicion.Text = row["numeroAdquisicion"].ToString();
                    txtUsuario.Text = row["nombreUsuario"].ToString();
                    cbFechaDevolucion.Text = row["fechaDevolucion"].ToString();
                    txtFechaPrestamo.Text = Convert.ToDateTime(row["fechaPrestamo"].ToString()).ToString("dd/MMMM/yyyy");
                }
                btnRegistrar.Text = "Modificar Prestamo";
                txtBibliotecario.Text = Convert.ToString(new Consultas().NombreBibliotecarioPorPrestamo(idPrestamo));
                txtNumeroAdquisicion.Enabled = false;
                txtUsuario.Enabled = false;
                btnRegistrar.Enabled = true;
            }
        }

        private void TxtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblTresPrestamos.Visible = false;

            if (txtUsuario.Text != "")
            {
                if (estatus == 0) //Agregar 
                {
                    var isNumeric = int.TryParse(txtUsuario.Text, out int n);

                    if (isNumeric)
                    {
                        txtNombreUsuario.Text = Convert.ToString(new Consultas().nombreUsuarioPorID(n));
                        txtIdUsuario.Text = new Consultas().idUsuarioPorNombre(txtNombreUsuario.Text) + "";
                    }
                    else
                    {

                        txtIdUsuario.Text = new Consultas().idUsuarioPorNombre(txtUsuario.Text) + "";
                        if (txtIdUsuario.Text != "")
                        {
                            txtNombreUsuario.Text = Convert.ToString(new Consultas().nombreUsuarioPorID(Int32.Parse(txtIdUsuario.Text)));
                        }
                    }

                    if (txtIdUsuario.Text == "")
                    {
                        btnUsuario.Enabled = true;
                        btnRegistrar.Enabled = false;
                    }
                    else
                    {
                        btnRegistrar.Enabled = true;
                        if (usuarioTresPrestamos(Int32.Parse(txtIdUsuario.Text)))
                        {
                            lblTresPrestamos.Visible = true;

                            btnRegistrar.Enabled = false;
                        }
                    }
                }
                else //Modificar
                {
                    if (txtUsuario.Text != "")
                    {
                        txtIdUsuario.Text = new Consultas().idUsuarioPorNombre(txtUsuario.Text) + "";
                        txtNombreUsuario.Text = Convert.ToString(new Consultas().nombreUsuarioPorID(Int32.Parse(txtIdUsuario.Text)));
                        if (usuarioTresPrestamos(Int32.Parse(txtIdUsuario.Text)))
                        {
                            lblTresPrestamos.Visible = true;

                        }
                    }

                }

                if (txtTitulo.Text != "" && txtIdUsuario.Text != "" && !lblDisponible.Visible && !lblTresPrestamos.Visible)
                {
                    btnRegistrar.Enabled = true;
                }
                else
                {
                    btnRegistrar.Enabled = false;
                }
            }
            else
            {
                txtIdUsuario.Text = "";
                txtNombreUsuario.Text = "";

                btnUsuario.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }
        private Boolean usuarioTresPrestamos(int idUsuario)
        {
            Boolean masDeTres = false;
            int numeroPrestamos = (int)new Consultas().CantidadPrestamosUsuarios(idUsuario);

            if (numeroPrestamos >= 3)
            {
                masDeTres = true;
            }
            return masDeTres;
        }

        private void BtnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            txtIdPrestamo.Text = (Convert.ToInt32(prestamos1TableAdapter1.numeroPrestamo()) + 1) + "";
            btnNuevoPrestamo.Visible = false;
            txtUsuario.Text = "";
            txtNumeroAdquisicion.Text = "";
            btnRegistrar.Text = "Registrar Prestamo";
            estatus = 0;
            txtBibliotecario.Text = "";
            txtIdUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtTitulo.Text = "";
            txtNumeroAdquisicion.Enabled = true;
            txtUsuario.Enabled = true;
            txtFechaPrestamo.Text = "";
            this.datosNuevoPrestamo();

        }

        private void datosNuevoPrestamo()
        {
            txtIdPrestamo.Text = (Convert.ToInt32(prestamos1TableAdapter1.numeroPrestamo()) + 1) + "";
            btnNuevoPrestamo.Visible = false;
            txtFechaPrestamo.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            cbFechaDevolucion.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            lblTresPrestamos.Visible = false;

            lblDisponible.Visible = false;

            btnRegistrar.Enabled = false;

            txtBibliotecario.Text = 1 + ""; //CAMBIAR POR EL BIBLIOTECARIO DEL LOGIN
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (btnRegistrar.Text == "Registrar Prestamo")
            {
                new DataTable1TableAdapter().insertPrestamo(Int32.Parse(txtIdPrestamo.Text),
                  DateTime.Now.ToString("yyyy/MM/dd"), txtNumeroAdquisicion.Text,
                  Int32.Parse(txtIdUsuario.Text),
                  Int32.Parse(txtBibliotecario.Text),
                  txtFechaDev.Text, "Y");

                new DataTable1TableAdapter().UpdateEstatusLibro("No Disponible", txtNumeroAdquisicion.Text);

            }
            else
            {
                new DataTable1TableAdapter().ModificarPrestamo(txtFechaDev.Text, Int32.Parse(txtIdPrestamo.Text));
            }
            //this.Dispose();
            txtUsuario.Text = "";
            txtNumeroAdquisicion.Text = "";
            txtIdPrestamo.Text = "" + (Convert.ToInt32(prestamos1TableAdapter1.numeroPrestamo()) + 1);
            raiseUpdate();
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        FrmMenú frm1;
        //Form1 frm1;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

        private void CbFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            txtFechaDev.Text = cbFechaDevolucion.Value.ToString("yyyy/MM/dd") + "";
        }
    }
}
